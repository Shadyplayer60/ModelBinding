using System.Collections.Generic;

namespace ModelBinding
{
    public interface IPersonDataSource
    {
        // Method to retrieve people
        IEnumerable<Person> GetPeople();

        // Method to save changes
        void SaveChanges();
    }
}
