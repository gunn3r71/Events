using System;

namespace Events.Events
{
    public class NumberGeneratedEvent : EventArgs
    {
        public NumberGeneratedEvent(int number)
        {
            Number = number;
        }

        public int Number { get; private set; }
    }
}
