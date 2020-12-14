namespace Bevasarlo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMennyi = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.cbVegan = new System.Windows.Forms.CheckBox();
            this.cbGluten = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEgyeb = new System.Windows.Forms.TextBox();
            this.btnListahoz = new System.Windows.Forms.Button();
            this.listBoxTermekek = new System.Windows.Forms.CheckedListBox();
            this.btnTorles = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbGlutenSelect = new System.Windows.Forms.CheckBox();
            this.cbVeganSelect = new System.Windows.Forms.CheckBox();
            this.cbMind = new System.Windows.Forms.CheckBox();
            this.cbTipus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTermek = new System.Windows.Forms.ComboBox();
            this.labelMennyiseg = new System.Windows.Forms.Label();
            this.btnRecept = new System.Windows.Forms.Button();
            this.btnMentes = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Termék";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mennyiség";
            // 
            // tbMennyi
            // 
            this.tbMennyi.Location = new System.Drawing.Point(12, 157);
            this.tbMennyi.Name = "tbMennyi";
            this.tbMennyi.Size = new System.Drawing.Size(43, 22);
            this.tbMennyi.TabIndex = 2;
            this.tbMennyi.TextChanged += new System.EventHandler(this.tbMennyi_TextChanged);
            // 
            // btnPlus
            // 
            this.btnPlus.Enabled = false;
            this.btnPlus.Location = new System.Drawing.Point(134, 157);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(26, 25);
            this.btnPlus.TabIndex = 4;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // cbVegan
            // 
            this.cbVegan.AutoSize = true;
            this.cbVegan.Location = new System.Drawing.Point(12, 199);
            this.cbVegan.Name = "cbVegan";
            this.cbVegan.Size = new System.Drawing.Size(71, 21);
            this.cbVegan.TabIndex = 7;
            this.cbVegan.Text = "Vegán";
            this.cbVegan.UseVisualStyleBackColor = true;
            // 
            // cbGluten
            // 
            this.cbGluten.AutoSize = true;
            this.cbGluten.Location = new System.Drawing.Point(12, 226);
            this.cbGluten.Name = "cbGluten";
            this.cbGluten.Size = new System.Drawing.Size(118, 21);
            this.cbGluten.TabIndex = 8;
            this.cbGluten.Text = "Gluténmentes";
            this.cbGluten.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Egyéb jellemző";
            // 
            // tbEgyeb
            // 
            this.tbEgyeb.Location = new System.Drawing.Point(12, 284);
            this.tbEgyeb.Name = "tbEgyeb";
            this.tbEgyeb.Size = new System.Drawing.Size(266, 22);
            this.tbEgyeb.TabIndex = 9;
            // 
            // btnListahoz
            // 
            this.btnListahoz.Location = new System.Drawing.Point(12, 376);
            this.btnListahoz.Name = "btnListahoz";
            this.btnListahoz.Size = new System.Drawing.Size(114, 42);
            this.btnListahoz.TabIndex = 11;
            this.btnListahoz.Text = "Listához ad";
            this.btnListahoz.UseVisualStyleBackColor = true;
            this.btnListahoz.Click += new System.EventHandler(this.btnListahoz_Click);
            // 
            // listBoxTermekek
            // 
            this.listBoxTermekek.CheckOnClick = true;
            this.listBoxTermekek.FormattingEnabled = true;
            this.listBoxTermekek.Location = new System.Drawing.Point(375, 21);
            this.listBoxTermekek.Name = "listBoxTermekek";
            this.listBoxTermekek.Size = new System.Drawing.Size(339, 412);
            this.listBoxTermekek.TabIndex = 12;
            // 
            // btnTorles
            // 
            this.btnTorles.Location = new System.Drawing.Point(738, 172);
            this.btnTorles.Name = "btnTorles";
            this.btnTorles.Size = new System.Drawing.Size(96, 30);
            this.btnTorles.TabIndex = 13;
            this.btnTorles.Text = "Törlés";
            this.btnTorles.UseVisualStyleBackColor = true;
            this.btnTorles.Click += new System.EventHandler(this.btnTorles_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(735, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Kiválaszt:";
            // 
            // cbGlutenSelect
            // 
            this.cbGlutenSelect.AutoSize = true;
            this.cbGlutenSelect.Location = new System.Drawing.Point(738, 106);
            this.cbGlutenSelect.Name = "cbGlutenSelect";
            this.cbGlutenSelect.Size = new System.Drawing.Size(118, 21);
            this.cbGlutenSelect.TabIndex = 16;
            this.cbGlutenSelect.Text = "Gluténmentes";
            this.cbGlutenSelect.UseVisualStyleBackColor = true;
            this.cbGlutenSelect.CheckedChanged += new System.EventHandler(this.cbGlutenSelect_CheckedChanged);
            // 
            // cbVeganSelect
            // 
            this.cbVeganSelect.AutoSize = true;
            this.cbVeganSelect.Location = new System.Drawing.Point(738, 79);
            this.cbVeganSelect.Name = "cbVeganSelect";
            this.cbVeganSelect.Size = new System.Drawing.Size(71, 21);
            this.cbVeganSelect.TabIndex = 15;
            this.cbVeganSelect.Text = "Vegán";
            this.cbVeganSelect.UseVisualStyleBackColor = true;
            this.cbVeganSelect.CheckedChanged += new System.EventHandler(this.cbVeganSelect_CheckedChanged);
            // 
            // cbMind
            // 
            this.cbMind.AutoSize = true;
            this.cbMind.Location = new System.Drawing.Point(738, 52);
            this.cbMind.Name = "cbMind";
            this.cbMind.Size = new System.Drawing.Size(60, 21);
            this.cbMind.TabIndex = 20;
            this.cbMind.Text = "Mind";
            this.cbMind.UseVisualStyleBackColor = true;
            this.cbMind.CheckedChanged += new System.EventHandler(this.cbMind_CheckedChanged);
            // 
            // cbTipus
            // 
            this.cbTipus.FormattingEnabled = true;
            this.cbTipus.Location = new System.Drawing.Point(12, 41);
            this.cbTipus.Name = "cbTipus";
            this.cbTipus.Size = new System.Drawing.Size(190, 24);
            this.cbTipus.TabIndex = 21;
            this.cbTipus.SelectedIndexChanged += new System.EventHandler(this.cbTipus_SelectedIndexChanged);
            this.cbTipus.TextUpdate += new System.EventHandler(this.cbTipus_TextUpdate);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Típus";
            // 
            // cbTermek
            // 
            this.cbTermek.FormattingEnabled = true;
            this.cbTermek.Location = new System.Drawing.Point(12, 103);
            this.cbTermek.Name = "cbTermek";
            this.cbTermek.Size = new System.Drawing.Size(190, 24);
            this.cbTermek.TabIndex = 23;
            this.cbTermek.SelectedIndexChanged += new System.EventHandler(this.cbTermek_SelectedIndexChanged);
            this.cbTermek.TextUpdate += new System.EventHandler(this.cbTermek_TextUpdate);
            // 
            // labelMennyiseg
            // 
            this.labelMennyiseg.AutoSize = true;
            this.labelMennyiseg.Location = new System.Drawing.Point(61, 162);
            this.labelMennyiseg.Name = "labelMennyiseg";
            this.labelMennyiseg.Size = new System.Drawing.Size(23, 17);
            this.labelMennyiseg.TabIndex = 24;
            this.labelMennyiseg.Text = "kg";
            // 
            // btnRecept
            // 
            this.btnRecept.Location = new System.Drawing.Point(143, 376);
            this.btnRecept.Name = "btnRecept";
            this.btnRecept.Size = new System.Drawing.Size(135, 42);
            this.btnRecept.TabIndex = 25;
            this.btnRecept.Text = "Recept betöltés";
            this.btnRecept.UseVisualStyleBackColor = true;
            this.btnRecept.Click += new System.EventHandler(this.btnRecept_Click);
            // 
            // btnMentes
            // 
            this.btnMentes.Location = new System.Drawing.Point(738, 226);
            this.btnMentes.Name = "btnMentes";
            this.btnMentes.Size = new System.Drawing.Size(96, 30);
            this.btnMentes.TabIndex = 27;
            this.btnMentes.Text = "Mentés";
            this.btnMentes.UseVisualStyleBackColor = true;
            this.btnMentes.Click += new System.EventHandler(this.btnMentes_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Enabled = false;
            this.btnMinus.Location = new System.Drawing.Point(176, 156);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(26, 25);
            this.btnMinus.TabIndex = 28;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 450);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnMentes);
            this.Controls.Add(this.btnRecept);
            this.Controls.Add(this.labelMennyiseg);
            this.Controls.Add(this.cbTermek);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbTipus);
            this.Controls.Add(this.cbMind);
            this.Controls.Add(this.cbGlutenSelect);
            this.Controls.Add(this.cbVeganSelect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTorles);
            this.Controls.Add(this.listBoxTermekek);
            this.Controls.Add(this.btnListahoz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbEgyeb);
            this.Controls.Add(this.cbGluten);
            this.Controls.Add(this.cbVegan);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMennyi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMennyi;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.CheckBox cbVegan;
        private System.Windows.Forms.CheckBox cbGluten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEgyeb;
        private System.Windows.Forms.Button btnListahoz;
        private System.Windows.Forms.CheckedListBox listBoxTermekek;
        private System.Windows.Forms.Button btnTorles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbGlutenSelect;
        private System.Windows.Forms.CheckBox cbVeganSelect;
        private System.Windows.Forms.CheckBox cbMind;
        private System.Windows.Forms.ComboBox cbTipus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTermek;
        private System.Windows.Forms.Label labelMennyiseg;
        private System.Windows.Forms.Button btnRecept;
        private System.Windows.Forms.Button btnMentes;
        private System.Windows.Forms.Button btnMinus;
    }
}

