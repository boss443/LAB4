using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4Encapsulation
{
    internal class Person
    {
        private string name;
        private int birthYear;
        private int GPA;
        private int age;

        public Person(string input_name, int bYear, int GPA)
        {
            this.name = name;
            this.birthYear = bYear;
            this.GPA = GPA;
            this.age = 2566 - bYear;
        
        }
       
        public string getName() {
            return this.name;

        }
        public int getBirthYear()
        {
            return this.birthYear;
        }
        public int getGPA()
        {
            return this.GPA;
        }
    }
}
