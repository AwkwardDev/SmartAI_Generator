using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Smart_AI_Creator
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            _cbFindSourceType.SetEnumValues<source_type>("SourceType", "", false);
            _cbFindEventType.SetEnumValues<event_type>("EventType", "", false);
            _cbFindActionType.SetEnumValues<action_type>("ActionType", "", false);
            _cbFindTargetType.SetEnumValues<target_type>("TargetType", "", false);

            _cbEventType.SetEnumValues<event_type>("", "", true);
            _cbActionType.SetEnumValues<action_type>("", "", true);
            _cbTargetType.SetEnumValues<target_type>("", "", true);
            _cbSourceType.SetEnumValues<source_type>("", "", true);

            _lvScripts.FillColumnsFromDatabase("smart_scripts");
        }

        private void _bFind_Click(object sender, EventArgs e)
        {
            FilterQuery();
        }

        private void FilterQuery()
        {
            _lvScripts.FillColumnsFromDatabase("smart_scripts");

            string q = QueryHandler.FilterQuery(_tbFindEntryOrGuid.GetIntValue(), _tbFindID.GetIntValue(), _cbFindEventType.GetIntValue(),
                _cbFindSourceType.GetIntValue(), _cbFindActionType.GetIntValue(), _cbFindTargetType.GetIntValue());

            DatabaseHandler.SelectSmartAIScript(q);
            _lvScripts.VirtualListSize = DatabaseHandler.SmartAI.Count;
            _lvScripts.Refresh();
        }

        private void _cbFindSourceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ComboBox)sender).SelectedIndex > 0)
                FilterQuery();
        }

        private void _lvScripts_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            e.Item = new ListViewItem(DatabaseHandler.SmartAI[e.ItemIndex].ToArray()); 
        }

        private void _lvScripts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_lvScripts.SelectedIndices.Count > 0)
                SmartAIData(DatabaseHandler.SmartAI[_lvScripts.SelectedIndices[0]]);
        }

        private void SmartAIData(SmartAI script)
        {
            _tbEntryOrGuid.Text = script.EntryOrGuid.ToString();
            _tbID.Text = script.ID.ToString();
            _tbChance.Text = script.EventChance.ToString();
            _tbLink.Text = script.Link.ToString();

            _cbSourceType.SelectedValue = script.SourceType;
            _clbEventFlag.SetCheckedItemFromFlag((uint)script.EventFlags);
            _clbPhase.SetCheckedItemFromFlag((uint)script.EventPhaseMask);

            _cbEventType.SelectedValue = script.EventType;
            _cbEventParametr1.SetValue(script.EventParam[0]);
            _cbEventParametr2.SetValue(script.EventParam[1]);
            _cbEventParametr3.SetValue(script.EventParam[2]);
            _cbEventParametr4.SetValue(script.EventParam[3]);

            _cbActionType.SelectedValue = script.ActionType;
            _cbActionParam1.SetValue(script.ActionParam[0]);
            _cbActionParam2.SetValue(script.ActionParam[1]);
            _cbActionParam3.SetValue(script.ActionParam[2]);
            _cbActionParam4.SetValue(script.ActionParam[3]);
            _cbActionParam5.SetValue(script.ActionParam[4]);
            _cbActionParam6.SetValue(script.ActionParam[5]);

            _cbTargetType.SelectedValue = script.TargetType;
            _cbTargetParam1.SetValue(script.TargetParam[0]);
            _cbTargetParam2.SetValue(script.TargetParam[1]);
            _cbTargetParam3.SetValue(script.TargetParam[2]);
            _cbTargetParamX.SetValue(script.TargetX.ToString());
            _cbTargetParamY.SetValue(script.TargetY.ToString());
            _cbTargetParamZ.SetValue(script.TargetZ.ToString());
            _cbTargetParamO.SetValue(script.TargetO.ToString());

            _tbComment.Text = script.Comment;
        }

        private void _cbEventType_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataHandler.ShowEventType(_cbEventType, _cbEventParametr1, _cbEventParametr2, _cbEventParametr3, _cbEventParametr4, lEventType1, lEventType2, lEventType3, lEventType4);
        }

        private void _cbTargetType_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataHandler.ShowTargetType(_cbTargetType, _cbTargetParam1, _cbTargetParam2, _cbTargetParam3, _cbTargetParamX, _cbTargetParamY, _cbTargetParamZ, _cbTargetParamO,
                lTargetParam1, lTargetParam2, lTargetParam3, lTargetParamX, lTargetParamY, lTargetParamZ, lTargetParamO);
        }

        private void _tbChance_TextChanged(object sender, EventArgs e)
        {
            if (_tbChance.Text.ToInt32() > 100)
                _tbChance.Text = "100";
        }

        private void _cbActionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataHandler.ShowActionType(_cbActionType, _cbActionParam1, _cbActionParam2, _cbActionParam3, _cbActionParam4, _cbActionParam5, _cbActionParam6,
                lActionParam1, lActionParam2, lActionParam3, lActionParam4, lActionParam5, lActionParam6);
        }

        private void _ToolItem_Settings_Click(object sender, EventArgs e)
        {
            FrmSettings settings = new FrmSettings();
            settings.ShowDialog();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            SmartAI script = new SmartAI();
            script.EntryOrGuid = _tbEntryOrGuid.Text.ToInt32();
            script.SourceType = _cbSourceType.GetIntValue();
            script.ID = _tbID.Text.ToInt32();
            script.Link = _tbLink.Text.ToInt32();
            script.EventType = _cbEventType.GetIntValue();
            script.EventPhaseMask = _clbPhase.GetFlagsValue();
            script.EventChance = _tbChance.Text.ToInt32();
            script.EventParam[0] = _cbEventParametr1.GetIntValue();
            script.EventParam[1] = _cbEventParametr2.GetIntValue();
            script.EventParam[2] = _cbEventParametr3.GetIntValue();
            script.EventParam[3] = _cbEventParametr4.GetIntValue();
            script.ActionType = _cbActionType.GetIntValue();
            script.ActionParam[0] = _cbActionParam1.GetIntValue();
            script.ActionParam[1] = _cbActionParam2.GetIntValue();
            script.ActionParam[2] = _cbActionParam3.GetIntValue();
            script.ActionParam[3] = _cbActionParam4.GetIntValue();
            script.ActionParam[4] = _cbActionParam5.GetIntValue();
            script.ActionParam[5] = _cbActionParam6.GetIntValue();
            script.TargetType = _cbTargetType.GetIntValue();
            script.TargetParam[0] = _cbTargetParam1.GetIntValue();
            script.TargetParam[1] = _cbTargetParam2.GetIntValue();
            script.TargetParam[2] = _cbTargetParam3.GetIntValue();
            script.TargetX = _cbTargetParamX.Text.ToFloat();
            script.TargetY = _cbTargetParamY.Text.ToFloat();
            script.TargetZ = _cbTargetParamZ.Text.ToFloat();
            script.TargetO = _cbTargetParamO.Text.ToFloat();

            script.Comment = _tbComment.Text;

            QueryHandler.BuildScriptQuery(script);
        }
    }
}
