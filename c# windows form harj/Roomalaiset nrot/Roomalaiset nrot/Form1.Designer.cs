namespace Roomalaiset_nrot
{
    partial class form
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
            this.otsikkoLB = new System.Windows.Forms.Label();
            this.ohjeLB = new System.Windows.Forms.Label();
            this.numeroTB = new System.Windows.Forms.TextBox();
            this.muutaBTN = new System.Windows.Forms.Button();
            this.vastausLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // otsikkoLB
            // 
            this.otsikkoLB.AutoSize = true;
            this.otsikkoLB.BackColor = System.Drawing.Color.White;
            this.otsikkoLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otsikkoLB.Location = new System.Drawing.Point(12, 9);
            this.otsikkoLB.Name = "otsikkoLB";
            this.otsikkoLB.Size = new System.Drawing.Size(642, 73);
            this.otsikkoLB.TabIndex = 0;
            this.otsikkoLB.Text = "Roomalaiset numerot";
            // 
            // ohjeLB
            // 
            this.ohjeLB.AutoSize = true;
            this.ohjeLB.BackColor = System.Drawing.Color.White;
            this.ohjeLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ohjeLB.Location = new System.Drawing.Point(12, 98);
            this.ohjeLB.Name = "ohjeLB";
            this.ohjeLB.Size = new System.Drawing.Size(595, 24);
            this.ohjeLB.TabIndex = 1;
            this.ohjeLB.Text = "Anna numero välillä 1-3999, niin muutan sen roomalaisiksi numeroiksi:";
            // 
            // numeroTB
            // 
            this.numeroTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroTB.Location = new System.Drawing.Point(613, 98);
            this.numeroTB.Name = "numeroTB";
            this.numeroTB.Size = new System.Drawing.Size(133, 29);
            this.numeroTB.TabIndex = 2;
            // 
            // muutaBTN
            // 
            this.muutaBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muutaBTN.Location = new System.Drawing.Point(613, 133);
            this.muutaBTN.Name = "muutaBTN";
            this.muutaBTN.Size = new System.Drawing.Size(133, 38);
            this.muutaBTN.TabIndex = 3;
            this.muutaBTN.Text = "Muuta";
            this.muutaBTN.UseVisualStyleBackColor = true;
            this.muutaBTN.Click += new System.EventHandler(this.MuutaBtn_Click);
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vastausLB.Location = new System.Drawing.Point(13, 133);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(44, 42);
            this.vastausLB.TabIndex = 4;
            this.vastausLB.Text = "X";
            this.vastausLB.Visible = false;
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(773, 228);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.muutaBTN);
            this.Controls.Add(this.numeroTB);
            this.Controls.Add(this.ohjeLB);
            this.Controls.Add(this.otsikkoLB);
            this.Name = "form";
            this.Text = "Roomalaiset numerot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label otsikkoLB;
        private System.Windows.Forms.Label ohjeLB;
        private System.Windows.Forms.TextBox numeroTB;
        private System.Windows.Forms.Button muutaBTN;
        private System.Windows.Forms.Label vastausLB;
    }
}

