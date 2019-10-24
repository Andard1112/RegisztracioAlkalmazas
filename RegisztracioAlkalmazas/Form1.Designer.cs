namespace RegisztracioAlkalmazas
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
            this.nev = new System.Windows.Forms.TextBox();
            this.f = new System.Windows.Forms.RadioButton();
            this.n = new System.Windows.Forms.RadioButton();
            this.hobbik = new System.Windows.Forms.ListBox();
            this.ujhobbi = new System.Windows.Forms.TextBox();
            this.hozzaad = new System.Windows.Forms.Button();
            this.betoltes = new System.Windows.Forms.Button();
            this.mentes = new System.Windows.Forms.Button();
            this.neviras = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.szuldatum = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // nev
            // 
            this.nev.Location = new System.Drawing.Point(108, 13);
            this.nev.Name = "nev";
            this.nev.Size = new System.Drawing.Size(100, 22);
            this.nev.TabIndex = 0;
            this.nev.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // f
            // 
            this.f.AutoSize = true;
            this.f.Location = new System.Drawing.Point(108, 71);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(37, 21);
            this.f.TabIndex = 2;
            this.f.TabStop = true;
            this.f.Text = "F";
            this.f.UseVisualStyleBackColor = true;
            this.f.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // n
            // 
            this.n.AutoSize = true;
            this.n.Location = new System.Drawing.Point(169, 71);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(39, 21);
            this.n.TabIndex = 3;
            this.n.TabStop = true;
            this.n.Text = "N";
            this.n.UseVisualStyleBackColor = true;
            this.n.CheckedChanged += new System.EventHandler(this.N_CheckedChanged);
            // 
            // hobbik
            // 
            this.hobbik.FormattingEnabled = true;
            this.hobbik.ItemHeight = 16;
            this.hobbik.Location = new System.Drawing.Point(218, 41);
            this.hobbik.Name = "hobbik";
            this.hobbik.Size = new System.Drawing.Size(120, 84);
            this.hobbik.TabIndex = 4;
            this.hobbik.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // ujhobbi
            // 
            this.ujhobbi.Location = new System.Drawing.Point(238, 141);
            this.ujhobbi.Name = "ujhobbi";
            this.ujhobbi.Size = new System.Drawing.Size(100, 22);
            this.ujhobbi.TabIndex = 5;
            // 
            // hozzaad
            // 
            this.hozzaad.Location = new System.Drawing.Point(263, 169);
            this.hozzaad.Name = "hozzaad";
            this.hozzaad.Size = new System.Drawing.Size(75, 23);
            this.hozzaad.TabIndex = 6;
            this.hozzaad.Text = "Hozzáad";
            this.hozzaad.UseVisualStyleBackColor = true;
            this.hozzaad.Click += new System.EventHandler(this.Hozzaad_Click);
            // 
            // betoltes
            // 
            this.betoltes.Location = new System.Drawing.Point(263, 219);
            this.betoltes.Name = "betoltes";
            this.betoltes.Size = new System.Drawing.Size(75, 23);
            this.betoltes.TabIndex = 7;
            this.betoltes.Text = "Betöltés";
            this.betoltes.UseVisualStyleBackColor = true;
            this.betoltes.Click += new System.EventHandler(this.Betoltes_Click);
            // 
            // mentes
            // 
            this.mentes.Location = new System.Drawing.Point(159, 219);
            this.mentes.Name = "mentes";
            this.mentes.Size = new System.Drawing.Size(75, 23);
            this.mentes.TabIndex = 8;
            this.mentes.Text = "Mentés";
            this.mentes.UseVisualStyleBackColor = true;
            this.mentes.Click += new System.EventHandler(this.Mentes_Click);
            // 
            // neviras
            // 
            this.neviras.AutoSize = true;
            this.neviras.Location = new System.Drawing.Point(13, 13);
            this.neviras.Name = "neviras";
            this.neviras.Size = new System.Drawing.Size(37, 17);
            this.neviras.TabIndex = 9;
            this.neviras.Text = "Név:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Szül. dátum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Kedvenc hobbi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Új hobbi:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialog1_FileOk);
            // 
            // szuldatum
            // 
            this.szuldatum.Location = new System.Drawing.Point(108, 39);
            this.szuldatum.Mask = "0000/00/00";
            this.szuldatum.Name = "szuldatum";
            this.szuldatum.Size = new System.Drawing.Size(100, 22);
            this.szuldatum.TabIndex = 13;
            this.szuldatum.ValidatingType = typeof(System.DateTime);
            this.szuldatum.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MaskedTextBox1_MaskInputRejected);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 258);
            this.Controls.Add(this.szuldatum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.neviras);
            this.Controls.Add(this.mentes);
            this.Controls.Add(this.betoltes);
            this.Controls.Add(this.hozzaad);
            this.Controls.Add(this.ujhobbi);
            this.Controls.Add(this.hobbik);
            this.Controls.Add(this.n);
            this.Controls.Add(this.f);
            this.Controls.Add(this.nev);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nev;
        private System.Windows.Forms.RadioButton f;
        private System.Windows.Forms.RadioButton n;
        private System.Windows.Forms.ListBox hobbik;
        private System.Windows.Forms.TextBox ujhobbi;
        private System.Windows.Forms.Button hozzaad;
        private System.Windows.Forms.Button betoltes;
        private System.Windows.Forms.Button mentes;
        private System.Windows.Forms.Label neviras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MaskedTextBox szuldatum;
    }
}

