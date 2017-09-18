using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.DbHelper
{
    public static class QueryRepo
    {
        public static string GetAllTask = "SELECT * FROM public.\"Task\"";
        public static string InsertTask = "INSERT INTO public.\"Task\"(\"Id\",\"CreatedDate\",\"RequiredDate\",\"Desc\",\"Type\",\"AssignedTo\",\"NextActionDate\") VALUES(:TaskId,:DateCreated,:DateRequired,:TaskDesc,:TaskType,:TaskAssignee,NULL)";
        public static string SelectComments = "SELECT * FROM public.\"Comments\" WHERE \"TaskId\" = :taskId";
        public static string InsertComment = "INSERT INTO public.\"Comments\"(\"Id\",\"CreatedOn\",\"Description\",\"Reminder\",\"TaskId\",\"Type\",\"Author\") VALUES(:Id,:DateCreated,:Desc,:Reminder,:TaskId,:CommentType,:Author)";
    }
}
