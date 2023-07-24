using Microsoft.EntityFrameworkCore;
using TestCrud.Models;
using System.Data.SqlClient;


namespace TestCrud.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>contextOptions)
           : base(contextOptions)
        {
            
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
