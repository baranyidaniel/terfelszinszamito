
namespace terfelszinszamito
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.eredmeny1Lbl = new System.Windows.Forms.Label();
            this.eredmeny1Txt = new System.Windows.Forms.TextBox();
            this.eredmeny2Lbl = new System.Windows.Forms.Label();
            this.eredmeny2Txt = new System.Windows.Forms.TextBox();
            this.eredmenyLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Válassz egy alakzatot:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(319, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Háromszög",
            "Négyzet",
            "Trapéz",
            "Téglalap",
            "Paralelogramma",
            "Rombusz",
            "Deltoid",
            "Kör",
            "Henger",
            "Gúla",
            "Gömb"});
            this.comboBox1.Location = new System.Drawing.Point(20, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // eredmeny1Lbl
            // 
            this.eredmeny1Lbl.AutoSize = true;
            this.eredmeny1Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eredmeny1Lbl.Location = new System.Drawing.Point(14, 297);
            this.eredmeny1Lbl.Name = "eredmeny1Lbl";
            this.eredmeny1Lbl.Size = new System.Drawing.Size(52, 16);
            this.eredmeny1Lbl.TabIndex = 18;
            this.eredmeny1Lbl.Text = "Kerület:";
            this.eredmeny1Lbl.Visible = false;
            // 
            // eredmeny1Txt
            // 
            this.eredmeny1Txt.Location = new System.Drawing.Point(72, 296);
            this.eredmeny1Txt.Name = "eredmeny1Txt";
            this.eredmeny1Txt.Size = new System.Drawing.Size(132, 20);
            this.eredmeny1Txt.TabIndex = 17;
            this.eredmeny1Txt.Visible = false;
            // 
            // eredmeny2Lbl
            // 
            this.eredmeny2Lbl.AutoSize = true;
            this.eredmeny2Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eredmeny2Lbl.Location = new System.Drawing.Point(14, 323);
            this.eredmeny2Lbl.Name = "eredmeny2Lbl";
            this.eredmeny2Lbl.Size = new System.Drawing.Size(53, 16);
            this.eredmeny2Lbl.TabIndex = 20;
            this.eredmeny2Lbl.Text = "Terület:";
            this.eredmeny2Lbl.Visible = false;
            // 
            // eredmeny2Txt
            // 
            this.eredmeny2Txt.Location = new System.Drawing.Point(72, 322);
            this.eredmeny2Txt.Name = "eredmeny2Txt";
            this.eredmeny2Txt.Size = new System.Drawing.Size(132, 20);
            this.eredmeny2Txt.TabIndex = 19;
            this.eredmeny2Txt.Visible = false;
            // 
            // eredmenyLbl
            // 
            this.eredmenyLbl.AutoSize = true;
            this.eredmenyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eredmenyLbl.Location = new System.Drawing.Point(13, 266);
            this.eredmenyLbl.Name = "eredmenyLbl";
            this.eredmenyLbl.Size = new System.Drawing.Size(123, 24);
            this.eredmenyLbl.TabIndex = 21;
            this.eredmenyLbl.Text = "Eredmények:";
            this.eredmenyLbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 401);
            this.Controls.Add(this.eredmenyLbl);
            this.Controls.Add(this.eredmeny2Lbl);
            this.Controls.Add(this.eredmeny2Txt);
            this.Controls.Add(this.eredmeny1Lbl);
            this.Controls.Add(this.eredmeny1Txt);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(850, 440);
            this.MinimumSize = new System.Drawing.Size(850, 440);
            this.Name = "Form1";
            this.Text = "Térfelszínszámító";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label eredmeny1Lbl;
        private System.Windows.Forms.TextBox eredmeny1Txt;
        private System.Windows.Forms.Label eredmeny2Lbl;
        private System.Windows.Forms.TextBox eredmeny2Txt;
        private System.Windows.Forms.Label eredmenyLbl;
    }
}

