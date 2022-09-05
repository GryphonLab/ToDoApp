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

        public MainForm()
        {
            InitializeComponent();

   
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            Form AddForm = new NewTaskForm();
            AddForm.Show();
        }

        private void btnShowRange_Click(object sender, EventArgs e)
        {
            try
            {
                using(var cont = new Data.AppDbContext())
                {
                    var data = (from id in cont.Tasks select id);
                    dgTable.DataSource = data.ToList();

                    /*
                    var task = new Data.Tables.Task {Id = 8 };
                    cont.Tasks.Attach(task);
                    cont.Tasks.Remove(task);
                    cont.SaveChanges();
                    */
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить выбранную задачу?", "Удаление задачи", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (dr)
            {
                case DialogResult.Yes:

                    try
                    {
                        AppDbContext.DeleteTask(15);
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
        }

        private void cbNotifyUser_CheckedChanged(object sender, EventArgs e)
        {
            //Set timer to check on alarm/notification date
        }
    }
}
