using System;
namespace InterfaceDemo
{
    public class Ticket : IEquatable<Ticket>
    {
        // property o store the duration of the ticket in hour.
        public int DurationInHours { get; set; }

        //simple constructor
        public Ticket(int durationInHours)
        {
            DurationInHours = durationInHours;
        }

        //method to check if the tickets durations are the same.
        public bool Equals(Ticket other)
        {
            return this.DurationInHours == other.DurationInHours;
        }
    }
}
