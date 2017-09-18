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
            queryRunner = new QueryRunner(Constants.DbConnStr);
            Constants.QueryRunnerPub = queryRunner;
            FillTaskPanel(queryRunner.GetAllTasks());

        }

        private void FillTaskPanel(List<TaskObj> list)
        {
            currentY = 12;
            foreach(var task in list)
            {
                AddTaskInPanel(task);
                currentY += 51;
            }
        }

        private void AddTaskInPanel(TaskObj task)
        {
            var taskLabel = new CustomRichLabel(task) ;
            taskLabel.Location = new Point(12, currentY);
            taskPanel.Controls.Add(taskLabel);
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
