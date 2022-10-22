using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_inheritance_and_more_about_oop
{
    class Ticket : IEquatable<Ticket>
    {
        // property to store the duration of the ticket in hours
        public int DurationInHours { get; set; }
        public Ticket(int durationInHours)
        {
            DurationInHours = durationInHours;
        }

        public bool Equals(Ticket other)
        {
            return DurationInHours == other.DurationInHours;
        }

        public static void Run()
        {
            Ticket ticket1 = new Ticket(3);
            Ticket ticket2 = new Ticket(3);
            Console.WriteLine(ticket1.Equals(ticket2));
        }
    }
}
