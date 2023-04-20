using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timerTimeNow.Start();
        }

        private void tmrSecondumer_Tick(object sender, EventArgs e)
        {
            int tmp = Int32.Parse(txtSeconds.Text);
            if (tmp == 59) //Так как в 60 это произойдет в следующий тик таймера
            {
                txtMinutes.Text = (Int32.Parse(txtMinutes.Text) + 1).ToString();
                txtSeconds.Text = "0";
            }
            
            else
            {
                tmp += 1;
                txtSeconds.Text = tmp.ToString();
            }
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!tmrSecondumer.Enabled)
            {
                tmrSecondumer.Start();
                tmrSecondumer.Enabled = true;
            }

            else
            {
                tmrSecondumer.Stop();
                tmrSecondumer.Enabled = false;
            }
            
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            tmrSecondumer.Stop();
            tmrSecondumer.Enabled = false;
            txtMinutes.Text = "0";
            txtSeconds.Text = "0";
        }

        private void timerTimeNow_Tick(object sender, EventArgs e)
        {
            txtTimeNow.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
