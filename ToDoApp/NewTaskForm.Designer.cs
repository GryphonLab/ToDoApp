
namespace ToDoApp
{
    partial class NewTaskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancel = new System.Windows.Forms.Button();
            this.dtpNewTaskDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.dtpNewTaskTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(232, 153);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dtpNewTaskDate
            // 
            this.dtpNewTaskDate.CustomFormat = "dd.MM.yyyy";
            this.dtpNewTaskDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNewTaskDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpNewTaskDate.Location = new System.Drawing.Point(97, 32);
            this.dtpNewTaskDate.Name = "dtpNewTaskDate";
            this.dtpNewTaskDate.Size = new System.Drawing.Size(91, 20);
            this.dtpNewTaskDate.TabIndex = 1;
            this.dtpNewTaskDate.ValueChanged += new System.EventHandler(this.dtpNewTaskDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите дату и время";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Описание";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(12, 81);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(367, 66);
            this.tbDescription.TabIndex = 4;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(12, 153);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(145, 23);
            this.btnAddTask.TabIndex = 5;
            this.btnAddTask.Text = "Добавить";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // dtpNewTaskTime
            // 
            this.dtpNewTaskTime.CustomFormat = "hh:mm";
            this.dtpNewTaskTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNewTaskTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpNewTaskTime.Location = new System.Drawing.Point(227, 32);
            this.dtpNewTaskTime.Name = "dtpNewTaskTime";
            this.dtpNewTaskTime.ShowUpDown = true;
            this.dtpNewTaskTime.Size = new System.Drawing.Size(64, 20);
            this.dtpNewTaskTime.TabIndex = 6;
            // 
            // NewTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 188);
            this.Controls.Add(this.dtpNewTaskTime);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpNewTaskDate);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "NewTaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить новую задачу";
            this.Load += new System.EventHandler(this.NewTaskForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NewTaskForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dtpNewTaskDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Button btnAddTask;
        public System.Windows.Forms.DateTimePicker dtpNewTaskTime;
    }
}