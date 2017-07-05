using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Collections;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace SQLPerformanceTest
{
    public partial class PerfCheck : Form
    {

        bool CleanUp = false;
        //string _Values;


        public PerfCheck()
        {
            string _SqlInstance = string.Empty;
            bool Cancel = false;
            try
            {
                string[] args = Environment.GetCommandLineArgs();
                _SqlInstance = args[1].ToString();
            }
            catch (IndexOutOfRangeException err)
            {
                MessageBox.Show("You must supply a server name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cancel = true;
            }
            InitializeComponent();
            if (!Cancel)
            {
                if (_SqlInstance.Trim().Length > 0)
                {
                    _CountCpu1.MachineName = _SqlInstance;
                    _CountCpu2.MachineName = _SqlInstance;
                    _CountMem1.MachineName = _SqlInstance;
                    _CountMem2.MachineName = _SqlInstance;
                    _CountDsk1.MachineName = _SqlInstance;
                    _CountDsk2.MachineName = _SqlInstance;
                    _CountDsk3.MachineName = _SqlInstance;
                    IsRunning();
                    timer1_Tick(null, null);
                    timer1.Start();
                }
            }
            else
            {
                DisableAll();
            }
        }
    

        void IsRunning()
        {
            Status.Text = "Running";
            PlayButton.Enabled = false;
            PauseButton.Enabled = true;
            StopButton.Enabled = true;
        }

        void IsPaused()
        {
            Status.Text = "Paused";
            PlayButton.Enabled = true;
            PauseButton.Enabled = false;
            StopButton.Enabled = true;
        }

        void Isstopped()
        {
            Status.Text = "Stopped";
            PlayButton.Enabled = true;
            PauseButton.Enabled = false;
            StopButton.Enabled = false;
        }

        void CleanUpGrid()
        {
            if (CleanUp)
                dataGridView1.Rows.Clear();
        }

        #region Performance

        void timer1_Tick(object sender, EventArgs e)
        {

            dataGridView1.Rows.Add(DateTime.Now, _CountCpu1.NextValue().ToString(), _CountCpu2.NextValue().ToString(), _CountMem1.NextValue().ToString(), _CountMem2.NextValue().ToString(), _CountDsk1.NextValue().ToString(), _CountDsk2.NextValue().ToString(), _CountDsk3.NextValue().ToString());
            //_Values = string.Concat(_CountCpu1.NextValue().ToString(), ";", _CountCpu2.NextValue().ToString(), ";", _CountMem1.NextValue().ToString(), ";", _CountMem2.NextValue().ToString(), ";", _CountDsk1.NextValue().ToString(), ";", _CountDsk2.NextValue().ToString(), ";", _CountDsk3.NextValue().ToString());
            //_Results.Add(_Values);
        }

        void DisableAll()
        {
            PlayButton.Enabled = false;
            PauseButton.Enabled = false;
            StopButton.Enabled = false;
        }

        #endregion

        private void PlayButton_Click(object sender, EventArgs e)
        {
            IsRunning();
            CleanUpGrid();
            CleanUp = false;
            timer1.Start();
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            CleanUp = false;
            timer1.Enabled = false;
            timer1.Stop();
            IsPaused();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            CleanUp = true;
            timer1.Enabled = false;
            timer1.Stop();
            Isstopped();
        }

       
    }
}
