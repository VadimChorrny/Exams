using System;
using System.Collections.Generic;
using System.Text;

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

    interface IAdmin
    {
    }

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
        public Users(string log,string pass,DateTime time)
        {
            this.Login = log;
            this.Password = pass;
            this.Date = time;
        }
    }

    class Questions
    {
        // quest - file
        // 
        public Questions()
        {

        }
    }

    class Victorina
    {
        public List<Questions> questions = new List<Questions>();
        public List<Users> users = new List<Users>();
        public Users current;

        public DateTime date = new DateTime();
        string login;
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
        string password;
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
        
        public List<string> mathQuestion = new List<string>()
        {
            "P = ", //0
            "2 + 2 = ",//1
            "1 + 3 = ",//2
            "2 + 4 = ",//3
            "4 + 5 = ",//4
            "6 + 6 = ",//5
            "5 + 7 = ",//6
            "32 + 64 = ",//7
            "21 + 23 = ", // 8
            "45 + 54 = ",//9
            "7 + 3 + 2 = "// 10
        };

        public void SignIn(string pass, string login)
        {
            foreach (var item in users)
            {
                if(item.Login == login && item.Password == pass)
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

        public void CreateVictorine(TypeQuestion type)
        {
            if (type == TypeQuestion.Math)
            {
                Console.WriteLine(mathQuestion[0]);
                Console.Write("Enter answer ->");
                string tmp0 = Console.ReadLine();
                if (tmp0 == "3.14")
                {
                    Console.WriteLine("Your answer - true");
                    Score++;

                    Console.WriteLine(mathQuestion[1]);
                    Console.Write("Enter answer ->");
                    int tmp1 = Convert.ToInt32(Console.ReadLine());
                    if (tmp1 == 4)
                    {
                        Console.WriteLine("Your answer - true");
                        Score++;

                        Console.WriteLine(mathQuestion[2]);
                        Console.Write("Enter answer ->"); int tmp2 = Convert.ToInt32(Console.ReadLine());
                        if (tmp2 == 4)
                        {
                            Console.WriteLine("Your answer - true");
                            Score++;

                            Console.WriteLine(mathQuestion[3]);
                            Console.WriteLine("Enter answer ->"); int tmp3 = Convert.ToInt32(Console.ReadLine());
                            if (tmp3 == 6)
                            {
                                Console.WriteLine("Your answer - true");
                                Score++;

                                Console.WriteLine(mathQuestion[4]);
                                Console.WriteLine("Enter answer ->"); int tmp4 = Convert.ToInt32(Console.ReadLine());
                                if (tmp4 == 9)
                                {
                                    Console.WriteLine("Your answer- true");
                                    Score++;

                                    Console.WriteLine(mathQuestion[5]);
                                    Console.WriteLine("Enter answers ->"); int tmp5 = Convert.ToInt32(Console.ReadLine());
                                    if (tmp5 == 12)
                                    {
                                        Console.WriteLine("Your answer - true");
                                        Score++;

                                        Console.WriteLine(mathQuestion[6]);
                                        Console.WriteLine("Enter answers ->"); int tmp6 = Convert.ToInt32(Console.ReadLine());
                                        if (tmp6 == 12)
                                        {
                                            Console.WriteLine("Your answer - true");
                                            Score++;

                                            Console.WriteLine(mathQuestion[7]);
                                            Console.WriteLine("Enter answers ->"); int tmp7 = Convert.ToInt32(Console.ReadLine());
                                            if (tmp7 == 96)
                                            {
                                                Console.WriteLine("Your answer - true");
                                                Score++;

                                                Console.WriteLine(mathQuestion[8]);
                                                Console.WriteLine("Enter answers ->"); int tmp8 = Convert.ToInt32(Console.ReadLine());
                                                if (tmp8 == 44)
                                                {
                                                    Console.WriteLine("Your answer - true");
                                                    Score++;

                                                    Console.WriteLine(mathQuestion[9]);
                                                    Console.WriteLine("Enter answers ->"); int tmp9 = Convert.ToInt32(Console.ReadLine());
                                                    if (tmp9 == 99)
                                                    {
                                                        Console.WriteLine("Your answer - true");
                                                        Score++;
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("error");
                                                        return;
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("error");
                                                    return;
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("error");
                                                return;
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("error");
                                            return;
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("error");
                                        return;
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("error!");
                                return;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Your answer - false");
                            return;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Your answer - false");
                        return;
                    }


                }
                // maybe add here !!!!!!!
                else
                {
                    Console.WriteLine("Error answer!");
                }
            }
            Console.WriteLine($"Your count score - {Score}");
        }

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
                    CreateVictorine(TypeQuestion.Math);
                }

            } while (true);

        }

        public void CreateVictorine()
        {
            throw new NotImplementedException();
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