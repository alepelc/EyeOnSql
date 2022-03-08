using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace SQLStressTool
{
    public partial class ConnSQL : Form
    {
        private Main parent;
        private SqlConnectionStringBuilder _sqlstring;


        public ConnSQL(Main parent_form)
        {
            parent = parent_form;
            InitializeComponent();
        }

        private void ConnSQL_Load(object sender, EventArgs e)
        {
            chk_Integrated.Checked = true;
            box_dbs.Enabled = true;
            btn_connect.Enabled = false;
            button1.Enabled = false;
            box_dbs.Items.Clear();
        }
        private void chk_sql_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chk_sql.Checked)
            {
                txt_pwd.Enabled = true;
                txt_pwd.Text = string.Empty;
                txt_user.Enabled = true;
            }
            else
            {
                txt_pwd.Enabled = false;
                txt_pwd.Text = string.Empty;
                txt_user.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _sqlstring.InitialCatalog = box_dbs.SelectedItem.ToString().Trim();
            parent._SqlConnString = _sqlstring;
            //if (txt_sqlsrv.Text.Trim().IndexOf(@"\") > 0)
            //{
            //    parent._SqlInstance = txt_sqlsrv.Text.Trim().Substring(0, txt_sqlsrv.Text.Trim().IndexOf(@"\")).Replace("(local)", System.Environment.MachineName).Replace("localhost", System.Environment.MachineName);
            //}
            //else
            //    parent._SqlInstance = txt_sqlsrv.Text.Trim().Replace("(local)", System.Environment.MachineName).Replace("localhost", System.Environment.MachineName);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void txt_sqlsrv_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if ((txt_sqlsrv.Text.Trim().Length > 0) && (chk_Integrated.Checked))
                btn_connect.Enabled = true;
            else
                btn_connect.Enabled = false;
            
        }
        void box_dbs_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (box_dbs.SelectedItem.ToString().Trim().Length > 0)
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }
        void box_dbs_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {

            if (box_dbs.SelectedItem == null)
            {
                button1.Enabled = false;
                box_dbs.SelectedIndex = -1;
            }
            
        }
        void box_dbs_Click(object sender, System.EventArgs e)
        {
            btn_connect_Click(null, null);
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            box_dbs.Items.Clear();
            _sqlstring = new SqlConnectionStringBuilder();
            _sqlstring.DataSource = txt_sqlsrv.Text.Trim();
            _sqlstring.InitialCatalog = "master";

            if (chk_sql.Checked)
            {
                _sqlstring.UserID = txt_user.Text;
                _sqlstring.Password = txt_pwd.Text;
            }
            else
            {
                _sqlstring.IntegratedSecurity = true;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(_sqlstring.ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand comm = new SqlCommand("select name from sys.databases order by name", conn))
                    {
                        comm.CommandTimeout = 300;
                        DateTime StartTime = DateTime.Now;
                        SqlDataReader rs = comm.ExecuteReader();
                        while (rs.Read())
                        {
                            box_dbs.Items.Add(rs["name"].ToString());
                        }
                        rs.Close();
                    }
                }
                box_dbs.Enabled = true;
            }
            catch (SqlException err)
            {
                box_dbs.Items.Clear();
                MessageBox.Show(err.Message, "Connection Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}