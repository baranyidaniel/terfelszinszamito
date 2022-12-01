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
        static List<NumericUpDown> NumericUpDowns = new List<NumericUpDown>();
        public Form1()
        {
            InitializeComponent();
            InputSetup();
        }

        private void InputSetup()
        {
            NumericUpDowns.Add(numericUpDown1);
            NumericUpDowns.Add(numericUpDown2);
            NumericUpDowns.Add(numericUpDown3);
            NumericUpDowns.Add(numericUpDown4);
            NumericUpDowns.Add(numericUpDown5);

            foreach (NumericUpDown item in NumericUpDowns)
            {
                item.Controls[0].Hide();
                item.Controls[1].Width = Width - 4;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            KiUrit();

            eredmenyLbl.Visible = true;
            eredmeny1Lbl.Visible = true;
            eredmeny2Lbl.Visible = true;
            eredmeny1Txt.Visible = true;
            eredmeny2Txt.Visible = true;
            szamolBtn.Visible = true;
            torolBtn.Visible = true; 
            comboBox2.Visible = true;
            label6.Visible = true;
            label7.Visible = true;

            Megjelenit(comboBox1.SelectedItem.ToString());
            comboBox2.SelectedIndex = 1;
            MertekegysegLbl();
        }

        private void Megjelenit(string selectedItem)
        {
            switch (selectedItem)
            {
                case "Háromszög":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/haromszog/3szeg_alap.png");

                        label1.Text = "a oldal:";
                        label1.Visible = true;
                        numericUpDown1.Visible = true;

                        label2.Text = "b oldal:";
                        label2.Visible = true;
                        numericUpDown2.Visible = true;

                        label3.Text = "c oldal:";
                        label3.Visible = true;
                        numericUpDown3.Visible = true;

                        label4.Text = "";
                        label4.Visible = false;
                        numericUpDown4.Visible = false;

                        label5.Text = "";
                        label5.Visible = false;
                        numericUpDown5.Visible = false;

                        eredmeny1Lbl.Text = "Kerület:";
                        eredmeny2Lbl.Text = "Terület:";

                        break;
                    }

                case "Négyzet":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/negyzet/negyzet_alap.png");

                        label1.Text = "a oldal:";
                        label1.Visible = true;
                        numericUpDown1.Visible = true;

                        label2.Text = "";
                        label2.Visible = false;
                        numericUpDown2.Visible = false;

                        label3.Text = "";
                        label3.Visible = false;
                        numericUpDown3.Visible = false;

                        label4.Text = "";
                        label4.Visible = false;
                        numericUpDown4.Visible = false;

                        label5.Text = "";
                        label5.Visible = false;
                        numericUpDown5.Visible = false;

                        eredmeny1Lbl.Text = "Kerület:";
                        eredmeny2Lbl.Text = "Terület:";

                        break;
                    }

                case "Trapéz":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/trapez/trapez_alap.png");

                        label1.Text = "a oldal:";
                        label1.Visible = true;
                        numericUpDown1.Visible = true;

                        label2.Text = "b oldal:";
                        label2.Visible = true;
                        numericUpDown2.Visible = true;

                        label3.Text = "c oldal:";
                        label3.Visible = true;
                        numericUpDown3.Visible = true;

                        label4.Text = "d oldal:";
                        label4.Visible = true;
                        numericUpDown4.Visible = true;

                        label5.Text = "m magasság:";
                        label5.Visible = true;
                        numericUpDown5.Visible = true;

                        eredmeny1Lbl.Text = "Kerület:";
                        eredmeny2Lbl.Text = "Terület:";

                        break;
                    }

                case "Téglalap":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/teglalap/teglalap_alap.png");

                        label1.Text = "a oldal:";
                        label1.Visible = true;
                        numericUpDown1.Visible = true;

                        label2.Text = "b oldal:";
                        label2.Visible = true;
                        numericUpDown2.Visible = true;

                        label3.Text = "";
                        label3.Visible = false;
                        numericUpDown3.Visible = false;

                        label4.Text = "";
                        label4.Visible = false;
                        numericUpDown4.Visible = false;

                        label5.Text = "";
                        label5.Visible = false;
                        numericUpDown5.Visible = false;

                        eredmeny1Lbl.Text = "Kerület:";
                        eredmeny2Lbl.Text = "Terület:";

                        break;
                    }

                case "Paralelogramma":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/para/paralelogramma_alap.png");

                        label1.Text = "a oldal:";
                        label1.Visible = true;
                        numericUpDown1.Visible = true;

                        label2.Text = "b oldal:";
                        label2.Visible = true;
                        numericUpDown2.Visible = true;

                        label3.Text = "m magasság:";
                        label3.Visible = true;
                        numericUpDown3.Visible = true;

                        label4.Text = "";
                        label4.Visible = false;
                        numericUpDown4.Visible = false;

                        label5.Text = "";
                        label5.Visible = false;
                        numericUpDown5.Visible = false;

                        eredmeny1Lbl.Text = "Kerület:";
                        eredmeny2Lbl.Text = "Terület:";

                        break;
                    }

                case "Rombusz":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/rombusz/rombusz_alap.png");

                        label1.Text = "a oldal:";
                        label1.Visible = true;
                        numericUpDown1.Visible = true;

                        label2.Text = "e átló:";
                        label2.Visible = true;
                        numericUpDown2.Visible = true;

                        label3.Text = "f átló:";
                        label3.Visible = true;
                        numericUpDown3.Visible = true;

                        label4.Text = "";
                        label4.Visible = false;
                        numericUpDown4.Visible = false;

                        label5.Text = "";
                        label5.Visible = false;
                        numericUpDown5.Visible = false;

                        eredmeny1Lbl.Text = "Kerület:";
                        eredmeny2Lbl.Text = "Terület:";

                        break;
                    }

                case "Deltoid":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/deltoid/deltoid_alap.png");

                        label1.Text = "a oldal:";
                        label1.Visible = true;
                        numericUpDown1.Visible = true;

                        label2.Text = "b oldal:";
                        label2.Visible = true;
                        numericUpDown2.Visible = true;

                        label3.Text = "e átló:";
                        label3.Visible = true;
                        numericUpDown3.Visible = true;

                        label4.Text = "f átló:";
                        label4.Visible = true;
                        numericUpDown4.Visible = true;

                        label5.Text = "";
                        label5.Visible = false;
                        numericUpDown5.Visible = false;

                        eredmeny1Lbl.Text = "Kerület:";
                        eredmeny2Lbl.Text = "Terület:";

                        break;
                    }

                case "Kör":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/kor/le_cercle_alap.png");

                        label1.Text = "r sugár:";
                        label1.Visible = true;
                        numericUpDown1.Visible = true;

                        label2.Text = "";
                        label2.Visible = false;
                        numericUpDown2.Visible = false;

                        label3.Text = "";
                        label3.Visible = false;
                        numericUpDown3.Visible = false;

                        label4.Text = "";
                        label4.Visible = false;
                        numericUpDown4.Visible = false;

                        label5.Text = "";
                        label5.Visible = false;
                        numericUpDown5.Visible = false;

                        eredmeny1Lbl.Text = "Kerület:";
                        eredmeny2Lbl.Text = "Terület:";

                        break;
                    }

                case "Henger":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/henger/henger_alap.png");

                        label1.Text = "m magasság:";
                        label1.Visible = true;
                        numericUpDown1.Visible = true;

                        label2.Text = "r sugár:";
                        label2.Visible = true;
                        numericUpDown2.Visible = true;

                        label3.Text = "";
                        label3.Visible = false;
                        numericUpDown3.Visible = false;

                        label4.Text = "";
                        label4.Visible = false;
                        numericUpDown4.Visible = false;

                        label5.Text = "";
                        label5.Visible = false;
                        numericUpDown5.Visible = false;

                        eredmeny1Lbl.Text = "Felület:";
                        eredmeny2Lbl.Text = "Térfogat:";

                        break;
                    }

                case "Gúla":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/gula/gula_alap.png");

                        label1.Text = "a oldal:";
                        label1.Visible = true;
                        numericUpDown1.Visible = true;

                        label2.Text = "o oldal:";
                        label2.Visible = true;
                        numericUpDown2.Visible = true;

                        label3.Text = "r oldal:";
                        label3.Visible = true;
                        numericUpDown3.Visible = true;

                        label4.Text = "m oldalmagasság:";
                        label4.Visible = true;
                        numericUpDown4.Visible = true;

                        label5.Text = "M testmagasság:";
                        label5.Visible = true;
                        numericUpDown5.Visible = true;

                        eredmeny1Lbl.Text = "Felület:";
                        eredmeny2Lbl.Text = "Térfogat:";

                        break;
                    }

                case "Gömb":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/gomb/gomb_alap.png");

                        label1.Text = "r sugár:";
                        label1.Visible = true;
                        numericUpDown1.Visible = true;

                        label2.Text = "";
                        label2.Visible = false;
                        numericUpDown2.Visible = false;

                        label3.Text = "";
                        label3.Visible = false;
                        numericUpDown3.Visible = false;

                        label4.Text = "";
                        label4.Visible = false;
                        numericUpDown4.Visible = false;

                        label5.Text = "";
                        label5.Visible = false;
                        numericUpDown5.Visible = false;

                        eredmeny1Lbl.Text = "Felület:";
                        eredmeny2Lbl.Text = "Térfogat:";

                        break;
                    }
            }
        }

        private void numericUpDown1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Háromszög":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/haromszog/3szeg_aoldal.png");
                        break;
                    }

                case "Négyzet":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/negyzet/negyzet_aoldal.png");
                        break;
                    }

                case "Trapéz":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/trapez/trapez_aoldal.png");
                        break;
                    }

                case "Téglalap":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/teglalap/teglalap_aoldal.png");
                        break;
                    }

                case "Paralelogramma":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/para/paralelogramma_aoldal.png");
                        break;
                    }

                case "Rombusz":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/rombusz/rombusz_aoldal.png");
                        break;
                    }

                case "Deltoid":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/deltoid/deltoid_aoldal.png");
                        break;
                    }

                case "Kör":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/kor/le_cercle_sugair.png");
                        break;
                    }

                case "Henger":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/henger/henger_magassag.png");
                        break;
                    }

                case "Gúla":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/gula/gula_aoldal.png");
                        break;
                    }

                case "Gömb":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/gomb/gomb_sugar.png");
                        break;
                    }
            }
        }

        private void numericUpDown2_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Háromszög":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/haromszog/3szeg_boldal.png");
                        break;
                    }

                case "Trapéz":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/trapez/trapez_boldal.png");
                        break;
                    }

                case "Téglalap":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/teglalap/teglalap_boldal.png");
                        break;
                    }

                case "Paralelogramma":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/para/paralelogramma_boldal.png");
                        break;
                    }

                case "Rombusz":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/rombusz/rombusz_eatlo.png");
                        break;
                    }

                case "Deltoid":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/deltoid/deltoid_boldal.png");
                        break;
                    }

                case "Henger":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/henger/henger_sugar.png");
                        break;
                    }

                case "Gúla":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/gula/gula_oldal.png");
                        break;
                    }
            }
        }

        private void numericUpDown3_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Háromszög":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/haromszog/3szeg_coldal.png");
                        break;
                    }

                case "Trapéz":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/trapez/trapez_coldal.png");
                        break;
                    }

                case "Paralelogramma":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/para/paralelogramma_magassag.png");
                        break;
                    }

                case "Rombusz":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/rombusz/rombusz_fatlo.png");
                        break;
                    }

                case "Deltoid":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/deltoid/deltoid_eatlo.png");
                        break;
                    }

                case "Gúla":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/gula/gula_roldal.png");
                        break;
                    }
            }
        }

        private void numericUpDown4_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Trapéz":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/trapez/trapez_doldal.png");
                        break;
                    }

                case "Deltoid":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/deltoid/deltoid_fatlo.png");
                        break;
                    }

                case "Gúla":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/gula/gula_oldalmagassag.png");
                        break;
                    }
            }
        }

        private void numericUpDown5_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Trapéz":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/trapez/trapez_magassag.png");
                        break;
                    }

                case "Gúla":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/gula/gula_testmagassag.png");
                        break;
                    }
            }
        }

        private void torolBtn_Click(object sender, EventArgs e)
        {
            KiUrit();
        }

        private void KiUrit()
        {
            foreach (NumericUpDown item in NumericUpDowns) item.Value = 0;
            eredmeny1Txt.Text = "";
            eredmeny2Txt.Text = "";
        }

        private void szamolBtn_Click(object sender, EventArgs e)
        {
            double eredmeny1 = 0, eredmeny2 = 0;
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Háromszög":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/haromszog/3szeg_alap.png");

                        double a = Convert.ToDouble(numericUpDown1.Value),
                               b = Convert.ToDouble(numericUpDown2.Value),
                               c = Convert.ToDouble(numericUpDown3.Value),
                               s = (a+b+c) / 2;

                        if ((a < b + c) && (b < a + c) && (c < a + b))
                        {
                            eredmeny1 = a + b + c;
                            eredmeny2 = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                        }
                        break;
                    }

                case "Négyzet":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/negyzet/negyzet_alap.png");

                        double a = Convert.ToDouble(numericUpDown1.Value);

                        eredmeny1 = 4 * a;
                        eredmeny2 = Math.Pow(a, 2);

                        break;
                    }

                case "Trapéz":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/trapez/trapez_alap.png");

                        double a = Convert.ToDouble(numericUpDown1.Value),
                               b = Convert.ToDouble(numericUpDown2.Value),
                               c = Convert.ToDouble(numericUpDown3.Value),
                               d = Convert.ToDouble(numericUpDown4.Value),
                               m = Convert.ToDouble(numericUpDown5.Value);

                        eredmeny1 = a + b + c + d;
                        eredmeny2 = (a + c) * m / 2;

                        break;
                    }

                case "Téglalap":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/teglalap/teglalap_alap.png");

                        double a = Convert.ToDouble(numericUpDown1.Value),
                               b = Convert.ToDouble(numericUpDown2.Value);

                        eredmeny1 = 2 * (a + b);
                        eredmeny2 = a * b;

                        break;
                    }

                case "Paralelogramma":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/para/paralelogramma_alap.png");

                        double a = Convert.ToDouble(numericUpDown1.Value),
                               b = Convert.ToDouble(numericUpDown2.Value),
                               m = Convert.ToDouble(numericUpDown3.Value);

                        eredmeny1 = 2 * (a + b);
                        eredmeny2 = a * m;
                        break;
                    }

                case "Rombusz":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/rombusz/rombusz_alap.png");

                        double a = Convert.ToDouble(numericUpDown1.Value),
                               e_atlo = Convert.ToDouble(numericUpDown2.Value),
                               f_atlo = Convert.ToDouble(numericUpDown3.Value);

                        if (e_atlo < 2 * a && f_atlo < 2 * a)
                        {
                            eredmeny1 = 4 * a;
                            eredmeny2 = e_atlo * f_atlo / 2;
                        }
                        else
                        {
                            eredmeny1 = 0;
                            eredmeny2 = 0;
                        }
                            
                        break;
                    }

                case "Deltoid":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/deltoid/deltoid_alap.png");

                        double a = Convert.ToDouble(numericUpDown1.Value),
                               b = Convert.ToDouble(numericUpDown2.Value),
                               e_atlo = Convert.ToDouble(numericUpDown3.Value),
                               f_atlo = Convert.ToDouble(numericUpDown4.Value);

                        if (e_atlo < 2 * a && f_atlo < a + b)
                        {
                            eredmeny1 = 2 * (a + b);
                            eredmeny2 = e_atlo * f_atlo / 2;
                        }
                        else return;
                        break;
                    }

                case "Kör":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/kor/le_cercle_alap.png");

                        double r = Convert.ToDouble(numericUpDown1.Value);

                        eredmeny1 = Math.PI * Math.Pow(r, 2);
                        eredmeny2 = 2 * r * Math.PI;

                        break;
                    }

                case "Henger":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/henger/henger_alap.png");

                        double r = Convert.ToDouble(numericUpDown1.Value),
                               m = Convert.ToDouble(numericUpDown2.Value),
                               terulet_palast = 2 * Math.PI * m;

                        eredmeny1 = terulet_palast + Math.PI * Math.Pow(r, 2);
                        eredmeny2 = Math.PI * Math.Pow(r, 2) * m;

                        break;
                    }

                case "Gúla":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/gula/gula_alap.png");

                        double a = Convert.ToDouble(numericUpDown1.Value),
                               P = 4 * (Math.Sqrt(3) / 2 * a),
                               test_m = Convert.ToDouble(numericUpDown5.Value);

                        eredmeny1 = Math.Pow(a, 2) + P;
                        eredmeny2 = 4 * a * test_m / 3;

                        break;
                    }

                case "Gömb":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/gomb/gomb_alap.png");

                        double r = Convert.ToDouble(numericUpDown1.Value);

                        eredmeny1 = 4 * Math.PI * Math.Pow(r, 2);
                        eredmeny2 = 4 / 3 * Math.PI + Math.Pow(r, 3);

                        break;
                    }
            }

            if (eredmeny1 <= 0 || eredmeny2 <= 0)
            {
                eredmeny1Txt.Text = "Nem létezik!";
                eredmeny2Txt.Text = "Nem létezik!";
            }
            else
            {
                eredmeny1Txt.Text = eredmeny1.ToString("#.##");
                eredmeny2Txt.Text = eredmeny2.ToString("#.##");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            MertekegysegLbl();
        }

        private void MertekegysegLbl()
        {
            string mertekegyseg = comboBox2.SelectedItem.ToString();

            if (eredmeny1Lbl.Text == "Kerület:")
            {
                label6.Text = $"{mertekegyseg}";
                label7.Text = $"{mertekegyseg}²";
            }
            else
            {
                label6.Text = $"{mertekegyseg}²";
                label7.Text = $"{mertekegyseg}³";
            }
        }
    }
}
