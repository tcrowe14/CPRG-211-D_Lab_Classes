using System;

namespace Lab_creating_classes
{
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FavoriteColour { get; set; }
        public int Age { get; set; }
        public bool IsWorking { get; set; }
        public Person(int personId, string firstName, string lastName, string favoriteColour, int age, bool isWorking)
        {
            PersonId = personId;
            FirstName = firstName;
            LastName = lastName;
            FavoriteColour = favoriteColour;
            Age = age;
            IsWorking = isWorking;
        }

        public void displayPersonInfo()
        {
            Console.WriteLine($"{PersonId}: {FirstName} {LastName}'s favorite colour is {FavoriteColour}");
            //Console.ReadLine();
        }
        public void changeFavoriteColour()
        {
            FavoriteColour = "White";
        }
        public void getAgeInTenYears()
        {
            Console.WriteLine($"Mary Beals’s Age in 10 years is: {Age + 10}");
        }
        public void toString()
        {
            Console.WriteLine($"PersonId: {PersonId}");
            Console.WriteLine($"FirstName: {FirstName}");
            Console.WriteLine($"LastName: {LastName}");
            Console.WriteLine($"FavoriteColour: {FavoriteColour}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"IsWorking: {IsWorking}");
            //Console.ReadLine();
        }
        public override string ToString()
        {
            return $"{FirstName}";
        }


    }
    
}
