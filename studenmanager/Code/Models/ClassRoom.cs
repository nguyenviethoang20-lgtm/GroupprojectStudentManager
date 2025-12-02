using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studenmanager.Code.Models
{
    internal class ClassRoom
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public ClassRoom() { }

        public ClassRoom(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
