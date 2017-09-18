using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Enums
{
    public enum CommentType
    {
        [PgName("Normal")]
        Normal,
        [PgName("Reminder")]
        Reminder
    }
}
