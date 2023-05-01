using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third
{
    public class CustomEventArgs : EventArgs
    {
        public string Name { get; set; }
        public int Priority { get; set; }
        public object Data { get; set; }
    }
}
