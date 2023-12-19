namespace SAE_Projekt_Auto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btSpeichern = new System.Windows.Forms.Button();
            this.btSuchen = new System.Windows.Forms.Button();
            this.tbMarke = new System.Windows.Forms.TextBox();
            this.tbModell = new System.Windows.Forms.TextBox();
            this.tbKilometerstand = new System.Windows.Forms.TextBox();
            this.tbBaujahr = new System.Windows.Forms.TextBox();
            this.tbPreis = new System.Windows.Forms.TextBox();
            this.rtbHauptausgabe = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rtbAusgabe = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btSpeichern
            // 
            this.btSpeichern.Location = new System.Drawing.Point(21, 159);
            this.btSpeichern.Name = "btSpeichern";
            this.btSpeichern.Size = new System.Drawing.Size(75, 23);
            this.btSpeichern.TabIndex = 0;
            this.btSpeichern.Text = "Speichern";
            this.btSpeichern.UseVisualStyleBackColor = true;
            this.btSpeichern.Click += new System.EventHandler(this.btSpeichern_Click);
            // 
            // btSuchen
            // 
            this.btSuchen.BackColor = System.Drawing.Color.Gainsboro;
            this.btSuchen.Location = new System.Drawing.Point(21, 263);
            this.btSuchen.Name = "btSuchen";
            this.btSuchen.Size = new System.Drawing.Size(75, 23);
            this.btSuchen.TabIndex = 1;
            this.btSuchen.Text = "Suchen";
            this.btSuchen.UseVisualStyleBackColor = false;
            this.btSuchen.Click += new System.EventHandler(this.btSuchen_Click);
            // 
            // tbMarke
            // 
            this.tbMarke.BackColor = System.Drawing.Color.White;
            this.tbMarke.Location = new System.Drawing.Point(131, 68);
            this.tbMarke.Name = "tbMarke";
            this.tbMarke.Size = new System.Drawing.Size(100, 23);
            this.tbMarke.TabIndex = 3;
            // 
            // tbModell
            // 
            this.tbModell.BackColor = System.Drawing.Color.White;
            this.tbModell.Location = new System.Drawing.Point(262, 68);
            this.tbModell.Name = "tbModell";
            this.tbModell.Size = new System.Drawing.Size(100, 23);
            this.tbModell.TabIndex = 4;
            // 
            // tbKilometerstand
            // 
            this.tbKilometerstand.BackColor = System.Drawing.Color.White;
            this.tbKilometerstand.Location = new System.Drawing.Point(392, 68);
            this.tbKilometerstand.Name = "tbKilometerstand";
            this.tbKilometerstand.Size = new System.Drawing.Size(100, 23);
            this.tbKilometerstand.TabIndex = 5;
            // 
            // tbBaujahr
            // 
            this.tbBaujahr.BackColor = System.Drawing.Color.White;
            this.tbBaujahr.Location = new System.Drawing.Point(517, 68);
            this.tbBaujahr.Name = "tbBaujahr";
            this.tbBaujahr.Size = new System.Drawing.Size(100, 23);
            this.tbBaujahr.TabIndex = 6;
            // 
            // tbPreis
            // 
            this.tbPreis.BackColor = System.Drawing.Color.White;
            this.tbPreis.Location = new System.Drawing.Point(641, 68);
            this.tbPreis.Name = "tbPreis";
            this.tbPreis.Size = new System.Drawing.Size(100, 23);
            this.tbPreis.TabIndex = 7;
            // 
            // rtbHauptausgabe
            // 
            this.rtbHauptausgabe.BackColor = System.Drawing.Color.White;
            this.rtbHauptausgabe.Location = new System.Drawing.Point(131, 112);
            this.rtbHauptausgabe.Name = "rtbHauptausgabe";
            this.rtbHauptausgabe.Size = new System.Drawing.Size(610, 257);
            this.rtbHauptausgabe.TabIndex = 8;
            this.rtbHauptausgabe.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Marke";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Modell";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Killometerstand";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(541, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Baujahr";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(675, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Preis";
            // 
            // rtbAusgabe
            // 
            this.rtbAusgabe.BackColor = System.Drawing.Color.White;
            this.rtbAusgabe.Location = new System.Drawing.Point(131, 396);
            this.rtbAusgabe.Name = "rtbAusgabe";
            this.rtbAusgabe.Size = new System.Drawing.Size(610, 39);
            this.rtbAusgabe.TabIndex = 14;
            this.rtbAusgabe.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtbAusgabe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbHauptausgabe);
            this.Controls.Add(this.tbPreis);
            this.Controls.Add(this.tbBaujahr);
            this.Controls.Add(this.tbKilometerstand);
            this.Controls.Add(this.tbModell);
            this.Controls.Add(this.tbMarke);
            this.Controls.Add(this.btSuchen);
            this.Controls.Add(this.btSpeichern);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Gebrauchtwagen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btSpeichern;
        private Button btSuchen;
        private TextBox tbMarke;
        private TextBox tbModell;
        private TextBox tbKilometerstand;
        private TextBox tbBaujahr;
        private TextBox tbPreis;
        private RichTextBox rtbHauptausgabe;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private RichTextBox rtbAusgabe;
        private Label label6;
    }
}