using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SQLite;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Panchrukhi.DAO;

namespace Panchrukhi.DAO
{
    class AppMainPersonTab
    {
        DatabaseConnection BDConnectionClass = new DatabaseConnection();
        public SQLiteConnection sql_conn;
        public SQLiteCommand sql_cmd;
        public SQLiteDataAdapter DB;

        // Load Data From SQlite Database
        public void LoadDate()
        {
            BDConnectionClass.SetConnection();
            sql_conn.Open();
            sql_cmd = sql_conn.CreateCommand();
            string CommandText = "Select * from emp_info order by emp_id desc";
            DB = new SQLiteDataAdapter(CommandText, sql_conn);
            sql_conn.Close();
        }

    }
}
