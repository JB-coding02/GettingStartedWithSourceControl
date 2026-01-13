using System;

namespace SourceControlAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("=== Git Practice App ===");
                Console.WriteLine("1. Say Hello");
                Console.WriteLine("2. Add Two Numbers");
                Console.WriteLine("3. Show Current Time");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        SayHello();
                        break;

                    case "2":
                        AddNumbers();
                        break;

                    case "3":
                        ShowTime();
                        break;

                    case "4":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void SayHello()
        {
            Console.WriteLine("Hello!");
        }

        static void AddNumbers()
        {
            Console.WriteLine("AddNumbers method not implemented yet.");
        }

        static void ShowTime()
        {
            Console.WriteLine("ShowTime method not implemented yet.");
        }
    }
}
