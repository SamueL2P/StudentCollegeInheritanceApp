using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCollegeInheritanceApp.Models
{
    internal class Person
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public DateOnly Dob {  get; set; }

        public Person()
        {
            
        }
        public Person(int id , string address , DateOnly dob)
        {
            Id = id ;   
            Address = address ;
            Dob = dob ;
        }

        public virtual string PrintDetails() {

            return $"Person Id : {Id} \nPerson Address : {Address} \nPerson Date of Birth : {Dob}";
            
        }

    }
}
