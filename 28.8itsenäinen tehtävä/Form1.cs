using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28._8itsenäinen_tehtävä
{
    public partial class Form1 : Form
    {
        //En halunnut korvata kuvilla mutta tein koko tehtävän silti
        public static PictureBox tempPB = new PictureBox();
        public static PictureBox tempPB2 = new PictureBox();
        private Random rng=new Random();
        private static  Dice tempdice = new Dice(6, tempPB);
        private static Dice tempdices = new Dice(6, tempPB2);
         

               
        public Form1()
        {
            InitializeComponent();

            this.Controls.Add(tempPB);
            this.Controls.Add(tempPB2);



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void Noppa1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tempdice.Koko; i++)
            {
                tempdice.Roll(rng);
                labl.Text = tempdice.Value.ToString();
                    //label1.Text = noppa1.Luku.ToString();
                    Noppa1.Enabled=false;
                editPictureBox(tempdice, i);
                labl.Show();
                label3.Show();
                tempPB.Show();
            }
            if (Noppa2.Enabled==false)
            {
                if (tempdice.Koko > tempdices.Koko)
                {
                    label3.Text = "Pelaaja 1 Voitti!";
                }
                if (tempdice.Koko < tempdices.Koko)
                {
                    label3.Text = "Pelaaja 2 Voitti!";
                }
              
            }
        }

        private void Noppa2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tempdices.Koko; i++)
            {
                tempdices.Roll(rng);
                lbl2.Text = tempdices.Value.ToString();
                editPictureBoxes(tempdices, i);
                //label1.Text = noppa1.Luku.ToString();
                Noppa2.Enabled =false;
                lbl2.Show();
                label3.Show();
                tempPB2.Show();
            }
            if (Noppa1.Enabled == false)
            {
                if (tempdice.Value > tempdices.Value)
                {
                    label3.Text = "Pelaaja 1 Voitti!";
                }
                if (tempdice.Value < tempdices.Value)
                {
                    label3.Text = "Pelaaja 2 Voitti!";
                }
             
            }
        }

        private void Resetointi_Click(object sender, EventArgs e)
        {
            labl.Hide();
            lbl2.Hide();
            Noppa1.Enabled = true;
            Noppa2.Enabled=true;
            label3.Hide();
            tempPB.Hide();
            tempPB2.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
        private void editPictureBox(Dice jokuNoppa, int count)
        {
            string key = jokuNoppa.GetNoppaKey();
            jokuNoppa.Boxi.Image = Dice.GetPictureResX(key);
            jokuNoppa.Boxi.Location = new
                Point( 100);
        }
        private void editPictureBoxes(Dice jokuNoppa, int count)
        {
            string key = jokuNoppa.GetNoppaKey();
            jokuNoppa.Boxi.Image = Dice.GetPictureResX(key);
            jokuNoppa.Boxi.Location = new
                Point(300);
        }
    }
}
