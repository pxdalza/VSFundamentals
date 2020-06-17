using HospitalVSFundamentals.BL.BE;
using HospitalVSFundamentals.DL.DALC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalVSFundamentals.BL.BC
{
    public class UserBC
    {

        UserDALC userDALC = new UserDALC();

        public bool CreateUser(UserBE userBE)
        {
            bool registrado = false;

            try
            {

                registrado = userDALC.CreateUser(userBE);

            }
            catch (Exception)
            {
                throw;
            }

            return registrado;
        }

        public List<UserBE> GetUsers()
        {

            List<UserBE> users = new List<UserBE>();

            try
            {

                users = userDALC.GetUsers();

            }
            catch (Exception)
            {
                throw;
            }

            return users;

        }

        public UserBE GetUser(String userId)
        {
            UserBE user = new UserBE();

            try
            {

                user = userDALC.GetUser(userId);

            }
            catch (Exception)
            {
                throw;
            }

            return user;

        }

        public UserLoginBE getLogin(String username, String password)
        {
            UserLoginBE user = new UserLoginBE();

            try
            {

                user = userDALC.getLogin(username, password);

            }
            catch (Exception)
            {
                throw;
            }

            return user;

        }

        public UserLoginBE getUserByEmail(String email)
        {
            UserLoginBE user = new UserLoginBE();

            try
            {

                user = userDALC.getUserByEmail(email);

            }
            catch (Exception)
            {
                throw;
            }

            return user;

        }

        public bool UpdateUser(UserBE userupdate)
        {

            bool update = false;
           
            try
            {

                update = userDALC.UpdateUser(userupdate);

            }
            catch (Exception)
            {
                throw ;
            }

            return update;

        }

    }
}
