namespace Smart_AI_Creator
{
    partial class FrmSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.edtServer = new System.Windows.Forms.TextBox();
            this.edtPort = new System.Windows.Forms.TextBox();
            this.edtUser = new System.Windows.Forms.TextBox();
            this.edtPass = new System.Windows.Forms.TextBox();
            this.edtDB = new System.Windows.Forms.TextBox();
            this._cbConnect = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Database";
            // 
            // edtServer
            // 
            this.edtServer.Location = new System.Drawing.Point(86, 12);
            this.edtServer.Name = "edtServer";
            this.edtServer.Size = new System.Drawing.Size(100, 20);
            this.edtServer.TabIndex = 5;
            // 
            // edtPort
            // 
            this.edtPort.Location = new System.Drawing.Point(86, 38);
            this.edtPort.Name = "edtPort";
            this.edtPort.Size = new System.Drawing.Size(100, 20);
            this.edtPort.TabIndex = 6;
            // 
            // edtUser
            // 
            this.edtUser.Location = new System.Drawing.Point(86, 64);
            this.edtUser.Name = "edtUser";
            this.edtUser.Size = new System.Drawing.Size(100, 20);
            this.edtUser.TabIndex = 7;
            // 
            // edtPass
            // 
            this.edtPass.Location = new System.Drawing.Point(86, 90);
            this.edtPass.Name = "edtPass";
            this.edtPass.Size = new System.Drawing.Size(100, 20);
            this.edtPass.TabIndex = 8;
            // 
            // edtDB
            // 
            this.edtDB.Location = new System.Drawing.Point(86, 116);
            this.edtDB.Name = "edtDB";
            this.edtDB.Size = new System.Drawing.Size(100, 20);
            this.edtDB.TabIndex = 9;
            // 
            // _cbConnect
            // 
            this._cbConnect.AutoSize = true;
            this._cbConnect.Location = new System.Drawing.Point(86, 142);
            this._cbConnect.Name = "_cbConnect";
            this._cbConnect.Size = new System.Drawing.Size(81, 17);
            this._cbConnect.TabIndex = 10;
            this._cbConnect.Text = "DBConnect";
            this._cbConnect.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 167);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(111, 167);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 13;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 202);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this._cbConnect);
            this.Controls.Add(this.edtDB);
            this.Controls.Add(this.edtPass);
            this.Controls.Add(this.edtUser);
            this.Controls.Add(this.edtPort);
            this.Controls.Add(this.edtServer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edtServer;
        private System.Windows.Forms.TextBox edtPort;
        private System.Windows.Forms.TextBox edtUser;
        private System.Windows.Forms.TextBox edtPass;
        private System.Windows.Forms.TextBox edtDB;
        private System.Windows.Forms.CheckBox _cbConnect;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnTest;
    }
}