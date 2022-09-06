using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoApp.Data;

namespace ToDoApp
{
    public partial class NewTaskForm : Form
    {
        private MainForm mainForm = null;

        public NewTaskForm(Form callingForm)
        {
            InitializeComponent();
            mainForm = callingForm as MainForm;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewTaskForm_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show(e.KeyCode.ToString());
            if (e.KeyCode == Keys.Escape) this.Close();
        }

        private void NewTaskForm_Load(object sender, EventArgs e)
        {
            dtpNewTaskDate.CustomFormat = "dd.MM.yyyy";
            dtpNewTaskDate.Format = DateTimePickerFormat.Custom;

            dtpNewTaskTime.CustomFormat = "HH:mm";
            dtpNewTaskTime.Format = DateTimePickerFormat.Custom;
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (tbDescription.Text.Length == 0) MessageBox.Show("Введите описание задачи", "Добавление новой задачи", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                DateTime newTaskDate = (dtpNewTaskDate.Value).Date.Add(dtpNewTaskTime.Value.TimeOfDay);
                newTaskDate = newTaskDate.AddSeconds(-dtpNewTaskTime.Value.Second);
                //Pack data and transfer to DB, then update Data Grid View
                try
                {
                    DbAccess.AddNewTask(tbDescription.Text, newTaskDate);
                    this.mainForm.UpdateDataGrid();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка добавления задачи", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();
            }   
        }

        private void dtpNewTaskDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
