using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Button_Clicker2
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void ClickBtn_Click(object sender, EventArgs e)
        {
            count++;
            counterLbl.Text = count.ToString();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            count = 0;
            counterLbl.Text = count.ToString();
        }
    }
}
