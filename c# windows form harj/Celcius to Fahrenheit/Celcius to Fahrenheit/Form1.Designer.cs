namespace Celcius_to_Fahrenheit
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
            this.annaAsteetLB = new System.Windows.Forms.Label();
            this.vastausLB = new System.Windows.Forms.Label();
            this.mitenMuunnatLB = new System.Windows.Forms.Label();
            this.asteetTB = new System.Windows.Forms.TextBox();
            this.celciusRB = new System.Windows.Forms.RadioButton();
            this.fahrenheitRB = new System.Windows.Forms.RadioButton();
            this.muunnaBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // annaAsteetLB
            // 
            this.annaAsteetLB.AutoSize = true;
            this.annaAsteetLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annaAsteetLB.Location = new System.Drawing.Point(12, 54);
            this.annaAsteetLB.Name = "annaAsteetLB";
            this.annaAsteetLB.Size = new System.Drawing.Size(133, 25);
            this.annaAsteetLB.TabIndex = 0;
            this.annaAsteetLB.Text = "Anna asteet:";
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vastausLB.Location = new System.Drawing.Point(12, 155);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(26, 25);
            this.vastausLB.TabIndex = 1;
            this.vastausLB.Text = "X";
            this.vastausLB.Visible = false;
            // 
            // mitenMuunnatLB
            // 
            this.mitenMuunnatLB.AutoSize = true;
            this.mitenMuunnatLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mitenMuunnatLB.Location = new System.Drawing.Point(294, 9);
            this.mitenMuunnatLB.Name = "mitenMuunnatLB";
            this.mitenMuunnatLB.Size = new System.Drawing.Size(166, 25);
            this.mitenMuunnatLB.TabIndex = 2;
            this.mitenMuunnatLB.Text = "Miten muunnat?";
            // 
            // asteetTB
            // 
            this.asteetTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asteetTB.Location = new System.Drawing.Point(151, 51);
            this.asteetTB.Name = "asteetTB";
            this.asteetTB.Size = new System.Drawing.Size(100, 31);
            this.asteetTB.TabIndex = 3;
            // 
            // celciusRB
            // 
            this.celciusRB.AutoSize = true;
            this.celciusRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celciusRB.Location = new System.Drawing.Point(299, 54);
            this.celciusRB.Name = "celciusRB";
            this.celciusRB.Size = new System.Drawing.Size(151, 29);
            this.celciusRB.TabIndex = 4;
            this.celciusRB.TabStop = true;
            this.celciusRB.Text = "Celciukseksi";
            this.celciusRB.UseVisualStyleBackColor = true;
            // 
            // fahrenheitRB
            // 
            this.fahrenheitRB.AutoSize = true;
            this.fahrenheitRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fahrenheitRB.Location = new System.Drawing.Point(299, 98);
            this.fahrenheitRB.Name = "fahrenheitRB";
            this.fahrenheitRB.Size = new System.Drawing.Size(165, 29);
            this.fahrenheitRB.TabIndex = 5;
            this.fahrenheitRB.TabStop = true;
            this.fahrenheitRB.Text = "Fahrenheitiksi";
            this.fahrenheitRB.UseVisualStyleBackColor = true;
            // 
            // muunnaBTN
            // 
            this.muunnaBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muunnaBTN.Location = new System.Drawing.Point(525, 54);
            this.muunnaBTN.Name = "muunnaBTN";
            this.muunnaBTN.Size = new System.Drawing.Size(130, 32);
            this.muunnaBTN.TabIndex = 6;
            this.muunnaBTN.Text = "Muunna";
            this.muunnaBTN.UseVisualStyleBackColor = true;
            this.muunnaBTN.Click += new System.EventHandler(this.muunnaBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(692, 213);
            this.Controls.Add(this.muunnaBTN);
            this.Controls.Add(this.fahrenheitRB);
            this.Controls.Add(this.celciusRB);
            this.Controls.Add(this.asteetTB);
            this.Controls.Add(this.mitenMuunnatLB);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.annaAsteetLB);
            this.Name = "Form1";
            this.Text = "Celcius to Fahrenheit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label annaAsteetLB;
        private System.Windows.Forms.Label vastausLB;
        private System.Windows.Forms.Label mitenMuunnatLB;
        private System.Windows.Forms.TextBox asteetTB;
        private System.Windows.Forms.RadioButton celciusRB;
        private System.Windows.Forms.RadioButton fahrenheitRB;
        private System.Windows.Forms.Button muunnaBTN;
    }
}

