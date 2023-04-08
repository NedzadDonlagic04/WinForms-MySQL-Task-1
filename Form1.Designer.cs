namespace Zadatak3
{
    partial class MySQLProba
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
            this.connectionStringInputGroupBox = new System.Windows.Forms.GroupBox();
            this.connectToDbBtn = new System.Windows.Forms.Button();
            this.connectionStatusLabel = new System.Windows.Forms.Label();
            this.databaseGroupBox = new System.Windows.Forms.GroupBox();
            this.databaseTextBox = new System.Windows.Forms.TextBox();
            this.pwdGroupBox = new System.Windows.Forms.GroupBox();
            this.pwdTextBox = new System.Windows.Forms.TextBox();
            this.uidGroupBox = new System.Windows.Forms.GroupBox();
            this.uidTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.serverTextBox = new System.Windows.Forms.TextBox();
            this.queryGroupBox = new System.Windows.Forms.GroupBox();
            this.queryBtn = new System.Windows.Forms.Button();
            this.queryRichTextBox = new System.Windows.Forms.RichTextBox();
            this.connectionStringInputGroupBox.SuspendLayout();
            this.databaseGroupBox.SuspendLayout();
            this.pwdGroupBox.SuspendLayout();
            this.uidGroupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.queryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectionStringInputGroupBox
            // 
            this.connectionStringInputGroupBox.Controls.Add(this.connectToDbBtn);
            this.connectionStringInputGroupBox.Controls.Add(this.connectionStatusLabel);
            this.connectionStringInputGroupBox.Controls.Add(this.databaseGroupBox);
            this.connectionStringInputGroupBox.Controls.Add(this.pwdGroupBox);
            this.connectionStringInputGroupBox.Controls.Add(this.uidGroupBox);
            this.connectionStringInputGroupBox.Controls.Add(this.groupBox3);
            this.connectionStringInputGroupBox.Location = new System.Drawing.Point(13, 13);
            this.connectionStringInputGroupBox.Name = "connectionStringInputGroupBox";
            this.connectionStringInputGroupBox.Size = new System.Drawing.Size(220, 336);
            this.connectionStringInputGroupBox.TabIndex = 0;
            this.connectionStringInputGroupBox.TabStop = false;
            this.connectionStringInputGroupBox.Text = "Connection Info Input:";
            this.connectionStringInputGroupBox.Paint += new System.Windows.Forms.PaintEventHandler(this.connectionStringInputGroupBox_Paint);
            // 
            // connectToDbBtn
            // 
            this.connectToDbBtn.Location = new System.Drawing.Point(9, 291);
            this.connectToDbBtn.Name = "connectToDbBtn";
            this.connectToDbBtn.Size = new System.Drawing.Size(198, 39);
            this.connectToDbBtn.TabIndex = 4;
            this.connectToDbBtn.Text = "Connect To Database";
            this.connectToDbBtn.UseVisualStyleBackColor = true;
            this.connectToDbBtn.Click += new System.EventHandler(this.connectToDbBtn_Click);
            // 
            // connectionStatusLabel
            // 
            this.connectionStatusLabel.AutoSize = true;
            this.connectionStatusLabel.Location = new System.Drawing.Point(6, 240);
            this.connectionStatusLabel.Name = "connectionStatusLabel";
            this.connectionStatusLabel.Size = new System.Drawing.Size(97, 13);
            this.connectionStatusLabel.TabIndex = 2;
            this.connectionStatusLabel.Text = "Connection Status:";
            // 
            // databaseGroupBox
            // 
            this.databaseGroupBox.Controls.Add(this.databaseTextBox);
            this.databaseGroupBox.Location = new System.Drawing.Point(7, 170);
            this.databaseGroupBox.Name = "databaseGroupBox";
            this.databaseGroupBox.Size = new System.Drawing.Size(200, 44);
            this.databaseGroupBox.TabIndex = 3;
            this.databaseGroupBox.TabStop = false;
            this.databaseGroupBox.Text = "Database:";
            // 
            // databaseTextBox
            // 
            this.databaseTextBox.Location = new System.Drawing.Point(0, 20);
            this.databaseTextBox.Name = "databaseTextBox";
            this.databaseTextBox.Size = new System.Drawing.Size(200, 20);
            this.databaseTextBox.TabIndex = 0;
            // 
            // pwdGroupBox
            // 
            this.pwdGroupBox.Controls.Add(this.pwdTextBox);
            this.pwdGroupBox.Location = new System.Drawing.Point(7, 120);
            this.pwdGroupBox.Name = "pwdGroupBox";
            this.pwdGroupBox.Size = new System.Drawing.Size(200, 44);
            this.pwdGroupBox.TabIndex = 2;
            this.pwdGroupBox.TabStop = false;
            this.pwdGroupBox.Text = "Password:";
            // 
            // pwdTextBox
            // 
            this.pwdTextBox.Location = new System.Drawing.Point(0, 20);
            this.pwdTextBox.Name = "pwdTextBox";
            this.pwdTextBox.Size = new System.Drawing.Size(200, 20);
            this.pwdTextBox.TabIndex = 0;
            // 
            // uidGroupBox
            // 
            this.uidGroupBox.Controls.Add(this.uidTextBox);
            this.uidGroupBox.Location = new System.Drawing.Point(7, 70);
            this.uidGroupBox.Name = "uidGroupBox";
            this.uidGroupBox.Size = new System.Drawing.Size(200, 44);
            this.uidGroupBox.TabIndex = 1;
            this.uidGroupBox.TabStop = false;
            this.uidGroupBox.Text = "User ID:";
            // 
            // uidTextBox
            // 
            this.uidTextBox.Location = new System.Drawing.Point(0, 20);
            this.uidTextBox.Name = "uidTextBox";
            this.uidTextBox.Size = new System.Drawing.Size(200, 20);
            this.uidTextBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.serverTextBox);
            this.groupBox3.Location = new System.Drawing.Point(7, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 44);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Server:";
            // 
            // serverTextBox
            // 
            this.serverTextBox.Location = new System.Drawing.Point(0, 20);
            this.serverTextBox.Name = "serverTextBox";
            this.serverTextBox.Size = new System.Drawing.Size(200, 20);
            this.serverTextBox.TabIndex = 0;
            // 
            // queryGroupBox
            // 
            this.queryGroupBox.Controls.Add(this.queryBtn);
            this.queryGroupBox.Controls.Add(this.queryRichTextBox);
            this.queryGroupBox.Location = new System.Drawing.Point(366, 13);
            this.queryGroupBox.Name = "queryGroupBox";
            this.queryGroupBox.Size = new System.Drawing.Size(326, 336);
            this.queryGroupBox.TabIndex = 1;
            this.queryGroupBox.TabStop = false;
            this.queryGroupBox.Text = "Query Input:";
            // 
            // queryBtn
            // 
            this.queryBtn.Location = new System.Drawing.Point(61, 291);
            this.queryBtn.Name = "queryBtn";
            this.queryBtn.Size = new System.Drawing.Size(207, 39);
            this.queryBtn.TabIndex = 1;
            this.queryBtn.Text = "Query Database";
            this.queryBtn.UseVisualStyleBackColor = true;
            this.queryBtn.Click += new System.EventHandler(this.queryBtn_Click);
            // 
            // queryRichTextBox
            // 
            this.queryRichTextBox.Location = new System.Drawing.Point(7, 20);
            this.queryRichTextBox.Name = "queryRichTextBox";
            this.queryRichTextBox.Size = new System.Drawing.Size(313, 265);
            this.queryRichTextBox.TabIndex = 0;
            this.queryRichTextBox.Text = "";
            // 
            // MySQLProba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 361);
            this.Controls.Add(this.queryGroupBox);
            this.Controls.Add(this.connectionStringInputGroupBox);
            this.Name = "MySQLProba";
            this.Text = "MySQLProba";
            this.connectionStringInputGroupBox.ResumeLayout(false);
            this.connectionStringInputGroupBox.PerformLayout();
            this.databaseGroupBox.ResumeLayout(false);
            this.databaseGroupBox.PerformLayout();
            this.pwdGroupBox.ResumeLayout(false);
            this.pwdGroupBox.PerformLayout();
            this.uidGroupBox.ResumeLayout(false);
            this.uidGroupBox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.queryGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox connectionStringInputGroupBox;
        private System.Windows.Forms.Button connectToDbBtn;
        private System.Windows.Forms.Label connectionStatusLabel;
        private System.Windows.Forms.GroupBox databaseGroupBox;
        private System.Windows.Forms.TextBox databaseTextBox;
        private System.Windows.Forms.GroupBox pwdGroupBox;
        private System.Windows.Forms.TextBox pwdTextBox;
        private System.Windows.Forms.GroupBox uidGroupBox;
        private System.Windows.Forms.TextBox uidTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox serverTextBox;
        private System.Windows.Forms.GroupBox queryGroupBox;
        private System.Windows.Forms.Button queryBtn;
        private System.Windows.Forms.RichTextBox queryRichTextBox;
    }
}

