using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ModelBinding
{
    public class PersonDbContext : DbContext, IPersonDataSource
    {
        public DbSet<Person> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=people.db");
        }

        // Implement GetPeople from IPersonDataSource
        public IEnumerable<Person> GetPeople()
        {
            return People.ToList(); // Convert DbSet to a list
        }

        // Implement SaveChanges from IPersonDataSource
        void IPersonDataSource.SaveChanges()
        {
            base.SaveChanges(); // Call the DbContext's SaveChanges method
        }
    }
}