using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw4
{
    internal class User
    {
        public User()
        {
            DateSubmited = DateTime.UtcNow;
        }

        public string Login { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public DateTime DateSubmited { get; }
    }
}
