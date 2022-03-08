namespace SQLStressTool
{
    partial class ConnSQL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnSQL));
            this.txt_sqlsrv = new System.Windows.Forms.TextBox();
            this.box_dbs = new System.Windows.Forms.ComboBox();
            this.chk_Integrated = new System.Windows.Forms.RadioButton();
            this.chk_sql = new System.Windows.Forms.RadioButton();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_connect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_sqlsrv
            // 
            this.txt_sqlsrv.BackColor = System.Drawing.SystemColors.Window;
            this.txt_sqlsrv.Location = new System.Drawing.Point(73, 20);
            this.txt_sqlsrv.Name = "txt_sqlsrv";
            this.txt_sqlsrv.Size = new System.Drawing.Size(199, 20);
            this.txt_sqlsrv.TabIndex = 0;
            this.txt_sqlsrv.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_sqlsrv_KeyDown);
            // 
            // box_dbs
            // 
            this.box_dbs.FormattingEnabled = true;
            this.box_dbs.Location = new System.Drawing.Point(64, 248);
            this.box_dbs.Name = "box_dbs";
            this.box_dbs.Size = new System.Drawing.Size(208, 21);
            this.box_dbs.TabIndex = 6;
            this.box_dbs.SelectedIndexChanged += new System.EventHandler(this.box_dbs_SelectedIndexChanged);
            this.box_dbs.KeyUp += new System.Windows.Forms.KeyEventHandler(this.box_dbs_KeyUp);
            this.box_dbs.Click += new System.EventHandler(this.box_dbs_Click);
            // 
            // chk_Integrated
            // 
            this.chk_Integrated.AutoSize = true;
            this.chk_Integrated.Location = new System.Drawing.Point(8, 55);
            this.chk_Integrated.Name = "chk_Integrated";
            this.chk_Integrated.Size = new System.Drawing.Size(136, 17);
            this.chk_Integrated.TabIndex = 1;
            this.chk_Integrated.TabStop = true;
            this.chk_Integrated.Text = "Use Integrated Security";
            this.chk_Integrated.UseVisualStyleBackColor = true;
            // 
            // chk_sql
            // 
            this.chk_sql.AutoSize = true;
            this.chk_sql.Location = new System.Drawing.Point(8, 79);
            this.chk_sql.Name = "chk_sql";
            this.chk_sql.Size = new System.Drawing.Size(139, 17);
            this.chk_sql.TabIndex = 2;
            this.chk_sql.TabStop = true;
            this.chk_sql.Text = "Use SQL Authentication";
            this.chk_sql.UseVisualStyleBackColor = true;
            this.chk_sql.CheckedChanged += new System.EventHandler(this.chk_sql_CheckedChanged);
            // 
            // txt_user
            // 
            this.txt_user.Enabled = false;
            this.txt_user.Location = new System.Drawing.Point(64, 105);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(208, 20);
            this.txt_user.TabIndex = 3;
            // 
            // txt_pwd
            // 
            this.txt_pwd.Enabled = false;
            this.txt_pwd.Location = new System.Drawing.Point(64, 131);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(208, 20);
            this.txt_pwd.TabIndex = 4;
            this.txt_pwd.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "SQL Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Database";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(159, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_connect
            // 
            this.btn_connect.Enabled = false;
            this.btn_connect.Location = new System.Drawing.Point(64, 180);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(150, 23);
            this.btn_connect.TabIndex = 5;
            this.btn_connect.Text = "Retrieve Databases";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // ConnSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(299, 342);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.chk_sql);
            this.Controls.Add(this.chk_Integrated);
            this.Controls.Add(this.box_dbs);
            this.Controls.Add(this.txt_sqlsrv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnSQL";
            this.ShowInTaskbar = false;
            this.Text = "SQL Instance Locator";
            this.Load += new System.EventHandler(this.ConnSQL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.TextBox txt_sqlsrv;
        private System.Windows.Forms.ComboBox box_dbs;
        private System.Windows.Forms.RadioButton chk_Integrated;
        private System.Windows.Forms.RadioButton chk_sql;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_connect;
    }
}