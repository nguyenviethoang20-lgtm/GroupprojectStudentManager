using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studenmanager.Code.Models
{
    internal class ClassRoom
    {
        public string MSSV { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string BirthDay { get; set; }


        public string ClassName { get; set; }
        public double Point { get; set; }
        public String Grade { get; set; }
        public string Year { get; set; }

        public ClassRoom() { }

        public ClassRoom(string MSSV, string Name, string Gender, string BirthDay, string ClassName, double Point, String Grade, string Year)
        {

           this.MSSV = MSSV;
            this.Name = Name;
            this.Gender = Gender;
            this.BirthDay = BirthDay;
            this.ClassName = ClassName;
            this.Point = Point;
            this.Grade = Grade;
            this.Year = Year;

        }
    }
}
