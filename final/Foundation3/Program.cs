using System;

public class Program
{
    public static void Main()
    {
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Address address3 = new Address("789 Oak St", "Vancouver", "BC", "Canada");

        Lecture lecture = new Lecture("C# Programming Lecture", "An in-depth look at C# programming.", "2024-07-15", "10:00 AM", address1, "Jane Smith", 100);
        Reception reception = new Reception("Networking Reception", "An opportunity to network with professionals.", "2024-08-10", "6:00 PM", address2, "rsvp@example.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Summer Picnic", "A fun summer picnic for everyone.", "2024-09-05", "12:00 PM", address3, "Sunny");

        Event[] events = { lecture, reception, outdoorGathering };

        foreach (var ev in events)
        {
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine();
        }
    }
}
