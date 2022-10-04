using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1
{
    internal class Address
    {
        private int _index;
        private string _city;
        private string _street;
        private string _house;
        private string _apartment;

        public int Index { get { return _index; } set { _index = value; } }

        public string City { get { return _city; } set { _city = value; } }

        public string Street { get { return _street; } set { _street = value; } }

        public string House { get { return _house; } set { _house = value; } }

        public string Apartment { get { return _apartment; } set { _apartment = value; } }
    }
}
