
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
            this.rbShowAll = new System.Windows.Forms.RadioButton();
            this.btnShowRange = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFinallDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpInitialDate = new System.Windows.Forms.DateTimePicker();
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
            this.dgTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTable_CellContentClick);
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
            this.groupBox1.Controls.Add(this.rbShowAll);
            this.groupBox1.Controls.Add(this.btnShowRange);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpFinallDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpInitialDate);
            this.groupBox1.Controls.Add(this.rbShowSelected);
            this.groupBox1.Controls.Add(this.rbShowTomorrow);
            this.groupBox1.Controls.Add(this.rbShowToday);
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 213);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Отобразить задачи";
            // 
            // rbShowAll
            // 
            this.rbShowAll.AutoSize = true;
            this.rbShowAll.Checked = true;
            this.rbShowAll.Location = new System.Drawing.Point(6, 19);
            this.rbShowAll.Name = "rbShowAll";
            this.rbShowAll.Size = new System.Drawing.Size(44, 17);
            this.rbShowAll.TabIndex = 8;
            this.rbShowAll.TabStop = true;
            this.rbShowAll.Text = "Все";
            this.rbShowAll.UseVisualStyleBackColor = true;
            // 
            // btnShowRange
            // 
            this.btnShowRange.Location = new System.Drawing.Point(9, 184);
            this.btnShowRange.Name = "btnShowRange";
            this.btnShowRange.Size = new System.Drawing.Size(171, 23);
            this.btnShowRange.TabIndex = 7;
            this.btnShowRange.Text = "Отобразить";
            this.btnShowRange.UseVisualStyleBackColor = true;
            this.btnShowRange.Click += new System.EventHandler(this.btnShowRange_Click);
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
            // dtpFinallDate
            // 
            this.dtpFinallDate.Location = new System.Drawing.Point(30, 142);
            this.dtpFinallDate.Name = "dtpFinallDate";
            this.dtpFinallDate.Size = new System.Drawing.Size(150, 20);
            this.dtpFinallDate.TabIndex = 5;
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
            // dtpInitialDate
            // 
            this.dtpInitialDate.Location = new System.Drawing.Point(30, 116);
            this.dtpInitialDate.Name = "dtpInitialDate";
            this.dtpInitialDate.Size = new System.Drawing.Size(150, 20);
            this.dtpInitialDate.TabIndex = 3;
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
            // 
            // cbNotifyUser
            // 
            this.cbNotifyUser.AutoSize = true;
            this.cbNotifyUser.Location = new System.Drawing.Point(12, 284);
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
        private System.Windows.Forms.Button btnShowRange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFinallDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpInitialDate;
        private System.Windows.Forms.RadioButton rbShowSelected;
        private System.Windows.Forms.CheckBox cbNotifyUser;
        private System.Windows.Forms.RadioButton rbShowAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsDone;
    }
}

