using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ACD_Construction.ORM.Entities;

namespace ACD_Construction.ORM.Context
{
    internal class ProjectContext : DbContext
    {
        public ProjectContext() : base(@"Data Source=DESKTOP-UVMSNSF;Initial Catalog=ACD;Integrated Security=True")
        {
            //Database.Connection.ConnectionString = "Server=DESKTOP-9IJKPL9\\SQLDERS;Database=EFDB;uid=sa;pwd=1";
        }
        public DbSet<Document> Document { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Letter> Letter { get; set; }
        public DbSet<Register> Register { get; set; }//NOIRegister
    }
}
