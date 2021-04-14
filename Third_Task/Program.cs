using System;
using Third_Task;

namespace Victorina
{
    class Program
    {
        static void Main(string[] argc)
        {
            Users users = new Users("admin", "admin", new DateTime(2021, 01, 21), 0);

            Resourse res = new Resourse();
            res.Registration(users);
            res.SignIn("admin","admin");
            //res.ShowMenu();
            res.CreateQuiz();
        }
    }

}