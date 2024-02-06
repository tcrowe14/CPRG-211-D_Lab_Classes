using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_creating_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person person2 = new Person(2, "Gina", "James", "Green", 18, false);
            Person person3 = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person person4 = new Person(4, "Mary", "Beals", "Yellow", 28, true);

            person2.displayPersonInfo();
            person3.toString();
            person1.changeFavoriteColour();
            person1.displayPersonInfo();
            person4.getAgeInTenYears();
            Console.ReadLine();

            Relation relation1 = new Relation(RelationshipType.Sister);
            relation1.ShowRelationship(person2, person4);
            Console.ReadLine();

            Relation relation2 = new Relation(RelationshipType.Brother);
            relation2.ShowRelationship(person1, person3);
            Console.ReadLine();


            // Create a list to hold people
            List<Person> peopleList = new List<Person>();
            peopleList.Add(person1);
            peopleList.Add(person2);
            peopleList.Add(person3);
            peopleList.Add(person4);

            // Calculate average age
            int totalAge = 0;
            foreach (Person person in peopleList)
            {
                totalAge += person.Age;
            }
            double average = (double)totalAge / peopleList.Count;
            //Console.WriteLine(totalAge); // Display age total
            //Console.WriteLine(peopleList.Count); // Display the people count
            Console.WriteLine($"Average age is: {average}");
            Console.ReadLine();


            // Oldest and youngest
            Person youngestPerson = peopleList.OrderBy(p => p.Age).First();
            Console.WriteLine($"The youngest person is: {youngestPerson}");
            Console.ReadLine();

            Person oldestPerson = peopleList.OrderByDescending(p => p.Age).First();
            Console.WriteLine($"The oldest person is: {oldestPerson}");
            Console.ReadLine();


            // People who start with M
            foreach (Person person in peopleList.Where(p => p.FirstName.StartsWith("M", StringComparison.OrdinalIgnoreCase)))
            {
                person.toString();
                Console.WriteLine("");
                Console.ReadLine();
            }


            // People who like Blue
            foreach (Person person in peopleList.Where(p => p.FavoriteColour.Equals("blue", StringComparison.OrdinalIgnoreCase)))
            {
                person.toString();
                Console.WriteLine("");
                Console.ReadLine();
            }
        }
    }  
}
