using System;
using System.IO;
using System.Threading;
namespace Namespace
{
    internal class Programm
    {

        static void Main(string[] Args)
        {
            int Counter = 0;
            Person[] person = new Person[20];
            while (true)
            {
                if (person[Counter] == null)
                {
                    person[Counter] = new Person();
                }

                Console.WriteLine("Press [D] if you want to Check for Data oder [N] if you want to Enter new Data! [Esc] to end the Programm!");
                ConsoleKeyInfo Key = Console.ReadKey(intercept: true);
                if (Key.Key == ConsoleKey.N)
                {
                    while (true)
                    {
                        if (Counter == 20)
                        {
                            Console.WriteLine("You Can't add any new Data! Press [Esc] to go Back!");
                        }
                        else
                        {
                            Console.Write("Whats your first Name?: ");
                            person[Counter].FirstName = Console.ReadLine();
                            Console.Write("Whats your Last Name?: ");
                            person[Counter].LastName = Console.ReadLine();
                            Console.Write("When were you born? (DD.MM.YYYY): ");
                            while (true)
                            {
                                try
                                {
                                    person[Counter].Birthday = Convert.ToDateTime(Console.ReadLine());
                                    break;
                                }
                                catch
                                {
                                    Console.WriteLine("Please Enter a correct Input!");
                                }
                            }
                            Console.WriteLine($@"
Your Data:
-------------------------------------------------
First Name: {person[Counter].FirstName}
Last Name: {person[Counter].LastName}
Birthday: {person[Counter].Birthday.ToShortDateString()}
-------------------------------------------------");
                            Console.WriteLine("Do you want to Enter more Data? [Y/N]");
                            Key = Console.ReadKey(intercept: true);
                            if (Key.Key == ConsoleKey.Y)
                            {
                                Console.Clear();
                            }
                            if (Key.Key == ConsoleKey.N)
                            {
                                Console.Clear();
                                break;
                            }
                        }
                        if (Counter < 20)
                        {
                            Counter++;
                        }
                    }
                }
                if (Key.Key == ConsoleKey.D)
                {
                    Console.Clear();
                    Console.Write("Enter your First Name:");
                    string firstName = Console.ReadLine();
                    Console.Write("Enter your Last Name:");
                    string lastName = Console.ReadLine();
                    while (true) 
                    {
                        try
                        {
                            for (int i = 0; i < person.Length; i++)
                            {
                                if (person[i].LastName == lastName && person[i].FirstName == firstName)
                                {
                                    Console.WriteLine($@"
Your Data:
-------------------------------------------------
First Name: {person[i].FirstName}
Last Name: {person[i].LastName}
Birthday: {person[i].Birthday.ToShortDateString()}
-------------------------------------------------");
                                    Console.WriteLine("Do you want to save your Data in a Text-File? [Y/N]");
                                    Key = Console.ReadKey(intercept: true);
                                    if (Key.Key == ConsoleKey.Y)
                                    {
                                        while (true)
                                        {
                                            try
                                            {
                                                File.WriteAllText($@"C:\Users\Public\Documents\{person[i].FirstName}_{person[i].LastName}_Data", $@"
Your Data:
-------------------------------------------------
First Name: {person[Counter].FirstName}
Last Name: {person[Counter].LastName}
Birthday: {person[Counter].Birthday.ToShortDateString()}
-------------------------------------------------");
                                                Console.WriteLine($@"Data saved successfully in C:\Users\Public\Documents\{person[i].FirstName}_{person[i].LastName}_Data!");
                                                break;
                                            }
                                            catch
                                            {
                                                Console.WriteLine(@"Failed to save Data! Do you want to try again? [Y/N]");
                                                Key = Console.ReadKey(intercept: true);
                                                if (Key.Key == ConsoleKey.Y)
                                                {
                                                    Console.Clear();
                                                }
                                                if (Key.Key == ConsoleKey.N)
                                                {
                                                    Console.Clear();
                                                    break;
                                                }
                                            }
                                        }
                                        break;
                                    }
                                    if (Key.Key == ConsoleKey.N )
                                    {
                                        Console.Clear();
                                        break;
                                    }
                                }
                            }
                            Console.WriteLine("Do you want to Check more Data? [Y/N]");
                            Key = Console.ReadKey(intercept: true);
                            if (Key.Key == ConsoleKey.Y)
                            {
                                Console.Clear();
                            }
                            if (Key.Key == ConsoleKey.N )
                            {
                                Console.Clear();
                                break ;
                            }

                        }
                        catch
                        {
                            Console.WriteLine("This Name isn't registered! Do you Want to try again? [Y/N]");
                            Key = Console.ReadKey(intercept: true);
                            if (Key.Key == ConsoleKey.Y)
                            {
                                Console.Clear();
                            }
                            else
                            {
                                Console.Clear();
                                break;
                            }
                        }
                    }
                }
                if (Key.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }
    }
    class Person
    {
        public string LastName;
        public string FirstName;
        public DateTime Birthday;
    }
}
