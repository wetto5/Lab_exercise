using System;

namespace GitExercise
{
    public class Startup
    {
        private const string Password = "abcd1234";
        private static bool CheckCredentials() 
        {
            Console.Write("Enter password to gain access: ");
            string password = Console.ReadLine();
            Console.Clear();

            return password == Password;
        }
        public static void Main()
        {
            bool isAuthorized = CheckCredentials();

            if (!isAuthorized)
            {
                Console.WriteLine("Acces denied.");
                Console.ReadKey(intercept: true);
                return;
            }
            

            Console.WriteLine("Console Calculator App");
            Console.WriteLine(new string('-', 15));

            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            Console.WriteLine("Choose one from the listed options:");
            foreach (string option in OptionsManager.OptionsList)
            {
                Console.WriteLine($"\t{option}");
            }

            Console.Write("Option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "a":
                    OptionsManager.Add(a, b);
                    break;
                case "s":
                    OptionsManager.Subtract(a, b);
                    break;
                case "m":
                    OptionsManager.Multiply(a, b);
                    break;

                case "d":
                    OptionsManager.Devide(a, b);
                    break;
                case "abs":
                    OptionsManager.Absolute(a, b);
                    break;
            }

            Console.WriteLine("Pres any key to close the app...");
            Console.ReadKey(true);
        }
    }
}
