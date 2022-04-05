namespace Päiväkirja
{
    partial class diaryForm
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
            this.syottoTB = new System.Windows.Forms.TextBox();
            this.tallennaBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // syottoTB
            // 
            this.syottoTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.syottoTB.Location = new System.Drawing.Point(3, 3);
            this.syottoTB.Multiline = true;
            this.syottoTB.Name = "syottoTB";
            this.syottoTB.Size = new System.Drawing.Size(459, 394);
            this.syottoTB.TabIndex = 0;
            // 
            // tallennaBTN
            // 
            this.tallennaBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tallennaBTN.Location = new System.Drawing.Point(3, 403);
            this.tallennaBTN.Name = "tallennaBTN";
            this.tallennaBTN.Size = new System.Drawing.Size(459, 35);
            this.tallennaBTN.TabIndex = 1;
            this.tallennaBTN.Text = "Tallenna päiväkirjaan";
            this.tallennaBTN.UseVisualStyleBackColor = true;
            this.tallennaBTN.Click += new System.EventHandler(this.tallennaBTN_Click);
            // 
            // diaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 445);
            this.Controls.Add(this.tallennaBTN);
            this.Controls.Add(this.syottoTB);
            this.Name = "diaryForm";
            this.Text = "Päiväkirja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox syottoTB;
        private System.Windows.Forms.Button tallennaBTN;
    }
}

