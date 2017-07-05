namespace SQLPerformanceTest
{
    partial class PerfCheck
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PerfCheck));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this._CountCpu1 = new System.Diagnostics.PerformanceCounter();
            this._CountCpu2 = new System.Diagnostics.PerformanceCounter();
            this._CountMem1 = new System.Diagnostics.PerformanceCounter();
            this._CountMem2 = new System.Diagnostics.PerformanceCounter();
            this._CountDsk1 = new System.Diagnostics.PerformanceCounter();
            this._CountDsk2 = new System.Diagnostics.PerformanceCounter();
            this._CountDsk3 = new System.Diagnostics.PerformanceCounter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CollectedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mem1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mem2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disk1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disk2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disk3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.PlayButton = new System.Windows.Forms.ToolStripButton();
            this.PauseButton = new System.Windows.Forms.ToolStripButton();
            this.StopButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Status = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this._CountCpu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._CountCpu2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._CountMem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._CountMem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._CountDsk1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._CountDsk2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._CountDsk3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // _CountCpu1
            // 
            this._CountCpu1.CategoryName = "System";
            this._CountCpu1.CounterName = "Processor Queue Length";
            // 
            // _CountCpu2
            // 
            this._CountCpu2.CategoryName = "Processor";
            this._CountCpu2.CounterName = "% Processor Time";
            this._CountCpu2.InstanceName = "_Total";
            // 
            // _CountMem1
            // 
            this._CountMem1.CategoryName = "Memory";
            this._CountMem1.CounterName = "Page Faults/sec";
            // 
            // _CountMem2
            // 
            this._CountMem2.CategoryName = "Memory";
            this._CountMem2.CounterName = "Available MBytes";
            // 
            // _CountDsk1
            // 
            this._CountDsk1.CategoryName = "PhysicalDisk";
            this._CountDsk1.CounterName = "Disk Read Bytes/sec";
            this._CountDsk1.InstanceName = "_Total";
            // 
            // _CountDsk2
            // 
            this._CountDsk2.CategoryName = "PhysicalDisk";
            this._CountDsk2.CounterName = "Disk Writes/sec";
            this._CountDsk2.InstanceName = "_Total";
            // 
            // _CountDsk3
            // 
            this._CountDsk3.CategoryName = "PhysicalDisk";
            this._CountDsk3.CounterName = "Current Disk Queue Length";
            this._CountDsk3.InstanceName = "_Total";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CollectedOn,
            this.ProcQ,
            this.ProcT,
            this.Mem1,
            this.Mem2,
            this.Disk1,
            this.Disk2,
            this.Disk3});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(928, 288);
            this.dataGridView1.TabIndex = 0;
            // 
            // CollectedOn
            // 
            dataGridViewCellStyle18.Format = "G";
            dataGridViewCellStyle18.NullValue = null;
            this.CollectedOn.DefaultCellStyle = dataGridViewCellStyle18;
            this.CollectedOn.HeaderText = "Date & Time";
            this.CollectedOn.Name = "CollectedOn";
            this.CollectedOn.ReadOnly = true;
            this.CollectedOn.Width = 150;
            // 
            // ProcQ
            // 
            dataGridViewCellStyle19.Format = "N0";
            dataGridViewCellStyle19.NullValue = null;
            this.ProcQ.DefaultCellStyle = dataGridViewCellStyle19;
            this.ProcQ.HeaderText = "Processor Queue Lenght";
            this.ProcQ.Name = "ProcQ";
            this.ProcQ.ReadOnly = true;
            // 
            // ProcT
            // 
            this.ProcT.HeaderText = "% Processor Time - Total";
            this.ProcT.Name = "ProcT";
            this.ProcT.ReadOnly = true;
            // 
            // Mem1
            // 
            this.Mem1.HeaderText = "Page Faults/sec";
            this.Mem1.Name = "Mem1";
            this.Mem1.ReadOnly = true;
            // 
            // Mem2
            // 
            this.Mem2.HeaderText = "Available MB";
            this.Mem2.Name = "Mem2";
            this.Mem2.ReadOnly = true;
            // 
            // Disk1
            // 
            this.Disk1.HeaderText = "Disk Read Bytes/sec - Total";
            this.Disk1.Name = "Disk1";
            this.Disk1.ReadOnly = true;
            this.Disk1.Width = 120;
            // 
            // Disk2
            // 
            this.Disk2.HeaderText = "Disk Writes/sec - Total";
            this.Disk2.Name = "Disk2";
            this.Disk2.ReadOnly = true;
            this.Disk2.Width = 120;
            // 
            // Disk3
            // 
            this.Disk3.HeaderText = "Disk Queue Length - Total";
            this.Disk3.Name = "Disk3";
            this.Disk3.ReadOnly = true;
            this.Disk3.Width = 110;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PlayButton,
            this.PauseButton,
            this.StopButton,
            this.toolStripSeparator1,
            this.Status});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(952, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // PlayButton
            // 
            this.PlayButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PlayButton.Image = ((System.Drawing.Image)(resources.GetObject("PlayButton.Image")));
            this.PlayButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(23, 22);
            this.PlayButton.Text = "Start";
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PauseButton.Image = ((System.Drawing.Image)(resources.GetObject("PauseButton.Image")));
            this.PauseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(23, 22);
            this.PauseButton.Text = "Pause";
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StopButton.Image = ((System.Drawing.Image)(resources.GetObject("StopButton.Image")));
            this.StopButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(23, 22);
            this.StopButton.Text = "Stop";
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // Status
            // 
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(33, 22);
            this.Status.Text = "Iddle";
            // 
            // PerfCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 351);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PerfCheck";
            this.Text = "Eye on SQL - Load Test Perf Check";
            ((System.ComponentModel.ISupportInitialize)(this._CountCpu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._CountCpu2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._CountMem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._CountMem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._CountDsk1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._CountDsk2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._CountDsk3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Diagnostics.PerformanceCounter _CountCpu1;
        private System.Diagnostics.PerformanceCounter _CountCpu2;
        private System.Diagnostics.PerformanceCounter _CountMem1;
        private System.Diagnostics.PerformanceCounter _CountMem2;
        private System.Diagnostics.PerformanceCounter _CountDsk1;
        private System.Diagnostics.PerformanceCounter _CountDsk2;
        private System.Diagnostics.PerformanceCounter _CountDsk3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CollectedOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mem2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disk1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disk2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disk3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton PlayButton;
        private System.Windows.Forms.ToolStripButton PauseButton;
        private System.Windows.Forms.ToolStripButton StopButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel Status;


    }
}

