namespace Nopan_heitto
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
            this.heitaLB = new System.Windows.Forms.Label();
            this.heitaBTN = new System.Windows.Forms.Button();
            this.noppa02PB = new System.Windows.Forms.PictureBox();
            this.noppa01PB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.noppa02PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noppa01PB)).BeginInit();
            this.SuspendLayout();
            // 
            // heitaLB
            // 
            this.heitaLB.AutoSize = true;
            this.heitaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heitaLB.Location = new System.Drawing.Point(5, 9);
            this.heitaLB.Name = "heitaLB";
            this.heitaLB.Size = new System.Drawing.Size(224, 39);
            this.heitaLB.TabIndex = 0;
            this.heitaLB.Text = "Nopan heitto";
            // 
            // heitaBTN
            // 
            this.heitaBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heitaBTN.Location = new System.Drawing.Point(12, 175);
            this.heitaBTN.Name = "heitaBTN";
            this.heitaBTN.Size = new System.Drawing.Size(206, 36);
            this.heitaBTN.TabIndex = 3;
            this.heitaBTN.Text = "Heitä";
            this.heitaBTN.UseVisualStyleBackColor = true;
            this.heitaBTN.Click += new System.EventHandler(this.heitaBTN_Click);
            // 
            // noppa02PB
            // 
            this.noppa02PB.Image = global::Nopan_heitto.Properties.Resources.noppaanime;
            this.noppa02PB.Location = new System.Drawing.Point(118, 64);
            this.noppa02PB.Name = "noppa02PB";
            this.noppa02PB.Size = new System.Drawing.Size(100, 92);
            this.noppa02PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.noppa02PB.TabIndex = 2;
            this.noppa02PB.TabStop = false;
            // 
            // noppa01PB
            // 
            this.noppa01PB.Image = global::Nopan_heitto.Properties.Resources.noppaanime;
            this.noppa01PB.Location = new System.Drawing.Point(12, 64);
            this.noppa01PB.Name = "noppa01PB";
            this.noppa01PB.Size = new System.Drawing.Size(100, 92);
            this.noppa01PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.noppa01PB.TabIndex = 1;
            this.noppa01PB.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.heitaBTN);
            this.Controls.Add(this.noppa02PB);
            this.Controls.Add(this.noppa01PB);
            this.Controls.Add(this.heitaLB);
            this.Name = "Form1";
            this.Text = "Heitä noppaa";
            ((System.ComponentModel.ISupportInitialize)(this.noppa02PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noppa01PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label heitaLB;
        private System.Windows.Forms.PictureBox noppa01PB;
        private System.Windows.Forms.PictureBox noppa02PB;
        private System.Windows.Forms.Button heitaBTN;
    }
}

