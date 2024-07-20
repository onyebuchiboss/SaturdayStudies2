using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaturdayStudies
{
    public class Person
    {
        public int Age { get; set; }
        public double Height { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }



        public List<Person> People()
        {
            List<Person> pP = new()
            {
                new Person { Age = 16, Height = 5.4, DOB = new DateTime(1996, 3, 23), Name = "IyiniOluwa" },
                new Person { Age = 12, Height = 5.3, DOB = new DateTime(1994, 2, 20), Name = "Iree" },
                new Person { Age = 34, Height = 5.8, DOB = new DateTime(1990, 1, 01), Name = "Victor" }
            };
            
            return pP;

        }
    }



}
