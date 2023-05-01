namespace Third
{
    internal class EventBus
    {
        private Dictionary<string, List<CustomEventHandler>> _subscribers;
        public delegate void CustomEventHandler(object sender, CustomEventArgs e);
        private readonly object subscribersLock = new object();
        private readonly Random random = new Random();
        private readonly RetryPolicy retryPolicy;

        public EventBus(RetryPolicy retryPolicy)
        {
            _subscribers = new Dictionary<string, List<CustomEventHandler>>();
            this.retryPolicy = retryPolicy;
        }

        // Define a method for subscribers to register for events.
        public void Subscribe(string name, CustomEventHandler handler)
        {
            if (!_subscribers.ContainsKey(name))
            {
                _subscribers.Add(name, new List<CustomEventHandler>());
            }
            _subscribers[name].Add(handler);
        }

        // Define a method for subscribers to unregister from events.
        public void Unsubscribe(string name, CustomEventHandler handler)
        {
            if (_subscribers.ContainsKey(name))
            {
                _subscribers[name].Remove(handler);
            }
        }

        public void PublishEvent(string eventName, CustomEventArgs args)
        {
            int retryCount = 0;
            while (true)
            {
                try
                {
                    if (random.Next(0, 2) == 1)
                    throw new Exception();

                    foreach (var subscriber in _subscribers[eventName])
                    {
                        subscriber(this, args);
                    }

                    break; // Event published successfully
                }
                catch (Exception ex)
                {
                    if (retryCount >= retryPolicy.MaxRetries)
                        throw;

                    retryCount++;

                    // Randomize the delay time to avoid multiple event handlers executing simultaneously
                    TimeSpan delay = retryPolicy.GetDelay(retryCount);
                    int jitter = random.Next((int)delay.TotalMilliseconds / 4);
                    delay += TimeSpan.FromMilliseconds(jitter);

                    Thread.Sleep(delay);
                }
            }
        }
    }
}
