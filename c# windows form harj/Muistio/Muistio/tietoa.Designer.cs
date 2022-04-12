namespace Muistio
{
    partial class tietoa
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
            this.nimiLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nimiLB
            // 
            this.nimiLB.AutoSize = true;
            this.nimiLB.Font = new System.Drawing.Font("Magneto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nimiLB.Location = new System.Drawing.Point(13, 13);
            this.nimiLB.Name = "nimiLB";
            this.nimiLB.Size = new System.Drawing.Size(604, 58);
            this.nimiLB.TabIndex = 0;
            this.nimiLB.Text = "Tehnyt: Niko Alander";
            // 
            // tietoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nimiLB);
            this.Name = "tietoa";
            this.Text = "tietoa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nimiLB;
    }
}