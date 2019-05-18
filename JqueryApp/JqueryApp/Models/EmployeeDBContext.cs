using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JqueryApp.Models
{
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext()
        {
            Database.SetInitializer<EmployeeDBContext>(new DropCreateDatabaseIfModelChanges<EmployeeDBContext>());
            //this.Configuration.LazyLoadingEnabled = true;
        }


        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}