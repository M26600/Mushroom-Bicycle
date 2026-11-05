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
    public partial class MushroomForm : Form
    {
        private int stage = 1;
        private string result = "";
        public MushroomForm()
        {
            InitializeComponent();
            ShowQuestion();
        }
        
        private void ShowQuestion()
        {
            rdoYes.Text = "Yes";
            rdoNo.Text = "No";

            rdoYes.Checked = false;
            rdoNo.Checked = false;

            if (stage == 1)
            {
                lblQuestion.Text = "Does your mushroom grow in a forest?";
            }
            else if (stage == 2 && result == "nonForest")
            {
                lblQuestion.Text = "Does your mushroom have a convex cup?";
            }
            else if (stage == 2)
            {
                lblQuestion.Text = "Does your mushroom have a ring?";
            }
            else if (stage == 3)
            {
                lblQuestion.Text = "Does your mushroom have gills?";
            }
            else
            {
                lblQuestion.Text = "Does your mushroom have a convex cup?";
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MushroomForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            if (!rdoYes.Checked && !rdoNo.Checked)
            {
                MessageBox.Show("Please choose Yes or No.");
                return;
            }

            bool answer = rdoYes.Checked;

            if (stage == 1)
            {
                if (answer)
                {
                    stage = 2;
                }
                else
                {
                    result = "nonForest";
                    stage = 2;
                }
            }
            else if (stage == 2 && result == "nonForest")
            {
                Finish(answer ? "Agaric jaunissant" : "Coprin chevelu");
                return;
            }
            else if (stage == 2)
            {
                if (answer)
                {
                    Finish("Amanite tue-mouche");
                    return;
                }

                stage = 3;
            }
            else if (stage == 3)
            {
                if (!answer)
                {
                    Finish("Cepe de bordeaux");
                    return;
                }

                stage = 4;
            }
            else
            {
                Finish(answer ? "Pied bleu" : "Girolle");
                return;
            }

            ShowQuestion();
        }
        private void Finish(string mushroom)
        {
            MessageBox.Show("The mushroom is: " + mushroom);

            stage = 1;
            result = "";

            ShowQuestion();
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
