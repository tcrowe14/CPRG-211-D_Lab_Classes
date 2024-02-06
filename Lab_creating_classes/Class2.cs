using System;

namespace Lab_creating_classes
{
    public class Relation
    {
        // Attribute
        public RelationshipType RelationshipType { get; set; }

        // Constructor
        public Relation(RelationshipType relationshipType)
        {
            RelationshipType = relationshipType;
        }

        // Method to show relationship between two Person objects
        public void ShowRelationship(Person person1, Person person2)
        {
            Console.WriteLine($"Relationship between {person1.FirstName} and {person2.FirstName} is: {RelationshipType}hood");
        }
    }

    // Enum for RelationshipType
    public enum RelationshipType
    {
        Sister,
        Brother,
        Mother,
        Father
    }
}
