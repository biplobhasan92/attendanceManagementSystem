using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SQLite;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Panchrukhi.DAO
{
    class DatabaseConnection
    {

        public SQLiteConnection  sql_conn;
        public SQLiteCommand     sql_cmd;
        public SQLiteDataAdapter DA;
        public DataSet DS;





        // set Connection 
        public void SetConnection()
        {
            sql_conn = new SQLiteConnection("Data Source=panchrukhi.db; Version=3; New=False;Compress=True;");
            
        }





        // Execution Query
        public bool ExecutionQuery(string txtQuery)
        {
            bool returnVal = false;
            try
            {
                SetConnection();
                sql_conn.Open();
                sql_cmd = sql_conn.CreateCommand();
                sql_cmd.CommandText = txtQuery;
                int success = sql_cmd.ExecuteNonQuery();
                if (success > 0)
                {
                    returnVal = true;
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
            sql_conn.Close();
            return returnVal;
        }

        public bool ExecutionQuery(SortedList SLQuery)
        {
            bool s = false;
            string txtQuery = ""; //"begin ";
            try
            {
                SetConnection();
                sql_conn.Open();
                sql_cmd = sql_conn.CreateCommand();
                for (int i = 0; i < SLQuery.Count; i++)
                {
                    txtQuery += SLQuery.GetByIndex(i) + "; ";   
                }

                //txtQuery += " end";

                sql_cmd.CommandText = txtQuery;
                int success = sql_cmd.ExecuteNonQuery();
                if (success > 0)
                {
                    s = true;
                }
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                MessageBox.Show(ex.Message);
            }
            sql_conn.Close();
            return s;
        }



        // Load Data From SQlite Database For Any Table ...
        public void LoadDate(String tableName, String orderByColumnName)
        {
            string CommandText = "Select * from " + tableName + " order by " + orderByColumnName + " desc";
            ExecutionQuery(CommandText);
            DA = new SQLiteDataAdapter(CommandText, sql_conn);
            DataSet DS = new DataSet();
            DS.Reset();
            DA.Fill(DS);
            if (DS.Tables[0].Rows.Count > 0)
            {

            }
        }

        // Delete Function For All Form Int Val
        public bool DeleteTableRowInt(String tableName, String whereConditionColName, int whereConditionValue) {

            bool returnVal = false;
            try
            {
                DialogResult result = MessageBox.Show("Do You Want to delete?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    string cmdText = "delete from " + tableName + " where  " + whereConditionColName + " = " + whereConditionValue;
                    if (ExecutionQuery(cmdText))
                    {
                        returnVal = true;
                    }
                    else
                    {
                        returnVal = false;
                    }
                }
            }
            catch (Exception exc) {
                MessageBox.Show(exc.Message + " - Problem in DeleteTableRowInt()");
            }
            return returnVal;
        }



        // Delete Function For All Form String Val
        public bool DeleteTableRowStr(String tableName, String whereConditionColName, String whereConditionValue)
        {               //                   "TBLCATEGORY"     "NCATID"                      "1"
            bool returnVal = false;
            try {
                DialogResult result = MessageBox.Show("Do You Want to delete?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    string cmdText = "delete from " + tableName + " where  " + whereConditionColName + " = " + whereConditionValue;
                    if (ExecutionQuery(cmdText))
                    {
                        returnVal = true;
                    }
                    else
                    {
                        returnVal = false;
                    }
                }
            } catch (Exception exc) {
                MessageBox.Show(exc.Message + " - Problem DeleteTableRowStr()");
            }
            return returnVal;
        }


        // Validate Data Before Delete. if data used in Other Table.
        public bool checkDataIfItUsedOtherTable(String tableName, String whereConditionColName, int whereConditionValue) {
            bool returnVal = false;
            try
            {
                string cmdText = "select " + whereConditionColName + " from " + tableName + " where  " + whereConditionColName + " = " + whereConditionValue;
                ExecutionQuery(cmdText);
                DA = new SQLiteDataAdapter(cmdText, sql_conn);
                DataSet DS = new DataSet();
                DS.Reset();
                DA.Fill(DS);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    returnVal = true;
                }
                
            }
            catch (Exception exc) {
                MessageBox.Show(exc.Message + " - Problem checkDataIfItUsedOtherTable()");
            }
            return returnVal;
        }


        
        // Holiday Validation Method. if return true then make reporting grid row green.
        public bool checkDataIfItUsedOtherTableStr(String tableName, String whereConditionColName, string whereConditionValue)
        {
            bool returnVal = false;
            try
            {
                string cmdText = "select "+whereConditionColName+" from "+tableName+" where  "+whereConditionColName+" = '"+whereConditionValue+"' ";
                ExecutionQuery(cmdText);
                DA = new SQLiteDataAdapter(cmdText, sql_conn);
                DataSet DS = new DataSet();
                DS.Reset();
                DA.Fill(DS);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    returnVal = true;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message + " - Problem checkDataIfItUsedOtherTableStr()");
            }
            return returnVal;
        }


        public bool checkIfTableIsReturnNull(string table_name) {

            bool returnVal = false;
            try
            {
                string cmdText = "select * from "+table_name;
                ExecutionQuery(cmdText);
                DA = new SQLiteDataAdapter(cmdText, sql_conn);
                DataSet DS = new DataSet();
                DS.Reset();
                DA.Fill(DS);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    returnVal = true;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message + " - Problem checkIfTableIsReturnNull()");
            }
            return returnVal;
        }




        // Holiday Validation Method. if return true then make reporting grid row green.
        public bool checkGeneralHoliday(String tableName, String whereConditionColName, string whereConditionValue)
        {
            bool returnVal = false;
            try
            {
                string cmdText = "select " + whereConditionColName + " from " + tableName + " where  " + whereConditionColName + " = '"+ whereConditionValue+"' ";
                ExecutionQuery(cmdText);
                DA = new SQLiteDataAdapter(cmdText, sql_conn);
                DataSet DS = new DataSet();
                DS.Reset();
                DA.Fill(DS);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    returnVal = true;
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message + " - Problem checkDataIfItUsedOtherTable()");
            }
            return returnVal;
        }





        // Holiday Validation Method. if return true then make reporting grid row green.
        public bool checkGeneralWeekend(string attenDate)
        {
            bool returnVal = false;
            try
            {
                string cmdText = "select VDAYSFLAG from TBL_WEEKEND where  VSPECIALID = '00' ";
                ExecutionQuery(cmdText);
                DA = new SQLiteDataAdapter(cmdText, sql_conn);
                DataSet DS = new DataSet();
                DS.Reset();
                DA.Fill(DS);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    returnVal = true;
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message + " - Problem checkDataIfItUsedOtherTable()");
            }
            return returnVal;
        }







        // User Check In LogIn Table  
        public int checkUserToLogIn(String userName, String Password)
        {
            int LoginType = 0;
            try
            {
                string cmdText = "select LoginType from TBLUSERS where Username = '"+userName+ "' AND Password = '"+Password+ "' ";
                ExecutionQuery(cmdText);
                DA = new SQLiteDataAdapter(cmdText, sql_conn);
                DS = new DataSet();
                DS.Reset();
                DA.Fill(DS);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                        LoginType = Convert.ToInt32(DS.Tables[0].Rows[i]["LoginType"]);
                    //returnVal = true;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message + " - Problem checkUserToLogIn()");
            }
            return LoginType;
        }




        // GET Company name 
        public DataRow getCompanyNameAndAddress() {

            try
            {
                string cmdText = "select * from TBL_COMPANY";
                ExecutionQuery(cmdText);
                DA = new SQLiteDataAdapter(cmdText, sql_conn);
                DS = new DataSet();
                DS.Reset();
                DA.Fill(DS);
                if (DS.Tables[0].Rows.Count > 0)
                    return DS.Tables[0].Rows[0];
                else
                {
                    MessageBox.Show("Company Name was not set properly. Please contact your system administrator.");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Company Name was not set properly. Please contact your system administrator.");
            }
            return null;
        }

    }
}
