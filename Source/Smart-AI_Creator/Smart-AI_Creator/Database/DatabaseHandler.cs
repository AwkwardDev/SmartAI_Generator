using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections.Specialized;
using Smart_AI_Creator.Properties;

namespace Smart_AI_Creator
{
    public static class DatabaseHandler
    {
        private static MySqlConnection _conn;
        private static MySqlCommand _command;

        private static List<SmartAI> _SmartAIScript = new List<SmartAI>();

        public static StringCollection GetColumns(string Table)
        {
            string query = "SHOW COLUMNS FROM " + Table;
            StringCollection fldCol = new StringCollection();

            if (!IsConnected)
                return fldCol = null;

            try
            {
                using (_conn = new MySqlConnection(ConnectionString))
                {
                    _command = new MySqlCommand(query, _conn);
                    _conn.Open();

                    using (var reader = _command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            fldCol.Add(reader.GetValue(0).ToString());
                        }
                    }
                    _conn.Close();
                }
                return fldCol;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                return fldCol;
            }
        }

        public static void SelectSmartAIScript(string query)
        {
            if (!IsConnected)
            {
                if (Settings.Default.UseConnect)
                    System.Windows.Forms.MessageBox.Show("No connection to database, please check settings", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return;
            }

            using (_conn = new MySqlConnection(ConnectionString))
            {
                _command = new MySqlCommand(query, _conn);
                _conn.Open();
                _SmartAIScript.Clear();

                using (var reader = _command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        SmartAI script = new SmartAI();

                        script.EntryOrGuid      = reader[0].ToInt32();
                        script.SourceType       = reader[1].ToInt32();
                        script.ID               = reader[2].ToInt32();
                        script.Link             = reader[3].ToInt32();
                        script.EventType        = reader[4].ToInt32();
                        script.EventPhaseMask   = reader[5].ToInt32();
                        script.EventChance      = reader[6].ToInt32();
                        script.EventFlags       = reader[7].ToInt32();
                        script.EventParam[0]    = reader[8].ToInt32();
                        script.EventParam[1]    = reader[9].ToInt32();
                        script.EventParam[2]    = reader[10].ToInt32();
                        script.EventParam[3]    = reader[11].ToInt32();
                        script.ActionType       = reader[12].ToInt32();
                        script.ActionParam[0]   = reader[13].ToInt32();
                        script.ActionParam[1]   = reader[14].ToInt32();
                        script.ActionParam[2]   = reader[15].ToInt32();
                        script.ActionParam[3]   = reader[16].ToInt32();
                        script.ActionParam[4]   = reader[17].ToInt32();
                        script.ActionParam[5]   = reader[18].ToInt32();
                        script.TargetType       = reader[19].ToInt32();
                        script.TargetParam[0]   = reader[20].ToInt32();
                        script.TargetParam[1]   = reader[21].ToInt32();
                        script.TargetParam[2]   = reader[22].ToInt32();
                        script.TargetX          = reader[23].ToFloat();
                        script.TargetY          = reader[24].ToFloat();
                        script.TargetZ          = reader[25].ToFloat();
                        script.TargetO          = reader[26].ToFloat();
                        script.Comment          = reader[27].ToString();

                        _SmartAIScript.Add(script);
                    }
                }
                _conn.Close();
            } 
        }

        public static void Insert(string query)
        {
            if (!IsConnected)
            {
                if (Settings.Default.UseConnect)
                    System.Windows.Forms.MessageBox.Show("No connection to database, please check settings", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return;
            }

            try
            {
                _conn = new MySqlConnection(ConnectionString);
                _command = new MySqlCommand(query, _conn);
                _conn.Open();
                _command.ExecuteNonQuery();
                _command.Connection.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Data not recorded " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _conn.Close();
            }
        }
        
        #region Properties

        public static List<SmartAI> SmartAI
        {
            get { return _SmartAIScript; }
        }

        private static String ConnectionString
        {
            get
            {
                return String.Format("Server={0};Port={1};Uid={2};Pwd={3};Database={4};character set=utf8;Connection Timeout=10",
                    Settings.Default.Server,
                    Settings.Default.Port,
                    Settings.Default.User,
                    Settings.Default.Password,
                    Settings.Default.Database);
            }
        }

        public static bool IsConnected
        {
            get
            {
                if (!Settings.Default.UseConnect)
                    return false;

                try
                {
                    _conn = new MySqlConnection(ConnectionString);
                    _conn.Open();
                    _conn.Close();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        #endregion
    }
}