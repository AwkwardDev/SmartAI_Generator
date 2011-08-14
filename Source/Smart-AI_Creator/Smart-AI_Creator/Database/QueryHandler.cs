using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Text;
using System.IO;

namespace Smart_AI_Creator
{
    public static class QueryHandler
    {
        public static string FilterQuery(int _EntryOrGuid, int _ID, int _EventType, int _SourceType, int _ActionType, int _TargetType)
        {
            string Query;

            string fquery = "SELECT * FROM `smart_scripts` WHERE ";
            string squery = "";
            squery += (_EntryOrGuid > 0) ? String.Format("entryorguid = {0} || ", _EntryOrGuid) : "";
            squery += (_SourceType > -1) ? String.Format("source_type = {0} || ", _SourceType) : "";
            squery += (_ID > 0) ? String.Format("id = {0} || ", _ID) : "";
            squery += (_EventType > -1) ? String.Format("event_type = {0} || ", _EventType) : "";
            squery += (_ActionType > -1) ? String.Format("action_type = {0} || ", _ActionType) : "";
            squery += (_TargetType > -1) ? String.Format("target_type = {0} || ", _TargetType) : "";
            Query   = (squery.Length == 0) ? fquery.Remove(fquery.Length - 6) : fquery + squery.Remove(squery.Length - 3);

            return Query;
        }

        public static void BuildScriptQuery(SmartAI _script)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormatLine("UPDATE `creature_template` SET `AIName`='SmartAI' WHERE `entry` = '{0}';", _script.EntryOrGuid);
            sb.AppendFormatLine("DELETE FROM `smart_scripts` WHERE `source_type`= '{0}' AND `entryorguid`= '{1}';", _script.SourceType, _script.EntryOrGuid);
            sb.AppendFormatLine("INSERT INTO `smart_scripts` VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}', '{21}', '{22}', '{23}','{24}', '{25}', '{26}', '{27}');",
                _script.EntryOrGuid, _script.SourceType, _script.ID, _script.Link, _script.EventType, _script.EventPhaseMask, _script.EventChance, _script.EventFlags,
                _script.EventParam[0], _script.EventParam[1], _script.EventParam[2], _script.EventParam[3], _script.ActionType,
                _script.ActionParam[0], _script.ActionParam[1], _script.ActionParam[2], _script.ActionParam[3], _script.ActionParam[4], _script.ActionParam[5],
                _script.TargetType, _script.TargetParam[0], _script.TargetParam[1], _script.TargetParam[2], _script.TargetX, _script.TargetY, _script.TargetZ, _script.TargetO,
                _script.Comment.RemExc());

            WriteToFile(sb);
        }

        private static void WriteToFile(StringBuilder _sb)
        {
            using (StreamWriter sw = new StreamWriter("NEW_EVENTAI_SQL.sql", true, Encoding.UTF8))
                sw.WriteLine(_sb.ToString());
        }
    }
}
