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
        readonly System.Timers.Timer reminderTimer;
        readonly System.Timers.Timer updateCurrentTimeTimer;
        const int timerDelayInMs = 60000; //1 min update time for reminder notification

        delegate void UpdateDTLabel(Label lbl, string value);
        delegate void UpdateDGView();
        #endregion


        public MainForm()
        {
            InitializeComponent();
            
            //5 minutes reminder timer
            reminderTimer = new System.Timers.Timer();
            reminderTimer.Interval = timerDelayInMs;
            reminderTimer.Elapsed += ReminderTick;

            //Timer to update a current date and time on main form 
            updateCurrentTimeTimer = new System.Timers.Timer();
            updateCurrentTimeTimer.Interval = 1000;
            updateCurrentTimeTimer.Elapsed += new System.Timers.ElapsedEventHandler(UpdateCurrentTimeTick);
            updateCurrentTimeTimer.Start();

            //Preparing form elements
            lbDateTimeNow.Text = DateTime.Now.ToString();
            dtpEndDate.Value = DateTime.Now.AddDays(1);

        }
        #region Add New Task Button
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            Form AddForm = new NewTaskForm(this);
            AddForm.Show();
        }
        #endregion


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
                            DbAccess.DeleteTask(dgId);
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
                ReminderTick(null, null);
            }
            else
            {
                reminderTimer.Stop();
            }
        }
        #endregion

        #region Timer on check future tasks
        private void ReminderTick(object o, System.Timers.ElapsedEventArgs e)
        {

            var startDate = DateTime.Now;
            var endDate = startDate.AddMinutes(5);

            try
            {
                var tasksToBeReminded = DbAccess.GetDisplayData(startDate, endDate);
                foreach (var task in tasksToBeReminded)
                {
                    if (!task.IsNotified)
                    {
                        new ToastContentBuilder()
                       .AddText("Через пять минут")
                       .AddText(task.Description)
                       .Show();
                        DbAccess.SetIsNotifiedFlag((int)task.Id, true);
                        //Updating the DGV since we have made some edits in the DB
                        UpdateDGView upd = UpdateDataGrid;
                        if (dgTable.InvokeRequired)
                            Invoke(upd);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void UpdateDateTimeLabel(Label lbl, string value)
        {
            lbl.Text = value;
        }

        #region Current time label update tick
        private void UpdateCurrentTimeTick(object o, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                UpdateDTLabel upd = UpdateDateTimeLabel;
                if (lbDateTimeNow.InvokeRequired)
                    Invoke(upd, lbDateTimeNow, DateTime.Now.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        #endregion

        #region Update Data Grid View by using Date Time range
        public void UpdateDataGrid()
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

            try
            {
                var filteredTasks = DbAccess.GetDisplayData(startDate, endDate);
                foreach (var task in filteredTasks) this.dgTable.Rows.Add(task.Id, task.StartDate.ToString("dd.MM.yyyy HH:mm"), task.Description, task.IsDone, task.IsNotified);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Update Data Grid View when pressing buttons
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
        #endregion
    }
}
