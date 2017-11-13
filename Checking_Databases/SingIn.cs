using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Checking_Databases
{
    public partial class SingIn : Form
    {
        const int WM_NCHITTEST = 0x84;
        const int HTCAPTION = 2;
        const int HTCLIENT = 1;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT)
                m.Result = (IntPtr)HTCAPTION;
        }


        private static string path = $@"..\..\Resources\{Assistant.Lang}\";
        private static string[] message = File.ReadAllLines(path + "message.txt");
        List<string> list = new List<string>();

        public SingIn()
        {
            InitializeComponent();
            list.AddRange(File.ReadAllLines(path + "SingIn.txt"));
            txtUserName.Text = list[0];
            txtPass.Text = list[1];
            btnOK.Text = list[2];
            btnClose.Text = list[3];
            cbOption.Text = list[4];
            txtServerName.Text = @"(local)\SQLEXPRESS";
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = this.WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text == list[0]) txtUserName.Text = "";
            panel1.BackColor = Color.Crimson;
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if(txtUserName.Text == "") txtUserName.Text = list[0];
            panel1.BackColor = Color.White;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Assistant.ConnectionString = cbOption.Checked == true ?
                       $@"Data Source={txtServerName.Text};Initial Catalog=CheckingDB;Integrated Security=True" :
                       $@"Data Source={txtServerName.Text};Initial Catalog=CheckingDB;User ID={txtUserName.Text};Password={txtPass.Text}";
            if (cbOption.Checked == false && (txtUserName.Text == list[0] || txtPass.Text == list[1]))
            {
                MessageBox.Show(Regex.Replace(message[1], "singinValidError1=", ""), "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection connection = null;
                try
                {
                    connection = new SqlConnection(Assistant.ConnectionString);
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT INFORMATION_SCHEMA.TABLES.TABLE_NAME FROM INFORMATION_SCHEMA.TABLES", connection);
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                    connection.Close();
                    this.Visible = false;
                    AddListChecking add = new AddListChecking();
                    add.ShowDialog();
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show(Regex.Replace(message[2], "singinValidError2=", ""), "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == list[1])
            {
                txtPass.Text = "";
                txtPass.UseSystemPasswordChar = true;
            }
            panel2.BackColor = Color.Crimson;
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.UseSystemPasswordChar = false;
                txtPass.Text = list[1];
            }
            panel2.BackColor = Color.White;
        }

        private void cbOption_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOption.Checked == true)
            {
                txtUserName.Enabled = false;
                panel1.Enabled = false;
                txtPass.Enabled = false;
                panel2.Enabled = false;
            }
            else
            {
                txtUserName.Enabled = true;
                panel1.Enabled = true;
                txtPass.Enabled = true;
                panel2.Enabled = true;
            }
        }

        private void txtServerName_Enter(object sender, EventArgs e)
        {
            if (txtServerName.Text == @"(local)\SQLEXPRESS") txtServerName.Text = "";
            panel3.BackColor = Color.Crimson;
        }

        private void txtServerName_Leave(object sender, EventArgs e)
        {
            if (txtServerName.Text == "") txtServerName.Text = @"(local)\SQLEXPRESS";
            panel3.BackColor = Color.White;
        }

        private void SingIn_SizeChanged(object sender, EventArgs e)
        {
            Assistant.Maximized = !Assistant.Maximized;
        }
    }
}
