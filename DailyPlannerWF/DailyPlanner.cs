using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Media;
using System.IO;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace DailyPlannerWF
{
    public partial class DailyPlanner : Form
    {
        public DailyPlanner()
        {
            InitializeComponent();
        }

        public List<PlannedTask> Tasks = new List<PlannedTask>();

        // Fills the taskview columns equally
        private void FillTaskViewCol()
        {
            int width = taskView.Width;
            int columnCount = taskView.Columns.Count;
            int divide = width / columnCount;

            for (int i = 0; i < columnCount; i++)
            {
                taskView.Columns[i].Width = divide;
            }
        }

        public void taskReady(PlannedTask FinishedTask)
        {
            SoundPlayer alert = new SoundPlayer();
            alert.SoundLocation = Path.Combine(Environment.CurrentDirectory, @"notify.wav");
            alert.Play();

            WindowState = FormWindowState.Normal;
            ntIcon.ShowBalloonTip(1000, FinishedTask.Name, "Alert", ToolTipIcon.Info);

            int currentTask = Tasks.FindIndex(x => x.Guid == FinishedTask.Guid);
            refreshTasks();
        }


        private void refreshTasks()
        {
            taskView.Items.Clear();

            foreach (PlannedTask task in Tasks)
            {
                ListViewItem item = new ListViewItem(task.ToStringArray());
                taskView.Items.Add(item);
            }

            int count = taskView.Items.Count;

            if(count > 0)
            {
                btnSaveTasks.Enabled = true;
            }

            lblTaskCount.Text = "Task count: " + count.ToString();
        }

        public async void AlertTask(Action action, DateTime AlertTime)
        {
            int delay = (int)AlertTime.Subtract(DateTime.Now).TotalMilliseconds;

            if (delay < 0)
            {
                await Task.Delay(1);
                action();
            }
            else
            {
                await Task.Delay(delay);
                action();
            }
        }


        private void createTask()
        {
            string taskName = txtTaskName.Text;
            string taskTime = timePicker.Value.ToShortTimeString();
            bool remind = chkAlert.Checked;

            if (taskName == "")
            {
                MessageBox.Show("You must enter a task name", "Invalid task name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //else if (DateTime.Parse(taskTime) <= DateTime.Parse(DateTime.Now.ToShortTimeString()))
            //{
            //    MessageBox.Show("Task time must be greater than current time", "Invalid time", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            else
            {
                PlannedTask newTask = new PlannedTask(taskName, TimeSpan.Parse(taskTime), PlannedTask.TaskStatus.Incomplete, remind.ToString());
                Tasks.Add(newTask);
                refreshTasks();

                AlertTask(() => {
                    if (newTask.Reminder == "True")
                        taskReady(newTask);
                }, DateTime.Parse(taskTime));
            }
        }

        public void loadTasks()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON Files|*.json";
            openFileDialog.Title = "Load a set of daily tasks";
            openFileDialog.ShowDialog();

            string path = openFileDialog.FileName;

            if (path == "")
            {
                MessageBox.Show("You must select a path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (var sr = new StreamReader(path))
                {
                    List<PlannedTask> parsed = JsonConvert.DeserializeObject<List<PlannedTask>>(sr.ReadToEnd());
                    Tasks.Clear();

                    foreach (PlannedTask task in parsed)
                    {
                        //if (task.Time < DateTime.Parse(DateTime.Now.ToLongTimeString()))
                        //{
                        //    MessageBox.Show("Task: " + task.Name + "\nIs earlier than current times so could not be loaded.");
                        //}
                        //else
                        //{
                        //    Tasks.Add(task);
                        //}
                        Tasks.Add(task);
                    }
                    refreshTasks();
                }

            }
        }

        private void BtnCreateTask_Click(object sender, EventArgs e)
        {
            createTask();
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this task?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (taskView.SelectedItems.Count == 0)
                {
                    MessageBox.Show("No tasks selected", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Tasks.RemoveAt(taskView.SelectedItems[0].Index);
                    btnDeleteTask.Enabled = false;
                    btnTaskComplete.Enabled = false;
                    refreshTasks();
                }
            }
        }

        private void ntIcon_MouseClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Visible = true;
        }

        private void ntIcon_BalloonClick(object sendr, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.ShowUpDown = true;
            FillTaskViewCol();
            timePicker.Value = DateTime.Parse("00:00");
            ntIcon.Visible = true;

            btnDeleteTask.Enabled = false;
            btnTaskComplete.Enabled = false;
            btnSaveTasks.Enabled = false;
            KeyDown += DailyPlanner_KeyDown;
        }

        private void DailyPlanner_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
            {
                createTask();
            }
        }

        private void SizeChanged(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Minimized)
            {
                ShowInTaskbar = false;
                Visible = false;
            }
            else if(WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void ballonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTaskComplete_Click(object sender, EventArgs e)
        {
            ListViewItem selectedRow = taskView.SelectedItems[0];
            selectedRow.BackColor = System.Drawing.Color.FromArgb(86, 240, 150);
            selectedRow.SubItems[3].Text = "Completed";
        }

        private void taskView_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (taskView.SelectedItems.Count > 0)
            {
                btnDeleteTask.Enabled = true;
                btnTaskComplete.Enabled = true;
            }
            else
            {
                btnDeleteTask.Enabled = false;
                btnTaskComplete.Enabled = false;
            }
        }

        private void showPlannerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Visible = true;
        }

        private void btnSaveTasks_Click(object sender, EventArgs e)
        {

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "JSON Files|*.json";
            save.Title = "Save your tasks";
            save.ShowDialog();

            string savePath = save.FileName;

            if(savePath == "")
            {
                MessageBox.Show("You must select a path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string outputJson = JsonConvert.SerializeObject(Tasks);

                using (StreamWriter outputFile = new StreamWriter(savePath))
                {
                    outputFile.Write(outputJson);
                }
            }
        }

        private void btnLoadTasks_Click(object sender, EventArgs e)
        {
            if (Tasks.Count > 0)
            {
                DialogResult replaceTasks = MessageBox.Show("This will replace all current tasks with tasks from file,\nare you sure you want to to this?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (replaceTasks == DialogResult.Yes)
                {
                    loadTasks();
                }
            }
            else
            {
                loadTasks();
            }

        }

        private void btnToggleAlert_Click(object sender, EventArgs e)
        {
            ListViewItem currentItem = taskView.SelectedItems[0];

            if(currentItem.SubItems[2].Text == "True")
            {

            }
            
        }
    }
}
