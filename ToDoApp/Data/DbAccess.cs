using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Data
{
    class DbAccess
    {
        #region Add new task in database
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
        #endregion

        #region Delete the task in database by ID
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
        #endregion

        #region Set IsNotified flag in DB
        public static void SetIsNotifiedFlag(int id, bool isNotified)
        {
            try
            {
                using (var cont = new Data.AppDbContext())
                {
                    var task = cont.Tasks.Single(t => t.Id == id);
                    //var task = new Data.Tables.Task { Id = id };
                    
                    task.IsNotified = isNotified;
                    cont.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error in updating IsNotified flag");
            }
        }
        #endregion

        #region Filter tasks by date range
        public static List<Data.Tables.Task> GetDisplayData(DateTime startTime, DateTime endDate)
        {
            try
            {
                using (var cont = new Data.AppDbContext())
                {
                    var tasks = cont.Tasks.Where(task => task.StartDate >= startTime && task.StartDate < endDate);
                    tasks = tasks.OrderBy(task => task.StartDate); //Sorting all tasks by date before showing it in Data Grid
                    return tasks.ToList(); ;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error in filtering data");
            }
        }
        #endregion
    }
}
