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

namespace Checking_Databases
{
    public partial class Main : Form
    {
        private static string path = $@"..\..\Resources\{Assistant.Lang}\";
        private static string[] message = File.ReadAllLines(path + "message.txt");
        List<string> list = new List<string>();

        private void Reload()
        {
            list.AddRange(File.ReadAllLines(path + "Main.txt"));
            LMenu.Text = list[1];
            LFont.Text = list[6];
            LStyle.Text = list[7];
            LClose.Text = list[4];
            LConSrt.Text = list[13];
            cbTumbler.Text = list[8];
            LLanguage.Text = list[11];
            btnCheckStart.Text = list[0];
            LMain.Text = Regex.Split(list[5], ",|(, )")[0];
            LHistory.Text = Regex.Split(list[5], ",|(, )")[1];
            LSettings.Text = Regex.Split(list[5], ",|(, )")[2];
            LSubtitle.Text = Regex.Split(list[5], ",|(, )")[0];
            checkList.Columns[0].HeaderText = Regex.Split(list[9], ",")[0];
            checkList.Columns[1].HeaderText = Regex.Split(list[9], ",")[1];
            checkList.Columns[2].HeaderText = Regex.Split(list[9], ",")[2];
            checkList.Columns[3].HeaderText = Regex.Split(list[9], ",")[3];
            cbLang.Items.AddRange(Regex.Split(list[12], ",| (, )"));
        }

        const int WM_NCHITTEST = 0x84;
        const int HTCAPTION = 2;
        const int HTCLIENT = 1;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT)
                m.Result = (IntPtr)HTCAPTION;
        }

        public Main()
        {
            InitializeComponent();
            this.WindowState = Assistant.Maximized == true ? FormWindowState.Maximized : FormWindowState.Normal;
            LMain.Visible = false;
            LSettings.Visible = false;
            LClose.Visible = false;
            LHistory.Visible = false;
            btnCheckStart.Visible = true;
            Reload();
            cbFont.Items.AddRange(new System.Drawing.Text.InstalledFontCollection().Families);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Location.X < 70)
            {
                button1.BackgroundImage = Checking_Databases.Properties.Resources.closemenu;
                PMenu.Size = new Size(250, PMenu.Size.Height);
                LMain.Visible = true;
                LSettings.Visible = true;
                LClose.Visible = true;
                LHistory.Visible = true;
            }

            else
            {
                button1.BackgroundImage = Checking_Databases.Properties.Resources.openmenu;
                PMenu.Size = new Size(60, PMenu.Size.Height);
                LMain.Visible = false;
                LSettings.Visible = false;
                LClose.Visible = false;
                LHistory.Visible = false;
            }
        }

        private void LMain_MouseMove(object sender, MouseEventArgs e)
        {
            LMain.BackColor = Color.FromArgb(255, 128, 0);
        }

        private void LMain_MouseLeave(object sender, EventArgs e)
        {
            LMain.BackColor = Color.DarkOrange;
        }

        private void LHistory_MouseMove(object sender, MouseEventArgs e)
        {
            LHistory.BackColor = Color.FromArgb(255, 128, 0);
        }

        private void LHistory_MouseLeave(object sender, EventArgs e)
        {
            LHistory.BackColor = Color.DarkOrange;
        }

        private void LSettings_MouseMove(object sender, MouseEventArgs e)
        {
            LSettings.BackColor = Color.FromArgb(255, 128, 0);
        }

        private void LSettings_MouseLeave(object sender, EventArgs e)
        {
            LSettings.BackColor = Color.DarkOrange;
        }

        private void LClose_MouseMove(object sender, MouseEventArgs e)
        {
            LClose.BackColor = Color.FromArgb(255, 128, 0);
        }

        private void LClose_MouseLeave(object sender, EventArgs e)
        {
            LClose.BackColor = Color.DarkOrange;
        }

        private void panel2_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = this.WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void Main_SizeChanged(object sender, EventArgs e)
        {
           Assistant.Maximized = !Assistant.Maximized;
        }

        private void LClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Regex.Replace(message[0], "mainClose=", ""), "Questions", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void LMain_Click(object sender, EventArgs e)
        {
            button1.BackgroundImage = Checking_Databases.Properties.Resources.openmenu;
            PMenu.Size = new Size(60, PMenu.Size.Height);
            LMain.Visible = false;
            LSettings.Visible = false;
            LClose.Visible = false;
            LHistory.Visible = false;
            LSubtitle.Text = Regex.Split(list[5], ",|(, )")[0];
            btnCheckStart.Visible = true;
            PSettings.Visible = false;
            checkList.Visible = false;
        }

        private void LHistory_Click(object sender, EventArgs e)
        {
            button1.BackgroundImage = Checking_Databases.Properties.Resources.openmenu;
            PMenu.Size = new Size(60, PMenu.Size.Height);
            LMain.Visible = false;
            LSettings.Visible = false;
            LClose.Visible = false;
            LHistory.Visible = false;
            LSubtitle.Text = Regex.Split(list[5], ",|(, )")[1];
            btnCheckStart.Visible = false;
            PSettings.Visible = false;
            checkList.Visible = true;
        }

        private void LSettings_Click(object sender, EventArgs e)
        {
            button1.BackgroundImage = Checking_Databases.Properties.Resources.openmenu;
            PMenu.Size = new Size(60, PMenu.Size.Height);
            LMain.Visible = false;
            LSettings.Visible = false;
            LClose.Visible = false;
            LHistory.Visible = false;
            LSubtitle.Text = Regex.Split(list[5], ",|(, )")[2];
            btnCheckStart.Visible = false;
            PSettings.Visible = true;
            checkList.Visible = false;
        }

        private void Style1_Click(object sender, EventArgs e)
        {
            Style1.BorderStyle = BorderStyle.FixedSingle;
            Style2.BorderStyle = BorderStyle.None;
        }

        private void Style2_Click(object sender, EventArgs e)
        {
            Style1.BorderStyle = BorderStyle.None;
            Style2.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
