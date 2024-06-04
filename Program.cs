using System;

public class Program
{
    public static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Lecture lecture = new Lecture("C# Basics", "Introduction to C#", "01/06/2024", "10:00 AM", address1, "John Doe", 50);

        Address address2 = new Address("456 Elm St", "Springfield", "IL", "USA");
        Reception reception = new Reception("Networking Event", "Meet and greet with professionals", "01/07/2024", "6:00 PM", address2, "rsvp@example.com");

        Address address3 = new Address("789 Oak St", "Springfield", "IL", "USA");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Community Picnic", "Annual community picnic", "01/08/2024", "12:00 PM", address3, "Sunny");

        Event[] events = { lecture, reception, outdoorGathering };

        foreach (Event eventItem in events)
        {
            Console.WriteLine(eventItem.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine(eventItem.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine(eventItem.GetShortDescription());
            Console.WriteLine("\n-------------------------\n");
        }
    }
}
