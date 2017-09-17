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
        DateTime CreatedOn { get; set; }
        string CommentText { get; set; }
        CommentType Type { get; set; }
        DateTime Reminder { get; set; }
    }
}
