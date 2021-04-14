using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

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
        public Users(string log, string pass, DateTime time)
        {
            this.Login = log;
            this.Password = pass;
            this.Date = time;
        }
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
        public uint Score { get; set; }

        public List<QuestionData> quiz { get; set; } = new List<QuestionData>();
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
                    return;
                }
            }
        }

        public void Registration(Users user)
        {
            users.Add(user);
        }

        // Work with Victorina

        public void CreateQuiz()
        {
            //string json = File.ReadAllText("data.json");
            //JsonSerializerOptions options = new JsonSerializerOptions();
            //options.PropertyNameCaseInsensitive = true;
            //var moduleData = System.Text.Json.JsonSerializer.Deserialize<ModuleData>(json, options);

            foreach (var item in quiz)
            {
                for (int i = 0; i < quiz.Count; i++)
                {
                    Console.WriteLine(item.Question[i]);
                    Console.WriteLine(item.Answers);
                    int tmp = Convert.ToInt32(Console.ReadLine());
                    if (tmp == item.CorrectAnswer)
                    {
                        Score++;
                    }
                    else
                    {
                        Console.WriteLine("Hueta answer!");
                        return;
                    }
                }
            }

        }



        public void TopUsers()
        {
            Console.WriteLine("______Top Users");
            
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
                    //CreateVictorine(TypeQuestion.Math);
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