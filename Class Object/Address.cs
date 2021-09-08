using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object
{
    class Address
    {
        public string City;
        public string Street;
        public int ZipCode;

        public Address()
        {

        }

        public Address(string _city, string _street, int _zipcode)
        {
            City = _city;
            Street = _street;
            ZipCode = _zipcode;
        }

        public override string ToString()
        {
            return $"City = {City}, Street = {Street}, ZipCodeOfAddress = {ZipCode}";
        }
    }
}
