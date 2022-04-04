namespace BMI_laskuri
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
            this.painoLB = new System.Windows.Forms.Label();
            this.pituusLB = new System.Windows.Forms.Label();
            this.painoTB = new System.Windows.Forms.TextBox();
            this.pituusTB = new System.Windows.Forms.TextBox();
            this.kgLB = new System.Windows.Forms.Label();
            this.cmLB = new System.Windows.Forms.Label();
            this.laskeBTN = new System.Windows.Forms.Button();
            this.painoindeksiLB = new System.Windows.Forms.Label();
            this.painonVariLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // painoLB
            // 
            this.painoLB.AutoSize = true;
            this.painoLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.painoLB.Location = new System.Drawing.Point(13, 13);
            this.painoLB.Name = "painoLB";
            this.painoLB.Size = new System.Drawing.Size(133, 25);
            this.painoLB.TabIndex = 0;
            this.painoLB.Text = "Anna paino: ";
            // 
            // pituusLB
            // 
            this.pituusLB.AutoSize = true;
            this.pituusLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pituusLB.Location = new System.Drawing.Point(13, 60);
            this.pituusLB.Name = "pituusLB";
            this.pituusLB.Size = new System.Drawing.Size(138, 25);
            this.pituusLB.TabIndex = 1;
            this.pituusLB.Text = "Anna pituus: ";
            // 
            // painoTB
            // 
            this.painoTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.painoTB.Location = new System.Drawing.Point(152, 12);
            this.painoTB.Name = "painoTB";
            this.painoTB.Size = new System.Drawing.Size(100, 31);
            this.painoTB.TabIndex = 2;
            // 
            // pituusTB
            // 
            this.pituusTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pituusTB.Location = new System.Drawing.Point(152, 60);
            this.pituusTB.Name = "pituusTB";
            this.pituusTB.Size = new System.Drawing.Size(100, 31);
            this.pituusTB.TabIndex = 3;
            // 
            // kgLB
            // 
            this.kgLB.AutoSize = true;
            this.kgLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kgLB.Location = new System.Drawing.Point(258, 18);
            this.kgLB.Name = "kgLB";
            this.kgLB.Size = new System.Drawing.Size(38, 25);
            this.kgLB.TabIndex = 4;
            this.kgLB.Text = "Kg";
            // 
            // cmLB
            // 
            this.cmLB.AutoSize = true;
            this.cmLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmLB.Location = new System.Drawing.Point(258, 66);
            this.cmLB.Name = "cmLB";
            this.cmLB.Size = new System.Drawing.Size(44, 25);
            this.cmLB.TabIndex = 5;
            this.cmLB.Text = "Cm";
            // 
            // laskeBTN
            // 
            this.laskeBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laskeBTN.Location = new System.Drawing.Point(18, 110);
            this.laskeBTN.Name = "laskeBTN";
            this.laskeBTN.Size = new System.Drawing.Size(278, 39);
            this.laskeBTN.TabIndex = 6;
            this.laskeBTN.Text = "Laske painoindeksi";
            this.laskeBTN.UseVisualStyleBackColor = true;
            this.laskeBTN.Click += new System.EventHandler(this.laskeBTN_Click);
            // 
            // painoindeksiLB
            // 
            this.painoindeksiLB.AutoSize = true;
            this.painoindeksiLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.painoindeksiLB.Location = new System.Drawing.Point(18, 169);
            this.painoindeksiLB.Name = "painoindeksiLB";
            this.painoindeksiLB.Size = new System.Drawing.Size(26, 25);
            this.painoindeksiLB.TabIndex = 7;
            this.painoindeksiLB.Text = "X";
            this.painoindeksiLB.Visible = false;
            // 
            // painonVariLB
            // 
            this.painonVariLB.AutoSize = true;
            this.painonVariLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.painonVariLB.Location = new System.Drawing.Point(18, 225);
            this.painonVariLB.Name = "painonVariLB";
            this.painonVariLB.Size = new System.Drawing.Size(26, 25);
            this.painonVariLB.TabIndex = 8;
            this.painonVariLB.Text = "X";
            this.painonVariLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 349);
            this.Controls.Add(this.painonVariLB);
            this.Controls.Add(this.painoindeksiLB);
            this.Controls.Add(this.laskeBTN);
            this.Controls.Add(this.cmLB);
            this.Controls.Add(this.kgLB);
            this.Controls.Add(this.pituusTB);
            this.Controls.Add(this.painoTB);
            this.Controls.Add(this.pituusLB);
            this.Controls.Add(this.painoLB);
            this.Name = "Form1";
            this.Text = "BMI-laskuri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label painoLB;
        private System.Windows.Forms.Label pituusLB;
        private System.Windows.Forms.TextBox painoTB;
        private System.Windows.Forms.TextBox pituusTB;
        private System.Windows.Forms.Label kgLB;
        private System.Windows.Forms.Label cmLB;
        private System.Windows.Forms.Button laskeBTN;
        private System.Windows.Forms.Label painoindeksiLB;
        private System.Windows.Forms.Label painonVariLB;
    }
}

