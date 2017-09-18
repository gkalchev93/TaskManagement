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
    public partial class TaskView : Form
    {
        public TaskView(TaskObj task)
        {
            InitializeComponent();
            cbState.DataSource = Enum.GetValues(typeof(TaskState));
            cbType.DataSource = Enum.GetValues(typeof(TaskType));

            tbId.Text = task.Id.ToString();
            dateCreated.Value = task.CreatedDate;
            dateRequired.Value = task.RequiredByDate;
            tbDesc.Text = task.Description;
            cbState.SelectedIndex = (int)task.Status;
            cbType.SelectedIndex = (int)task.Type;
            cbUser.SelectedIndex = cbUser.FindStringExact(task.AssignedTo);
            panelComments.AutoScroll = true;

            FillComments(task.Comments);
        }

        private void FillComments(List<Comment> comments)
        {
            int currentY = 10;

            foreach(var comment in comments)
            {
                var tmpComment = new CustomRichLabel(comment);
                tmpComment.Location = new Point(12, currentY);
                panelComments.Controls.Add(tmpComment);
                currentY += 51;
            }
        }

        private void addCommentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dlg = new Dialogs.NewComments(tbId.Text))
            {
                dlg.ShowDialog();
            }
        }
    }
}
