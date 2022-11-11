
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
            this.valassz = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.eredmeny1Txt = new System.Windows.Forms.TextBox();
            this.eredmeny2Txt = new System.Windows.Forms.TextBox();
            this.eredmenyLbl = new System.Windows.Forms.Label();
            this.torolBtn = new System.Windows.Forms.Button();
            this.szamolBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.eredmeny1Lbl = new System.Windows.Forms.Label();
            this.eredmeny2Lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            this.SuspendLayout();
            // 
            // valassz
            // 
            this.valassz.AutoSize = true;
            this.valassz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.valassz.Location = new System.Drawing.Point(20, 10);
            this.valassz.Name = "valassz";
            this.valassz.Size = new System.Drawing.Size(191, 24);
            this.valassz.TabIndex = 0;
            this.valassz.Text = "Válassz egy alakzatot:";
            this.valassz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(319, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
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
            // eredmeny1Txt
            // 
            this.eredmeny1Txt.Enabled = false;
            this.eredmeny1Txt.Location = new System.Drawing.Point(94, 268);
            this.eredmeny1Txt.Name = "eredmeny1Txt";
            this.eredmeny1Txt.Size = new System.Drawing.Size(112, 20);
            this.eredmeny1Txt.TabIndex = 17;
            this.eredmeny1Txt.Visible = false;
            // 
            // eredmeny2Txt
            // 
            this.eredmeny2Txt.Enabled = false;
            this.eredmeny2Txt.Location = new System.Drawing.Point(94, 294);
            this.eredmeny2Txt.Name = "eredmeny2Txt";
            this.eredmeny2Txt.Size = new System.Drawing.Size(112, 20);
            this.eredmeny2Txt.TabIndex = 19;
            this.eredmeny2Txt.Visible = false;
            // 
            // eredmenyLbl
            // 
            this.eredmenyLbl.AutoSize = true;
            this.eredmenyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eredmenyLbl.Location = new System.Drawing.Point(12, 238);
            this.eredmenyLbl.Name = "eredmenyLbl";
            this.eredmenyLbl.Size = new System.Drawing.Size(123, 24);
            this.eredmenyLbl.TabIndex = 21;
            this.eredmenyLbl.Text = "Eredmények:";
            this.eredmenyLbl.Visible = false;
            // 
            // torolBtn
            // 
            this.torolBtn.Location = new System.Drawing.Point(11, 320);
            this.torolBtn.Name = "torolBtn";
            this.torolBtn.Size = new System.Drawing.Size(195, 23);
            this.torolBtn.TabIndex = 22;
            this.torolBtn.Text = "Mezők kiürítése";
            this.torolBtn.UseVisualStyleBackColor = true;
            this.torolBtn.Visible = false;
            this.torolBtn.Click += new System.EventHandler(this.torolBtn_Click);
            // 
            // szamolBtn
            // 
            this.szamolBtn.Location = new System.Drawing.Point(12, 200);
            this.szamolBtn.Name = "szamolBtn";
            this.szamolBtn.Size = new System.Drawing.Size(195, 23);
            this.szamolBtn.TabIndex = 23;
            this.szamolBtn.Text = "Számol";
            this.szamolBtn.UseVisualStyleBackColor = true;
            this.szamolBtn.Visible = false;
            this.szamolBtn.Click += new System.EventHandler(this.szamolBtn_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(17, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "text";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Visible = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(128, 70);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(79, 20);
            this.numericUpDown1.TabIndex = 25;
            this.numericUpDown1.Visible = false;
            this.numericUpDown1.Click += new System.EventHandler(this.numericUpDown1_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(128, 96);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(79, 20);
            this.numericUpDown2.TabIndex = 27;
            this.numericUpDown2.Visible = false;
            this.numericUpDown2.Click += new System.EventHandler(this.numericUpDown2_Click);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(128, 122);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(79, 20);
            this.numericUpDown3.TabIndex = 29;
            this.numericUpDown3.Visible = false;
            this.numericUpDown3.Click += new System.EventHandler(this.numericUpDown3_Click);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(128, 148);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(79, 20);
            this.numericUpDown4.TabIndex = 31;
            this.numericUpDown4.Visible = false;
            this.numericUpDown4.Click += new System.EventHandler(this.numericUpDown4_Click);
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(128, 174);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(79, 20);
            this.numericUpDown5.TabIndex = 33;
            this.numericUpDown5.Visible = false;
            this.numericUpDown5.Click += new System.EventHandler(this.numericUpDown5_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(17, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "text";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(17, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "text";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(17, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "text";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(17, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "text";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Visible = false;
            // 
            // eredmeny1Lbl
            // 
            this.eredmeny1Lbl.Location = new System.Drawing.Point(13, 268);
            this.eredmeny1Lbl.Name = "eredmeny1Lbl";
            this.eredmeny1Lbl.Size = new System.Drawing.Size(75, 20);
            this.eredmeny1Lbl.TabIndex = 38;
            this.eredmeny1Lbl.Text = "text";
            this.eredmeny1Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.eredmeny1Lbl.Visible = false;
            // 
            // eredmeny2Lbl
            // 
            this.eredmeny2Lbl.Location = new System.Drawing.Point(13, 294);
            this.eredmeny2Lbl.Name = "eredmeny2Lbl";
            this.eredmeny2Lbl.Size = new System.Drawing.Size(75, 20);
            this.eredmeny2Lbl.TabIndex = 39;
            this.eredmeny2Lbl.Text = "text";
            this.eredmeny2Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.eredmeny2Lbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 401);
            this.Controls.Add(this.eredmeny2Lbl);
            this.Controls.Add(this.eredmeny1Lbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown5);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.szamolBtn);
            this.Controls.Add(this.torolBtn);
            this.Controls.Add(this.eredmenyLbl);
            this.Controls.Add(this.eredmeny2Txt);
            this.Controls.Add(this.eredmeny1Txt);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.valassz);
            this.MaximumSize = new System.Drawing.Size(850, 440);
            this.MinimumSize = new System.Drawing.Size(850, 440);
            this.Name = "Form1";
            this.Text = "Térfelszínszámító";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label valassz;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox eredmeny1Txt;
        private System.Windows.Forms.TextBox eredmeny2Txt;
        private System.Windows.Forms.Label eredmenyLbl;
        private System.Windows.Forms.Button torolBtn;
        private System.Windows.Forms.Button szamolBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label eredmeny1Lbl;
        private System.Windows.Forms.Label eredmeny2Lbl;
    }
}

