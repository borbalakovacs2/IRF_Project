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
            this.textBoxTermek = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMennyi = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.cbVegan = new System.Windows.Forms.CheckBox();
            this.cbGluten = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxTermekek = new System.Windows.Forms.CheckedListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxTermek
            // 
            this.textBoxTermek.Location = new System.Drawing.Point(12, 41);
            this.textBoxTermek.Name = "textBoxTermek";
            this.textBoxTermek.Size = new System.Drawing.Size(190, 22);
            this.textBoxTermek.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
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
            // textBoxMennyi
            // 
            this.textBoxMennyi.Location = new System.Drawing.Point(12, 157);
            this.textBoxMennyi.Name = "textBoxMennyi";
            this.textBoxMennyi.Size = new System.Drawing.Size(56, 22);
            this.textBoxMennyi.TabIndex = 2;
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(74, 156);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(23, 23);
            this.btnPlus.TabIndex = 4;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(103, 156);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(23, 23);
            this.btnMinus.TabIndex = 5;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 284);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 22);
            this.textBox1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 42);
            this.button1.TabIndex = 11;
            this.button1.Text = "Listához ad";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxTermekek
            // 
            this.listBoxTermekek.FormattingEnabled = true;
            this.listBoxTermekek.Location = new System.Drawing.Point(289, 21);
            this.listBoxTermekek.Name = "listBoxTermekek";
            this.listBoxTermekek.Size = new System.Drawing.Size(339, 412);
            this.listBoxTermekek.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(652, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 30);
            this.button2.TabIndex = 13;
            this.button2.Text = "Törlés";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(649, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Kiválaszt:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(652, 106);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(118, 21);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Gluténmentes";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(652, 79);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(71, 21);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "Vegán";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(652, 133);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(93, 21);
            this.checkBox3.TabIndex = 17;
            this.checkBox3.Text = "Tejtermék";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(652, 160);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(97, 21);
            this.checkBox4.TabIndex = 18;
            this.checkBox4.Text = "Péktermék";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(651, 187);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(102, 21);
            this.checkBox5.TabIndex = 19;
            this.checkBox5.Text = "Tisztítószer";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(652, 52);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(60, 21);
            this.checkBox6.TabIndex = 20;
            this.checkBox6.Text = "Mind";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 103);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(190, 24);
            this.comboBox1.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Típus";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBoxTermekek);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbGluten);
            this.Controls.Add(this.cbVegan);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMennyi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTermek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTermek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMennyi;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.CheckBox cbVegan;
        private System.Windows.Forms.CheckBox cbGluten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox listBoxTermekek;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
    }
}

