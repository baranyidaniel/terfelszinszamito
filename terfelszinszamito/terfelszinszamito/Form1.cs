﻿using System;
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

                        label4.Text = "magasság (m):";
                        label4.Visible = true;
                        numericUpDown4.Visible = true;

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

                        label5.Text = "magasság (m):";
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

                        label3.Text = "magasság (m):";
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

                        label1.Text = "sugár (r):";
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

                        label1.Text = "magasság (m):";
                        label1.Visible = true;
                        numericUpDown1.Visible = true;

                        label2.Text = "sugár (r):";
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

                        label4.Text = "oldalmagasság (m):";
                        label4.Visible = true;
                        numericUpDown4.Visible = true;

                        label5.Text = "testmagasság (M):";
                        label5.Visible = true;
                        numericUpDown5.Visible = true;

                        eredmeny1Lbl.Text = "Felület:";
                        eredmeny2Lbl.Text = "Térfogat:";

                        break;
                    }

                case "Gömb":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/gomb/gomb_alap.png");

                        label1.Text = "sugár (r):";
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
                        pictureBox1.Image = Image.FromFile("alakzat/gula/gula_oldalmagassag.png");
                        break;
                    }
            }
        }

        private void numericUpDown4_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Háromszög":
                    {
                        pictureBox1.Image = Image.FromFile("alakzat/haromszog/3szeg_magassag.png");
                        break;
                    }

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
                        pictureBox1.Image = Image.FromFile("alakzat/gula/gula_sugar.png");
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
                        pictureBox1.Image = Image.FromFile("alakzat/gula/gula_oldalmagassag.png");
                        break;
                    }
            }
        }

        private void torolBtn_Click(object sender, EventArgs e)
        {
            foreach (NumericUpDown item in Controls) item.Text = "";
            eredmeny1Txt.Text = "";
            eredmeny2Txt.Text = "";
        }
    }
}
