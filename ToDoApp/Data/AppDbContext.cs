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

        //public List<Tables>GetAll

        public static void AddNewTask(string description, DateTime startTime)
        {
            try
            {
                using (var cont = new Data.AppDbContext())
                {
                    var task = new Data.Tables.Task { Description = description, StartDate = startTime };
                    cont.Tasks.Add(task);
                    cont.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error in adding the new task");
            }
        }

        public static void DeleteTask(int id)
        {
            try
            {
                using (var cont = new Data.AppDbContext())
                {
                    var task = new Data.Tables.Task { Id = id };
                    cont.Tasks.Attach(task);
                    cont.Tasks.Remove(task);
                    cont.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error in deleting of the task");
            }
        }
    }
}
