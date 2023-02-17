using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3
{
    public class Employee
    {
        public Employee(string name, string surname)
        {
            _name = name;
            _surname = surname;
            Random random = new Random();
            _experience = random.Next(0, 20);
            Role = (Role)random.Next(0, 3);

            if (_experience > 10)
            {
                _salary = _salary + 4442;
            }

            if (Role == (Role)2)
            {
                _salary = _salary + 5451;
            }
        }

        public string _name;
        public string _surname;
        public int _experience;
        public int _salary = 10000;
        public int _handouts;

        public Role Role { get; set; }

        public int Salary { get { return _salary; }  }

        public int Handouts
        {
            get {
                if (Salary >= 14000)
                {
                    _handouts = _salary / 15;
                }
                else
                {
                    _handouts = Salary / 10;
                }
                return _handouts;
            }
        }

        public int Koood {
            get
                { 

                Koood= 1;
                    return Koood;

                }
            set
            { 
            }
        }
    }
}
