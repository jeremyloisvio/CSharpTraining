using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = GenerateListOfPeople();

            //var peopleOverTheAgeOf30 = people.Where(x => x.Age > 30);
            //IEnumerable<FullName> afterTwo = people.Select(x => new FullName { First = x.FirstName, Last = x.LastName }); // Select FirstName and LastName
            //foreach (var person in afterTwo)
            //{
            //    Console.WriteLine(person.Last+" "+person.First);
            //}
            //Person firstOrDefault = people.FirstOrDefault(x => x.Age == 30); //two ways of condition
            //var firstDefault = people.Where(x => x.Age == 30).FirstOrDefault(); // 
            //Console.WriteLine(firstOrDefault.FirstName);
            //Console.WriteLine(firstDefault.FirstName);

            //Console.WriteLine("\n");
            //IEnumerable<string> afterTwo = people.Select(x => x.LastName); //Select All LastName on Items
            //foreach (var per in afterTwo)
            //{
            //    Console.WriteLine(per);
            //}

            //Console.WriteLine("\n");
            //Person lastOrDefault = people.LastOrDefault();
            //Console.WriteLine(lastOrDefault.FirstName);
            //Person lastThirtyYearOld = people.LastOrDefault(x => x.Age == 30); // Find the last item aged 30
            //Console.WriteLine(lastThirtyYearOld.FirstName);


            //Person single = people.SingleOrDefault(x => x.FirstName == "Eric"); //Find a single item Named Eric
            //Console.WriteLine(single.FirstName);
            //// Uncomment the next line to see it throw an exception
            //Person singleDev = people.SingleOrDefault(x => x.Occupation == "Manager"); 
            ////Console.Write(singleDev.FirstName);
            //int count = people.Count();//Count the Items
            //Console.WriteLine(count);
            //bool pep = people.Any();//Check if ELEMENTS exist , good way than Count 
            //Console.WriteLine(pep); 

            //bool everyoneatleasttwentyfour = people.All(x => x.Age >=24); // Check if all Elements are Aged 24 and above
            //Console.WriteLine(everyoneatleasttwentyfour);

            //List<Person> listOfDevs = people.Where(x => x.Occupation == "Dev").ToList(); //This will return a List<Person>
            //foreach (var person in listOfDevs)
            //{
            //    Console.WriteLine(person.Occupation);
            //}

            //Person[] arrayOfDevs = people.Where(x => x.Occupation == "Dev").ToArray(); //This will return a Person[] array
            //foreach (var person in arrayOfDevs)
            //{
            //    Console.WriteLine(person.FirstName);
            //}
          

              
                while (true)
                {
                    string answer;
                    Console.WriteLine("Filter Name to Search: ");
                    answer = (Console.ReadLine());
                    
                    IEnumerable<Person> afterTwo = people.Where(x => x.FirstName.Contains(answer)||
                        x.LastName.Contains(answer) || x.FirstName.Contains(answer.ToUpper()) || x.LastName.Contains(answer.ToUpper()))
                        .Select(x => new Person { FirstName = x.FirstName, LastName = x.LastName });


                    IEnumerable<Person> allFirstNames = people.Select(x => new Person{ FirstName = x.FirstName, LastName = x.LastName });
                  




                    if (answer == "exit"||answer =="EXIT") break;
                    bool checkstatus = afterTwo.Any();
                    if (checkstatus == true&&answer !="")
                    {
                        foreach (var person in afterTwo)
                        {
                            Console.WriteLine("Name: " + person.FirstName + " " + person.LastName);
                        }
                    }
                    else if (answer == "All")
                    {
                        foreach (var firstName in allFirstNames)
                        {
                            Console.WriteLine("Name: " +firstName.FirstName+ " " + firstName.LastName);
                        }

                    }
                    else
                    {
                        Console.WriteLine("No Person Named : " + answer + " on the List");
                    }
                  

                }
                Console.WriteLine("Process Completed");
                Console.ReadLine();
        }

        public static List<Person> GenerateListOfPeople()
        {
            var people = new List<Person>();
            people.Add(new Person { FirstName = "Eric", LastName = "Fleming", Occupation = "Dev", Age = 24 });
            people.Add(new Person { FirstName = "Steve", LastName = "Smith", Occupation = "Manager", Age = 40 });
            people.Add(new Person { FirstName = "Jeremy", LastName = "Enrick", Occupation = "Dev", Age = 30 });
            people.Add(new Person { FirstName = "Jane", LastName = "Doe", Occupation = "IT Associate", Age = 35 });
            people.Add(new Person { FirstName = "Jeremy", LastName = "Jones", Occupation = "Dev", Age = 24 });
            people.Add(new Person { FirstName = "Jeremy", LastName = "Viovicente", Occupation = "Dev", Age = 20 });
            people.Add(new Person { FirstName = "Lebron", LastName = "Jones", Occupation = "Manager", Age = 45 });
            people.Add(new Person { FirstName = "Mary", LastName = "Jones", Occupation = "IT Associate", Age = 35 });
            people.Add(new Person { FirstName = "Kobe", LastName = "Bryant", Occupation = "Qa", Age = 32 });
            people.Add(new Person { FirstName = "Jr", LastName = "Louis", Occupation = "Qa", Age = 21 });

            return people;
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Occupation { get; set; }
        public int Age { get; set; }
    }



    public class FullName
    {
        public string First { get; set; }
        public string Last { get; set; }
    }
}
