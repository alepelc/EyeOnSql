namespace SQLStressTool
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closetestmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.New_Panel = new System.Windows.Forms.Panel();
            this.CloseTestButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_log = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.num_attempt = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.num_failed = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.num_executed = new System.Windows.Forms.NumericUpDown();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.gr_conns = new System.Windows.Forms.GroupBox();
            this.chk_continous = new System.Windows.Forms.CheckBox();
            this.DurationMinutes = new System.Windows.Forms.NumericUpDown();
            this.l_duration = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_progress = new System.Windows.Forms.TextBox();
            this.chk_progress = new System.Windows.Forms.CheckBox();
            this.lb_Connections = new System.Windows.Forms.Label();
            this.txt_Connections = new System.Windows.Forms.TextBox();
            this.gr_SelectFiles = new System.Windows.Forms.GroupBox();
            this.l_elapsedtime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_results = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_selectFiles = new System.Windows.Forms.TextBox();
            this.btn_browseSelect = new System.Windows.Forms.Button();
            this.txt_DirSelect = new System.Windows.Forms.TextBox();
            this.BrowseFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.CountDown = new System.Windows.Forms.Timer(this.components);
            this.ProcessTest = new System.Windows.Forms.Timer(this.components);
            this.ElapsedTimeOfTest = new System.Windows.Forms.Timer(this.components);
            this.NewTest = new System.Windows.Forms.Button();
            this.MenuBar.SuspendLayout();
            this.New_Panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_attempt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_failed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_executed)).BeginInit();
            this.gr_conns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DurationMinutes)).BeginInit();
            this.gr_SelectFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuBar
            // 
            this.MenuBar.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MenuBar.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Padding = new System.Windows.Forms.Padding(8, 4, 0, 4);
            this.MenuBar.Size = new System.Drawing.Size(1780, 44);
            this.MenuBar.TabIndex = 0;
            this.MenuBar.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTestToolStripMenuItem,
            this.closetestmenu,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(72, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newTestToolStripMenuItem
            // 
            this.newTestToolStripMenuItem.Name = "newTestToolStripMenuItem";
            this.newTestToolStripMenuItem.Size = new System.Drawing.Size(345, 44);
            this.newTestToolStripMenuItem.Text = "New Test (Ctrl+ N)";
            this.newTestToolStripMenuItem.Click += new System.EventHandler(this.newTestToolStripMenuItem_Click);
            // 
            // closetestmenu
            // 
            this.closetestmenu.Enabled = false;
            this.closetestmenu.Name = "closetestmenu";
            this.closetestmenu.Size = new System.Drawing.Size(345, 44);
            this.closetestmenu.Text = "Close Test";
            this.closetestmenu.Click += new System.EventHandler(this.closetestmenu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(342, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(345, 44);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(85, 36);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(214, 44);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // StatusBar
            // 
            this.StatusBar.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.StatusBar.Location = new System.Drawing.Point(0, 857);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Padding = new System.Windows.Forms.Padding(2, 0, 20, 0);
            this.StatusBar.Size = new System.Drawing.Size(1780, 22);
            this.StatusBar.TabIndex = 1;
            this.StatusBar.Text = "statusStrip1";
            // 
            // New_Panel
            // 
            this.New_Panel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.New_Panel.Controls.Add(this.CloseTestButton);
            this.New_Panel.Controls.Add(this.groupBox1);
            this.New_Panel.Controls.Add(this.gr_conns);
            this.New_Panel.Controls.Add(this.gr_SelectFiles);
            this.New_Panel.Enabled = false;
            this.New_Panel.Location = new System.Drawing.Point(0, 48);
            this.New_Panel.Margin = new System.Windows.Forms.Padding(4);
            this.New_Panel.Name = "New_Panel";
            this.New_Panel.Size = new System.Drawing.Size(1758, 788);
            this.New_Panel.TabIndex = 2;
            this.New_Panel.Visible = false;
            // 
            // CloseTestButton
            // 
            this.CloseTestButton.Location = new System.Drawing.Point(1701, 13);
            this.CloseTestButton.Name = "CloseTestButton";
            this.CloseTestButton.Size = new System.Drawing.Size(47, 41);
            this.CloseTestButton.TabIndex = 14;
            this.CloseTestButton.Text = "x";
            this.CloseTestButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.CloseTestButton.UseVisualStyleBackColor = true;
            this.CloseTestButton.Click += new System.EventHandler(this.CloseTestButton_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_log);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.num_attempt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.num_failed);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.num_executed);
            this.groupBox1.Controls.Add(this.btn_Start);
            this.groupBox1.Controls.Add(this.btn_Stop);
            this.groupBox1.Location = new System.Drawing.Point(1072, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(588, 194);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General Options";
            // 
            // btn_log
            // 
            this.btn_log.Enabled = false;
            this.btn_log.Location = new System.Drawing.Point(12, 138);
            this.btn_log.Margin = new System.Windows.Forms.Padding(6);
            this.btn_log.Name = "btn_log";
            this.btn_log.Size = new System.Drawing.Size(150, 44);
            this.btn_log.TabIndex = 17;
            this.btn_log.Text = "View Log";
            this.btn_log.UseVisualStyleBackColor = true;
            this.btn_log.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Attempted Executions";
            // 
            // num_attempt
            // 
            this.num_attempt.Enabled = false;
            this.num_attempt.InterceptArrowKeys = false;
            this.num_attempt.Location = new System.Drawing.Point(382, 37);
            this.num_attempt.Margin = new System.Windows.Forms.Padding(6);
            this.num_attempt.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.num_attempt.Name = "num_attempt";
            this.num_attempt.ReadOnly = true;
            this.num_attempt.Size = new System.Drawing.Size(194, 31);
            this.num_attempt.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Failed Executions";
            // 
            // num_failed
            // 
            this.num_failed.Enabled = false;
            this.num_failed.InterceptArrowKeys = false;
            this.num_failed.Location = new System.Drawing.Point(382, 135);
            this.num_failed.Margin = new System.Windows.Forms.Padding(6);
            this.num_failed.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.num_failed.Name = "num_failed";
            this.num_failed.ReadOnly = true;
            this.num_failed.Size = new System.Drawing.Size(194, 31);
            this.num_failed.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Succeded Executions";
            // 
            // num_executed
            // 
            this.num_executed.Enabled = false;
            this.num_executed.InterceptArrowKeys = false;
            this.num_executed.Location = new System.Drawing.Point(382, 85);
            this.num_executed.Margin = new System.Windows.Forms.Padding(6);
            this.num_executed.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.num_executed.Name = "num_executed";
            this.num_executed.ReadOnly = true;
            this.num_executed.Size = new System.Drawing.Size(194, 31);
            this.num_executed.TabIndex = 6;
            // 
            // btn_Start
            // 
            this.btn_Start.Enabled = false;
            this.btn_Start.Location = new System.Drawing.Point(10, 40);
            this.btn_Start.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(150, 44);
            this.btn_Start.TabIndex = 6;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Enabled = false;
            this.btn_Stop.Location = new System.Drawing.Point(10, 88);
            this.btn_Stop.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(150, 44);
            this.btn_Stop.TabIndex = 12;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // gr_conns
            // 
            this.gr_conns.Controls.Add(this.chk_continous);
            this.gr_conns.Controls.Add(this.DurationMinutes);
            this.gr_conns.Controls.Add(this.l_duration);
            this.gr_conns.Controls.Add(this.label2);
            this.gr_conns.Controls.Add(this.textBox1);
            this.gr_conns.Controls.Add(this.button1);
            this.gr_conns.Controls.Add(this.txt_progress);
            this.gr_conns.Controls.Add(this.chk_progress);
            this.gr_conns.Controls.Add(this.lb_Connections);
            this.gr_conns.Controls.Add(this.txt_Connections);
            this.gr_conns.Location = new System.Drawing.Point(18, 13);
            this.gr_conns.Margin = new System.Windows.Forms.Padding(4);
            this.gr_conns.Name = "gr_conns";
            this.gr_conns.Padding = new System.Windows.Forms.Padding(4);
            this.gr_conns.Size = new System.Drawing.Size(994, 194);
            this.gr_conns.TabIndex = 3;
            this.gr_conns.TabStop = false;
            this.gr_conns.Text = "General Options";
            // 
            // chk_continous
            // 
            this.chk_continous.AutoSize = true;
            this.chk_continous.Location = new System.Drawing.Point(795, 42);
            this.chk_continous.Name = "chk_continous";
            this.chk_continous.Size = new System.Drawing.Size(153, 29);
            this.chk_continous.TabIndex = 18;
            this.chk_continous.Text = "Continuous";
            this.chk_continous.UseVisualStyleBackColor = true;
            this.chk_continous.CheckedChanged += new System.EventHandler(this.chk_continous_CheckedChanged);
            // 
            // DurationMinutes
            // 
            this.DurationMinutes.Location = new System.Drawing.Point(304, 98);
            this.DurationMinutes.Margin = new System.Windows.Forms.Padding(6);
            this.DurationMinutes.Maximum = new decimal(new int[] {
            2880,
            0,
            0,
            0});
            this.DurationMinutes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DurationMinutes.Name = "DurationMinutes";
            this.DurationMinutes.Size = new System.Drawing.Size(152, 31);
            this.DurationMinutes.TabIndex = 17;
            this.DurationMinutes.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.DurationMinutes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DurationMinutes_KeyPress);
            this.DurationMinutes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DurationMinutes_KeyUp);
            // 
            // l_duration
            // 
            this.l_duration.AutoSize = true;
            this.l_duration.Location = new System.Drawing.Point(16, 98);
            this.l_duration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_duration.Name = "l_duration";
            this.l_duration.Size = new System.Drawing.Size(204, 25);
            this.l_duration.TabIndex = 15;
            this.l_duration.Text = "Duration in Minutes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "SQL Server Name:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(304, 142);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(304, 31);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(621, 142);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "..";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_progress
            // 
            this.txt_progress.Enabled = false;
            this.txt_progress.Location = new System.Drawing.Point(682, 38);
            this.txt_progress.Margin = new System.Windows.Forms.Padding(4);
            this.txt_progress.MaxLength = 3;
            this.txt_progress.Name = "txt_progress";
            this.txt_progress.Size = new System.Drawing.Size(92, 31);
            this.txt_progress.TabIndex = 8;
            this.txt_progress.Text = "100";
            this.txt_progress.TextChanged += new System.EventHandler(this.txt_progress_TextChanged);
            this.txt_progress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_progress_KeyPress);
            // 
            // chk_progress
            // 
            this.chk_progress.AutoSize = true;
            this.chk_progress.Location = new System.Drawing.Point(468, 42);
            this.chk_progress.Margin = new System.Windows.Forms.Padding(6);
            this.chk_progress.Name = "chk_progress";
            this.chk_progress.Size = new System.Drawing.Size(209, 29);
            this.chk_progress.TabIndex = 7;
            this.chk_progress.Text = "Progress Load %";
            this.chk_progress.UseVisualStyleBackColor = true;
            this.chk_progress.CheckedChanged += new System.EventHandler(this.chk_progress_CheckedChanged);
            // 
            // lb_Connections
            // 
            this.lb_Connections.AutoSize = true;
            this.lb_Connections.Location = new System.Drawing.Point(16, 46);
            this.lb_Connections.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Connections.Name = "lb_Connections";
            this.lb_Connections.Size = new System.Drawing.Size(244, 25);
            this.lb_Connections.TabIndex = 1;
            this.lb_Connections.Text = "Concurrent Connections";
            // 
            // txt_Connections
            // 
            this.txt_Connections.Location = new System.Drawing.Point(304, 38);
            this.txt_Connections.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Connections.MaxLength = 6;
            this.txt_Connections.Name = "txt_Connections";
            this.txt_Connections.Size = new System.Drawing.Size(148, 31);
            this.txt_Connections.TabIndex = 0;
            this.txt_Connections.Text = "25";
            this.txt_Connections.TextChanged += new System.EventHandler(this.txt_Connections_TextChanged);
            this.txt_Connections.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Connections_KeyPress);
            // 
            // gr_SelectFiles
            // 
            this.gr_SelectFiles.Controls.Add(this.l_elapsedtime);
            this.gr_SelectFiles.Controls.Add(this.label1);
            this.gr_SelectFiles.Controls.Add(this.txt_results);
            this.gr_SelectFiles.Controls.Add(this.progressBar1);
            this.gr_SelectFiles.Controls.Add(this.WarningLabel);
            this.gr_SelectFiles.Controls.Add(this.label6);
            this.gr_SelectFiles.Controls.Add(this.txt_selectFiles);
            this.gr_SelectFiles.Controls.Add(this.btn_browseSelect);
            this.gr_SelectFiles.Controls.Add(this.txt_DirSelect);
            this.gr_SelectFiles.Location = new System.Drawing.Point(18, 215);
            this.gr_SelectFiles.Margin = new System.Windows.Forms.Padding(4);
            this.gr_SelectFiles.Name = "gr_SelectFiles";
            this.gr_SelectFiles.Padding = new System.Windows.Forms.Padding(4);
            this.gr_SelectFiles.Size = new System.Drawing.Size(1730, 550);
            this.gr_SelectFiles.TabIndex = 2;
            this.gr_SelectFiles.TabStop = false;
            this.gr_SelectFiles.Text = "Query Statements";
            // 
            // l_elapsedtime
            // 
            this.l_elapsedtime.AutoSize = true;
            this.l_elapsedtime.Location = new System.Drawing.Point(22, 513);
            this.l_elapsedtime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.l_elapsedtime.Name = "l_elapsedtime";
            this.l_elapsedtime.Size = new System.Drawing.Size(239, 25);
            this.l_elapsedtime.TabIndex = 9;
            this.l_elapsedtime.Text = "Elapsed Time: 00:00:00";
            this.l_elapsedtime.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Progress";
            // 
            // txt_results
            // 
            this.txt_results.Location = new System.Drawing.Point(22, 170);
            this.txt_results.Margin = new System.Windows.Forms.Padding(6);
            this.txt_results.Multiline = true;
            this.txt_results.Name = "txt_results";
            this.txt_results.ReadOnly = true;
            this.txt_results.Size = new System.Drawing.Size(638, 285);
            this.txt_results.TabIndex = 7;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.progressBar1.Location = new System.Drawing.Point(22, 465);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.MarqueeAnimationSpeed = 50;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(642, 37);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Visible = false;
            // 
            // WarningLabel
            // 
            this.WarningLabel.AutoSize = true;
            this.WarningLabel.ForeColor = System.Drawing.Color.Red;
            this.WarningLabel.Location = new System.Drawing.Point(680, 469);
            this.WarningLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(140, 25);
            this.WarningLabel.TabIndex = 6;
            this.WarningLabel.Text = "Warning Text";
            this.WarningLabel.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Folder:";
            // 
            // txt_selectFiles
            // 
            this.txt_selectFiles.AcceptsReturn = true;
            this.txt_selectFiles.Location = new System.Drawing.Point(682, 33);
            this.txt_selectFiles.Margin = new System.Windows.Forms.Padding(4);
            this.txt_selectFiles.Multiline = true;
            this.txt_selectFiles.Name = "txt_selectFiles";
            this.txt_selectFiles.ReadOnly = true;
            this.txt_selectFiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_selectFiles.Size = new System.Drawing.Size(1032, 423);
            this.txt_selectFiles.TabIndex = 3;
            this.txt_selectFiles.TextChanged += new System.EventHandler(this.txt_selectFiles_TextChanged);
            // 
            // btn_browseSelect
            // 
            this.btn_browseSelect.Location = new System.Drawing.Point(620, 35);
            this.btn_browseSelect.Margin = new System.Windows.Forms.Padding(4);
            this.btn_browseSelect.Name = "btn_browseSelect";
            this.btn_browseSelect.Size = new System.Drawing.Size(44, 37);
            this.btn_browseSelect.TabIndex = 2;
            this.btn_browseSelect.Text = "...";
            this.btn_browseSelect.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_browseSelect.UseVisualStyleBackColor = true;
            this.btn_browseSelect.Click += new System.EventHandler(this.btn_browseSelect_Click);
            // 
            // txt_DirSelect
            // 
            this.txt_DirSelect.Enabled = false;
            this.txt_DirSelect.Location = new System.Drawing.Point(104, 33);
            this.txt_DirSelect.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DirSelect.Name = "txt_DirSelect";
            this.txt_DirSelect.Size = new System.Drawing.Size(504, 31);
            this.txt_DirSelect.TabIndex = 1;
            // 
            // BrowseFolder
            // 
            this.BrowseFolder.ShowNewFolderButton = false;
            // 
            // ProcessTest
            // 
            this.ProcessTest.Interval = 1000;
            this.ProcessTest.Tick += new System.EventHandler(this.ProcessTest_Tick);
            // 
            // ElapsedTimeOfTest
            // 
            this.ElapsedTimeOfTest.Interval = 1000;
            this.ElapsedTimeOfTest.Tick += new System.EventHandler(this.ElapsedTimeOfTest_Tick);
            // 
            // NewTest
            // 
            this.NewTest.Location = new System.Drawing.Point(53, 128);
            this.NewTest.Name = "NewTest";
            this.NewTest.Size = new System.Drawing.Size(143, 115);
            this.NewTest.TabIndex = 3;
            this.NewTest.Text = "Start New Test";
            this.NewTest.UseVisualStyleBackColor = true;
            this.NewTest.Click += new System.EventHandler(this.NewTest_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1780, 879);
            this.Controls.Add(this.New_Panel);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.MenuBar);
            this.Controls.Add(this.NewTest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.MenuBar;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Eye on SQL - Load Test ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.New_Panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_attempt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_failed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_executed)).EndInit();
            this.gr_conns.ResumeLayout(false);
            this.gr_conns.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DurationMinutes)).EndInit();
            this.gr_SelectFiles.ResumeLayout(false);
            this.gr_SelectFiles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }







        #endregion

        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.Panel New_Panel;
        private System.Windows.Forms.TextBox txt_Connections;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lb_Connections;
        private System.Windows.Forms.GroupBox gr_SelectFiles;
        private System.Windows.Forms.TextBox txt_DirSelect;
        private System.Windows.Forms.Button btn_browseSelect;
        private System.Windows.Forms.TextBox txt_selectFiles;
        private System.Windows.Forms.GroupBox gr_conns;
        private System.Windows.Forms.FolderBrowserDialog BrowseFolder;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.TextBox txt_progress;
        private System.Windows.Forms.CheckBox chk_progress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.NumericUpDown num_executed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown num_failed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown num_attempt;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btn_log;
        private System.Windows.Forms.Timer CountDown;
        private System.Windows.Forms.Label l_duration;
        private System.Windows.Forms.NumericUpDown DurationMinutes;
        private System.Windows.Forms.Timer ProcessTest;
        private System.Windows.Forms.Label WarningLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_results;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l_elapsedtime;
        private System.Windows.Forms.Timer ElapsedTimeOfTest;
        private System.Windows.Forms.ToolStripMenuItem closetestmenu;
        private System.Windows.Forms.Button NewTest;
        private System.Windows.Forms.Button CloseTestButton;
        private System.Windows.Forms.CheckBox chk_continous;
    }
}

