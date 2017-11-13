using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checking_Databases
{
    public partial class CheckingDB : Form
    {
        private bool flag = false;

        const int WM_NCHITTEST = 0x84;
        const int HTCAPTION = 2;
        const int HTCLIENT = 1;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT)
                m.Result = (IntPtr)HTCAPTION;
        }

        public CheckingDB()
        {
            InitializeComponent();
            this.WindowState = Assistant.Maximized == true ? FormWindowState.Maximized : FormWindowState.Normal;
        }

        private void btnStartAndStop_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                for (int i = 0; i < 100; i++)
                {
                    listData.Items.Add("Select * from table" + (1 + i));
                }
                flag = true;
                btnStartAndStop.Text = "Закончить";
            }
            else
            {
                this.Close();
            }
        }
    }
}
