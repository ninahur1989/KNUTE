using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third
{
    internal class Subscriber
    {
        public Subscriber(string name, EventBus eventBus)
        {
            eventBus.Subscribe(name, CustomEventHandler);
        }

        private void CustomEventHandler(object sender, CustomEventArgs e)
        {
            Console.WriteLine($"Handling event {e.Name}");
        }
    }
}
