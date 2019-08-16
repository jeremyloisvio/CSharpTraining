using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingwithScopeAndAccessibilityModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
    
            Console.WriteLine(RosName);
            Console.Read();

        }
    }


            public class Person
        {
            public Person(string firstName, string lastName, DateTime dateOfBirth,string course)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.DateOfBirth = dateOfBirth;
                this.Course = course;
            }

            protected string FirstName { get; private set; }
            protected string LastName { get; private set; }
            public DateTime DateOfBirth { get; private set; }
            public string Course { get; private set; }
            public string FullName { get { return this.FirstName+" "+this.LastName; } }
    
            public bool IsAnAdult()
            {
                var eighteenYearsAgo = DateTime.Today.AddYears(-18);
                return this.DateOfBirth < eighteenYearsAgo;
            }
        }

        public class Student : Person
        {
            public Student (string firstName, string lastName, DateTime dateOfBirth,string course)
                : base(firstName, lastName, dateOfBirth, course)
            { }
            public string SchoolName { get; set; }

            public string RosterName { get { return this.LastName+" "+this.FirstName; } }
        }

        public class Course : Person
        {

            public Course(string firstName, string lastName, DateTime dateofBirth, string course)
               :base (firstName,lastName,dateofBirth,course)
            { 
            }
  
                    
        public void OtherFunction()
        {
            Student one = new Student("Jimmy", "Jones", new DateTime(1990, 3, 15),"IT");
            Student two = new Student("Jeremy", "Lois", new DateTime(1999, 6, 05),"IT");
            Student three = new Student("Lebron", "James", new DateTime(1990, 3, 2),"CS");
            Student four = new Student("Mer", "Ann", new DateTime(1998, 3, 20),"IT");
            List<Student> st = new List<Student>();
            {      
            st.Add(one);
            st.Add(two);
            st.Add(three);
            st.Add(four);
            }
            foreach(Student rec in st ){
                Console.WriteLine("{0}\nBday: {1}\nCourse: {2}\n, s.RosterName, s.DateOfBirth, s.Courses");
            }
     
            }
        public string RosName { get { return this.LastName + " " + this.FirstName; } } 
        }

}
