using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object
{
    abstract class Person
    {
        public string name;
        public int age;
        public Address address;

        public Person()
        { }

        public Person(string _name, int _age, Address _address)
        {
            name = _name;
            age = _age;
            address = _address;
        }

        public override string ToString()
        {
            return $"Name = {name} ,Age = {age}, {address.ToString()}";
        }

        public abstract Person Clone();

    }
}
