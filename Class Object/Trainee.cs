using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object
{
    class Trainee:Person
    {
        public int NID;
        public int IntakeNumber;

        public Trainee()
        {
                
        }

        public Trainee(int _NID, int _IntakeNumber, string _name, int _age, Address _address)
        {
            NID = _NID;
            IntakeNumber = _IntakeNumber;
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
            return $"NID = {NID}, IntakeNumber = {IntakeNumber}, {base.ToString()}";
        }
    }
}
