using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace _13._2
{
    internal class Man
    {
        string name;
        int birthdayDate;
        string city;

        int BirthdayDate
        {
            get 
            {
                return birthdayDate;
            } 
            set
            {
                if (value > 2021)
                    birthdayDate = 2021;
                else if (value < 1900)
                    birthdayDate = 1900;
                else
                    birthdayDate = value;                          
            }
        }
        public Man(string name, int birthdayDate, string city)
        {
            this.name = name;
            this.birthdayDate = birthdayDate;
            this.city = city;
        }
        public string Print()
        {
            return $"{name}, {birthdayDate}, {city}";
        }
    }
}
