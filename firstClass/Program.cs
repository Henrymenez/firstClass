using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;

namespace firstClass
{
   
 
    
    internal class Program
    {
        public void strConvert()
        {

            string str = Console.ReadLine();
            if(str.Length > 4)
            {
                string s = str.Substring(str.Length - 4);
                int Place = str.IndexOf(s);
                string result = str.Remove(Place, s.Length);
                string newHash = "";
                foreach (char c in result)
                {
                    if (c == ' ')
                    {
                        newHash += "#"; 
                    }
                    else
                    { 
                        newHash += "#";
                    }
                }
                string output = newHash + s;
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("String should be more than four characters!!!");
            }
           
        }

        public void capstrIndex()
        {
            string str = Console.ReadLine();

            string result = string.Concat(Regex
              .Matches(str, "[A-Z]")
              .OfType<Match>()
              .Select(match => match.Value));

            List<int> list = new List<int>();
            foreach (char c in result)
            {
                list.Add(str.IndexOf(c));

            }

            Console.Write("The Indexes are: ");

            Console.WriteLine(String.Join("; ", list));
        }

        public void difBtwBreakCont()
        {
            Console.WriteLine("Continue Statement skips the number 4 but contunies to finish te loop: ");
            for (int x = 0; x < 10; x++)
            {
                if (x == 4)
                {
                    continue;
                }
                Console.WriteLine(x);
            }
            Console.WriteLine("Break Statment stops the loop when the condition is met : ");
            for (int x = 0; x < 10; x++)
            {
                if (x == 4)
                {
                    break;
                }
                Console.WriteLine(x);
            }
        }

        public void libManagement()
        {

            Console.WriteLine("Enter an Option: ");
            string str = Console.ReadLine().ToLower();


            if (str == "e")
            {
                Console.WriteLine("EFCore Books");
            }
            else if (str == "c")
            {
                Console.WriteLine("C# Books");
            }
            else if (str == "d")
            {
                Console.WriteLine("Clean Coding Books");
            }
            else if (str == "o")
            {
                Console.WriteLine(".NET Core Books");
            }
            else
            {
                Console.WriteLine("Select from the valid options e,c,d & o");
            }
        }

        public void dateToSevenDays()
        {

            // DateTime inSevenDays = DateTime.Today.AddDays(7);
            try
            {
                Console.WriteLine("Insert Date with the formart '08 Nov 2022'");
                string data = Console.ReadLine();
                DateTime inSevenDays = DateTime.Parse(data).AddDays(7);
                Console.WriteLine(inSevenDays);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public void basicAuth()
        {
            Console.WriteLine("What would u like to do?");
            Console.WriteLine("Type reg to register or log to login");
            string str = Console.ReadLine();
            if (str == "reg")
            {
                Console.WriteLine("Register Here \n");
                Console.WriteLine("Username: ");
                string username = Console.ReadLine();
                Console.WriteLine("Password: ");
                string password = Console.ReadLine();
                File.WriteAllText(username + ".txt", password);
                Console.WriteLine("You have successfully completed you registration, Thank you");
            }
            else if (str == "log")
            {
                Console.WriteLine("Enter Username: ");
                string savedPassword = "";
                string username = Console.ReadLine();
                foreach (string fileName in Directory.GetFiles("C:\\Users\\USER\\Desktop\\bezao\\firstClass\\firstClass\\bin\\Debug\\net6.0"))
                {
                    FileInfo fi = new FileInfo(fileName);
                    string justFileName = fi.Name;
                    if (username.ToLower() + ".txt" == justFileName)
                    {
                        string readText = File.ReadAllText(justFileName);
                        savedPassword = readText;

                    }

                }
                if (savedPassword != "")
                {
                    Console.WriteLine("Enter Password: ");
                    string pass = Console.ReadLine();
                    if (savedPassword == pass)
                    {
                        Console.WriteLine("Congrats login successful");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Password");
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect Username");
                }
            }
        }


        static void Main(string[] args)
        {
            Program p = new Program();

                // p.strConvert(); //first task
                //p.capstrIndex();// second task
                //  p.dateToSevenDays(); third task
                // p.difBtwBreakCont(); fourth task
              //  p.basicAuth(); //fifth task
            // p.libManagement(); sixth task

            }
            


        
    }
}