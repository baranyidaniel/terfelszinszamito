using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace terfelszinszamito
{
    public partial class Form1 : Form
    {
        static List<Label> labels = new List<Label>();
        static List<NumericUpDown> NumericUpDowns = new List<NumericUpDown>();
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            eredmenyLbl.Visible = true;
            eredmeny1Lbl.Visible = true;
            eredmeny2Lbl.Visible = true;
            eredmeny1Txt.Visible = true;
            eredmeny2Txt.Visible = true;
            szamolBtn.Visible = true;
            torolBtn.Visible = true;

            Megjelenit(comboBox1.SelectedItem.ToString());
        }

        private void Megjelenit(string selectedItem)
        {
            /*
            Háromszög
            Négyzet
            Trapéz
            Téglalap
            Paralelogramma
            Rombusz
            Deltoid
            Kör
            Henger
            Gúla
            Gömb
            */
            if (labels.Count > 0 || NumericUpDowns.Count > 0)
            {
                foreach (Label item in labels) Controls.Remove(item);
                foreach (NumericUpDown item in NumericUpDowns) Controls.Remove(item);
            }

            switch (selectedItem)
            {
                case "Háromszög":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/haromszog/3szeg_alap.png");

                        label2.Text = "a oldal:";
                        label2.Visible = true;
                        numericUpDown1.Visible = true;

                        label3.Text = "b oldal:";
                        label3.Visible = true;
                        numericUpDown2.Visible = true;

                        label4.Text = "c oldal:";
                        label4.Visible = true;
                        numericUpDown3.Visible = true;

                        label5.Text = "magasság (m):";
                        label5.Visible = true;
                        numericUpDown4.Visible = true;

                        break;
                    }

                case "Négyzet":
                    {
                        label2.Text = "a oldal:";
                        label2.Visible = true;
                        numericUpDown1.Visible = true;

                        break;
                    }

                case "Trapéz":
                    pictureBox1.Image = Image.FromFile("alakzat/trapez/trapez_alap.png");
                    break;

                case "Téglalap":
                    pictureBox1.Image = Image.FromFile("alakzat/teglalap/teglalap_alap.png");
                    break;

                case "Paralelogramma":
                    pictureBox1.Image = Image.FromFile("alakzat/para/paralelogramma_alap.png");
                    break;

                case "Rombusz":
                    pictureBox1.Image = Image.FromFile("alakzat/rombusz/rombusz_alap.png");
                    break;

                case "Deltoid":
                    pictureBox1.Image = Image.FromFile("alakzat/deltoid/deltoid_alap.png");
                    break;

                case "Kör":
                    pictureBox1.Image = Image.FromFile("alakzat/kor/le_cercle_alap.png");
                    break;

                case "Henger":
                    pictureBox1.Image = Image.FromFile("alakzat/henger/henger_alap.png");
                    break;

                case "Gúla":
                    pictureBox1.Image = Image.FromFile("alakzat/gula/gula_alap.png");
                    break;

                case "Gömb":
                    pictureBox1.Image = Image.FromFile("alakzat/gomb/gomb_alap.png");
                    break;
            }
        }

        private void numericUpDown_Click(object sender, EventArgs e)
        {

        }

        private void torolBtn_Click(object sender, EventArgs e)
        {
            foreach (NumericUpDown item in NumericUpDowns) item.Text = "";
        }
    }
}
