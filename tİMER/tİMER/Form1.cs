using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tİMER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac=0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label1.Text=sayac.ToString();   
        }
        private void btnBasla_Click(object sender, EventArgs e)
        {
            timer1.Start();
            sayac++;
            

        }

        private void btnDur_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btnBıtır_Click(object sender, EventArgs e)
        {
            sayac = 0;
            timer1.Stop();
        }


    }
}
