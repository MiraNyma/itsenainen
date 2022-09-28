using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28._8itsenäinen_tehtävä
{
    internal class Dice
    {
        public PictureBox Boxi { get; set; }
        public int Value { get; set; }
        public int Koko { get; set; }
        public Dice(int koko, PictureBox boxi)
        {
            Value = 1;
            Koko = koko;
            Boxi = boxi;
            Boxi.Size = new Size(40, 40);
            Boxi.SizeMode = PictureBoxSizeMode.Zoom;

        }
        public void Roll(Random rng)
        {
            Value = rng.Next(1, Koko + 1);
        }
        public string GetNoppaKey() 
        {
            string returnValue = "N"; 

            return returnValue + Value;
        }
        public static Image GetPictureResX(string key)
        {
            return _28._8itsenäinen_tehtävä.kuvia.ResourceManager.GetObject(key) as Image;  
        }
    }
}
