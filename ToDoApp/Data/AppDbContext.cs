using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SQLite.CodeFirst;

namespace ToDoApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base() { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var sqliteConnectionInitializer = new SqliteCreateDatabaseIfNotExists<AppDbContext>(modelBuilder);
            Database.SetInitializer(sqliteConnectionInitializer);

            var model = modelBuilder.Build(Database.Connection);
            ISqlGenerator sqlGenerator = new SqliteSqlGenerator();
            _ = sqlGenerator.Generate(model.StoreModel);
            
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Tables.Task> Tasks { get; set; }
    }
}
