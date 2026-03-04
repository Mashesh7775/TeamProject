using College_WebApplication.Models;
using CollegeWebApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace College_WebApplication.Data1
{
    public class CollegeWebDbContext : DbContext
    {
        public CollegeWebDbContext(DbContextOptions<CollegeWebDbContext> options)
            : base(options)
        {
        }

        public DbSet<Studentinfo> Studentinfos { get; set; }

        public DbSet<CountryMaster> CountryMasters { get; set; }
        public DbSet<EmployeesMaster> EmployeesMaster { get; set; }
    }
}
