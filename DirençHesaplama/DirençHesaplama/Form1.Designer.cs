namespace DirençHesaplama
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
            this.btn_Hesapla = new System.Windows.Forms.Button();
            this.pcb_Direnc = new System.Windows.Forms.PictureBox();
            this.lbl_DirencAdet = new System.Windows.Forms.Label();
            this.cmb_DirencAdet = new System.Windows.Forms.ComboBox();
            this.lbl_Sonuc = new System.Windows.Forms.Label();
            this.btn_Onayla = new System.Windows.Forms.Button();
            this.cmb_secim2 = new System.Windows.Forms.ComboBox();
            this.cmb_secim3 = new System.Windows.Forms.ComboBox();
            this.cmb_secim4 = new System.Windows.Forms.ComboBox();
            this.cmb_secim5 = new System.Windows.Forms.ComboBox();
            this.cmb_secim6 = new System.Windows.Forms.ComboBox();
            this.cmb_secim1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Direnc)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Hesapla
            // 
            this.btn_Hesapla.Location = new System.Drawing.Point(461, 56);
            this.btn_Hesapla.Name = "btn_Hesapla";
            this.btn_Hesapla.Size = new System.Drawing.Size(75, 23);
            this.btn_Hesapla.TabIndex = 7;
            this.btn_Hesapla.Text = "Hesapla";
            this.btn_Hesapla.UseVisualStyleBackColor = true;
            this.btn_Hesapla.Click += new System.EventHandler(this.button1_Click);
            // 
            // pcb_Direnc
            // 
            this.pcb_Direnc.Image = global::DirençHesaplama.Properties.Resources.Direnç;
            this.pcb_Direnc.Location = new System.Drawing.Point(12, 12);
            this.pcb_Direnc.Name = "pcb_Direnc";
            this.pcb_Direnc.Size = new System.Drawing.Size(443, 196);
            this.pcb_Direnc.TabIndex = 2;
            this.pcb_Direnc.TabStop = false;
            this.pcb_Direnc.Click += new System.EventHandler(this.pcb_Direnc_Click);
            // 
            // lbl_DirencAdet
            // 
            this.lbl_DirencAdet.AutoSize = true;
            this.lbl_DirencAdet.Location = new System.Drawing.Point(458, 13);
            this.lbl_DirencAdet.Name = "lbl_DirencAdet";
            this.lbl_DirencAdet.Size = new System.Drawing.Size(174, 13);
            this.lbl_DirencAdet.TabIndex = 3;
            this.lbl_DirencAdet.Text = "Kaç Adet Renk Kodu Gireceksiniz?";
            // 
            // cmb_DirencAdet
            // 
            this.cmb_DirencAdet.FormattingEnabled = true;
            this.cmb_DirencAdet.Items.AddRange(new object[] {
            "4",
            "5",
            "6"});
            this.cmb_DirencAdet.Location = new System.Drawing.Point(461, 29);
            this.cmb_DirencAdet.Name = "cmb_DirencAdet";
            this.cmb_DirencAdet.Size = new System.Drawing.Size(75, 21);
            this.cmb_DirencAdet.TabIndex = 0;
            // 
            // lbl_Sonuc
            // 
            this.lbl_Sonuc.AutoSize = true;
            this.lbl_Sonuc.Location = new System.Drawing.Point(458, 82);
            this.lbl_Sonuc.Name = "lbl_Sonuc";
            this.lbl_Sonuc.Size = new System.Drawing.Size(45, 13);
            this.lbl_Sonuc.TabIndex = 18;
            this.lbl_Sonuc.Text = "SONUC";
            // 
            // btn_Onayla
            // 
            this.btn_Onayla.Location = new System.Drawing.Point(542, 27);
            this.btn_Onayla.Name = "btn_Onayla";
            this.btn_Onayla.Size = new System.Drawing.Size(83, 23);
            this.btn_Onayla.TabIndex = 19;
            this.btn_Onayla.Text = "Onayla";
            this.btn_Onayla.UseVisualStyleBackColor = true;
            this.btn_Onayla.Click += new System.EventHandler(this.btn_Onayla_Click);
            // 
            // cmb_secim2
            // 
            this.cmb_secim2.FormattingEnabled = true;
            this.cmb_secim2.Items.AddRange(new object[] {
            "Black",
            "Brown",
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Purple",
            "Gray",
            "White",
            "Gold",
            "Silver",
            "No Color"});
            this.cmb_secim2.Location = new System.Drawing.Point(83, 214);
            this.cmb_secim2.Name = "cmb_secim2";
            this.cmb_secim2.Size = new System.Drawing.Size(64, 21);
            this.cmb_secim2.TabIndex = 21;
            this.cmb_secim2.SelectedIndexChanged += new System.EventHandler(this.cmb_secim2_SelectedIndexChanged);
            // 
            // cmb_secim3
            // 
            this.cmb_secim3.FormattingEnabled = true;
            this.cmb_secim3.Items.AddRange(new object[] {
            "Black",
            "Brown",
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Purple",
            "Gray",
            "White",
            "Gold",
            "Silver",
            "No Color"});
            this.cmb_secim3.Location = new System.Drawing.Point(153, 214);
            this.cmb_secim3.Name = "cmb_secim3";
            this.cmb_secim3.Size = new System.Drawing.Size(64, 21);
            this.cmb_secim3.TabIndex = 21;
            this.cmb_secim3.SelectedIndexChanged += new System.EventHandler(this.cmb_secim3_SelectedIndexChanged);
            // 
            // cmb_secim4
            // 
            this.cmb_secim4.FormattingEnabled = true;
            this.cmb_secim4.Items.AddRange(new object[] {
            "Black",
            "Brown",
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Purple",
            "Gray",
            "White",
            "Gold",
            "Silver",
            "No Color"});
            this.cmb_secim4.Location = new System.Drawing.Point(255, 214);
            this.cmb_secim4.Name = "cmb_secim4";
            this.cmb_secim4.Size = new System.Drawing.Size(64, 21);
            this.cmb_secim4.TabIndex = 21;
            this.cmb_secim4.SelectedIndexChanged += new System.EventHandler(this.cmb_secim4_SelectedIndexChanged);
            // 
            // cmb_secim5
            // 
            this.cmb_secim5.FormattingEnabled = true;
            this.cmb_secim5.Items.AddRange(new object[] {
            "Black",
            "Brown",
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Purple",
            "Gray",
            "White",
            "Gold",
            "Silver",
            "No Color"});
            this.cmb_secim5.Location = new System.Drawing.Point(325, 214);
            this.cmb_secim5.Name = "cmb_secim5";
            this.cmb_secim5.Size = new System.Drawing.Size(64, 21);
            this.cmb_secim5.TabIndex = 21;
            this.cmb_secim5.SelectedIndexChanged += new System.EventHandler(this.cmb_secim5_SelectedIndexChanged);
            // 
            // cmb_secim6
            // 
            this.cmb_secim6.FormattingEnabled = true;
            this.cmb_secim6.Items.AddRange(new object[] {
            "Black",
            "Brown",
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Purple",
            "Gray",
            "White",
            "Gold",
            "Silver",
            "No Color"});
            this.cmb_secim6.Location = new System.Drawing.Point(395, 214);
            this.cmb_secim6.Name = "cmb_secim6";
            this.cmb_secim6.Size = new System.Drawing.Size(64, 21);
            this.cmb_secim6.TabIndex = 21;
            this.cmb_secim6.SelectedIndexChanged += new System.EventHandler(this.cmb_secim6_SelectedIndexChanged);
            // 
            // cmb_secim1
            // 
            this.cmb_secim1.FormattingEnabled = true;
            this.cmb_secim1.Items.AddRange(new object[] {
            "Black",
            "Brown",
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Purple",
            "Gray",
            "White",
            "Gold",
            "Silver",
            "No Color"});
            this.cmb_secim1.Location = new System.Drawing.Point(13, 214);
            this.cmb_secim1.Name = "cmb_secim1";
            this.cmb_secim1.Size = new System.Drawing.Size(64, 21);
            this.cmb_secim1.TabIndex = 21;
            this.cmb_secim1.SelectedIndexChanged += new System.EventHandler(this.cmb_secim1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(637, 247);
            this.Controls.Add(this.cmb_secim6);
            this.Controls.Add(this.cmb_secim5);
            this.Controls.Add(this.cmb_secim4);
            this.Controls.Add(this.cmb_secim1);
            this.Controls.Add(this.cmb_secim3);
            this.Controls.Add(this.cmb_secim2);
            this.Controls.Add(this.btn_Onayla);
            this.Controls.Add(this.lbl_Sonuc);
            this.Controls.Add(this.cmb_DirencAdet);
            this.Controls.Add(this.lbl_DirencAdet);
            this.Controls.Add(this.pcb_Direnc);
            this.Controls.Add(this.btn_Hesapla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Direnc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Hesapla;
        private System.Windows.Forms.PictureBox pcb_Direnc;
        private System.Windows.Forms.Label lbl_DirencAdet;
        private System.Windows.Forms.ComboBox cmb_DirencAdet;
        private System.Windows.Forms.Label lbl_Sonuc;
        private System.Windows.Forms.Button btn_Onayla;
        private System.Windows.Forms.ComboBox cmb_secim2;
        private System.Windows.Forms.ComboBox cmb_secim3;
        private System.Windows.Forms.ComboBox cmb_secim4;
        private System.Windows.Forms.ComboBox cmb_secim5;
        private System.Windows.Forms.ComboBox cmb_secim6;
        private System.Windows.Forms.ComboBox cmb_secim1;
    }
}

