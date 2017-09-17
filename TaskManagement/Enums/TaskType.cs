using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Enums
{
    public enum TaskType
    {
        [PgName("Task")]
        Task,
        [PgName("Estimate")]
        Estimate
    }
}
