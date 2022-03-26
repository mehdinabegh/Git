using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Person
{
    internal class Person  
    {
        public Person()
        {

        }
        public Person(int id)
        {
            this.ID = id;
        }
        public Person(int id,string name , string family):this(id)
        {
            this.Name = name;
            this.Family= family;
        }
        private string _name;
        private string _family;
        public string Name { get { return _name; } set { _name = value; } }
        public string Family { get { return _family; } set { _family = value; } }
        public int ID { get; set; }
        public string ShowInfo { get { return string.Format("{0}\r\n{1}\r\n{2}", this.Name, this.Family, this.ID); } }
    }
}
