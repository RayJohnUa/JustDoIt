using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JustDoIt.Models
{
    public class DoItContext : DbContext
    {
        public DoItContext()
            : base("DoItContext")
        {
            Database.SetInitializer<DoItContext>(new DropCreateDatabaseIfModelChanges<DoItContext>());
            UserModels User = new UserModels() { Mail = "mail@mail.com" , Name ="Romesta" , Password ="password" };
            this.Users.Add(User);
            this.SaveChanges();
        }

        public virtual DbSet<UserModels> Users { get; set; }
        public virtual DbSet<ContentTaskModels> Contents { get; set; }
        public virtual DbSet<TaskModels> Tasks { get; set; }
        public virtual DbSet<ColumnModels> Columns { get; set; }
        public virtual DbSet<TaskListModels> TaskLists { get; set; }
    }
}