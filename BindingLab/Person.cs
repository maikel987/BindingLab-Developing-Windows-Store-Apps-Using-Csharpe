using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingLab
{
    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Person(int _age, string _name)
        {
            Age = _age;
            Name = _name;
        }
    }
}
