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
        const string strQueryDisk = "";
        string strTime = "";
        int valHour = 0;
        int valMin = 0;
        int valSec = 0;

        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

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
            player.Stop();
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            if (txtBoxSecs.Text.Equals("")||txtBoxMin.Text.Equals("")|| txtBoxHoras.Text.Equals(""))
            {
                MessageBox.Show("Introduce algun valor");
            }
            else
            {
                Conversion();
                System.Diagnostics.Process.Start(strFileName, strQuery + strTime);
            }            
        }

        public void Conversion()
        {
            valHour = int.Parse(txtBoxHoras.Text)*120;
            valMin = int.Parse(txtBoxMin.Text) * 60;
            valSec = int.Parse(txtBoxSecs.Text)+valMin+valHour;
            strTime = valSec.ToString();
        }

        private void txtBoxHoras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtBoxMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtBoxSecs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        #region EasterEggs
        private void btnCancionBB_Click(object sender, EventArgs e)
        {
            player.Play();
            MessageBox.Show("hola");
        }

        private void btnDisketera_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(strFileName, strQueryDisk);
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            player.SoundLocation = "CancionBB.mp3";
        }
    }
}
