using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Linq;

namespace Third_Task
{

    public enum TypeQuestion { History, Geographic, Biology, Math }

    //interface IVictorina
    //{
    //    public void SignIn(string pass, string login);
    //    public void Registration(string pass, string login);
    //    public void ShowMenu();
    //    public void CreateVictorine();
    //}

    class Users
    {
        public string Login { get; set; }
        public string Password
        {
            get => Login;
            set
            {
                this.Login = value;
            }
        }
        public DateTime Date { get; set; } = new DateTime();
        public uint Score { get; set; } = 0;
        public Users(string log, string pass, DateTime time, uint score)
        {
            this.Login = log;
            this.Password = pass;
            this.Date = time;
            this.Score = score;
        }
    }
    class AdminPanel
    {

    }


    class Resourse
    {
        // variable
        string login;
        string password;
        public string Login
        {
            get => login;
            set
            {
                if (value != null)
                    this.login = value;
                else
                    throw new Exception("Error! Login is Null!");
            }
        }
        public string Password
        {
            get => password;
            set
            {
                if (value != null)
                    this.password = value;
                else
                    throw new Exception("Error! Password is Null!");
            }
        }
        public List<QuestionData> quiz = new List<QuestionData>()
        {
            new QuestionData(1,"1+1",new string[] {"2", "3"},0),
            new QuestionData(3,"2+2 =",new string[] {"4", "3"},0),
            new QuestionData(4,"2+1 = ",new string[] {"5", "3"},1),
            new QuestionData(6,"5-3",new string[] {"3","2"},1)
        };
        public List<Users> users = new List<Users>();
        public DateTime date = new DateTime();
        public Users current;

        // Sign In

        public void SignIn(string pass, string login)
        {
            foreach (var item in users)
            {
                if (item.Login == login && item.Password == pass)
                {
                    current = item;
                    Console.WriteLine("User sign in!");
                    return;
                }
            }
        }

        public void Registration(Users user)
        {
            users.Add(user);
            Console.WriteLine("new user has been registration!");
        }

        // Work with Victorina

        public void CreateQuiz()
        {
            //string json = File.ReadAllText("MathQuiz.json");
            //JsonSerializerOptions options = new JsonSerializerOptions();
            //options.PropertyNameCaseInsensitive = true;
            //var moduleData = System.Text.Json.JsonSerializer.Deserialize<ModuleData>(json, options);
            Console.WriteLine("___________ready");
            foreach (var item in quiz)
            {
                Console.WriteLine("we in cycle");
                Console.WriteLine(item.Question);
                for (int i = 0; i < item.Answers.Length; i++)
                {
                    Console.WriteLine(item.Answers[i]);
                }
                int tmp = Convert.ToInt32(Console.ReadLine());
                if (tmp == item.CorrectAnswer)
                {
                    foreach (var u in users)
                    {
                        u.Score++;
                    }
                }
                else
                {
                    Console.WriteLine("false answer!");
                    return;
                }
            }

        }

        public void TopUsers()
        {
            var res = (from e in users
                       orderby e.Score
                       select e
                       );
            Console.WriteLine("______Top Users");
            foreach (var item in res)
            {
                Console.WriteLine(item.Score);
            }
        }

        // Menu

        public void ShowMenu()
        {
            int action;
            do
            {
                Console.WriteLine("1.Game in Victorine");
                Console.WriteLine("2.Exit");
                action = Convert.ToInt32(Console.ReadLine());
                if (action == 1)
                {
                    CreateQuiz();
                }
                if (action == 2)
                {
                    Console.WriteLine("exit dont worked!!!");
                }
                else
                {
                    Console.WriteLine("nepravilno");
                }

            } while (true);

        }


    }
}


// ToDo
//
// --Add Login and Password
//   --Create registration || SignIn
// 
// --Menu for user
//   --Start new victorine
//   ( public void CreateVictorine() )
//   --Show TOP-20 leaders
//   ( )
//   --Show old victorine result
//   --Settings(Change password and login)
//
//
//