using ATMSim;
using System;
using System.Windows.Forms;

namespace ATM_Sim
{
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form atm = new ATM();
            atm.Show();
        }
    }
}
