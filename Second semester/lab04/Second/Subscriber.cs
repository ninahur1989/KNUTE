using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    internal class Subscriber
    {
        public Subscriber(EventBus eventBus, int priority)
        {
            eventBus.Subscribe(priority, CustomEventHandler);
        }

        private void CustomEventHandler(object sender, CustomEventArgs e)
        {
            Console.WriteLine($"Handling event '{e.Name}' with priority {e.Priority}: {e.Data}");
        }
    }
}
