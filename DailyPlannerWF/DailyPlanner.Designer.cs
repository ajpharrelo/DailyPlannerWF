
namespace DailyPlannerWF
{
    partial class DailyPlanner
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyPlanner));
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.lblTasks = new System.Windows.Forms.Label();
            this.lblTaskTime = new System.Windows.Forms.Label();
            this.chkAlert = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.lblTaskCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.btnCreateTask = new System.Windows.Forms.Button();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.taskView = new System.Windows.Forms.ListView();
            this.taskName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.taskTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Alert = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ntIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.balloonMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ballonClose = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTaskComplete = new System.Windows.Forms.Button();
            this.btnSaveTasks = new System.Windows.Forms.Button();
            this.btnLoadTasks = new System.Windows.Forms.Button();
            this.statusBar.SuspendLayout();
            this.balloonMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTaskName
            // 
            this.txtTaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskName.Location = new System.Drawing.Point(6, 38);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(250, 26);
            this.txtTaskName.TabIndex = 0;
            // 
            // lblTasks
            // 
            this.lblTasks.AutoSize = true;
            this.lblTasks.Location = new System.Drawing.Point(12, 90);
            this.lblTasks.Name = "lblTasks";
            this.lblTasks.Size = new System.Drawing.Size(58, 13);
            this.lblTasks.TabIndex = 1;
            this.lblTasks.Text = "Daily tasks";
            // 
            // lblTaskTime
            // 
            this.lblTaskTime.AutoSize = true;
            this.lblTaskTime.Location = new System.Drawing.Point(263, 22);
            this.lblTaskTime.Name = "lblTaskTime";
            this.lblTaskTime.Size = new System.Drawing.Size(53, 13);
            this.lblTaskTime.TabIndex = 3;
            this.lblTaskTime.Text = "Task time";
            // 
            // chkAlert
            // 
            this.chkAlert.AutoSize = true;
            this.chkAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAlert.Location = new System.Drawing.Point(385, 43);
            this.chkAlert.Name = "chkAlert";
            this.chkAlert.Size = new System.Drawing.Size(86, 20);
            this.chkAlert.TabIndex = 4;
            this.chkAlert.Text = "Reminder";
            this.chkAlert.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTaskCount});
            this.statusBar.Location = new System.Drawing.Point(0, 480);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(800, 22);
            this.statusBar.TabIndex = 7;
            this.statusBar.Text = "statusStrip1";
            // 
            // lblTaskCount
            // 
            this.lblTaskCount.Name = "lblTaskCount";
            this.lblTaskCount.Size = new System.Drawing.Size(105, 17);
            this.lblTaskCount.Text = "Remaining tasks: 0";
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.Location = new System.Drawing.Point(6, 22);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(60, 13);
            this.lblTaskName.TabIndex = 3;
            this.lblTaskName.Text = "Task name";
            // 
            // timePicker
            // 
            this.timePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(262, 38);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(117, 26);
            this.timePicker.TabIndex = 8;
            this.timePicker.Value = new System.DateTime(2022, 7, 4, 19, 38, 0, 0);
            // 
            // btnCreateTask
            // 
            this.btnCreateTask.Location = new System.Drawing.Point(477, 19);
            this.btnCreateTask.Name = "btnCreateTask";
            this.btnCreateTask.Size = new System.Drawing.Size(283, 57);
            this.btnCreateTask.TabIndex = 5;
            this.btnCreateTask.Text = "Create new task";
            this.btnCreateTask.UseVisualStyleBackColor = true;
            this.btnCreateTask.Click += new System.EventHandler(this.BtnCreateTask_Click);
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Location = new System.Drawing.Point(12, 432);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(123, 32);
            this.btnDeleteTask.TabIndex = 9;
            this.btnDeleteTask.Text = "Delete task";
            this.btnDeleteTask.UseVisualStyleBackColor = true;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // taskView
            // 
            this.taskView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.taskName,
            this.taskTime,
            this.Alert,
            this.Status});
            this.taskView.FullRowSelect = true;
            this.taskView.GridLines = true;
            this.taskView.HideSelection = false;
            this.taskView.Location = new System.Drawing.Point(12, 111);
            this.taskView.MultiSelect = false;
            this.taskView.Name = "taskView";
            this.taskView.Size = new System.Drawing.Size(776, 315);
            this.taskView.TabIndex = 10;
            this.taskView.UseCompatibleStateImageBehavior = false;
            this.taskView.View = System.Windows.Forms.View.Details;
            this.taskView.SelectedIndexChanged += new System.EventHandler(this.taskView_SelectedIndexChanged_1);
            // 
            // taskName
            // 
            this.taskName.Text = "Task";
            // 
            // taskTime
            // 
            this.taskTime.Text = "Time";
            // 
            // Alert
            // 
            this.Alert.Text = "Reminder";
            // 
            // Status
            // 
            this.Status.Text = "Task status";
            // 
            // ntIcon
            // 
            this.ntIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ntIcon.BalloonTipTitle = "Daily planner";
            this.ntIcon.ContextMenuStrip = this.balloonMenu;
            this.ntIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("ntIcon.Icon")));
            this.ntIcon.Text = "Click to view daily planner";
            this.ntIcon.Visible = true;
            this.ntIcon.BalloonTipClicked += new System.EventHandler(this.ntIcon_BalloonClick);
            this.ntIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ntIcon_MouseClick);
            // 
            // balloonMenu
            // 
            this.balloonMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ballonClose});
            this.balloonMenu.Name = "balloonMenu";
            this.balloonMenu.Size = new System.Drawing.Size(147, 26);
            this.balloonMenu.Text = "Daily planner";
            // 
            // ballonClose
            // 
            this.ballonClose.Name = "ballonClose";
            this.ballonClose.Size = new System.Drawing.Size(146, 22);
            this.ballonClose.Text = "Close Planner";
            this.ballonClose.Click += new System.EventHandler(this.ballonClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTaskName);
            this.groupBox1.Controls.Add(this.lblTaskName);
            this.groupBox1.Controls.Add(this.timePicker);
            this.groupBox1.Controls.Add(this.lblTaskTime);
            this.groupBox1.Controls.Add(this.btnCreateTask);
            this.groupBox1.Controls.Add(this.chkAlert);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 82);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create new task";
            // 
            // btnTaskComplete
            // 
            this.btnTaskComplete.Location = new System.Drawing.Point(141, 432);
            this.btnTaskComplete.Name = "btnTaskComplete";
            this.btnTaskComplete.Size = new System.Drawing.Size(127, 32);
            this.btnTaskComplete.TabIndex = 9;
            this.btnTaskComplete.Text = "Task Completed";
            this.btnTaskComplete.UseVisualStyleBackColor = true;
            this.btnTaskComplete.Click += new System.EventHandler(this.btnTaskComplete_Click);
            // 
            // btnSaveTasks
            // 
            this.btnSaveTasks.Location = new System.Drawing.Point(677, 432);
            this.btnSaveTasks.Name = "btnSaveTasks";
            this.btnSaveTasks.Size = new System.Drawing.Size(111, 32);
            this.btnSaveTasks.TabIndex = 12;
            this.btnSaveTasks.Text = "Save tasks";
            this.btnSaveTasks.UseVisualStyleBackColor = true;
            this.btnSaveTasks.Click += new System.EventHandler(this.btnSaveTasks_Click);
            // 
            // btnLoadTasks
            // 
            this.btnLoadTasks.Location = new System.Drawing.Point(552, 432);
            this.btnLoadTasks.Name = "btnLoadTasks";
            this.btnLoadTasks.Size = new System.Drawing.Size(119, 32);
            this.btnLoadTasks.TabIndex = 13;
            this.btnLoadTasks.Text = "Load tasks";
            this.btnLoadTasks.UseVisualStyleBackColor = true;
            this.btnLoadTasks.Click += new System.EventHandler(this.btnLoadTasks_Click);
            // 
            // DailyPlanner
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.btnLoadTasks);
            this.Controls.Add(this.btnSaveTasks);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.taskView);
            this.Controls.Add(this.btnTaskComplete);
            this.Controls.Add(this.btnDeleteTask);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTasks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DailyPlanner";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daily planner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.SizeChanged);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.balloonMenu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.Label lblTasks;
        private System.Windows.Forms.Label lblTaskTime;
        private System.Windows.Forms.CheckBox chkAlert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel lblTaskCount;
        private System.Windows.Forms.Label lblTaskName;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Button btnCreateTask;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.ListView taskView;
        private System.Windows.Forms.ColumnHeader taskName;
        private System.Windows.Forms.ColumnHeader taskTime;
        private System.Windows.Forms.ColumnHeader Alert;
        private System.Windows.Forms.NotifyIcon ntIcon;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ContextMenuStrip balloonMenu;
        private System.Windows.Forms.ToolStripMenuItem ballonClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTaskComplete;
        private System.Windows.Forms.Button btnSaveTasks;
        private System.Windows.Forms.Button btnLoadTasks;
    }
}

