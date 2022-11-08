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
        static List<Label> labels;
        static List<TextBox> textBoxes;
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedindex = comboBox1.SelectedIndex;
            eredmenyLbl.Visible = true;
            eredmeny1Lbl.Visible = true;
            eredmeny2Lbl.Visible = true;
            eredmeny1Txt.Visible = true;
            eredmeny2Txt.Visible = true;
        }

        private void torolBtn_Click(object sender, EventArgs e)
        {
            foreach (TextBox item in textBoxes) item.Text = "";
        }
    }
}
