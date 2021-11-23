using Events.Events;
using System;
using System.Threading;
using static Events.Program;

namespace Events.Entities
{
    public class NumberGenerator
    {
        public Random Random { get; private set; }
        public event NumberHandler OnGenerated;

        public NumberGenerator()
        {
            Random = new Random();
        }

        public void Start()
        {
            while (true)
            {
                var n = Random.Next(100);
                if (OnGenerated is not null)
                    OnGenerated(this, new NumberGeneratedEvent(n));
                Thread.Sleep(500);
            }
        }
    }
}
