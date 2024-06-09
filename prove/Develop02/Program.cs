using System;
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Write a new entry
                    Console.WriteLine("Writing a new entry...");
                    // Prompt the user for response and save it to journal
                    // You can generate a random prompt here
                    Console.Write("Enter response: ");
                    string response = Console.ReadLine();
                    Console.Write("Enter date (YYYY-MM-DD): ");
                    string date = Console.ReadLine();
                    // You can choose a random prompt here
                    string prompt = "Who was the most interesting person I interacted with today?";
                    journal.AddEntry(prompt, response, date);
                    break;
                case "2":
                    // Display the journal
                    Console.WriteLine("Displaying the journal...");
                    journal.DisplayJournal();
                    break;
                case "3":
                    // Save the journal to a file
                    Console.Write("Enter filename to save: ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    Console.WriteLine("Journal saved to file.");
                    break;
                case "4":
                    // Load the journal from a file
                    Console.Write("Enter filename to load: ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename);
                    Console.WriteLine("Journal loaded from file.");
                    break;
                case "5":
                    // Exit the program
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }
        }
    }
}
