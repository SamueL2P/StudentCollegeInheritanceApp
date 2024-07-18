using StudentCollegeInheritanceApp.Models;

namespace StudentCollegeInheritanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(1 , "Thane" , new DateOnly(2002 , 11 , 22));
            Student student = new Student(2 , "Mumbai" , new DateOnly(2002 , 10 , 3) , "Computer");
            Professor professor = new Professor(3 , "Andheri" , new DateOnly(2002 , 4 , 10) , 40000);

            PrintDetails(person);
            PrintDetails(student);
            PrintDetails(professor);
         
        }

        static void PrintDetails(Person person)
        {
            Console.WriteLine($"======================={person.GetType().Name}========================");
            Console.WriteLine(person.PrintDetails());
        }
    }
}
