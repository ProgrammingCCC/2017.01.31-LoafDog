/*
 * LoafDog Mania
 * Your Name, Date
 * 
 * An example application to show some programming fundamental concepts
 * datatype, string, double, class, instance, object, method, function
 * LoafDog idea created by Spring 2017 Introduction to Programming class
 */

using System;

namespace LoafDog
{
    class Program
    {
        static void Main()
        {
            Yard.Run();
        }
    }

    class Dog
    {
        public string Name;
        public double Size;

        public void Loaf()
        {
            Console.WriteLine(Name + " sleeps");
        }
        public void Bork()
        {
            Console.WriteLine(Name + " borks\n");
        }
    }

    class Yard
    {
        static string Name = "Borkery";
        static double Size = 2.5;

        public static void Run()
        {
            Console.Title = "LoafDog Mania";
            Console.WriteLine("Welcome to the \"" + Name + "\" yard. It is " + Size + " acres.");
            Console.WriteLine("Loafdog Mania created by Your Name.\n\n");
            Console.WriteLine("Press enter to continue...");
            Console.ReadKey();
            Console.Clear();

            Dog Crispy = new Dog();
            Crispy.Name = "Crispy D. Wonderbread";
            Crispy.Size = 6;

            Crispy.Loaf();
            Crispy.Bork();

            Dog Toast = new Dog();
            Toast.Name = "Toasty Toast Toast";
            Toast.Size = 2;
            Toast.Loaf();
            Toast.Bork();

            Console.ReadKey();

        }

    }
}
