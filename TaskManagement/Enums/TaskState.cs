using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NpgsqlTypes;

namespace TaskManagement.Enums
{
    public enum TaskState
    {
        [PgName("New")]
        New,
        [PgName("Processing")]
        Processing,
        [PgName("OnHold")]
        OnHold,
        [PgName("Finished")]
        Finished,
        [PgName("Closed")]
        Closed
    }
}
