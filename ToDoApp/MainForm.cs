using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoApp.Data;

namespace ToDoApp
{
    public partial class MainForm : Form
    {
        #region Global Variables
        System.Timers.Timer reminderTimer;
        const int timerDelayInMs = 60000; //1 min
        #endregion


        public MainForm()
        {
            InitializeComponent();

            reminderTimer = new System.Timers.Timer();
            reminderTimer.Interval = timerDelayInMs;
            reminderTimer.Elapsed += OnTimerTick;

            dtpEndDate.Value = DateTime.Now.AddDays(1);

        }
        #region Add New Task Button
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            Form AddForm = new NewTaskForm();
            AddForm.Show();
        }
        #endregion

        private void btnShowRange_Click(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }

        #region Delete Selected Task Button
        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            if (dgTable.CurrentRow != null)
            {
                DialogResult dr = MessageBox.Show("Удалить выбранную задачу?", "Удаление задачи", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                switch (dr)
                {
                    case DialogResult.Yes:
                        int dgId = Convert.ToInt32(dgTable[0, dgTable.CurrentRow.Index].Value); // Get the Id from DG to remove a selected task

                        try
                        {
                            AppDbContext.DeleteTask(dgId);
                            MessageBox.Show("Задача удалена!", "Удаление задачи", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка при удалении задачи!", "Удаление задачи", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        break;
                    case DialogResult.No:
                        break;
                }
                UpdateDataGrid();
            }
            else MessageBox.Show("Задача не выделена!", "Удаление задачи", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
        }
        #endregion

        #region Enable timer checkbox
        private void cbNotifyUser_CheckedChanged(object sender, EventArgs e)
        {
            if (!reminderTimer.Enabled)
            {
                reminderTimer.Start();
            }
            else
            {
                reminderTimer.Stop();
            }
        }
        #endregion

        #region Timer on check future tasks
        private void OnTimerTick(object o, System.Timers.ElapsedEventArgs e)
        {

            var startDate = DateTime.Now;
            var endDate = startDate.AddMinutes(5);



            using (var cont = new Data.AppDbContext())
            {
                //Data.Tables.Task tsk = cont.Tasks.Find(3);

                //var filtereDdata 
                var tasks = cont.Tasks.Where(task => task.StartDate >= startDate && task.StartDate < endDate);
                //tasks += tasks.OrderBy(task => task.StartDate);

                //var tasks = cont.Tasks; //Show all values
                tasks = tasks.OrderBy(task => task.StartDate); //Sorting all tasks by date before showing it in Data Grid
                foreach (var task in tasks)
                    new ToastContentBuilder()
                        .AddText("Через пять минут")
                        .AddText(task.Description)
                        .Show();
            }
        }

        #endregion

        private void UpdateDataGrid()
        {
            var startDate = DateTime.Now;
            var endDate = DateTime.Now;

            if (rbShowWeek.Checked)
            {
                startDate = DateTime.Now.Date;
                endDate = startDate.AddDays(7);
            }
            if (rbShowToday.Checked)
            {
                startDate = DateTime.Now.Date;
                endDate = startDate.AddDays(1);
            }
            if (rbShowTomorrow.Checked)
            {
                startDate = DateTime.Now.Date.AddDays(1);
                endDate = startDate.AddDays(1);
            }
            if (rbShowSelected.Checked)
            {
                startDate = dtpStartDate.Value;
                endDate = dtpEndDate.Value.AddDays(1);
            }



            this.dgTable.Rows.Clear();
            //this.dgTable.Rows.Add(3, "test", "34234234", 0);
            //this.dgTable.Rows.Add(3, "dsfsdf", "34234234", 0);



            using (var cont = new Data.AppDbContext())
            {
                //Data.Tables.Task tsk = cont.Tasks.Find(3);

                //var filtereDdata 
                var tasks = cont.Tasks.Where(task => task.StartDate >= startDate && task.StartDate < endDate);
                //tasks += tasks.OrderBy(task => task.StartDate);

                //var tasks = cont.Tasks; //Show all values
                tasks = tasks.OrderBy(task => task.StartDate); //Sorting all tasks by date before showing it in Data Grid
                foreach (var task in tasks)
                    this.dgTable.Rows.Add(task.Id, task.Description, task.StartDate, task.IsDone);





                //dgTable.DataSource = tasks;

                //MessageBox.Show((cont.Tasks.OrderByDescending(u => u.Id).FirstOrDefault().ToString()), "",MessageBoxButtons.OK);
                //MessageBox.Show(tsk.Description, "", MessageBoxButtons.OK);
            }



            try
            {
                using (var cont = new Data.AppDbContext())
                {
                    // var data = (from id in cont.Tasks select id);
                    // dgTable.DataSource = data.ToList();


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }

        private void rbShowWeek_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }

        private void rbShowToday_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }

        private void rbShowTomorrow_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }

        private void rbShowSelected_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }
    }
}
