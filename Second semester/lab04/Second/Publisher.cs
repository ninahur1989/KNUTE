using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    internal class Publisher
    {
        private EventBus _eventBus;

        public Publisher(EventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public void PublishEvent(string name, int priority, object data)
        {
            _eventBus.Publish(name, priority, data);
        }
    }
}
