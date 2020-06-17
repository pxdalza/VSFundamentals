using HospitalVSFundamentals.BL.BE;
using HospitalVSFundamentals.FL.Utility;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalVSFundamentals.DL.DALC
{
    public class UserDALC
    {

        String connectionString = ConfigurationManager.ConnectionStrings["BDHospitalVSFundamentals"].ConnectionString;

        // ---- funciones-------

        public bool CreateUser(UserBE userBE)
        {
            bool registrado = false;

            try
            {
                using (SqlConnection cnx = new SqlConnection(connectionString))
                {

                    SqlCommand cmd = new SqlCommand("usp_CreationUser", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 600;//6 segundos

                    SQLHelper.AddParam(ref cmd, "@user_role", ParameterDirection.Input, SqlDbType.Int, userBE.User_Role);
                    SQLHelper.AddParam(ref cmd, "@username", ParameterDirection.Input, SqlDbType.VarChar, userBE.username);
                    SQLHelper.AddParam(ref cmd, "@name", ParameterDirection.Input, SqlDbType.VarChar, userBE.Name);
                    SQLHelper.AddParam(ref cmd, "@lastname", ParameterDirection.Input, SqlDbType.VarChar, userBE.LastName);
                    SQLHelper.AddParam(ref cmd, "@email", ParameterDirection.Input, SqlDbType.VarChar, userBE.Email);
                    SQLHelper.AddParam(ref cmd, "@phonenumber", ParameterDirection.Input, SqlDbType.VarChar, userBE.PhoneNumber);

                    //Encriptar contrasenia
                    var pass = PasswordSC.PasswordEncriptarSHA512(userBE.Password);
                    SQLHelper.AddParam(ref cmd, "@password", ParameterDirection.Input, SqlDbType.VarChar, pass);

                    SQLHelper.AddParam(ref cmd, "@dni", ParameterDirection.Input, SqlDbType.VarChar, userBE.DNI);
                    SQLHelper.AddParam(ref cmd, "@birthday", ParameterDirection.Input, SqlDbType.DateTime, userBE.Birthday);
                    SQLHelper.AddParam(ref cmd, "@status", ParameterDirection.Input, SqlDbType.Char, userBE.Status);
                    SQLHelper.AddParam(ref cmd, "@gener", ParameterDirection.Input, SqlDbType.Char, userBE.Gener);
                    //para recibir un parametro de respuesta del storedprocedure
                    //cmd.Parameters.Add("@userId", SqlDbType.UniqueIdentifier).Direction = ParameterDirection.Output;
                    
                    //abrimos la conexion
                    cnx.Open();
                    //ejecutamos el query
                    cmd.ExecuteNonQuery();

                    //obtenemos el valor de respuesta despues de recibir el output del stored procedure
                    //var userid = cmd.Parameters["@userId"].ToString();

                    registrado = true;

                }



            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return registrado;
        }

        public List<UserBE> GetUsers()
        {

            List<UserBE> users = new List<UserBE>();

            try
            {

                using (SqlConnection cnx = new SqlConnection(connectionString))
                {

                    SqlCommand cmd = new SqlCommand("usp_List_User", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 600;

                    cnx.Open();
                    IDataReader dr = cmd.ExecuteReader();

                    using (dr)
                    {

                        while (dr.Read())
                        {

                            UserBE user = ParseUser(dr);

                            users.Add(user);

                        }

                        cnx.Close();

                    }


                }

            }
            catch (Exception e )
            {
                throw new Exception(e.Message);
            }

            return users;

        }

        public UserBE GetUser(String userId)
        {
            UserBE user = new UserBE();

            try
            {

                using (SqlConnection cnx = new SqlConnection(connectionString))
                {

                    SqlCommand cmd = new SqlCommand("usp_Get_User", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 600;

                    cmd.Parameters.Add("@userid", SqlDbType.VarChar).Value = userId;

                    cnx.Open();
                    IDataReader dr = cmd.ExecuteReader();

                    using (dr)
                    {
                        user = ParseUser(dr);
                    }

                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return user;

        }

        public bool UpdateUser(UserBE userupdate)
        {

            bool update = false;

            SqlConnection cn = new SqlConnection(connectionString);
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "usp_Update_User";
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {

                SQLHelper.AddParam(ref cmd, "@userid", ParameterDirection.Input, SqlDbType.UniqueIdentifier, userupdate.IdUser);
                SQLHelper.AddParam(ref cmd, "@user_role", ParameterDirection.Input, SqlDbType.Int, userupdate.User_Role);
                SQLHelper.AddParam(ref cmd, "@username", ParameterDirection.Input, SqlDbType.VarChar, userupdate.username);
                SQLHelper.AddParam(ref cmd, "@name", ParameterDirection.Input, SqlDbType.VarChar, userupdate.Name);
                SQLHelper.AddParam(ref cmd, "@lastname", ParameterDirection.Input, SqlDbType.VarChar, userupdate.LastName);
                SQLHelper.AddParam(ref cmd, "@email", ParameterDirection.Input, SqlDbType.VarChar, userupdate.Email);
                SQLHelper.AddParam(ref cmd, "@phonenumber", ParameterDirection.Input, SqlDbType.VarChar, userupdate.PhoneNumber);
                SQLHelper.AddParam(ref cmd, "@password", ParameterDirection.Input, SqlDbType.VarChar, userupdate.Password);
                SQLHelper.AddParam(ref cmd, "@dni", ParameterDirection.Input, SqlDbType.VarChar, userupdate.DNI);
                SQLHelper.AddParam(ref cmd, "@birthday", ParameterDirection.Input, SqlDbType.DateTime, userupdate.Birthday);
                SQLHelper.AddParam(ref cmd, "@status", ParameterDirection.Input, SqlDbType.Char, userupdate.Status);

                cn.Open();
                cmd.ExecuteNonQuery();
                update = true;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {

                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                cn.Dispose();
                cmd.Dispose();

            }

            return update;

        }

        public UserLoginBE getLogin(String username, String password)
        {
            UserLoginBE user = new UserLoginBE();

            try
            {

                using (SqlConnection cnx = new SqlConnection(connectionString))
                {

                    SqlCommand cmd = new SqlCommand("usp_login", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 600;

                    cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
                    var pass = PasswordSC.PasswordEncriptarSHA512(password);
                    cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = pass;

                    cnx.Open();
                    IDataReader dr = cmd.ExecuteReader();

                    using (dr)
                    {

                        while (dr.Read())
                        {
                            user.IdUser = dr.GetGuid(dr.GetOrdinal("IdUser")).ToString();
                            user.Name = dr.GetString(dr.GetOrdinal("Name"));
                            user.LastName = dr.GetString(dr.GetOrdinal("LastName"));
                            user.DNI = dr.GetString(dr.GetOrdinal("DNI"));
                            user.Role = dr.GetString(dr.GetOrdinal("rol"));
                        }

                    }

                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return user;

        }

        public UserLoginBE getUserByEmail(String email)
        {
            UserLoginBE user = new UserLoginBE();

            try
            {

                using (SqlConnection cnx = new SqlConnection(connectionString))
                {

                    SqlCommand cmd = new SqlCommand("usp_getuserbyEmail", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 600;

                    cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;

                    cnx.Open();
                    IDataReader dr = cmd.ExecuteReader();

                    using (dr)
                    {

                        while (dr.Read())
                        {
                            user.IdUser = dr.GetGuid(dr.GetOrdinal("IdUser")).ToString();
                            user.Name = dr.GetString(dr.GetOrdinal("Name"));
                            user.LastName = dr.GetString(dr.GetOrdinal("LastName"));
                            user.DNI = dr.GetString(dr.GetOrdinal("DNI"));
                            user.Role = dr.GetString(dr.GetOrdinal("rol"));
                            user.Password = dr.GetString(dr.GetOrdinal("Password"));
                        }

                    }

                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return user;

        }

        private UserBE ParseUser(IDataReader dr)
        {

            UserBE user = new UserBE();

            //Executereader  q es una lista de IDataReader

            user.IdUser = dr.GetGuid(dr.GetOrdinal("IdUser")).ToString();
            user.Name = dr.GetString(dr.GetOrdinal("Name"));
            user.username = dr.GetString(dr.GetOrdinal("username"));
            user.LastName = dr.GetString(dr.GetOrdinal("LastName"));
            user.Email = dr.GetString(dr.GetOrdinal("Email"));
            user.PhoneNumber = dr.GetString(dr.GetOrdinal("PhoneNumber"));
            user.DNI = dr.GetString(dr.GetOrdinal("DNI"));
            user.Birthday = dr.GetDateTime(dr.GetOrdinal("Birthday"));
            user.Status = dr.GetString(dr.GetOrdinal("Status"));
            user.Gener = dr.GetString(dr.GetOrdinal("Gener"));

            return user;

        }


    }
}
