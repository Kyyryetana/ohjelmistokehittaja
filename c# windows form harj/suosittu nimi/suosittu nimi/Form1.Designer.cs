namespace suosittu_nimi
{
    partial class suosittuNimiForm
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
            this.annaNimiLB = new System.Windows.Forms.Label();
            this.vastausLB = new System.Windows.Forms.Label();
            this.annettuNimiTB = new System.Windows.Forms.TextBox();
            this.tarkistaBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // annaNimiLB
            // 
            this.annaNimiLB.AutoSize = true;
            this.annaNimiLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annaNimiLB.Location = new System.Drawing.Point(13, 13);
            this.annaNimiLB.Name = "annaNimiLB";
            this.annaNimiLB.Size = new System.Drawing.Size(660, 25);
            this.annaNimiLB.TabIndex = 0;
            this.annaNimiLB.Text = "Anna nimesi, niin tarkistan että onko se 50 suosituimman joukossa: ";
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vastausLB.Location = new System.Drawing.Point(13, 56);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(26, 25);
            this.vastausLB.TabIndex = 1;
            this.vastausLB.Text = "X";
            this.vastausLB.Visible = false;
            // 
            // annettuNimiTB
            // 
            this.annettuNimiTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annettuNimiTB.Location = new System.Drawing.Point(679, 10);
            this.annettuNimiTB.Name = "annettuNimiTB";
            this.annettuNimiTB.Size = new System.Drawing.Size(175, 31);
            this.annettuNimiTB.TabIndex = 2;
            // 
            // tarkistaBTN
            // 
            this.tarkistaBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarkistaBTN.Location = new System.Drawing.Point(679, 48);
            this.tarkistaBTN.Name = "tarkistaBTN";
            this.tarkistaBTN.Size = new System.Drawing.Size(175, 33);
            this.tarkistaBTN.TabIndex = 3;
            this.tarkistaBTN.Text = "Tarkista";
            this.tarkistaBTN.UseVisualStyleBackColor = true;
            this.tarkistaBTN.Click += new System.EventHandler(this.tarkistaBTN_Click);
            // 
            // suosittuNimiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 110);
            this.Controls.Add(this.tarkistaBTN);
            this.Controls.Add(this.annettuNimiTB);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.annaNimiLB);
            this.Name = "suosittuNimiForm";
            this.Text = "Onko nimesi suosittujen joukossa?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label annaNimiLB;
        private System.Windows.Forms.Label vastausLB;
        private System.Windows.Forms.TextBox annettuNimiTB;
        private System.Windows.Forms.Button tarkistaBTN;
    }
}

