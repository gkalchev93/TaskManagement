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
            conn.MapEnum<CommentType>("CommentType");
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
                cmd.Parameters.Add(new NpgsqlParameter("TaskId", NpgsqlDbType.Uuid) { Value = task.Id });
                cmd.Parameters.Add(new NpgsqlParameter("DateCreated", NpgsqlDbType.Date) { Value = task.CreatedDate });
                cmd.Parameters.Add(new NpgsqlParameter("DateRequired", NpgsqlDbType.Date) { Value = task.RequiredByDate });
                cmd.Parameters.Add(new NpgsqlParameter("TaskDesc", NpgsqlDbType.Text) { Value = task.Description });
                cmd.Parameters.Add(new NpgsqlParameter("TaskType", task.Type));
                cmd.Parameters.Add(new NpgsqlParameter("TaskAssignee", NpgsqlDbType.Text) { Value = task.AssignedTo });

                cmd.ExecuteNonQuery();
            }
        }

        public List<Comment> GetAllComments(string taskId)
        {
            var retList = new List<Comment>();

            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = QueryRepo.SelectComments;
                cmd.Parameters.Add(new NpgsqlParameter("TaskId", NpgsqlDbType.Uuid) { Value = taskId });

                using (var dbReader = cmd.ExecuteReader())
                {
                    while (dbReader.Read())
                    {
                        var tmpComment = new Comment();

                        tmpComment.CreatedOn = (DateTime)dbReader["CreatedOn"];
                        tmpComment.CommentText = (string)dbReader["Description"];
                        tmpComment.Reminder = (DateTime)(string.IsNullOrEmpty(dbReader["Reminder"].ToString()) ? DateTime.MinValue : dbReader["Reminder"]);
                        tmpComment.Type = (CommentType)dbReader["Type"];
                        tmpComment.Author = (string)dbReader["Author"];
                        retList.Add(tmpComment);
                    }
                }
            }
            return retList;
        }

        public void InsertComment(string taskId,Comment tmpComment)
        {
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = QueryRepo.InsertComment;
                cmd.Parameters.Add(new NpgsqlParameter("Id", NpgsqlDbType.Uuid) { Value = Guid.NewGuid() });
                cmd.Parameters.Add(new NpgsqlParameter("DateCreated", NpgsqlDbType.Date) { Value = DateTime.Now });
                cmd.Parameters.Add(new NpgsqlParameter("Desc", NpgsqlDbType.Text) { Value = tmpComment.CommentText });
                cmd.Parameters.Add(new NpgsqlParameter("Reminder", NpgsqlDbType.Date) { Value = tmpComment.Reminder });
                cmd.Parameters.Add(new NpgsqlParameter("TaskId", NpgsqlDbType.Uuid) { Value = taskId });
                cmd.Parameters.Add(new NpgsqlParameter("CommentType",tmpComment.Type));
                cmd.Parameters.Add(new NpgsqlParameter("Author", NpgsqlDbType.Text) { Value = tmpComment.Author });

                cmd.ExecuteNonQuery();
            }
        }
    }
}
