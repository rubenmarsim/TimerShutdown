using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApagarPC
{
    public partial class Form1 : Form
    {
        const string strFileName="shutdown";
        const string strQuery = "/s /t ";
        string strTime = "";
        int valHour = 0;
        int valMin = 0;
        int valSec = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(strFileName, "/a");
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(strFileName, strQuery+strTime);
        }

        public void Conversion()
        {
            valHour = int.Parse(txtBoxHoras.Text)*120;
            valMin = int.Parse(txtBoxMin.Text) * 60;
            valSec = int.Parse(txtBoxSecs.Text)+valMin+valHour;
            strTime = valSec.ToString();
        }
    }
}
