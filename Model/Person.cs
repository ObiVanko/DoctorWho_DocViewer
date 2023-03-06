using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_updated
{
    abstract class Person
    {
        public string Name;
        public string Actor;
        public List<int> Seasons;
        public string ImageWay;
        public int ID;

        public Person(string Name, string Actor, List<int> Seasons, int ID, string ImageWay) 
        { 
            this.Name = Name;  
            this.Actor = Actor;
            this.Seasons = Seasons;
            this.ImageWay = ImageWay;
            this.ID = ID;
        }

        public virtual string PersonInfo(Person person)
        { 
            return $"{person.Name} \n \nАктер: {person.Actor} \nСезоны: {person.Seasons} ";
        }
    }
}
