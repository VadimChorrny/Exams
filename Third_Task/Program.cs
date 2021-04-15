using System;
using Third_Task;

namespace Victorina
{
    class Program
    {
        static void Main(string[] argc)
        {
            Users users = new Users("admin", "admin", new DateTime(2021, 01, 21), 0);
            Users users1 = new Users("admin", "admin", new DateTime(2022, 09, 11), 0);
            Users users2 = new Users("admin", "admin", new DateTime(2011, 11, 07), 0);
            Users users3 = new Users("admin", "admin", new DateTime(2001, 02, 21), 0);
            Users users4 = new Users("admin", "admin", new DateTime(2012, 03, 31), 0);
            Users users5 = new Users("admin", "admin", new DateTime(2013, 04, 01), 0);

            Resourse res = new Resourse();
            res.Registration(users);
            res.SignIn("admin", "admin");
            res.Registration(users1);
            res.SignIn("admin", "admin");
            res.Registration(users2);
            res.SignIn("admin", "admin");
            res.Registration(users3);
            res.SignIn("admin", "admin");
            res.Registration(users4);

            res.SignIn("admin", "admin");
            res.Registration(users5);
            res.SignIn("admin", "admin");
            res.ShowMenu();
        }
    }

}