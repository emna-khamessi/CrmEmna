using CrmEmna.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmEmna.Data
{
    public class MyContext: DbContext
    {
        public MyContext():base("name=CRM")
        {
        }
        public DbSet<User> Users{get; set;}
    }
}
