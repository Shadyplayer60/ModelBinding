using System.Collections.Generic;
using System.Linq;

namespace ModelBinding
{
    public class PersonContextDataSource : IPersonDataSource
    {
        private readonly PersonDbContext _context;

        public PersonContextDataSource()
        {
            _context = new PersonDbContext(); // Instantiate the database context
        }

        // Implement GetPeople from IPersonDataSource
        public IEnumerable<Person> GetPeople()
        {
            return _context.People.ToList(); // Retrieve people from the database
        }

        // Implement SaveChanges from IPersonDataSource
        public void SaveChanges()
        {
            _context.SaveChanges(); // Save changes to the database
        }
    }
}
