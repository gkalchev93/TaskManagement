using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;
using TaskManagement.Models;
using TaskManagement.Enums;

namespace TaskManagement.DbHelper
{
    public class QueryRunner
    {
        private NpgsqlConnection conn;
        public QueryRunner(string connStr)
        {
            conn = new NpgsqlConnection(connStr);
            conn.Open();
            conn.MapEnum<TaskState>("TaskState");
            conn.MapEnum<TaskType>("TaskType");
        }

        public List<TaskObj> GetAllTasks()
        {
            var retList = new List<TaskObj>();

            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = QueryRepo.GetAllTask;
                using (var dbReader = cmd.ExecuteReader())
                {
                    while (dbReader.Read())
                    {
                        var tmpTask = new TaskObj();
                        tmpTask.Id = (Guid)dbReader["Id"];
                        tmpTask.CreatedDate = (DateTime)dbReader["CreatedDate"];
                        tmpTask.RequiredByDate = (DateTime)dbReader["RequiredDate"];
                        tmpTask.Description = (string)dbReader["Desc"];
                        tmpTask.AssignedTo = (string)dbReader["AssignedTo"];

                        tmpTask.NextActionDate = (DateTime)(string.IsNullOrEmpty(dbReader["NextActionDate"].ToString()) ? DateTime.MinValue : dbReader["NextActionDate"]);
                        tmpTask.Status = (TaskState)dbReader["State"];
                        tmpTask.Type = (TaskType)dbReader["Type"];

                        retList.Add(tmpTask);
                    }
                }
            }

            return retList;
        }

        public void CreateNewTask(TaskObj task)
        {
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = QueryRepo.InsertTask;
                cmd.Parameters.Add(new NpgsqlParameter("TaskId", NpgsqlDbType.Uuid) { Value = task.Id});
                cmd.Parameters.Add(new NpgsqlParameter("DateCreated", NpgsqlDbType.Date) { Value = task.CreatedDate });
                cmd.Parameters.Add(new NpgsqlParameter("DateRequired", NpgsqlDbType.Date) { Value = task.RequiredByDate});
                cmd.Parameters.Add(new NpgsqlParameter("TaskDesc", NpgsqlDbType.Text) { Value = task.Description});
                cmd.Parameters.Add(new NpgsqlParameter("TaskType", task.Type) );
                cmd.Parameters.Add(new NpgsqlParameter("TaskAssignee", NpgsqlDbType.Text) { Value = task.AssignedTo});

                cmd.ExecuteNonQuery();
            }
        }
    }
}
