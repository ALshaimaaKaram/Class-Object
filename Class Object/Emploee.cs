using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object
{
    class Emploee:Person
    {
        public int NID;
        public int Salary;

        public Emploee() { }
        public Emploee(int _NID, int _Salaray, string _name, int _age, Address _address)
        {
            NID = _NID;
            Salary = _Salaray;
            address = _address;
            name = _name;
            age = _age;
        }

        public override Person Clone()
        {
            Person p = (Person)this.MemberwiseClone();

            p.address.City = this.address.City;
            p.address.Street = this.address.Street;
            p.address.ZipCode = this.address.ZipCode;

            return p;
        }

        public override string ToString()
        {
            return $"NID = {NID}, Salary = {Salary}, {base.ToString()}";
        }
    }
}
