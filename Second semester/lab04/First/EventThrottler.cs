using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    public class EventThrottler
    {
        private DateTime _lastEventTime;
        private TimeSpan _throttleInterval;

        public EventThrottler(TimeSpan throttleInterval)
        {
            _lastEventTime = DateTime.MinValue;
            _throttleInterval = throttleInterval;
        }

        public bool CanSendEvent()
        {
            DateTime now = DateTime.Now;
            if (now - _lastEventTime > _throttleInterval)
            {
                _lastEventTime = now;
                return true;
            }
            return false;
        }
    }
}
