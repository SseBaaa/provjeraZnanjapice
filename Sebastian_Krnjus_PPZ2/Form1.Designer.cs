namespace Sebastian_Krnjus_PPZ2
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
            this.lblNaslov = new System.Windows.Forms.Label();
            this.rbGazirana = new System.Windows.Forms.RadioButton();
            this.rbNegazirana = new System.Windows.Forms.RadioButton();
            this.rbAlkoholna = new System.Windows.Forms.RadioButton();
            this.txtBoxNaziv = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.cmbKolicina = new System.Windows.Forms.ComboBox();
            this.lblPakiranje = new System.Windows.Forms.Label();
            this.cmbPakiranje = new System.Windows.Forms.ComboBox();
            this.lblAlkohol = new System.Windows.Forms.Label();
            this.trckAlkohol = new System.Windows.Forms.TrackBar();
            this.lblTrackbar = new System.Windows.Forms.Label();
            this.lblCijena = new System.Windows.Forms.Label();
            this.txtBoxCijena = new System.Windows.Forms.TextBox();
            this.rtbIspis = new System.Windows.Forms.RichTextBox();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.btnIspisi = new System.Windows.Forms.Button();
            this.lblAlk = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trckAlkohol)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.Location = new System.Drawing.Point(422, 13);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(64, 29);
            this.lblNaslov.TabIndex = 0;
            this.lblNaslov.Text = "Pića";
            // 
            // rbGazirana
            // 
            this.rbGazirana.AutoSize = true;
            this.rbGazirana.Location = new System.Drawing.Point(47, 55);
            this.rbGazirana.Name = "rbGazirana";
            this.rbGazirana.Size = new System.Drawing.Size(90, 17);
            this.rbGazirana.TabIndex = 1;
            this.rbGazirana.TabStop = true;
            this.rbGazirana.Text = "Gazirana pića";
            this.rbGazirana.UseVisualStyleBackColor = true;
            this.rbGazirana.CheckedChanged += new System.EventHandler(this.rbGazirana_CheckedChanged);
            // 
            // rbNegazirana
            // 
            this.rbNegazirana.AutoSize = true;
            this.rbNegazirana.Location = new System.Drawing.Point(47, 79);
            this.rbNegazirana.Name = "rbNegazirana";
            this.rbNegazirana.Size = new System.Drawing.Size(102, 17);
            this.rbNegazirana.TabIndex = 2;
            this.rbNegazirana.TabStop = true;
            this.rbNegazirana.Text = "Negazirana pića";
            this.rbNegazirana.UseVisualStyleBackColor = true;
            this.rbNegazirana.CheckedChanged += new System.EventHandler(this.rbNegazirana_CheckedChanged);
            // 
            // rbAlkoholna
            // 
            this.rbAlkoholna.AutoSize = true;
            this.rbAlkoholna.Location = new System.Drawing.Point(47, 103);
            this.rbAlkoholna.Name = "rbAlkoholna";
            this.rbAlkoholna.Size = new System.Drawing.Size(95, 17);
            this.rbAlkoholna.TabIndex = 3;
            this.rbAlkoholna.TabStop = true;
            this.rbAlkoholna.Text = "Alkoholna pića";
            this.rbAlkoholna.UseVisualStyleBackColor = true;
            this.rbAlkoholna.CheckedChanged += new System.EventHandler(this.rbAlkoholna_CheckedChanged);
            // 
            // txtBoxNaziv
            // 
            this.txtBoxNaziv.Location = new System.Drawing.Point(118, 156);
            this.txtBoxNaziv.Name = "txtBoxNaziv";
            this.txtBoxNaziv.Size = new System.Drawing.Size(121, 20);
            this.txtBoxNaziv.TabIndex = 4;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(47, 156);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(34, 13);
            this.lblNaziv.TabIndex = 5;
            this.lblNaziv.Text = "Naziv";
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Location = new System.Drawing.Point(47, 221);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(44, 13);
            this.lblKolicina.TabIndex = 6;
            this.lblKolicina.Text = "Količina";
            // 
            // cmbKolicina
            // 
            this.cmbKolicina.FormattingEnabled = true;
            this.cmbKolicina.Items.AddRange(new object[] {
            "0.5L",
            "1L",
            "1.5L",
            "2L"});
            this.cmbKolicina.Location = new System.Drawing.Point(118, 221);
            this.cmbKolicina.Name = "cmbKolicina";
            this.cmbKolicina.Size = new System.Drawing.Size(121, 21);
            this.cmbKolicina.TabIndex = 7;
            // 
            // lblPakiranje
            // 
            this.lblPakiranje.AutoSize = true;
            this.lblPakiranje.Location = new System.Drawing.Point(47, 288);
            this.lblPakiranje.Name = "lblPakiranje";
            this.lblPakiranje.Size = new System.Drawing.Size(51, 13);
            this.lblPakiranje.TabIndex = 8;
            this.lblPakiranje.Text = "Pakiranje";
            // 
            // cmbPakiranje
            // 
            this.cmbPakiranje.FormattingEnabled = true;
            this.cmbPakiranje.Items.AddRange(new object[] {
            "Staklo",
            "tetrapak",
            "Pet"});
            this.cmbPakiranje.Location = new System.Drawing.Point(118, 288);
            this.cmbPakiranje.Name = "cmbPakiranje";
            this.cmbPakiranje.Size = new System.Drawing.Size(121, 21);
            this.cmbPakiranje.TabIndex = 9;
            // 
            // lblAlkohol
            // 
            this.lblAlkohol.AutoSize = true;
            this.lblAlkohol.Location = new System.Drawing.Point(47, 355);
            this.lblAlkohol.Name = "lblAlkohol";
            this.lblAlkohol.Size = new System.Drawing.Size(42, 13);
            this.lblAlkohol.TabIndex = 10;
            this.lblAlkohol.Text = "Alkohol";
            // 
            // trckAlkohol
            // 
            this.trckAlkohol.LargeChange = 10;
            this.trckAlkohol.Location = new System.Drawing.Point(118, 355);
            this.trckAlkohol.Maximum = 50;
            this.trckAlkohol.Name = "trckAlkohol";
            this.trckAlkohol.Size = new System.Drawing.Size(121, 45);
            this.trckAlkohol.TabIndex = 11;
            this.trckAlkohol.Scroll += new System.EventHandler(this.trckAlkohol_Scroll);
            // 
            // lblTrackbar
            // 
            this.lblTrackbar.AutoSize = true;
            this.lblTrackbar.Location = new System.Drawing.Point(278, 288);
            this.lblTrackbar.Name = "lblTrackbar";
            this.lblTrackbar.Size = new System.Drawing.Size(0, 13);
            this.lblTrackbar.TabIndex = 12;
            // 
            // lblCijena
            // 
            this.lblCijena.AutoSize = true;
            this.lblCijena.Location = new System.Drawing.Point(50, 429);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(36, 13);
            this.lblCijena.TabIndex = 13;
            this.lblCijena.Text = "Cijena";
            // 
            // txtBoxCijena
            // 
            this.txtBoxCijena.Location = new System.Drawing.Point(118, 427);
            this.txtBoxCijena.Name = "txtBoxCijena";
            this.txtBoxCijena.Size = new System.Drawing.Size(121, 20);
            this.txtBoxCijena.TabIndex = 14;
            // 
            // rtbIspis
            // 
            this.rtbIspis.Location = new System.Drawing.Point(297, 156);
            this.rtbIspis.Name = "rtbIspis";
            this.rtbIspis.Size = new System.Drawing.Size(414, 330);
            this.rtbIspis.TabIndex = 15;
            this.rtbIspis.Text = "";
            this.rtbIspis.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(771, 156);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(212, 118);
            this.btnUnesi.TabIndex = 16;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // btnIspisi
            // 
            this.btnIspisi.Location = new System.Drawing.Point(771, 285);
            this.btnIspisi.Name = "btnIspisi";
            this.btnIspisi.Size = new System.Drawing.Size(212, 115);
            this.btnIspisi.TabIndex = 17;
            this.btnIspisi.Text = "Ispisi";
            this.btnIspisi.UseVisualStyleBackColor = true;
            this.btnIspisi.Click += new System.EventHandler(this.btnIspisi_Click);
            // 
            // lblAlk
            // 
            this.lblAlk.AutoSize = true;
            this.lblAlk.Location = new System.Drawing.Point(246, 355);
            this.lblAlk.Name = "lblAlk";
            this.lblAlk.Size = new System.Drawing.Size(0, 13);
            this.lblAlk.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 514);
            this.Controls.Add(this.lblAlk);
            this.Controls.Add(this.btnIspisi);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.rtbIspis);
            this.Controls.Add(this.txtBoxCijena);
            this.Controls.Add(this.lblCijena);
            this.Controls.Add(this.lblTrackbar);
            this.Controls.Add(this.trckAlkohol);
            this.Controls.Add(this.lblAlkohol);
            this.Controls.Add(this.cmbPakiranje);
            this.Controls.Add(this.lblPakiranje);
            this.Controls.Add(this.cmbKolicina);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.txtBoxNaziv);
            this.Controls.Add(this.rbAlkoholna);
            this.Controls.Add(this.rbNegazirana);
            this.Controls.Add(this.rbGazirana);
            this.Controls.Add(this.lblNaslov);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trckAlkohol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.RadioButton rbGazirana;
        private System.Windows.Forms.RadioButton rbNegazirana;
        private System.Windows.Forms.RadioButton rbAlkoholna;
        private System.Windows.Forms.TextBox txtBoxNaziv;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.ComboBox cmbKolicina;
        private System.Windows.Forms.Label lblPakiranje;
        private System.Windows.Forms.ComboBox cmbPakiranje;
        private System.Windows.Forms.Label lblAlkohol;
        private System.Windows.Forms.TrackBar trckAlkohol;
        private System.Windows.Forms.Label lblTrackbar;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.TextBox txtBoxCijena;
        private System.Windows.Forms.RichTextBox rtbIspis;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Button btnIspisi;
        private System.Windows.Forms.Label lblAlk;
    }
}

