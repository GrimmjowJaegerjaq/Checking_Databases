using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Checking_Databases
{
    public partial class AddListChecking : Form
    {
        const int WM_NCHITTEST = 0x84;
        const int HTCAPTION = 2;
        const int HTCLIENT = 1;

        private int id = 0;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT)
                m.Result = (IntPtr)HTCAPTION;
        }


        private static string path = $@"..\..\Resources\{Assistant.Lang}\";
        private static string[] message = File.ReadAllLines(path + "message.txt");
        List<string> list = new List<string>();

        public AddListChecking()
        {
            InitializeComponent();
            this.WindowState = Assistant.Maximized == true ? FormWindowState.Maximized : FormWindowState.Normal;
            list.AddRange(File.ReadAllLines(path + "AddListChecking.txt"));
            lTitle.Text = list[12];
            txtStudName.Text = list[0];
            txtGroup.Text = list[1];
            txtDBName.Text = list[4];
            txtConStr.Text = list[5];
            cbType.Items.AddRange(Regex.Split(list[2], ",|(, )"));
            cbView.Items.Add("MSSQL");
            cbView.Items.Add("Oracle");
            cbType.SelectedItem = cbType.Items[0];
            cbView.SelectedItem = cbView.Items[0];
            btnAdd.Text = list[6];
            btnDelete.Text = list[7];
            btnTestCon.Text = list[8];
            btnNext.Text = list[9];
            btnClose.Text = list[10];
            checkList.Columns[0].HeaderText = list[0];
            checkList.Columns[1].HeaderText = list[1];
            checkList.Columns[2].HeaderText = list[4];
            checkList.Columns[3].HeaderText = list[3];
            checkList.Columns[4].HeaderText = list[11];
            checkList.Columns[5].HeaderText = list[5];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (checkList.RowCount != 0) checkList.Rows.RemoveAt(checkList.CurrentRow.Index);
        }

        private void AddListChecking_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = this.WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbType.Text == cbType.Items[0].ToString())
            {
                if (cbView.Text == "MSSQL")
                    txtConStr.Text = $@"Data Source=(local)\SQLEXPRESS;Initial Catalog=|{txtDBName.Text}|;Integrated Security=True";
                else
                    txtConStr.Text = $@"Data Source=|{txtDBName.Text}|;Integrated Security=yes;";
            }
            else
            {
                if (cbView.Text == "MSSQL")
                    txtConStr.Text = $@"Data Source=1;Initial Catalog=|{txtDBName.Text}|;User Id=1;Password=1;";
                else
                    txtConStr.Text = $@"Data Source=localhost;Initial Catalog=|{txtDBName.Text}|;Persist Security Info=True;User ID=sa;Password=123456";
            }
        }

        private void cbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbType.Text == cbType.Items[0].ToString())
            {
                if (cbView.Text == "MSSQL")
                    txtConStr.Text = $@"Data Source=(local)\SQLEXPRESS;Initial Catalog=|{txtDBName.Text}|;Integrated Security=True";
                else
                    txtConStr.Text = $@"Provider=1;Data Source=|{txtDBName.Text}|;Integrated Security=yes;";
            }
            else
            {
                if (cbView.Text == "MSSQL")
                    txtConStr.Text = $@"Data Source=1;Initial Catalog=|{txtDBName.Text}|;User Id=1;Password=1;";
                else
                    txtConStr.Text = $@"Data Source=localhost;Initial Catalog=|{txtDBName.Text}|;Persist Security Info=True;User ID=sa;Password=123456";
            }
        }

        private void checkList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = checkList.CurrentRow.Index;
            txtStudName.Text = checkList.Rows[id].Cells[0].Value.ToString();
            txtGroup.Text = checkList.Rows[id].Cells[1].Value.ToString();
            txtDBName.Text = checkList.Rows[id].Cells[2].Value.ToString();
            cbView.Text = checkList.Rows[id].Cells[3].Value.ToString();
            cbType.Text = checkList.Rows[id].Cells[4].Value.ToString();
            txtConStr.Text = checkList.Rows[id].Cells[5].Value.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dbname()
        {
            txtConStr.Text = Regex.Replace(txtConStr.Text, @"\|[.\d\D]+\||(\|\|)", $"|{txtDBName.Text}|");
        }

        private void txtDBName_TextChanged(object sender, EventArgs e)
        {
            dbname();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            checkList.Rows.Add(txtStudName.Text, txtGroup.Text, txtDBName.Text, cbView.Text, cbType.Text, Regex.Replace(txtConStr.Text,
                @"(?<content1>[\d\D]+)(\|(?<dbname>[.\d\D]+)\||(\|\|))(?<content2>[\d\D]+)", "${content1}${dbname}${content2}"));

        }

        private void btnTestCon_Click(object sender, EventArgs e)
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

        private void AddListChecking_SizeChanged(object sender, EventArgs e)
        {
            Assistant.Maximized = !Assistant.Maximized;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Assistant.checkList.Columns.Count == 0)
            {
                Assistant.checkList.Columns.Add("Name");
                Assistant.checkList.Columns.Add("Group");
                Assistant.checkList.Columns.Add("Database");
                Assistant.checkList.Columns.Add("SMDB");
                Assistant.checkList.Columns.Add("Type");
                Assistant.checkList.Columns.Add("ConStr");
            }
            else Assistant.checkList.Rows.Clear();
            foreach (var item in checkList.Rows)
            {
                Assistant.checkList.Rows.Add(item);
            }
            this.Visible = false;
            TestList testList = new TestList();
            testList.ShowDialog();
            this.Visible = true;
        }
    }
}
