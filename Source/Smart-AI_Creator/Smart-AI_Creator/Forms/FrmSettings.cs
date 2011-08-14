using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Smart_AI_Creator.Properties;

namespace Smart_AI_Creator
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        public void LoadSettings()
        {
            edtServer.Text = Settings.Default.Server;
            edtPort.Text = Settings.Default.Port;
            edtUser.Text = Settings.Default.User;
            edtPass.Text = Settings.Default.Password;
            edtDB.Text = Settings.Default.Database;

            _cbConnect.Checked = Settings.Default.UseConnect;
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Settings.Default.Server = edtServer.Text;
            Settings.Default.Port = edtPort.Text;
            Settings.Default.User = edtUser.Text;
            Settings.Default.Password = edtPass.Text;
            Settings.Default.Database = edtDB.Text;
            Settings.Default.UseConnect = _cbConnect.Checked;
            Settings.Default.Save();
            Settings.Default.Reload();    

            if (((Button)sender).Text != "Save")
            {
                if (!_cbConnect.Checked)
                    return;

                if (DatabaseHandler.IsConnected)
                {
                    MessageBox.Show("Connection is successfully!", "MySQL Connections!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No connection to database, please check settings", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (((Button)sender).Text == "Save")
            {
                Settings.Default.Save();
                this.Close();
            }
        }
    }
}
