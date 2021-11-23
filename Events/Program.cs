using Events.Entities;
using Events.Events;
using System;

namespace Events
{
    public class Program
    {
        static void Main(string[] args)
        {
            var generator = new NumberGenerator();
            generator.OnGenerated += OnNumberGenerated;
            generator.Start();
        }

        public delegate void NumberHandler(object sender, NumberGeneratedEvent @event);

        static void OnNumberGenerated(object sender, NumberGeneratedEvent @event)
        {
            Console.WriteLine(@event.Number);
        }
    }
}
