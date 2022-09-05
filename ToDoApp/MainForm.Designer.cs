
namespace ToDoApp
{
    partial class MainForm
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
            this.dgTable = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsDone = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbShowWeek = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.rbShowSelected = new System.Windows.Forms.RadioButton();
            this.rbShowTomorrow = new System.Windows.Forms.RadioButton();
            this.rbShowToday = new System.Windows.Forms.RadioButton();
            this.cbNotifyUser = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgTable
            // 
            this.dgTable.AllowUserToAddRows = false;
            this.dgTable.AllowUserToDeleteRows = false;
            this.dgTable.AllowUserToResizeColumns = false;
            this.dgTable.AllowUserToResizeRows = false;
            this.dgTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.StartDate,
            this.Description,
            this.IsDone});
            this.dgTable.Location = new System.Drawing.Point(253, 65);
            this.dgTable.Name = "dgTable";
            this.dgTable.ReadOnly = true;
            this.dgTable.Size = new System.Drawing.Size(505, 369);
            this.dgTable.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // StartDate
            // 
            this.StartDate.DataPropertyName = "StartDate";
            this.StartDate.HeaderText = "Дата планирования";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            this.StartDate.Width = 150;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Описание";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // IsDone
            // 
            this.IsDone.DataPropertyName = "IsDone";
            this.IsDone.HeaderText = "Выполнено";
            this.IsDone.Name = "IsDone";
            this.IsDone.ReadOnly = true;
            this.IsDone.Width = 70;
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteSelected.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeleteSelected.Location = new System.Drawing.Point(631, 21);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(127, 23);
            this.btnDeleteSelected.TabIndex = 1;
            this.btnDeleteSelected.Text = "Удалить выделенное";
            this.btnDeleteSelected.UseVisualStyleBackColor = false;
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTask.Location = new System.Drawing.Point(517, 21);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(108, 23);
            this.btnAddTask.TabIndex = 2;
            this.btnAddTask.Text = "Добавить задачу";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbShowWeek);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpEndDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpStartDate);
            this.groupBox1.Controls.Add(this.rbShowSelected);
            this.groupBox1.Controls.Add(this.rbShowTomorrow);
            this.groupBox1.Controls.Add(this.rbShowToday);
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 177);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Отобразить задачи";
            // 
            // rbShowWeek
            // 
            this.rbShowWeek.AutoSize = true;
            this.rbShowWeek.Checked = true;
            this.rbShowWeek.Location = new System.Drawing.Point(6, 19);
            this.rbShowWeek.Name = "rbShowWeek";
            this.rbShowWeek.Size = new System.Drawing.Size(80, 17);
            this.rbShowWeek.TabIndex = 8;
            this.rbShowWeek.TabStop = true;
            this.rbShowWeek.Text = "На неделю";
            this.rbShowWeek.UseVisualStyleBackColor = true;
            this.rbShowWeek.CheckedChanged += new System.EventHandler(this.rbShowWeek_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "по";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(30, 142);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(150, 20);
            this.dtpEndDate.TabIndex = 5;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "с";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(30, 116);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(150, 20);
            this.dtpStartDate.TabIndex = 3;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // rbShowSelected
            // 
            this.rbShowSelected.AutoSize = true;
            this.rbShowSelected.Location = new System.Drawing.Point(6, 88);
            this.rbShowSelected.Name = "rbShowSelected";
            this.rbShowSelected.Size = new System.Drawing.Size(149, 17);
            this.rbShowSelected.TabIndex = 2;
            this.rbShowSelected.Text = "Выбранный промежуток";
            this.rbShowSelected.UseVisualStyleBackColor = true;
            this.rbShowSelected.CheckedChanged += new System.EventHandler(this.rbShowSelected_CheckedChanged);
            // 
            // rbShowTomorrow
            // 
            this.rbShowTomorrow.AutoSize = true;
            this.rbShowTomorrow.Location = new System.Drawing.Point(6, 65);
            this.rbShowTomorrow.Name = "rbShowTomorrow";
            this.rbShowTomorrow.Size = new System.Drawing.Size(77, 17);
            this.rbShowTomorrow.TabIndex = 1;
            this.rbShowTomorrow.Text = "На завтра";
            this.rbShowTomorrow.UseVisualStyleBackColor = true;
            this.rbShowTomorrow.CheckedChanged += new System.EventHandler(this.rbShowTomorrow_CheckedChanged);
            // 
            // rbShowToday
            // 
            this.rbShowToday.AutoSize = true;
            this.rbShowToday.Location = new System.Drawing.Point(6, 42);
            this.rbShowToday.Name = "rbShowToday";
            this.rbShowToday.Size = new System.Drawing.Size(83, 17);
            this.rbShowToday.TabIndex = 0;
            this.rbShowToday.Text = "На сегодня";
            this.rbShowToday.UseVisualStyleBackColor = true;
            this.rbShowToday.CheckedChanged += new System.EventHandler(this.rbShowToday_CheckedChanged);
            // 
            // cbNotifyUser
            // 
            this.cbNotifyUser.AutoSize = true;
            this.cbNotifyUser.Location = new System.Drawing.Point(30, 248);
            this.cbNotifyUser.Name = "cbNotifyUser";
            this.cbNotifyUser.Size = new System.Drawing.Size(146, 17);
            this.cbNotifyUser.TabIndex = 4;
            this.cbNotifyUser.Text = "Уведомлять за 5 минут";
            this.cbNotifyUser.UseVisualStyleBackColor = true;
            this.cbNotifyUser.CheckedChanged += new System.EventHandler(this.cbNotifyUser_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.cbNotifyUser);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.btnDeleteSelected);
            this.Controls.Add(this.dgTable);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 350);
            this.Name = "MainForm";
            this.Text = "ToDo Application";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTable;
        private System.Windows.Forms.Button btnDeleteSelected;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbShowToday;
        private System.Windows.Forms.RadioButton rbShowTomorrow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.RadioButton rbShowSelected;
        private System.Windows.Forms.CheckBox cbNotifyUser;
        private System.Windows.Forms.RadioButton rbShowWeek;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsDone;
    }
}

