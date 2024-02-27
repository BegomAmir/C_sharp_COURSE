using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._2
{
    internal class Student:Man
    {
        string university;
        public Student(string name, int birthdayDate, string city, string university)
            :base( name,  birthdayDate, city)
        {
            this.university = university;
        }
        public string Print()
        {
            string result = base.Print();
            result += $", {university}";
            return result;
        }
    }
}
