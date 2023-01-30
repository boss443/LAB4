using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4Encapsulation
{
    internal class Classroom
    {
        private string name;
        private List<Person> person = new List<Person>();
     
        public Classroom(string name) { 
            this.name = name;
            
        }

        public void addPerson2Class(Person p)
        {
            this.person.Add(p);

        }
        public string showAllPersoninClass() {
            string result = "";
            foreach (Person p in this.person)
            {
                result += p.getName() + "\r\n";
                result += p.getBirthYear() + "\r\n";
                result +=p.getGPA + "\r\n";
            }
            return "";
        }
    }

}   


           

    



    

   


