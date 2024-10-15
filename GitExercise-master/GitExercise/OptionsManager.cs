using System;

namespace GitExercise
{
    public static class OptionsManager
    {
        public static string[] OptionsList = {
            "a - Add",
            "s - Subtract",
            "m - Multiply",
            "d - Devide",
            "abs - Absolute"
        };

        public static void Add(double a, double b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }

        public static void Multiply(double a, double b)
        {
            Console.WriteLine($"{a} x {b} = {a * b}");
        }

        public static void Subtract(double a, double b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
        }

        public static void Devide(double a, double b) 
        {
            Console.WriteLine($"{a} / {b} = {a / b}");
        }

        public static void Absolute(double a, double b)
        {
            Console.WriteLine($"{a} - {b} = {a - Math.Abs(b)}");
        }
    }
}
