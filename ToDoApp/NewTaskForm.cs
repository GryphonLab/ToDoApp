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
        public NewTaskForm()
        {
            InitializeComponent();
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
            dtpNewTaskDate.CustomFormat = "dd.MM.yyy hh:mm:ss tt";
            dtpNewTaskDate.Format = DateTimePickerFormat.Custom;
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (tbDescription.Text.Length == 0) MessageBox.Show("Введите описание задачи", "Добавление новой задачи", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                //Pack data and transfer to DB
                try
                {
                    AppDbContext.AddNewTask(tbDescription.Text, dtpNewTaskDate.Value);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка добавления задачи", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                this.Close();
            }   
        }
    }
}
