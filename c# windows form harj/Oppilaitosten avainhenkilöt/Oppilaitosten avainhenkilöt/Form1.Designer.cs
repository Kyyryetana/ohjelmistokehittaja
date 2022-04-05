namespace Oppilaitosten_avainhenkilöt
{
    partial class oppilaitostenForm
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
            this.paaotsikkoLB = new System.Windows.Forms.Label();
            this.oppilaitosLB = new System.Windows.Forms.Label();
            this.vastuuHenkiloLB = new System.Windows.Forms.Label();
            this.oppilaitosCB = new System.Windows.Forms.ComboBox();
            this.vastuuhenkiloCB = new System.Windows.Forms.ComboBox();
            this.katuosoiteLB = new System.Windows.Forms.Label();
            this.postinumeroLB = new System.Windows.Forms.Label();
            this.postitoimipaikkaLB = new System.Windows.Forms.Label();
            this.puhelinLB = new System.Windows.Forms.Label();
            this.titteliLB = new System.Windows.Forms.Label();
            this.sijaintiLB = new System.Windows.Forms.Label();
            this.emailLB = new System.Windows.Forms.Label();
            this.phoneLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // paaotsikkoLB
            // 
            this.paaotsikkoLB.AutoSize = true;
            this.paaotsikkoLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paaotsikkoLB.Location = new System.Drawing.Point(12, 9);
            this.paaotsikkoLB.Name = "paaotsikkoLB";
            this.paaotsikkoLB.Size = new System.Drawing.Size(465, 42);
            this.paaotsikkoLB.TabIndex = 0;
            this.paaotsikkoLB.Text = "Oppilaitosten avainhenkilöt";
            // 
            // oppilaitosLB
            // 
            this.oppilaitosLB.AutoSize = true;
            this.oppilaitosLB.Location = new System.Drawing.Point(19, 81);
            this.oppilaitosLB.Name = "oppilaitosLB";
            this.oppilaitosLB.Size = new System.Drawing.Size(181, 25);
            this.oppilaitosLB.TabIndex = 1;
            this.oppilaitosLB.Text = "Valitse oppilaitos:";
            // 
            // vastuuHenkiloLB
            // 
            this.vastuuHenkiloLB.AutoSize = true;
            this.vastuuHenkiloLB.Location = new System.Drawing.Point(255, 81);
            this.vastuuHenkiloLB.Name = "vastuuHenkiloLB";
            this.vastuuHenkiloLB.Size = new System.Drawing.Size(222, 25);
            this.vastuuHenkiloLB.TabIndex = 2;
            this.vastuuHenkiloLB.Text = "Valitse vastuuhenkilö:";
            // 
            // oppilaitosCB
            // 
            this.oppilaitosCB.FormattingEnabled = true;
            this.oppilaitosCB.Location = new System.Drawing.Point(24, 109);
            this.oppilaitosCB.Name = "oppilaitosCB";
            this.oppilaitosCB.Size = new System.Drawing.Size(176, 33);
            this.oppilaitosCB.TabIndex = 3;
            this.oppilaitosCB.SelectedIndexChanged += new System.EventHandler(this.oppilaitosCB_SelectedIndexChanged);
            // 
            // vastuuhenkiloCB
            // 
            this.vastuuhenkiloCB.FormattingEnabled = true;
            this.vastuuhenkiloCB.Location = new System.Drawing.Point(260, 109);
            this.vastuuhenkiloCB.Name = "vastuuhenkiloCB";
            this.vastuuhenkiloCB.Size = new System.Drawing.Size(217, 33);
            this.vastuuhenkiloCB.TabIndex = 4;
            // 
            // katuosoiteLB
            // 
            this.katuosoiteLB.AutoSize = true;
            this.katuosoiteLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.katuosoiteLB.Location = new System.Drawing.Point(24, 161);
            this.katuosoiteLB.Name = "katuosoiteLB";
            this.katuosoiteLB.Size = new System.Drawing.Size(85, 20);
            this.katuosoiteLB.TabIndex = 5;
            this.katuosoiteLB.Text = "Katuosoite";
            // 
            // postinumeroLB
            // 
            this.postinumeroLB.AutoSize = true;
            this.postinumeroLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postinumeroLB.Location = new System.Drawing.Point(24, 186);
            this.postinumeroLB.Name = "postinumeroLB";
            this.postinumeroLB.Size = new System.Drawing.Size(98, 20);
            this.postinumeroLB.TabIndex = 6;
            this.postinumeroLB.Text = "Postinumero";
            // 
            // postitoimipaikkaLB
            // 
            this.postitoimipaikkaLB.AutoSize = true;
            this.postitoimipaikkaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postitoimipaikkaLB.Location = new System.Drawing.Point(24, 211);
            this.postitoimipaikkaLB.Name = "postitoimipaikkaLB";
            this.postitoimipaikkaLB.Size = new System.Drawing.Size(123, 20);
            this.postitoimipaikkaLB.TabIndex = 7;
            this.postitoimipaikkaLB.Text = "Postitoimipaikka";
            // 
            // puhelinLB
            // 
            this.puhelinLB.AutoSize = true;
            this.puhelinLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puhelinLB.Location = new System.Drawing.Point(24, 236);
            this.puhelinLB.Name = "puhelinLB";
            this.puhelinLB.Size = new System.Drawing.Size(61, 20);
            this.puhelinLB.TabIndex = 8;
            this.puhelinLB.Text = "Puhelin";
            // 
            // titteliLB
            // 
            this.titteliLB.AutoSize = true;
            this.titteliLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titteliLB.Location = new System.Drawing.Point(255, 161);
            this.titteliLB.Name = "titteliLB";
            this.titteliLB.Size = new System.Drawing.Size(46, 20);
            this.titteliLB.TabIndex = 9;
            this.titteliLB.Text = "Titteli";
            // 
            // sijaintiLB
            // 
            this.sijaintiLB.AutoSize = true;
            this.sijaintiLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sijaintiLB.Location = new System.Drawing.Point(255, 186);
            this.sijaintiLB.Name = "sijaintiLB";
            this.sijaintiLB.Size = new System.Drawing.Size(55, 20);
            this.sijaintiLB.TabIndex = 10;
            this.sijaintiLB.Text = "Sijainti";
            // 
            // emailLB
            // 
            this.emailLB.AutoSize = true;
            this.emailLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLB.Location = new System.Drawing.Point(255, 211);
            this.emailLB.Name = "emailLB";
            this.emailLB.Size = new System.Drawing.Size(89, 20);
            this.emailLB.TabIndex = 11;
            this.emailLB.Text = "Sähköposti";
            // 
            // phoneLB
            // 
            this.phoneLB.AutoSize = true;
            this.phoneLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLB.Location = new System.Drawing.Point(255, 236);
            this.phoneLB.Name = "phoneLB";
            this.phoneLB.Size = new System.Drawing.Size(61, 20);
            this.phoneLB.TabIndex = 12;
            this.phoneLB.Text = "Puhelin";
            // 
            // oppilaitostenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 310);
            this.Controls.Add(this.phoneLB);
            this.Controls.Add(this.emailLB);
            this.Controls.Add(this.sijaintiLB);
            this.Controls.Add(this.titteliLB);
            this.Controls.Add(this.puhelinLB);
            this.Controls.Add(this.postitoimipaikkaLB);
            this.Controls.Add(this.postinumeroLB);
            this.Controls.Add(this.katuosoiteLB);
            this.Controls.Add(this.vastuuhenkiloCB);
            this.Controls.Add(this.oppilaitosCB);
            this.Controls.Add(this.vastuuHenkiloLB);
            this.Controls.Add(this.oppilaitosLB);
            this.Controls.Add(this.paaotsikkoLB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "oppilaitostenForm";
            this.Text = "Oppilaitosten avainhenkilöt";
            this.Load += new System.EventHandler(this.oppilaitostenForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label paaotsikkoLB;
        private System.Windows.Forms.Label oppilaitosLB;
        private System.Windows.Forms.Label vastuuHenkiloLB;
        private System.Windows.Forms.ComboBox oppilaitosCB;
        private System.Windows.Forms.ComboBox vastuuhenkiloCB;
        private System.Windows.Forms.Label katuosoiteLB;
        private System.Windows.Forms.Label postinumeroLB;
        private System.Windows.Forms.Label postitoimipaikkaLB;
        private System.Windows.Forms.Label puhelinLB;
        private System.Windows.Forms.Label titteliLB;
        private System.Windows.Forms.Label sijaintiLB;
        private System.Windows.Forms.Label emailLB;
        private System.Windows.Forms.Label phoneLB;
    }
}

