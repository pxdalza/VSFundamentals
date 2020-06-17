using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Model context = new Model();

            ////listar
            //var users = context.Users.ToList(); // equivalente a un selct *
       

            //var users1 = context.Users.Select(x => new Users { IdUser = x.IdUser }).ToList();

            ////obtener
            //var user = context.Users.Where(x => x.IdUser.Equals(new Guid())).Single(); //afirmas de que el objeto existe y no sera null
            //var user2 = context.Users.Where(x => x.IdUser.Equals(new Guid())).SingleOrDefault(); // no estas seguro de q existe por lo que si no esta el objeto de respuesta es null.


            ////crear
            //var u = new Users();
            //u.IdUser = new Guid();


            ////update
            //user.Name = "ssssss";

            //// delete
            //context.Users.Remove(user);

            //context.SaveChanges();

        }
    }
}
