using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2A
{
    public partial class Bicycle : Form
    {
        public Bicycle()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int start, end;

            if (!int.TryParse(txtStartingTime.Text, out start) ||
                start < 0 || start > 23)
            {
                MessageBox.Show("Starting time must be from 0 to 23.");
                return;
            }

            if (!int.TryParse(txtEndingTime.Text, out end) ||
                end < 1 || end > 24)
            {
                MessageBox.Show("Ending time must be from 1 to 24.");
                return;
            }

            if (end <= start)
            {
                MessageBox.Show("Ending time must be greater than starting time.");
                return;
            }

            int total = 0;

            for (int hour = start; hour < end; hour++)
            {
                if ((hour >= 0 && hour < 7) ||
                    (hour >= 21 && hour < 24))
                {
                    total += 500;
                }
                else if ((hour >= 7 && hour < 14) ||
                         (hour >= 19 && hour < 21))
                {
                    total += 1000;
                }
                else
                {
                    total += 1500;
                }
            }

            txtTotal.Text = total + " RWF";

            MessageBox.Show("Total to pay: " + total + " RWF");

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new ChooseForm().Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Close();
        }
    }
}
