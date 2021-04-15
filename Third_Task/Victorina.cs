using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Linq;
using Third_Task;

namespace Third_Task
{
    public enum TypeQuestion { History, Geographic, Biology, Math }

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
        //public List<QuestionData> MathQuiz = new List<QuestionData>()
        //{
        //    new QuestionData(1,"1+1",new string[] {"2", "3","4","5"},0),
        //    new QuestionData(2,"2+2 =",new string[] {"4", "3","1","11"},0),
        //    new QuestionData(3,"2+1 = ",new string[] {"5", "3","3,14"},1),
        //    new QuestionData(4,"5-3",new string[] {"3","2","5"},1),
        //    new QuestionData(5,"2*3",new string[] {"6","2","10"},0),
        //    new QuestionData(6,"5+3",new string[] {"7","8","15"},1),
        //    new QuestionData(7,"10-3",new string[] {"7","2","121"},1),
        //    new QuestionData(8,"10*3",new string[] {"7","2","30"},2),
        //    new QuestionData(9,"PI",new string[] {"3","3.14","144.4"},1),
        //    new QuestionData(10,"PI + 0,2",new string[] {"3","3.16","144.4"},1),

        //};
        //public List<QuestionData> BiologyQuiz = new List<QuestionData>()
        //{
        //    new QuestionData(1,"Monkey love: ",new string[] {"strowberry", "banana"},1),
        //    new QuestionData(2,"Eagle move: ",new string[] {"fly", "run","looking"},0),
        //    new QuestionData(3,"Eliphan eat: ",new string[] {"vegetable", "meat","apple"},0),
        //    new QuestionData(4,"Mouse like: ",new string[] {"milk","chease","water"},1),
        //    new QuestionData(5,"Cat like eat: ",new string[] {"milk","chease","strawberry"},0),
        //    new QuestionData(6,"Which foods a dog: ",new string[] {"three","two","four"},2),
        //    new QuestionData(7,"Snake move: ",new string[] {"run","fly","crawls"},2),
        //    new QuestionData(8,"Pig like eat: ",new string[] {"apple","banana","carrot"},2),
        //    new QuestionData(9,"Bunny like eat: ",new string[] {"carrot","chease","strawberry"},0),
        //    new QuestionData(10,"GODZILA like eat: ",new string[] {"milk","chease","strawberry","nuclear radiation"},3),
        //    // add question
        //};
    };

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
        public List<Users> users = new List<Users>();
        public DateTime date = new DateTime();
        public Users current;
        public List<QuestionData> MathQuiz = new List<QuestionData>()
        {
            new QuestionData(1,"1+1",new string[] {"2", "3","4","5"},0),
            new QuestionData(2,"2+2 =",new string[] {"4", "3","1","11"},0),
            new QuestionData(3,"2+1 = ",new string[] {"5", "3","3,14"},1),
            new QuestionData(4,"5-3",new string[] {"3","2","5"},1),
            new QuestionData(5,"2*3",new string[] {"6","2","10"},0),
            new QuestionData(6,"5+3",new string[] {"7","8","15"},1),
            new QuestionData(7,"10-3",new string[] {"7","2","121"},0),
            new QuestionData(8,"10*3",new string[] {"7","2","30"},2),
            new QuestionData(9,"PI",new string[] {"3","3.14","144.4"},1),
            new QuestionData(10,"PI + 0,2",new string[] {"3","3.16","144.4"},1),

        };
        public List<QuestionData> BiologyQuiz = new List<QuestionData>()
        {
            new QuestionData(1,"Monkey love: ",new string[] {"strowberry", "banana"},1),
            new QuestionData(2,"Eagle move: ",new string[] {"fly", "run","looking"},0),
            new QuestionData(3,"Eliphan eat: ",new string[] {"vegetable", "meat","apple"},0),
            new QuestionData(4,"Mouse like: ",new string[] {"milk","chease","water"},1),
            new QuestionData(5,"Cat like eat: ",new string[] {"milk","chease","strawberry"},0),
            new QuestionData(6,"Which foods a dog: ",new string[] {"three","two","four"},2),
            new QuestionData(7,"Snake move: ",new string[] {"run","fly","crawls"},2),
            new QuestionData(8,"Pig like eat: ",new string[] {"apple","banana","carrot"},2),
            new QuestionData(9,"Bunny like eat: ",new string[] {"carrot","chease","strawberry"},0),
            new QuestionData(10,"GODZILA like eat: ",new string[] {"milk","chease","strawberry","nuclear radiation"},3),
            // add question
        };


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

        public void CreateQuiz(TypeQuestion type)
        {
            //string json = File.ReadAllText("MathQuiz.json");
            //JsonSerializerOptions options = new JsonSerializerOptions();
            //options.PropertyNameCaseInsensitive = true;
            //var moduleData = System.Text.Json.JsonSerializer.Deserialize<ModuleData>(json, options);

            if (type == TypeQuestion.Biology)
            {
                Console.WriteLine("_VICTORINA READY");
                foreach (var item in BiologyQuiz)
                {
                    Console.WriteLine("___QUESTION");
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
            if (type == TypeQuestion.Math)
            {
                Console.WriteLine("_VICTORINA READY");
                foreach (var item in MathQuiz)
                {
                    Console.WriteLine("___QUESTION");
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

        }

        // Top 20

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
                Console.WriteLine("2.TOP 20 Score");
                Console.WriteLine("3.Exit");
                action = Convert.ToInt32(Console.ReadLine());
                if (action == 1)
                {
                    Console.WriteLine("___TYPE QUESTION");
                    Console.WriteLine("1. Enter 'Math' for math question");
                    Console.WriteLine("2. Enter 'Biology' for biology question");
                    Console.Write("Enter type question: ");
                    string tmp = Console.ReadLine();
                    if (tmp.ToLower() == "math")
                    {
                        CreateQuiz(TypeQuestion.Math);
                    }
                    if (tmp.ToLower() == "biology")
                    {
                        CreateQuiz(TypeQuestion.Biology);
                    }
                    else
                    {
                        Console.WriteLine("error!");
                    }
                    //CreateQuiz();
                }
                if (action == 2)
                {
                    TopUsers();
                }
                if (action == 3)
                {
                    Console.WriteLine("Bye!");
                    return;
                }


            } while (true);
        }
    }
}