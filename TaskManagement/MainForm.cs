using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using TaskManagement.DbHelper;
using TaskManagement.Models;

namespace TaskManagement
{
    public partial class MainForm : Form
    {
        public QueryRunner queryRunner;
        private int currentY;

        public MainForm()
        {
            InitializeComponent();
            taskPanel.AutoScroll = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ConnectAndGetTasks();
        }

        private void ConnectAndGetTasks()
        {
            string connStr = @"Server=127.0.0.1;Port=5432;User Id=postgres;Password=Gkalchev93;Database=Tasks;";
            queryRunner = new QueryRunner(connStr);
            FillTaskPanel(queryRunner.GetAllTasks());

        }

        private void FillTaskPanel(List<TaskObj> list)
        {
            currentY = 12;
            AddScroll();
            foreach(var task in list)
            {
                AddTaskInPanel(task);
                currentY += 51;
            }
        }

        private void AddTaskInPanel(TaskObj task)
        {
            var sampleTaskLabel = "Assignee: {0} \nDescription: {1}";
            var taskLabel = new RichTextBox();
            taskLabel.BorderStyle = BorderStyle.FixedSingle;
            taskLabel.BackColor = Color.Gray;
            taskLabel.ReadOnly = true;
            taskLabel.Size = new Size(296, 41);
            taskLabel.Location = new Point(12, currentY);
            taskLabel.Text = string.Format(sampleTaskLabel,task.AssignedTo,task.Description);

            taskLabel.MouseEnter += taskLabelHover;
            taskLabel.MouseLeave += taskLabelLeave;

            taskPanel.Controls.Add(taskLabel);
        }

        private void taskLabelLeave(object sender, EventArgs e)
        {
            ((RichTextBox)sender).BackColor = Color.Gray;
        }

        private void taskLabelHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
            ((RichTextBox)sender).BackColor = Color.DimGray;
        }

        private void AddScroll()
        {
            ScrollBar vScrollBar1 = new VScrollBar();
            vScrollBar1.Dock = DockStyle.Right;
            vScrollBar1.Scroll += (sender, e) => { taskPanel.VerticalScroll.Value = vScrollBar1.Value; };
            taskPanel.Controls.Add(vScrollBar1);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dlg = new NewTask())
            {
                var dlgRes = dlg.ShowDialog();
                if(dlgRes == DialogResult.OK)
                {
                    queryRunner.CreateNewTask(dlg.task);
                }
            }
        }
    }
}
