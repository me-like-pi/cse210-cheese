using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathing = new BreathingActivity();
        ReflectionActivity reflecting = new ReflectionActivity();
        ListingActivity listing = new ListingActivity();
        bool exit = false;



        while(!exit)
        {
            Console.WriteLine("Hello MindfullnessApp World!");
            Console.WriteLine("Welcome to the Mindfullness App!");
            Console.WriteLine("Please enter a number to select one of the following activities.");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflection Activity");
            Console.WriteLine("4. Exit");

            string choice = Console.ReadLine();

            if (choice == "1")
            {

            }
            else if (choice == "2")
            {

            }
            else if (choice == "3")
            {
            
            }
            else if (choice == "4")
            {
                // Exit the program
                exit = true;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a valid option.");
            }
        }



        // Activity activity = new Activity();

        


    }
}