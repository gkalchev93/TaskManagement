using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagement.Enums;
using TaskManagement.Models;

namespace TaskManagement
{
    public partial class NewTask : Form
    {
        public TaskObj task { get; private set; }
        public NewTask()
        {
            InitializeComponent();
        }

        private void NewTask_Load(object sender, EventArgs e)
        {
            this.Size = new Size(383, 405);
            tbId.Text = Guid.NewGuid().ToString();
            dateCreated.Value = DateTime.Now;
            dateCreated.Value = DateTime.Now.AddDays(1);

            cbState.DataSource = Enum.GetValues(typeof(TaskState));
            cbState.SelectedIndex = 0;

            cbType.DataSource = Enum.GetValues(typeof(TaskType));
            cbType.SelectedIndex = 0;

            cbUser.DataSource = Enum.GetValues(typeof(Users));
            cbUser.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            task = new TaskObj();
            task.Id = new Guid(tbId.Text);
            task.CreatedDate = dateCreated.Value;
            task.RequiredByDate = dateRequired.Value;
            task.Description = tbDesc.Text;
            task.Type = (TaskType)cbType.SelectedIndex;
            task.AssignedTo = cbUser.GetItemText( cbUser.SelectedItem);
        }
    }
}
