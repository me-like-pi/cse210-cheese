using System;

class Program
{
    // Runs the program by calling a new instance of Scripture and using the display function.
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Scripture Memorizer!");
        // initializing new classes
        Reference newScriptureCPD = new Reference();
        Scripture verseCPD = new Scripture();
        
        
        //Displaying the scripture without anything missing.
        newScriptureCPD.Display();
        Console.WriteLine("Press Enter to Start or type 'quit' to exit.");

        //Starting the loop.
        verseCPD.Display();
        
        


    }
}