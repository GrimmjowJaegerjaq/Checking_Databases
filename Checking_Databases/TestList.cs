using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Checking_Databases
{
    public partial class TestList : Form
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

        public TestList()
        {
            InitializeComponent();
            this.WindowState = Assistant.Maximized == true ? FormWindowState.Maximized : FormWindowState.Normal;
            cbDMS.Items.AddRange(new object[] { "MSSQL", "Oracle" });
            cbType.Items.AddRange(Assistant.AddListChecking.Types);
            cbDMS.Text = cbDMS.Items[0].ToString();
            cbType.Text = cbType.Items[0].ToString();
            txtDBName.Text = Assistant.AddListChecking.DBName;
            txtSelect.Text = Assistant.TestList.QueryEditor;
            btnChecking.Text = Assistant.TestList.Checking;
            btnAdd.Text = Assistant.AddListChecking.Add;
            btnSelectChecking.Text = Assistant.TestList.CheckingQuery;
            btnNext.Text = Assistant.AddListChecking.Next;
            btnClose.Text = Assistant.SingIn.Close;
            LTitle.Text = Assistant.TestList.TLTitle;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelectChecking_Click(object sender, EventArgs e)
        {
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(Regex.Replace(txtConStr.Text,
                @"(?<content1>[\d\D]+)(\|(?<dbname>[.\d\D]+)\||(\|\|))(?<content2>[\d\D]+)", "${content1}${dbname}${content2}"));
                connection.Open();
                SqlCommand command = new SqlCommand(txtSelect.Text, connection);
                SqlDataReader reader = command.ExecuteReader();
                reader.Close();
                connection.Close();
                LResult.ForeColor = Color.SpringGreen;
                LResult.Text = Assistant.TestList.Succes;
            }
            catch (Exception ex)
            {
                LResult.ForeColor = Color.IndianRed;
                LResult.Text = ex.Message;
                connection.Close();
            }
        }

        private void cbDMS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbType.Text == cbType.Items[0].ToString())
            {
                if (cbDMS.Text == "MSSQL")
                    txtConStr.Text = $@"Data Source=(local)\SQLEXPRESS;Initial Catalog=|{txtDBName.Text}|;Integrated Security=True";
                else
                    txtConStr.Text = $@"Provider=1;Data Source=|{txtDBName.Text}|;Integrated Security=yes;";
            }
            else
            {
                if (cbDMS.Text == "MSSQL")
                    txtConStr.Text = $@"Data Source=1;Initial Catalog=|{txtDBName.Text}|;User Id=1;Password=1;";
                else
                    txtConStr.Text = $@"Data Source=localhost;Initial Catalog=|{txtDBName.Text}|;Persist Security Info=True;User ID=sa;Password=123456";
            }
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbType.Text == cbType.Items[0].ToString())
            {
                if (cbDMS.Text == "MSSQL")
                    txtConStr.Text = $@"Data Source=(local)\SQLEXPRESS;Initial Catalog=|{txtDBName.Text}|;Integrated Security=True";
                else
                    txtConStr.Text = $@"Provider=1;Data Source=|{txtDBName.Text}|;Integrated Security=yes;";
            }
            else
            {
                if (cbDMS.Text == "MSSQL")
                    txtConStr.Text = $@"Data Source=1;Initial Catalog=|{txtDBName.Text}|;User Id=1;Password=1;";
                else
                    txtConStr.Text = $@"Data Source=localhost;Initial Catalog=|{txtDBName.Text}|;Persist Security Info=True;User ID=sa;Password=123456";
            }
        }

        private void dbname()
        {
            txtConStr.Text = Regex.Replace(txtConStr.Text, @"\|[.\d\D]+\||(\|\|)", $"|{txtDBName.Text}|");
        }

        private void TestList_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = this.WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;
        }

        private void TestList_SizeChanged(object sender, EventArgs e)
        {
            Assistant.Maximized = !Assistant.Maximized;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            selectList.Items.Add(txtSelect.Text);
        }

        private void selectList_DoubleClick(object sender, EventArgs e)
        {
            selectList.Items.RemoveAt(selectList.SelectedIndex);
        }

        private void selectList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                selectList.Items.RemoveAt(selectList.SelectedIndex);
            if (e.KeyCode == Keys.Enter)
                txtSelect.Text = selectList.SelectedItem.ToString();
        }

        private void txtDBName_TextChanged(object sender, EventArgs e)
        {
            dbname();
        }

        private void btnChecking_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(Regex.Replace(txtConStr.Text,
                @"(?<content1>[\d\D]+)(\|(?<dbname>[.\d\D]+)\||(\|\|))(?<content2>[\d\D]+)", "${content1}${dbname}${content2}"));
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT INFORMATION_SHEMA.TABLES.TABLE.NAME FROM INFORMATION_SHEMA.TABLES", connection);
                connection.Close();
                MessageBox.Show("Проверка завершилась успехом!", "Успех", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Assistant.EtalonDbName = txtDBName.Text;
            Assistant.EtalonDbConnectionString = txtConStr.Text;
            foreach (var item in selectList.Items)
            {
                Assistant.testList.Add(item.ToString());
            }
            this.Visible = false;
            CheckingDB checking = new CheckingDB();
            checking.ShowDialog();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSelect_Enter(object sender, EventArgs e)
        {
            if (txtSelect.Text == Assistant.TestList.QueryEditor) txtSelect.Text = "";
        }

        private void txtSelect_Leave(object sender, EventArgs e)
        {
            if (txtSelect.Text == "") txtSelect.Text = Assistant.TestList.QueryEditor;
        }
    }
}
