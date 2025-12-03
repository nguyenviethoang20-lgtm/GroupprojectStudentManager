using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studenmanager.Code.Models
{
    internal class ClassRoom
    {
        public string MSSV { get; set; }
        public string Name { get; set; }
      
        
        public string ClassName { get; set; }
        public double Point { get; set; }

        public ClassRoom() { }

        public ClassRoom(string name, string mssv,double point,string classname )
        {
            Name = name;
            Point = point;
            MSSV = mssv;
            ClassName = classname;



        }
    }
}
