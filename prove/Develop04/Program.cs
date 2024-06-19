// Main program class
    class Program
    {
        static void Main(string[] args)
        {
            // Load existing activity log if available
            Activity.LoadLog();

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Hello MindfulnessApp World!");
                Console.WriteLine("Welcome to the Mindfulness App!");
                Console.WriteLine("Please enter a number to select one of the following activities.");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Listing Activity");
                Console.WriteLine("3. Reflection Activity");
                Console.WriteLine("4. Exit");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Activity activity = new BreathingActivity();
                    activity.Start();
                }
                else if (choice == "2")
                {
                    Activity activity = new ListingActivity();
                    activity.Start();
                }
                else if (choice == "3")
                {
                    Activity activity = new ReflectionActivity();
                    activity.Start();
                }
                else if (choice == "4")
                {
                    // Save log and exit the program
                    Activity.SaveLog();
                    Console.WriteLine("Log saved. Goodbye!");
                    exit = true;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                }
            }
        }
    }