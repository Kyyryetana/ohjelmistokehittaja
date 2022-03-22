namespace iän_laskeminen
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
            this.synttariDT = new System.Windows.Forms.DateTimePicker();
            this.LaskeBT = new System.Windows.Forms.Button();
            this.VuosissaLB = new System.Windows.Forms.Label();
            this.KuukausissaLB = new System.Windows.Forms.Label();
            this.PaivissaLB = new System.Windows.Forms.Label();
            this.TunneissaLB = new System.Windows.Forms.Label();
            this.MinuuteissaLB = new System.Windows.Forms.Label();
            this.SekunneissaLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // synttariDT
            // 
            this.synttariDT.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.synttariDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.synttariDT.Location = new System.Drawing.Point(12, 12);
            this.synttariDT.Name = "synttariDT";
            this.synttariDT.Size = new System.Drawing.Size(384, 31);
            this.synttariDT.TabIndex = 0;
            // 
            // LaskeBT
            // 
            this.LaskeBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaskeBT.Location = new System.Drawing.Point(402, 12);
            this.LaskeBT.Name = "LaskeBT";
            this.LaskeBT.Size = new System.Drawing.Size(128, 31);
            this.LaskeBT.TabIndex = 1;
            this.LaskeBT.Text = "Laske";
            this.LaskeBT.UseVisualStyleBackColor = true;
            this.LaskeBT.Click += new System.EventHandler(this.LaskeBT_Click);
            // 
            // VuosissaLB
            // 
            this.VuosissaLB.AutoSize = true;
            this.VuosissaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VuosissaLB.Location = new System.Drawing.Point(12, 59);
            this.VuosissaLB.Name = "VuosissaLB";
            this.VuosissaLB.Size = new System.Drawing.Size(23, 25);
            this.VuosissaLB.TabIndex = 2;
            this.VuosissaLB.Text = "x";
            this.VuosissaLB.Visible = false;
            // 
            // KuukausissaLB
            // 
            this.KuukausissaLB.AutoSize = true;
            this.KuukausissaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KuukausissaLB.Location = new System.Drawing.Point(12, 100);
            this.KuukausissaLB.Name = "KuukausissaLB";
            this.KuukausissaLB.Size = new System.Drawing.Size(23, 25);
            this.KuukausissaLB.TabIndex = 3;
            this.KuukausissaLB.Text = "x";
            this.KuukausissaLB.Visible = false;
            // 
            // PaivissaLB
            // 
            this.PaivissaLB.AutoSize = true;
            this.PaivissaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaivissaLB.Location = new System.Drawing.Point(12, 138);
            this.PaivissaLB.Name = "PaivissaLB";
            this.PaivissaLB.Size = new System.Drawing.Size(23, 25);
            this.PaivissaLB.TabIndex = 4;
            this.PaivissaLB.Text = "x";
            this.PaivissaLB.Visible = false;
            // 
            // TunneissaLB
            // 
            this.TunneissaLB.AutoSize = true;
            this.TunneissaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TunneissaLB.Location = new System.Drawing.Point(321, 59);
            this.TunneissaLB.Name = "TunneissaLB";
            this.TunneissaLB.Size = new System.Drawing.Size(23, 25);
            this.TunneissaLB.TabIndex = 5;
            this.TunneissaLB.Text = "x";
            this.TunneissaLB.Visible = false;
            // 
            // MinuuteissaLB
            // 
            this.MinuuteissaLB.AutoSize = true;
            this.MinuuteissaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinuuteissaLB.Location = new System.Drawing.Point(321, 100);
            this.MinuuteissaLB.Name = "MinuuteissaLB";
            this.MinuuteissaLB.Size = new System.Drawing.Size(23, 25);
            this.MinuuteissaLB.TabIndex = 6;
            this.MinuuteissaLB.Text = "x";
            this.MinuuteissaLB.Visible = false;
            // 
            // SekunneissaLB
            // 
            this.SekunneissaLB.AutoSize = true;
            this.SekunneissaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SekunneissaLB.Location = new System.Drawing.Point(321, 138);
            this.SekunneissaLB.Name = "SekunneissaLB";
            this.SekunneissaLB.Size = new System.Drawing.Size(23, 25);
            this.SekunneissaLB.TabIndex = 7;
            this.SekunneissaLB.Text = "x";
            this.SekunneissaLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 196);
            this.Controls.Add(this.SekunneissaLB);
            this.Controls.Add(this.MinuuteissaLB);
            this.Controls.Add(this.TunneissaLB);
            this.Controls.Add(this.PaivissaLB);
            this.Controls.Add(this.KuukausissaLB);
            this.Controls.Add(this.VuosissaLB);
            this.Controls.Add(this.LaskeBT);
            this.Controls.Add(this.synttariDT);
            this.Name = "Form1";
            this.Text = "Ikälaskuri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker synttariDT;
        private System.Windows.Forms.Button LaskeBT;
        private System.Windows.Forms.Label VuosissaLB;
        private System.Windows.Forms.Label KuukausissaLB;
        private System.Windows.Forms.Label PaivissaLB;
        private System.Windows.Forms.Label TunneissaLB;
        private System.Windows.Forms.Label MinuuteissaLB;
        private System.Windows.Forms.Label SekunneissaLB;
    }
}

