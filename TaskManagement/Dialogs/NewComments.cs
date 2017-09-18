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

namespace TaskManagement.Dialogs
{
    public partial class NewComments : Form
    {
        private string TaskId { get; set; }
        public NewComments(string taskId)
        {
            InitializeComponent();
            TaskId = taskId;
            cbType.DataSource = Enum.GetValues(typeof(CommentType));
            cbType.SelectedIndex = 0;
            cbUser.DataSource = Enum.GetValues(typeof(Users));
            cbUser.SelectedIndex = 0;
            dateReminder.Enabled = false;
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cb = (ComboBox)sender;
            if ((CommentType)cb.SelectedIndex == CommentType.Reminder)
                dateReminder.Enabled = true;
            else
                dateReminder.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tmpComment = new Comment();
            tmpComment.Type = (CommentType)cbType.SelectedIndex;
            tmpComment.CommentText = tbComment.Text;
            tmpComment.Reminder = cbType.SelectedIndex == 1 ? dateReminder.Value : DateTime.MinValue;
            tmpComment.Author = cbUser.SelectedValue.ToString();

            Constants.QueryRunnerPub.InsertComment(TaskId, tmpComment);
        }
    }
}
