using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Enums;

namespace TaskManagement.Models
{
    public class Comment
    {
        public DateTime CreatedOn { get; set; }
        public string Author { get; set; }
        public string CommentText { get; set; }
        public CommentType Type { get; set; }
        public DateTime Reminder { get; set; }
    }
}
