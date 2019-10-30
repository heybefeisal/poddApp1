namespace poddApp11
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
            this.listViewPoddar = new System.Windows.Forms.ListView();
            this.listViewPoddarAvsnitt = new System.Windows.Forms.ListView();
            this.textBoxAvsSammanfattning = new System.Windows.Forms.TextBox();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.comboBoxUppdatering = new System.Windows.Forms.ComboBox();
            this.comboBoxKategori = new System.Windows.Forms.ComboBox();
            this.textBoxKategori = new System.Windows.Forms.TextBox();
            this.buttonLaggTillPodd = new System.Windows.Forms.Button();
            this.buttonTaBortPodd = new System.Windows.Forms.Button();
            this.buttonSparaPodd = new System.Windows.Forms.Button();
            this.buttonTaBortKat = new System.Windows.Forms.Button();
            this.buttonSparaKat = new System.Windows.Forms.Button();
            this.buttonLaggTillKat = new System.Windows.Forms.Button();
            this.labelPoddar = new System.Windows.Forms.Label();
            this.labelUrl = new System.Windows.Forms.Label();
            this.labelUpp = new System.Windows.Forms.Label();
            this.labelKategori = new System.Windows.Forms.Label();
            this.labelPoddAvs = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.PoddNamn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kategori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Avsnitt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Frekvens = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewPoddar
            // 
            this.listViewPoddar.BackColor = System.Drawing.SystemColors.Menu;
            this.listViewPoddar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PoddNamn,
            this.Kategori,
            this.Avsnitt,
            this.Frekvens});
            this.listViewPoddar.Location = new System.Drawing.Point(24, 36);
            this.listViewPoddar.Name = "listViewPoddar";
            this.listViewPoddar.Size = new System.Drawing.Size(497, 223);
            this.listViewPoddar.TabIndex = 0;
            this.listViewPoddar.UseCompatibleStateImageBehavior = false;
            this.listViewPoddar.SelectedIndexChanged += new System.EventHandler(this.listViewPoddar_SelectedIndexChanged);
            // 
            // listViewPoddarAvsnitt
            // 
            this.listViewPoddarAvsnitt.HideSelection = false;
            this.listViewPoddarAvsnitt.Location = new System.Drawing.Point(24, 388);
            this.listViewPoddarAvsnitt.Name = "listViewPoddarAvsnitt";
            this.listViewPoddarAvsnitt.Size = new System.Drawing.Size(497, 161);
            this.listViewPoddarAvsnitt.TabIndex = 1;
            this.listViewPoddarAvsnitt.UseCompatibleStateImageBehavior = false;
            // 
            // textBoxAvsSammanfattning
            // 
            this.textBoxAvsSammanfattning.Location = new System.Drawing.Point(620, 399);
            this.textBoxAvsSammanfattning.Multiline = true;
            this.textBoxAvsSammanfattning.Name = "textBoxAvsSammanfattning";
            this.textBoxAvsSammanfattning.Size = new System.Drawing.Size(303, 150);
            this.textBoxAvsSammanfattning.TabIndex = 3;
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(24, 286);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(217, 22);
            this.textBoxUrl.TabIndex = 4;
            // 
            // comboBoxUppdatering
            // 
            this.comboBoxUppdatering.FormattingEnabled = true;
            this.comboBoxUppdatering.Location = new System.Drawing.Point(261, 284);
            this.comboBoxUppdatering.Name = "comboBoxUppdatering";
            this.comboBoxUppdatering.Size = new System.Drawing.Size(116, 24);
            this.comboBoxUppdatering.TabIndex = 5;
            // 
            // comboBoxKategori
            // 
            this.comboBoxKategori.FormattingEnabled = true;
            this.comboBoxKategori.Location = new System.Drawing.Point(427, 282);
            this.comboBoxKategori.Name = "comboBoxKategori";
            this.comboBoxKategori.Size = new System.Drawing.Size(94, 24);
            this.comboBoxKategori.TabIndex = 6;
            // 
            // textBoxKategori
            // 
            this.textBoxKategori.Location = new System.Drawing.Point(620, 205);
            this.textBoxKategori.Name = "textBoxKategori";
            this.textBoxKategori.Size = new System.Drawing.Size(303, 22);
            this.textBoxKategori.TabIndex = 7;
            // 
            // buttonLaggTillPodd
            // 
            this.buttonLaggTillPodd.Location = new System.Drawing.Point(217, 329);
            this.buttonLaggTillPodd.Name = "buttonLaggTillPodd";
            this.buttonLaggTillPodd.Size = new System.Drawing.Size(81, 34);
            this.buttonLaggTillPodd.TabIndex = 8;
            this.buttonLaggTillPodd.Text = "Ny";
            this.buttonLaggTillPodd.UseVisualStyleBackColor = true;
            // 
            // buttonTaBortPodd
            // 
            this.buttonTaBortPodd.Location = new System.Drawing.Point(427, 329);
            this.buttonTaBortPodd.Name = "buttonTaBortPodd";
            this.buttonTaBortPodd.Size = new System.Drawing.Size(94, 34);
            this.buttonTaBortPodd.TabIndex = 9;
            this.buttonTaBortPodd.Text = "Ta bort";
            this.buttonTaBortPodd.UseVisualStyleBackColor = true;
            // 
            // buttonSparaPodd
            // 
            this.buttonSparaPodd.Location = new System.Drawing.Point(325, 329);
            this.buttonSparaPodd.Name = "buttonSparaPodd";
            this.buttonSparaPodd.Size = new System.Drawing.Size(87, 34);
            this.buttonSparaPodd.TabIndex = 10;
            this.buttonSparaPodd.Text = "Spara";
            this.buttonSparaPodd.UseVisualStyleBackColor = true;
            // 
            // buttonTaBortKat
            // 
            this.buttonTaBortKat.Location = new System.Drawing.Point(842, 245);
            this.buttonTaBortKat.Name = "buttonTaBortKat";
            this.buttonTaBortKat.Size = new System.Drawing.Size(81, 34);
            this.buttonTaBortKat.TabIndex = 11;
            this.buttonTaBortKat.Text = "Ta bort";
            this.buttonTaBortKat.UseVisualStyleBackColor = true;
            // 
            // buttonSparaKat
            // 
            this.buttonSparaKat.Location = new System.Drawing.Point(731, 245);
            this.buttonSparaKat.Name = "buttonSparaKat";
            this.buttonSparaKat.Size = new System.Drawing.Size(81, 34);
            this.buttonSparaKat.TabIndex = 12;
            this.buttonSparaKat.Text = "Spara";
            this.buttonSparaKat.UseVisualStyleBackColor = true;
            // 
            // buttonLaggTillKat
            // 
            this.buttonLaggTillKat.Location = new System.Drawing.Point(620, 245);
            this.buttonLaggTillKat.Name = "buttonLaggTillKat";
            this.buttonLaggTillKat.Size = new System.Drawing.Size(81, 34);
            this.buttonLaggTillKat.TabIndex = 13;
            this.buttonLaggTillKat.Text = "Ny";
            this.buttonLaggTillKat.UseVisualStyleBackColor = true;
            // 
            // labelPoddar
            // 
            this.labelPoddar.AutoSize = true;
            this.labelPoddar.Location = new System.Drawing.Point(24, 365);
            this.labelPoddar.Name = "labelPoddar";
            this.labelPoddar.Size = new System.Drawing.Size(46, 17);
            this.labelPoddar.TabIndex = 14;
            this.labelPoddar.Text = "label1";
            // 
            // labelUrl
            // 
            this.labelUrl.AutoSize = true;
            this.labelUrl.Location = new System.Drawing.Point(24, 262);
            this.labelUrl.Name = "labelUrl";
            this.labelUrl.Size = new System.Drawing.Size(26, 17);
            this.labelUrl.TabIndex = 15;
            this.labelUrl.Text = "Url";
            // 
            // labelUpp
            // 
            this.labelUpp.AutoSize = true;
            this.labelUpp.Location = new System.Drawing.Point(258, 264);
            this.labelUpp.Name = "labelUpp";
            this.labelUpp.Size = new System.Drawing.Size(147, 17);
            this.labelUpp.TabIndex = 16;
            this.labelUpp.Text = "Uppdateringsfrekvens";
            // 
            // labelKategori
            // 
            this.labelKategori.AutoSize = true;
            this.labelKategori.Location = new System.Drawing.Point(424, 262);
            this.labelKategori.Name = "labelKategori";
            this.labelKategori.Size = new System.Drawing.Size(61, 17);
            this.labelKategori.TabIndex = 17;
            this.labelKategori.Text = "Kategori";
            // 
            // labelPoddAvs
            // 
            this.labelPoddAvs.AutoSize = true;
            this.labelPoddAvs.Location = new System.Drawing.Point(617, 365);
            this.labelPoddAvs.Name = "labelPoddAvs";
            this.labelPoddAvs.Size = new System.Drawing.Size(46, 17);
            this.labelPoddAvs.TabIndex = 18;
            this.labelPoddAvs.Text = "label1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(620, 36);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(303, 148);
            this.listBox1.TabIndex = 19;
            // 
            // PoddNamn
            // 
            this.PoddNamn.Text = "PoddNamn";
            this.PoddNamn.Width = 100;
            // 
            // Kategori
            // 
            this.Kategori.Text = "Kategori";
            // 
            // Avsnitt
            // 
            this.Avsnitt.Text = "Avsnitt";
            // 
            // Frekvens
            // 
            this.Frekvens.Text = "Frekvens";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(950, 573);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelPoddAvs);
            this.Controls.Add(this.labelKategori);
            this.Controls.Add(this.labelUpp);
            this.Controls.Add(this.labelUrl);
            this.Controls.Add(this.labelPoddar);
            this.Controls.Add(this.buttonLaggTillKat);
            this.Controls.Add(this.buttonSparaKat);
            this.Controls.Add(this.buttonTaBortKat);
            this.Controls.Add(this.buttonSparaPodd);
            this.Controls.Add(this.buttonTaBortPodd);
            this.Controls.Add(this.buttonLaggTillPodd);
            this.Controls.Add(this.textBoxKategori);
            this.Controls.Add(this.comboBoxKategori);
            this.Controls.Add(this.comboBoxUppdatering);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.textBoxAvsSammanfattning);
            this.Controls.Add(this.listViewPoddarAvsnitt);
            this.Controls.Add(this.listViewPoddar);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewPoddar;
        private System.Windows.Forms.ListView listViewPoddarAvsnitt;
        private System.Windows.Forms.TextBox textBoxAvsSammanfattning;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.ComboBox comboBoxUppdatering;
        private System.Windows.Forms.ComboBox comboBoxKategori;
        private System.Windows.Forms.TextBox textBoxKategori;
        private System.Windows.Forms.Button buttonLaggTillPodd;
        private System.Windows.Forms.Button buttonTaBortPodd;
        private System.Windows.Forms.Button buttonSparaPodd;
        private System.Windows.Forms.Button buttonTaBortKat;
        private System.Windows.Forms.Button buttonSparaKat;
        private System.Windows.Forms.Button buttonLaggTillKat;
        private System.Windows.Forms.Label labelPoddar;
        private System.Windows.Forms.Label labelUrl;
        private System.Windows.Forms.Label labelUpp;
        private System.Windows.Forms.Label labelKategori;
        private System.Windows.Forms.Label labelPoddAvs;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ColumnHeader PoddNamn;
        private System.Windows.Forms.ColumnHeader Kategori;
        private System.Windows.Forms.ColumnHeader Avsnitt;
        private System.Windows.Forms.ColumnHeader Frekvens;
    }
}

