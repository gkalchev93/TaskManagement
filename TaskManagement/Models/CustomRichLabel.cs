using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagement.Models;

namespace TaskManagement
{
    class CustomRichLabel : RichTextBox
    {
        public object TaskObject { get; set; }

        public CustomRichLabel (TaskObj task)
        {
            var sampleTaskLabel = "Assignee: {0} \nDescription: {1}";
            this.TaskObject = task;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.BackColor = Color.Gray;
            this.ReadOnly = true;
            this.Size = new Size(296, 41);
            this.Text = string.Format(sampleTaskLabel, task.AssignedTo, task.Description);

            this.DoubleClick += LabelDoubleClick;
            this.MouseEnter += LabelHover;
            this.MouseLeave += LabelLeave;
        }

        public CustomRichLabel(Comment comment)
        {
            var sampleComment = $"Author: {comment.Author}\n {comment.CommentText}";
            this.TaskObject = comment;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.BackColor = Color.Gray;
            this.ReadOnly = true;
            this.Size = new Size(238, 39);
            this.Text = sampleComment;

            this.MouseDoubleClick += CommentDoubleClick;
            this.TextChanged += LabelOnTextChanged;
        }

        private void CommentDoubleClick(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LabelOnTextChanged(object sender, EventArgs e)
        {
            using (Graphics g = CreateGraphics())
            {
                SizeF size = g.MeasureString(Text, Font);
                Width = (int)Math.Ceiling(size.Width);
            }
        }

        private void LabelDoubleClick(object sender, EventArgs e)
        {
            var commentsList = ((MainForm)this.Parent.Parent).queryRunner.GetAllComments(((TaskObj)((CustomRichLabel)sender).TaskObject).Id.ToString());
            ((TaskObj)((CustomRichLabel)sender).TaskObject).Comments = commentsList;
            using (var dlg = new TaskView((TaskObj)((CustomRichLabel)sender).TaskObject))
            {
                dlg.ShowDialog();
            }
        }

        private void LabelLeave(object sender, EventArgs e)
        {
            ((RichTextBox)sender).BackColor = Color.Gray;
        }

        private void LabelHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
            ((RichTextBox)sender).BackColor = Color.DimGray;
        }
    }
}
