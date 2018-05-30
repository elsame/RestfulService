using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace RestfulService.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
    }

    public class EmployeeDBContext : DbContext
    {
        public DbSet<EmployeeModel> Employees { get; set; }
    }
}