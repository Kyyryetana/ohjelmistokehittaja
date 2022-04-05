namespace Sekuntikello
{
    partial class sekuntikelloForm
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
            this.components = new System.ComponentModel.Container();
            this.aikaLB = new System.Windows.Forms.Label();
            this.kaynnistaBTN = new System.Windows.Forms.Button();
            this.lopetaBTN = new System.Windows.Forms.Button();
            this.tyhjennaBTN = new System.Windows.Forms.Button();
            this.ajanottoTM = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // aikaLB
            // 
            this.aikaLB.AutoSize = true;
            this.aikaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aikaLB.Location = new System.Drawing.Point(13, 13);
            this.aikaLB.Name = "aikaLB";
            this.aikaLB.Size = new System.Drawing.Size(410, 73);
            this.aikaLB.TabIndex = 0;
            this.aikaLB.Text = "00:00:00:000";
            // 
            // kaynnistaBTN
            // 
            this.kaynnistaBTN.Location = new System.Drawing.Point(26, 101);
            this.kaynnistaBTN.Name = "kaynnistaBTN";
            this.kaynnistaBTN.Size = new System.Drawing.Size(127, 34);
            this.kaynnistaBTN.TabIndex = 1;
            this.kaynnistaBTN.Text = "Käynnistä";
            this.kaynnistaBTN.UseVisualStyleBackColor = true;
            this.kaynnistaBTN.Click += new System.EventHandler(this.kaynnistaBTN_Click);
            // 
            // lopetaBTN
            // 
            this.lopetaBTN.Location = new System.Drawing.Point(161, 101);
            this.lopetaBTN.Name = "lopetaBTN";
            this.lopetaBTN.Size = new System.Drawing.Size(127, 34);
            this.lopetaBTN.TabIndex = 2;
            this.lopetaBTN.Text = "Lopeta";
            this.lopetaBTN.UseVisualStyleBackColor = true;
            this.lopetaBTN.Click += new System.EventHandler(this.lopetaBTN_Click);
            // 
            // tyhjennaBTN
            // 
            this.tyhjennaBTN.Location = new System.Drawing.Point(296, 101);
            this.tyhjennaBTN.Name = "tyhjennaBTN";
            this.tyhjennaBTN.Size = new System.Drawing.Size(127, 34);
            this.tyhjennaBTN.TabIndex = 3;
            this.tyhjennaBTN.Text = "Tyhjennä";
            this.tyhjennaBTN.UseVisualStyleBackColor = true;
            this.tyhjennaBTN.Click += new System.EventHandler(this.tyhjennaBTN_Click);
            // 
            // ajanottoTM
            // 
            this.ajanottoTM.Enabled = true;
            this.ajanottoTM.Tick += new System.EventHandler(this.ajanottoTM_Tick);
            // 
            // sekuntikelloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 171);
            this.Controls.Add(this.tyhjennaBTN);
            this.Controls.Add(this.lopetaBTN);
            this.Controls.Add(this.kaynnistaBTN);
            this.Controls.Add(this.aikaLB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "sekuntikelloForm";
            this.Text = "Sekuntikello";
            this.Load += new System.EventHandler(this.sekuntikelloForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aikaLB;
        private System.Windows.Forms.Button kaynnistaBTN;
        private System.Windows.Forms.Button lopetaBTN;
        private System.Windows.Forms.Button tyhjennaBTN;
        private System.Windows.Forms.Timer ajanottoTM;
    }
}

