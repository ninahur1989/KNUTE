namespace Second
{

    internal class EventBus
    {
        private Dictionary<int, List<CustomEventHandler>> _subscribers;
        public delegate void CustomEventHandler(object sender, CustomEventArgs e);

        public EventBus()
        {
            _subscribers = new Dictionary<int, List<CustomEventHandler>>();
        }

        // Define a method for subscribers to register for events.
        public void Subscribe(int priority, CustomEventHandler handler)
        {
            if (!_subscribers.ContainsKey(priority))
            {
                _subscribers.Add(priority, new List<CustomEventHandler>());
            }
            _subscribers[priority].Add(handler);
        }

        // Define a method for subscribers to unregister from events.
        public void Unsubscribe(int priority, CustomEventHandler handler)
        {
            if (_subscribers.ContainsKey(priority))
            {
                _subscribers[priority].Remove(handler);
            }
        }

        // Define a method for creating and publishing events.
        public void Publish(string name, int priority, object data)
        {
            var e = new CustomEventArgs { Name = name, Priority = priority, Data = data };

            // Iterate over the list of subscribers for this priority.
            foreach (var handler in _subscribers[priority])
            {
                // Invoke the subscriber's event handler with the event data.
                handler(this, e);
            }
        }
    }
}
