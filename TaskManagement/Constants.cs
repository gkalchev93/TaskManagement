using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.DbHelper;

namespace TaskManagement
{
    public static class Constants
    {
        public static string DbConnStr = @"Server=127.0.0.1;Port=5432;User Id=postgres;Password=Gkalchev93;Database=Tasks;";
        public static QueryRunner QueryRunnerPub;
    }
}
