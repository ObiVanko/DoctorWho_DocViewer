using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_updated
{
    class Companion : Person
    {
        public List<string> Doctors;

        public Companion(string Name, string Actor, List<int> Seasons, int ID, List<string> Doctors, string ImageWay) : base(Name, Actor, Seasons, ID, ImageWay)
        {
            this.Doctors = Doctors;
        }
        public Companion(string Name, string Actor, List<int> Seasons, int ID, string ImageWay) : base(Name, Actor, Seasons, ID, ImageWay)
        {
        }
 
        public override string PersonInfo(Person person)
        {
            return base.PersonInfo(person) + $"Докторы: {Doctors}";
        }
    }
}
