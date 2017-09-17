using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Enums;

namespace TaskManagement.Models
{
    public class TaskObj
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime RequiredByDate { get; set; }
        public string Description { get; set; }
        public TaskState Status { get; set; }
        public TaskType Type { get; set; }
        public string AssignedTo { get; set; }
        public DateTime NextActionDate { get; set; }
        public List<Comment> Comments { get; set; }

        public TaskObj()
        {
            Comments = new List<Comment>();
        }
    }
}
