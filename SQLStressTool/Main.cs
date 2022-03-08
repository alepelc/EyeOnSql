using System;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using System.IO;
using System.Collections;
using System.Diagnostics;


namespace SQLStressTool
{
    public partial class Main : Form
    {
        #region GlobalVariables

        public SqlConnectionStringBuilder _SqlConnString;
        public static int _Conns;
        private int _LoopCount;
        public ManualResetEvent finished;
        public bool _Redo;
        public Thread t;
        public Thread Perf;
        public int threadCount;
        //public SqlConnectionStringBuilder _connstring;
        private bool _Stop = false;
        
        public StringBuilder _ExecutionLog;
        public ArrayList _PerformanceResutls;

        public string[] _Selectfiles;
        public string[] _files;
        public bool _KeepRunning = true;
        private int _MinsToRun = 0;
        private int _MaxFiles = 30;
        private int _MaxConns = 150;
        private DateTime StartTime;
        private DateTime _Crono;
        
        public StreamWriter _PerfLog;
        //public PerformanceCounter _Mem1 = null;
        //public PerformanceCounter _Mem2 = null;
        //public PerformanceCounter _Proc1 = null;
        //public PerformanceCounter[] _Proc2 = null;
        //public PerformanceCounter[] _Disk1 = null;
        //public PerformanceCounter[] _Disk2 = null;
        //public PerformanceCounter[] _Disk3 = null;
        //bool _roundwait = true;
        //string _PerfPath = Directory.GetCurrentDirectory();

        #endregion
        public Main()
        {
            InitializeComponent();
        }
        void Main_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
            {
                if (!New_Panel.Visible)
                    newTestToolStripMenuItem_Click(null, null);
            }
            if (e.Control && e.KeyCode == Keys.V)
                e.Handled = true;
        }

        private void NewTest_Click(object sender, EventArgs e)
        {
            if (!New_Panel.Visible)
            {
                NewTest.Visible = false;
                NewTest.Enabled = false;
                newTestToolStripMenuItem_Click(null, null);
            }
        }
        private void CloseTestButton_Click_1(object sender, EventArgs e)
        {
            btn_Stop_Click(null, null);
            closetestmenu_Click(null, null);
        }


        #region Menu

        private void newTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closetestmenu.Enabled = true;
            newTestToolStripMenuItem.Enabled = false;
            New_Panel.Enabled = true;
            New_Panel.Visible = true;
            InitialValues();
        }
        private void closetestmenu_Click(object sender, EventArgs e)
        {
            closetestmenu.Enabled = false;
            newTestToolStripMenuItem.Enabled = true;
            New_Panel.Enabled = false;
            New_Panel.Visible = false;
            NewTest.Visible = true;
            NewTest.Enabled = true;
            InitialValues();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About _about = new About();
            _about.ShowDialog();
        }

        #endregion

        #region ConfigureStress

        void txt_Connections_TextChanged(object sender, EventArgs e)
        {
            if ((txt_Connections.TextLength > 0) && (Convert.ToInt32(txt_Connections.Text) <= _MaxConns))
            {
                if (CheckInfo())
                    btn_Start.Enabled = true;
                else
                    btn_Start.Enabled = false;
            }
            else if (txt_Connections.TextLength > 0)
            {
                MessageBox.Show("The maximum value cannot exceed " + _MaxConns.ToString() + ".", "Concurrent Connections", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Connections.Text = "25";
            }
        }
        void txt_Connections_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        void DurationMinutes_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        void DurationMinutes_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (DurationMinutes.Value > 2880)
                DurationMinutes.Value = 2880;
        }

        void textBox1_TextChanged(object sender, System.EventArgs e)
        {
            if (CheckInfo())
                btn_Start.Enabled = true;
            else
                btn_Start.Enabled = false;
        }

        void txt_progress_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        void txt_progress_TextChanged(object sender, System.EventArgs e)
        {
            if (txt_progress.Text.Length > 0)
            {
                if (Convert.ToInt32(txt_progress.Text) > 100)
                {
                    MessageBox.Show("The Porcentage can't be bigger than 100. Please correct the value", "Percentage Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_progress.Text = string.Empty;
                }
            }
            if (CheckInfo())
                btn_Start.Enabled = true;
            else
                btn_Start.Enabled = false;
        }

        private void chk_progress_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_progress.Checked == true)
            {
                txt_progress.Text = string.Empty;
                txt_progress.Enabled = true;
            }
            else
            {
                txt_progress.Text = "100";
                txt_progress.Enabled = false;
            }
        }

        private void chk_continous_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_continous.Checked == true)
            {
                txt_progress.Enabled = false;
                txt_Connections.Enabled = false;
                chk_progress.Enabled = false;
                DurationMinutes.Enabled = false;

                txt_progress.Text = "100";
                txt_Connections.Text = "1";
            }
            else
            {
                txt_progress.Enabled = true;
                txt_Connections.Enabled = true;
                chk_progress.Enabled = true;
                DurationMinutes.Enabled = true;
            }
        }

        void txt_selectFiles_TextChanged(object sender, System.EventArgs e)
        {
            if (CheckInfo())
                btn_Start.Enabled = true;
            else
                btn_Start.Enabled = false;
        }

        private void btn_browseSelect_Click(object sender, EventArgs e)
        {
            //int file = 0;
            DialogResult _FolderSelect = this.BrowseFolder.ShowDialog();
            if (_FolderSelect == DialogResult.OK)
            {
                WarningLabel.Visible = false;
                txt_DirSelect.Text = this.BrowseFolder.SelectedPath.ToString();

                //file = Directory.GetFiles(txt_DirSelect.Text, "*.sql").Length;

                txt_selectFiles.Text = string.Empty;

                _files = Directory.GetFiles(txt_DirSelect.Text, "*.sql");

                //foreach (string _file in _files)
                //{
                //    txt_selectFiles.Text += _file +"\r\n";
                //    file++;
                //    if (file == _MaxFiles)
                //    {
                //        WarningLabel.Text = "The folder contains more files than the allowed. Only the first 30 will be used.";
                //        WarningLabel.Visible = true;
                //        break;
                //    }
                //}
            }
            txt_selectFiles.Text = _files.Length.ToString();
        }


        bool CheckInfo()
        {
            bool cons = false;
            bool srv = false;
            bool files = false;
            bool progress = false;

            if ((txt_Connections.TextLength > 0) && (Convert.ToInt32(txt_Connections.Text) >= 1))
                cons = true;

            if (textBox1.TextLength > 0)
                srv = true;

            if (txt_selectFiles.Text.Trim().Length > 0)
                files = true;

            if (txt_progress.Text.Trim().Length > 0)
                progress = true;

            if (cons && srv && files && progress)
                return true;
            else
                return false;
        }

        #endregion

        #region StartStress

        public void btn_Start_Click(object sender, EventArgs e)
        {
            
            try
            {
                int files = Directory.GetFiles(txt_DirSelect.Text, "*.sql").Length;


                closetestmenu.Enabled = false;
                _Crono = Convert.ToDateTime("00:00:00");
                StartTime = DateTime.Now;
                ElapsedTimeOfTest.Enabled = true;
                _KeepRunning = true;
                CleanUpStuff();
                DisableControls();
                _ExecutionLog = new StringBuilder();
                _ExecutionLog.AppendLine(string.Concat(DateTime.Now.ToUniversalTime().ToString(), " - Start of load test"));
                txt_results.BeginInvoke(new MethodInvoker(delegate () { txt_results.Text += "Start of load test.\r\n"; }));
                _Stop = false;
                bool _filevalid = true;
                //string[] _Selectfiles = txt_selectFiles.Lines;
                string[] _Selectfiles = _files;
                string _filestoprocess = string.Empty;
                object _Objs;

                foreach (string _file in _Selectfiles)
                {
                    if (_file.Length > 0)
                    {
                        if (!File.Exists(_file))
                        {
                            _filevalid = false;
                            MessageBox.Show(string.Concat("File ", _file, " does not exist."), "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            _ExecutionLog.AppendLine(string.Concat(DateTime.Now.ToUniversalTime().ToString(), " - File ", _file, " does not exist."));
                        }
                        if (_filestoprocess == string.Empty)
                            _filestoprocess = _file;
                        else
                            _filestoprocess = _filestoprocess + "," + _file;
                    }
                }
                if (chk_continous.Checked)
                {
                    if (_filevalid)
                    {
                        _ExecutionLog.AppendLine(string.Concat(DateTime.Now.ToUniversalTime().ToString(), " - Files checked. Starting test."));
                        txt_results.BeginInvoke(new MethodInvoker(delegate () { txt_results.Text += "Files checked. Starting test.\r\n"; }));
                        _Objs = new object[1] { _filestoprocess };
                        t = new Thread(new ParameterizedThreadStart(StartStressContinous));
                        t.Name = "StartThread";
                        t.Start(_Objs);
                    }
                }
                else
                {
                    _MinsToRun = Convert.ToInt32(DurationMinutes.Value * 60);
                    _Conns = Convert.ToInt32(txt_Connections.Text);

                    if (_filevalid)
                    {
                        _ExecutionLog.AppendLine(string.Concat(DateTime.Now.ToUniversalTime().ToString(), " - Files checked. Starting test."));
                        txt_results.BeginInvoke(new MethodInvoker(delegate () { txt_results.Text += "Files checked. Starting test.\r\n"; }));
                        ProcessTest.Enabled = true;
                        _Objs = new object[2] { _filestoprocess, Convert.ToInt32(txt_progress.Text) };
                        t = new Thread(new ParameterizedThreadStart(StartStress));
                        t.Name = "StartThread";
                        t.Start(_Objs);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message.ToString());
                RestoreControls();
            }
        }
        
        public void StartStress(object _ThreadObjs)
        {
            int round = 0;            
            Array argArray = new object[2];
            argArray = (Array)_ThreadObjs;
            string[] _SelectFiles = argArray.GetValue(0).ToString().Split(new Char[] { ',' });
            int _precentage = (int)argArray.GetValue(1);
            txt_results.BeginInvoke(new MethodInvoker(delegate() { txt_results.Text += "Please wait while the test performs...\r\n"; }));
            Random _rndnum = new Random();
            while (_KeepRunning)
            {
                _Redo = true;
                _LoopCount = 0;
                int _baseConns = 0;
                while (_Redo)
                {
                    if (_precentage == 100)
                    {
                        _LoopCount = _Conns;
                        _Redo = false;
                    }
                    else
                    {
                        _baseConns += _Conns * _precentage / 100;
                        _LoopCount = _baseConns;
                        if (_LoopCount >= _Conns)
                        {
                            _LoopCount = _Conns;
                            _Redo = false;
                        }
                    }
                    _SqlConnString.ConnectTimeout = 300;
                    threadCount = 1;
                    finished = new ManualResetEvent(false);
                    for (int i = 0; i < _LoopCount; i++)
                    {
                        Interlocked.Increment(ref threadCount);
                        ThreadPool.QueueUserWorkItem(delegate
                        {
                            try
                            {
                                string Query = _SelectFiles[_rndnum.Next(0, _SelectFiles.Length)].ToString();
                                object _Objs = new object[1] { Query };
                                SelectQuery(_Objs);
                            }
                            finally
                            {
                                if (Interlocked.Decrement(ref threadCount) == 0) finished.Set();
                            }
                        });
                    }
                    try
                    {
                        if (Interlocked.Decrement(ref threadCount) == 0)
                            finished.Set();
                        finished.WaitOne();
                    }
                    catch
                    {
                        progressBar1.BeginInvoke(new MethodInvoker(RestoreControls));
                        progressBar1.BeginInvoke(new MethodInvoker(DisableTimers));
                        StopCheckPerf();
                    }
                    round++;
                    _ExecutionLog.AppendLine(string.Concat(DateTime.Now.ToUniversalTime().ToString(), " - Finished executing round number ", round.ToString(), "."));
                }
            }
            if (_Stop)
            {
                txt_results.BeginInvoke(new MethodInvoker(delegate() { txt_results.Text += "\r\nProcess cancelled by the user.\r\n"; }));
                _ExecutionLog.AppendLine(string.Concat(DateTime.Now.ToUniversalTime().ToString(), " - Process cancelled by the user."));
            }
            else
            {
                txt_results.BeginInvoke(new MethodInvoker(delegate() { txt_results.Text += "\r\nEnd of Process.\r\n"; }));
                _ExecutionLog.AppendLine(string.Concat(DateTime.Now.ToUniversalTime().ToString(), " - End of Process."));
            }
            string _finishTime = DateTime.Now.Subtract(StartTime).ToString();
            txt_results.BeginInvoke(new MethodInvoker(delegate() { txt_results.Text += "Total duration was " + _finishTime + "\r\n"; }));
            _ExecutionLog.AppendLine(string.Concat(DateTime.Now.ToUniversalTime().ToString(), " - Total duration was ", _finishTime));

            progressBar1.BeginInvoke(new MethodInvoker(RestoreControls));
            progressBar1.BeginInvoke(new MethodInvoker(DisableTimers));
        }

        public void StartStressContinous(object _ThreadObjs)
        {
            int round = 1;
            Array argArray = new object[2];
            argArray = (Array)_ThreadObjs;
            string[] _SelectFiles = argArray.GetValue(0).ToString().Split(new Char[] { ',' });
            txt_results.BeginInvoke(new MethodInvoker(delegate () { txt_results.Text += "Please wait while the test performs...\r\n"; }));

            while (_KeepRunning)
            {
                _LoopCount = 0;
                _SqlConnString.ConnectTimeout = 300;

                finished = new ManualResetEvent(false);
                string Query = _SelectFiles[0].ToString();
                object _Objs = new object[1] { Query };
                SelectQuery(_Objs);
                try
                {
                    string _query = new FileInfo(Query).OpenText().ReadToEnd();
                    Random _rndnum = new Random();
                    _SqlConnString.ApplicationName = "EyeOnSQL_" + _rndnum.Next(10, 99).ToString();
                    while (!_Stop)
                    {
                        using (SqlConnection conn = new SqlConnection(_SqlConnString.ConnectionString))
                        {
                            try
                            {
                                num_attempt.BeginInvoke(new MethodInvoker(delegate () { num_attempt.Value += 1; }));
                                conn.Open();
                                using (SqlCommand comm = new SqlCommand(_query, conn))
                                {
                                    comm.CommandTimeout = 600;
                                    DateTime StartTime = DateTime.Now;
                                    comm.ExecuteNonQuery();
                                    _ExecutionLog.AppendLine(string.Concat(DateTime.Now.ToUniversalTime().ToString(), " - Finished execution of script \"", Query, "\". The duration was ", DateTime.Now.Subtract(StartTime).ToString()));
                                    num_executed.BeginInvoke(new MethodInvoker(delegate () { num_executed.Value += 1; }));
                                }
                            }
                            catch (SqlException err)
                            {
                                _ExecutionLog.AppendLine(string.Concat(DateTime.Now.ToUniversalTime().ToString(), " - Error for script ", Query, ": ", err.Message.ToString()));
                                num_failed.BeginInvoke(new MethodInvoker(delegate () { num_failed.Value += 1; }));
                            }
                            finally
                            {
                                conn.Close();
                                conn.Dispose();
                            }
                            round++;
                        }
                    }
                }
                catch
                {
                    progressBar1.BeginInvoke(new MethodInvoker(RestoreControls));
                    progressBar1.BeginInvoke(new MethodInvoker(DisableTimers));
                    progressBar1.BeginInvoke(new MethodInvoker(CleanUpStuff));
                    StopCheckPerf();
                }
            }


            if (_Stop)
            {
                _ExecutionLog.AppendLine(string.Concat(DateTime.Now.ToUniversalTime().ToString(), " - Finished executing. Total rounds: ", round.ToString(), "."));
                txt_results.BeginInvoke(new MethodInvoker(delegate () { txt_results.Text += "\r\nProcess stopped.\r\n"; }));
                _ExecutionLog.AppendLine(string.Concat(DateTime.Now.ToUniversalTime().ToString(), " - Process stopped."));
            }
            string _finishTime = DateTime.Now.Subtract(StartTime).ToString();
            txt_results.BeginInvoke(new MethodInvoker(delegate () { txt_results.Text += "Total duration was " + _finishTime + "\r\n"; }));
            _ExecutionLog.AppendLine(string.Concat(DateTime.Now.ToUniversalTime().ToString(), " - Total duration was ", _finishTime));

            progressBar1.BeginInvoke(new MethodInvoker(RestoreControls));
            progressBar1.BeginInvoke(new MethodInvoker(DisableTimers));
            progressBar1.BeginInvoke(new MethodInvoker(CleanUpStuff));
        }
        private void SelectQuery(object _Objs)
        {
            Array argArray = new object[1];
            argArray = (Array)_Objs;
            string Query = (string)argArray.GetValue(0);
            string _query = new FileInfo(Query).OpenText().ReadToEnd();
            Random _rndnum = new Random();
            _SqlConnString.ApplicationName = "EyeOnSQL_" + _rndnum.Next(10, 99).ToString();
            while (!_Stop)
            {
                using (SqlConnection conn = new SqlConnection(_SqlConnString.ConnectionString))
                {
                    try                    {
                        num_attempt.BeginInvoke(new MethodInvoker(delegate() { num_attempt.Value += 1; }));
                        conn.Open();
                        using (SqlCommand comm = new SqlCommand(_query, conn))
                        {
                            comm.CommandTimeout = 600;
                            DateTime StartTime = DateTime.Now;
                            comm.ExecuteNonQuery();
                            _ExecutionLog.AppendLine(string.Concat(DateTime.Now.ToUniversalTime().ToString(), " - Finished execution of script \"", Query, "\". The duration was ", DateTime.Now.Subtract(StartTime).ToString()));
                            num_executed.BeginInvoke(new MethodInvoker(delegate() { num_executed.Value += 1; }));
                        }
                    }
                    catch (SqlException err)
                    {
                        _ExecutionLog.AppendLine(string.Concat(DateTime.Now.ToUniversalTime().ToString(), " - Error for script ", Query, ": ", err.Message.ToString()));
                        num_failed.BeginInvoke(new MethodInvoker(delegate() { num_failed.Value += 1; }));
                    }
                    finally
                    {
                        conn.Close();
                        conn.Dispose();
                    }
                }
                break;
            }
        }


        void StopCheckPerf()
        {
            Process[] pname = Process.GetProcessesByName("SQLPerformanceTest");
            if (pname.Length != 0)
            {
                if (MessageBox.Show("PerfMonitor is running. Do you want to close it?", "PerfCheck", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (Process _p in pname)
                        _p.Kill();
                }
            }
        }

        void Main_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            _Stop = true;
            Process[] pname = Process.GetProcessesByName("SQLPerformanceTest");
            if (pname.Length != 0)
            {
                foreach (Process _p in pname)
                    _p.Kill();
            }
        }


        #endregion


        #region Restore And Cleanup Controls

        void RestoreControls()
        {
            progressBar1.Visible = false;
            btn_Start.Enabled = true;
            btn_Stop.Enabled = false;
            btn_log.Enabled = true;
            txt_Connections.Enabled = true;
            DurationMinutes.Enabled = true;
        }

        void CleanUpStuff()
        {
            num_executed.Value = 0;
            num_attempt.Value = 0;
            num_failed.Value = 0;
            txt_results.Text = string.Empty;
            l_elapsedtime.Text = "Elapsed Time: 00:00:00";
        }

        void DisableControls()
        {
            btn_log.Enabled = false;
            btn_Stop.Enabled = true;
            progressBar1.Visible = true;
            btn_Start.Enabled = false;
            num_executed.Value = 0;
            txt_results.Text = string.Empty;
            l_elapsedtime.Visible = true;
            txt_Connections.Enabled = false;
            DurationMinutes.Enabled = false;
        }

        void DisableTimers()
        {
            ElapsedTimeOfTest.Enabled = false;
            ProcessTest.Enabled = false;
            closetestmenu.Enabled = true;
            CountDown.Enabled = false;
        }

        void InitialValues()
        {
            txt_Connections.Text = "25";
            DurationMinutes.Value = 10;
            textBox1.Text = string.Empty;
            txt_selectFiles.Text = string.Empty;
            txt_results.Text = string.Empty;
            txt_DirSelect.Text = string.Empty;
            l_elapsedtime.Text = "Elapsed Time: 00:00:00";
            l_elapsedtime.Visible = false;
            WarningLabel.Visible = false;
            chk_progress.Checked = false;
            num_attempt.Value = 0;
            num_executed.Value = 0;
            num_failed.Value = 0;
            progressBar1.Visible = false;
            //chk_perfmon.Checked = false;
            btn_log.Enabled = false;
            _ExecutionLog = new StringBuilder();
            //_roundwait = true;
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            ConnSQL _LocateSQL = new ConnSQL(this);
            _LocateSQL.ShowDialog();
            try
            {
                textBox1.Text = _SqlConnString.DataSource;
            }
            catch
            {
            }
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            btn_Stop.Enabled = false;
            _KeepRunning = false;
            _Stop = true;
            _Redo = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ErrorForm _ErrForm = new ErrorForm(this);
            _ErrForm.ShowDialog();
        }


        
        
        void ProcessTest_Tick(object sender, System.EventArgs e)
        {
            if (_MinsToRun == 0)
            {
                ProcessTest.Enabled = false;
                ProcessTest.Stop();
                _KeepRunning = false;
            }
            else
                _MinsToRun--;
        }

        void ElapsedTimeOfTest_Tick(object sender, System.EventArgs e)
        {
            _Crono = _Crono.AddSeconds(1);
            l_elapsedtime.Text = string.Concat("Elapsed Time: ", _Crono.ToString("HH:mm:ss"));
        }



        #region PerformanceTest

        //public void ConfigureTest()
        //{
        //    _Mem1 = new PerformanceCounter("Memory", "Page Faults/sec");
        //    _Mem1.MachineName = _SqlInstance;
        //    _Mem2 = new PerformanceCounter("Memory", "Available MBytes");
        //    _Mem2.MachineName = _SqlInstance;
        //    _Proc1 = new PerformanceCounter("System", "Processor Queue Length");
        //    _Proc1.MachineName = _SqlInstance;
        //    _Proc2 = GetPerfInstances.GetCountInstances("Processor", "% Processor Time", _SqlInstance);
        //    _Disk1 = GetPerfInstances.GetCountInstances("PhysicalDisk", "Disk Reads/sec", _SqlInstance);
        //    _Disk2 = GetPerfInstances.GetCountInstances("PhysicalDisk", "Disk Writes/sec", _SqlInstance);
        //    _Disk3 = GetPerfInstances.GetCountInstances("PhysicalDisk", "Avg. Disk Read Queue Length", _SqlInstance);
        //    StringBuilder _Header = new StringBuilder(string.Concat("Date", ";", "Memory/Page Faults/Sec", ";", "Memory/Available MBytes", ";", "System/Processor Queue Length"));
        //    for (int x = 0; x < _Proc2.Length; x++)
        //        _Header.Append(string.Concat(";", _Proc2[x].CategoryName, "/", _Proc2[x].InstanceName, " ", _Proc2[x].CounterName));
        //    for (int x = 0; x < _Disk1.Length; x++)
        //        _Header.Append(string.Concat(";", _Disk1[x].CategoryName, "/", _Disk1[x].InstanceName, " ", _Disk1[x].CounterName));
        //    for (int x = 0; x < _Disk2.Length; x++)
        //        _Header.Append(string.Concat(";", _Disk2[x].CategoryName, "/", _Disk2[x].InstanceName, " ", _Disk2[x].CounterName));
        //    for (int x = 0; x < _Disk3.Length; x++)
        //        _Header.Append(string.Concat(";", _Disk3[x].CategoryName, "/", _Disk3[x].InstanceName, " ", _Disk3[x].CounterName));
        //    WriteLog(_Header);
        //    _roundwait = false;
        //}


        //void CountDown_Tick(object sender, System.EventArgs e)
        //{
        //    StringBuilder _Line = new StringBuilder(string.Concat(DateTime.Now.ToString(), ";", _Mem1.NextValue().ToString(), ";", _Mem2.NextValue().ToString(), ";", _Proc1.NextValue().ToString()));
        //    foreach (PerformanceCounter _count in _Proc2)
        //    {
        //        _count.MachineName = _SqlInstance;
        //        _Line.Append(string.Concat(";", _count.NextValue()));
        //    }
        //    foreach (PerformanceCounter _count in _Disk1)
        //    {
        //        _count.MachineName = _SqlInstance;
        //        _Line.Append(string.Concat(";", _count.NextValue()));
        //    }
        //    foreach (PerformanceCounter _count in _Disk2)
        //    {
        //        _count.MachineName = _SqlInstance;
        //        _Line.Append(string.Concat(";", _count.NextValue()));
        //    }
        //    foreach (PerformanceCounter _count in _Disk3)
        //    {
        //        _count.MachineName = _SqlInstance;
        //        _Line.Append(string.Concat(";", _count.NextValue()));
        //    }
        //    WriteLog(_Line);
        //}

        //void WriteLog(StringBuilder _Line)
        //{
        //    using (_PerfLog = new StreamWriter(_PerfPath, true))
        //    {
        //        _PerfLog.WriteLine(_Line.ToString());
        //        _PerfLog.Flush();
        //    }

        //}


        #endregion

        
    }
}