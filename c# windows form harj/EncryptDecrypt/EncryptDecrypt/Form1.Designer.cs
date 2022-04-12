namespace EncryptDecrypt
{
    partial class salasanaForm
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
            this.salasanaLB = new System.Windows.Forms.Label();
            this.cryptattuLB = new System.Windows.Forms.Label();
            this.vastausLB = new System.Windows.Forms.Label();
            this.salasanaTB = new System.Windows.Forms.TextBox();
            this.cryptattuTB = new System.Windows.Forms.TextBox();
            this.cryptaaBTN = new System.Windows.Forms.Button();
            this.salasanaBTN = new System.Windows.Forms.Button();
            this.tyhjaaBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // salasanaLB
            // 
            this.salasanaLB.AutoSize = true;
            this.salasanaLB.Location = new System.Drawing.Point(12, 20);
            this.salasanaLB.Name = "salasanaLB";
            this.salasanaLB.Size = new System.Drawing.Size(108, 25);
            this.salasanaLB.TabIndex = 0;
            this.salasanaLB.Text = "Salasana:";
            // 
            // cryptattuLB
            // 
            this.cryptattuLB.AutoSize = true;
            this.cryptattuLB.Location = new System.Drawing.Point(13, 78);
            this.cryptattuLB.Name = "cryptattuLB";
            this.cryptattuLB.Size = new System.Drawing.Size(105, 25);
            this.cryptattuLB.TabIndex = 1;
            this.cryptattuLB.Text = "Cryptattu:";
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Location = new System.Drawing.Point(13, 137);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(87, 25);
            this.vastausLB.TabIndex = 2;
            this.vastausLB.Text = "vastaus";
            this.vastausLB.Visible = false;
            // 
            // salasanaTB
            // 
            this.salasanaTB.Location = new System.Drawing.Point(126, 14);
            this.salasanaTB.Name = "salasanaTB";
            this.salasanaTB.Size = new System.Drawing.Size(337, 31);
            this.salasanaTB.TabIndex = 3;
            // 
            // cryptattuTB
            // 
            this.cryptattuTB.Location = new System.Drawing.Point(126, 72);
            this.cryptattuTB.Name = "cryptattuTB";
            this.cryptattuTB.Size = new System.Drawing.Size(337, 31);
            this.cryptattuTB.TabIndex = 4;
            // 
            // cryptaaBTN
            // 
            this.cryptaaBTN.Location = new System.Drawing.Point(503, 12);
            this.cryptaaBTN.Name = "cryptaaBTN";
            this.cryptaaBTN.Size = new System.Drawing.Size(184, 33);
            this.cryptaaBTN.TabIndex = 5;
            this.cryptaaBTN.Text = "Cryptaa";
            this.cryptaaBTN.UseVisualStyleBackColor = true;
            this.cryptaaBTN.Click += new System.EventHandler(this.cryptaaBTN_Click);
            // 
            // salasanaBTN
            // 
            this.salasanaBTN.Location = new System.Drawing.Point(503, 70);
            this.salasanaBTN.Name = "salasanaBTN";
            this.salasanaBTN.Size = new System.Drawing.Size(184, 33);
            this.salasanaBTN.TabIndex = 6;
            this.salasanaBTN.Text = "Näytä salasana";
            this.salasanaBTN.UseVisualStyleBackColor = true;
            this.salasanaBTN.Click += new System.EventHandler(this.salasanaBTN_Click);
            // 
            // tyhjaaBTN
            // 
            this.tyhjaaBTN.Location = new System.Drawing.Point(503, 129);
            this.tyhjaaBTN.Name = "tyhjaaBTN";
            this.tyhjaaBTN.Size = new System.Drawing.Size(184, 33);
            this.tyhjaaBTN.TabIndex = 7;
            this.tyhjaaBTN.Text = "Tyhjennä";
            this.tyhjaaBTN.UseVisualStyleBackColor = true;
            this.tyhjaaBTN.Click += new System.EventHandler(this.tyhjaaBTN_Click);
            // 
            // salasanaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 212);
            this.Controls.Add(this.tyhjaaBTN);
            this.Controls.Add(this.salasanaBTN);
            this.Controls.Add(this.cryptaaBTN);
            this.Controls.Add(this.cryptattuTB);
            this.Controls.Add(this.salasanaTB);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.cryptattuLB);
            this.Controls.Add(this.salasanaLB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "salasanaForm";
            this.Text = "Encrypt Decrypt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label salasanaLB;
        private System.Windows.Forms.Label cryptattuLB;
        private System.Windows.Forms.Label vastausLB;
        private System.Windows.Forms.TextBox salasanaTB;
        private System.Windows.Forms.TextBox cryptattuTB;
        private System.Windows.Forms.Button cryptaaBTN;
        private System.Windows.Forms.Button salasanaBTN;
        private System.Windows.Forms.Button tyhjaaBTN;
    }
}

