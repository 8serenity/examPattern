using System;
using System.Data.Entity;

namespace exam
{
    public class UserContext : DbContext
    {
        public UserContext() : base("defaultConnection")
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
