using System.Collections.Generic;
using System.Linq;

namespace ModelBinding
{
    public class PersonListDataSource : IPersonDataSource
    {
        // Private list to store Person objects
        private List<Person> _people;

        // Constructor
        public PersonListDataSource()
        {
            // Initialize the list and add three Person objects
            _people = new List<Person>
            {
                new Person(1, "John Doe", "123-456-7890"),
                new Person(2, "Jane Smith", "987-654-3210"),
                new Person(3, "Bob Johnson", "555-555-5555")
            };
        }

        // Implementation of GetPeople
        public IEnumerable<Person> GetPeople()
        {
            return _people.ToList(); // Return a copy of the list
        }

        // Implementation of SaveChanges
        public void SaveChanges()
        {
            // No operation needed for in-memory implementation
        }

        // Method to update the internal list with changes
        public void UpdateList(List<Person> updatedList)
        {
            _people = updatedList; // Replace the internal list with the updated list
        }
    }
}

/*  Definition: ISP states that no client should be forced to depend on methods it does not use.
Violation in PersonListDataSource:
The IPersonDataSource interface requires a SaveChanges method, but the PersonListDataSource class doesn’t need it because changes to the in-memory list don’t need explicit saving. This forces PersonListDataSource to implement a method it doesn’t actually use.*/