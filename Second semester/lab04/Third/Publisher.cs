using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third
{
    internal class Publisher
    {
        private EventBus _eventBus;

        public Publisher(EventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public void PublishEvent(string eventName, CustomEventArgs args)
        {
            _eventBus.PublishEvent(eventName, args);
        }
    }
}
