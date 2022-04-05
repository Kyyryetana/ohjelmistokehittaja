namespace _10_kysymystä
{
    partial class kysymyksetForm
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
            this.kysymysLB = new System.Windows.Forms.Label();
            this.vastausGB = new System.Windows.Forms.GroupBox();
            this.vastausDRB = new System.Windows.Forms.RadioButton();
            this.vastausCRB = new System.Windows.Forms.RadioButton();
            this.vastausBRB = new System.Windows.Forms.RadioButton();
            this.vastausARB = new System.Windows.Forms.RadioButton();
            this.dummyRB = new System.Windows.Forms.RadioButton();
            this.vastausLB = new System.Windows.Forms.Label();
            this.vastausGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // kysymysLB
            // 
            this.kysymysLB.AutoSize = true;
            this.kysymysLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kysymysLB.Location = new System.Drawing.Point(13, 13);
            this.kysymysLB.Name = "kysymysLB";
            this.kysymysLB.Size = new System.Drawing.Size(250, 25);
            this.kysymysLB.TabIndex = 0;
            this.kysymysLB.Text = "Vastaus 1. kysymykseen";
            // 
            // vastausGB
            // 
            this.vastausGB.Controls.Add(this.vastausDRB);
            this.vastausGB.Controls.Add(this.vastausCRB);
            this.vastausGB.Controls.Add(this.vastausBRB);
            this.vastausGB.Controls.Add(this.vastausARB);
            this.vastausGB.Controls.Add(this.dummyRB);
            this.vastausGB.Location = new System.Drawing.Point(18, 53);
            this.vastausGB.Name = "vastausGB";
            this.vastausGB.Size = new System.Drawing.Size(200, 119);
            this.vastausGB.TabIndex = 1;
            this.vastausGB.TabStop = false;
            this.vastausGB.Text = "Vastaus";
            // 
            // vastausDRB
            // 
            this.vastausDRB.AutoSize = true;
            this.vastausDRB.Location = new System.Drawing.Point(6, 89);
            this.vastausDRB.Name = "vastausDRB";
            this.vastausDRB.Size = new System.Drawing.Size(33, 17);
            this.vastausDRB.TabIndex = 4;
            this.vastausDRB.TabStop = true;
            this.vastausDRB.Text = "D";
            this.vastausDRB.UseVisualStyleBackColor = true;
            // 
            // vastausCRB
            // 
            this.vastausCRB.AutoSize = true;
            this.vastausCRB.Location = new System.Drawing.Point(6, 66);
            this.vastausCRB.Name = "vastausCRB";
            this.vastausCRB.Size = new System.Drawing.Size(32, 17);
            this.vastausCRB.TabIndex = 3;
            this.vastausCRB.TabStop = true;
            this.vastausCRB.Text = "C";
            this.vastausCRB.UseVisualStyleBackColor = true;
            // 
            // vastausBRB
            // 
            this.vastausBRB.AutoSize = true;
            this.vastausBRB.Location = new System.Drawing.Point(5, 43);
            this.vastausBRB.Name = "vastausBRB";
            this.vastausBRB.Size = new System.Drawing.Size(32, 17);
            this.vastausBRB.TabIndex = 2;
            this.vastausBRB.TabStop = true;
            this.vastausBRB.Text = "B";
            this.vastausBRB.UseVisualStyleBackColor = true;
            // 
            // vastausARB
            // 
            this.vastausARB.AutoSize = true;
            this.vastausARB.Location = new System.Drawing.Point(6, 20);
            this.vastausARB.Name = "vastausARB";
            this.vastausARB.Size = new System.Drawing.Size(32, 17);
            this.vastausARB.TabIndex = 1;
            this.vastausARB.TabStop = true;
            this.vastausARB.Text = "A";
            this.vastausARB.UseVisualStyleBackColor = true;
            // 
            // dummyRB
            // 
            this.dummyRB.AutoCheck = false;
            this.dummyRB.AutoSize = true;
            this.dummyRB.Location = new System.Drawing.Point(7, 20);
            this.dummyRB.Name = "dummyRB";
            this.dummyRB.Size = new System.Drawing.Size(32, 17);
            this.dummyRB.TabIndex = 0;
            this.dummyRB.TabStop = true;
            this.dummyRB.Text = "X";
            this.dummyRB.UseVisualStyleBackColor = true;
            this.dummyRB.Visible = false;
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vastausLB.Location = new System.Drawing.Point(13, 194);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(90, 25);
            this.vastausLB.TabIndex = 2;
            this.vastausLB.Text = "Vastaus";
            this.vastausLB.Visible = false;
            // 
            // kysymyksetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 241);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.vastausGB);
            this.Controls.Add(this.kysymysLB);
            this.Name = "kysymyksetForm";
            this.Text = "10 kysymystä";
            this.Load += new System.EventHandler(this.kysymyksetForm_Load);
            this.vastausGB.ResumeLayout(false);
            this.vastausGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kysymysLB;
        private System.Windows.Forms.GroupBox vastausGB;
        private System.Windows.Forms.RadioButton vastausDRB;
        private System.Windows.Forms.RadioButton vastausCRB;
        private System.Windows.Forms.RadioButton vastausBRB;
        private System.Windows.Forms.RadioButton vastausARB;
        private System.Windows.Forms.RadioButton dummyRB;
        private System.Windows.Forms.Label vastausLB;
    }
}

