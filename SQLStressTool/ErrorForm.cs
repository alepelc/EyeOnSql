using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SQLStressTool
{
    public partial class ErrorForm : Form
    {
        private Main parent;
        public ErrorForm(Main parent_form)
        {
            parent = parent_form;
            InitializeComponent();
            textBox1.Text = parent._ExecutionLog.ToString();
            textBox1.Select(0, 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            try
            {
                _SaveFile = new SaveFileDialog();
                _SaveFile.Filter = "Log Files|*.log";
                _SaveFile.Title = "Save Log to File";
                _SaveFile.ShowDialog();
                if (_SaveFile.FileName != "")
                {
                    using (StreamWriter _writer = new StreamWriter(_SaveFile.FileName, false))
                    {
                        _writer.Write(textBox1.Text);
                        _writer.Flush();
                        _writer.Close();
                    }
                    MessageBox.Show("Log successfully saved.", "Save to File", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (IOException err)
            {
                MessageBox.Show(err.Message.ToString(), "Save to File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
