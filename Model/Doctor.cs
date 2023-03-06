using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_updated
{
    class Doctor : Person
    {

        public List<Companion> Companions;

        public Doctor(string Name, string Actor, List<int> Seasons, int ID, List<Companion> Companions, string ImageWay) : base(Name, Actor, Seasons, ID, ImageWay) 
        {
            this.Companions = Companions;
        }
        public Doctor(string Name, string Actor, List<int> Seasons, int ID, string ImageWay) : this(Name, Actor, Seasons, ID, null, ImageWay)
        {
        }

        public override string PersonInfo(Person person)
        {
            return base.PersonInfo(person) + $"Спутники: {Companions}";
        }

    }
}
