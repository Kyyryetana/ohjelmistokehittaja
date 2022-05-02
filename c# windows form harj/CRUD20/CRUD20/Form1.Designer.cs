namespace CRUD20
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
            this.idLB = new System.Windows.Forms.Label();
            this.etunimiLB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.puhelinLB = new System.Windows.Forms.Label();
            this.sahkopostiLB = new System.Windows.Forms.Label();
            this.opiskelijanroLB = new System.Windows.Forms.Label();
            this.tyhjennaBTN = new System.Windows.Forms.Button();
            this.tallennaBTN = new System.Windows.Forms.Button();
            this.paivitaBTN = new System.Windows.Forms.Button();
            this.poistaBTN = new System.Windows.Forms.Button();
            this.idTB = new System.Windows.Forms.TextBox();
            this.enimiTB = new System.Windows.Forms.TextBox();
            this.snimiTB = new System.Windows.Forms.TextBox();
            this.puhelinTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.oNroTB = new System.Windows.Forms.TextBox();
            this.tietotauluDG = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tietotauluDG)).BeginInit();
            this.SuspendLayout();
            // 
            // idLB
            // 
            this.idLB.AutoSize = true;
            this.idLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLB.Location = new System.Drawing.Point(9, 18);
            this.idLB.Name = "idLB";
            this.idLB.Size = new System.Drawing.Size(35, 24);
            this.idLB.TabIndex = 0;
            this.idLB.Text = "ID:";
            // 
            // etunimiLB
            // 
            this.etunimiLB.AutoSize = true;
            this.etunimiLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etunimiLB.Location = new System.Drawing.Point(9, 67);
            this.etunimiLB.Name = "etunimiLB";
            this.etunimiLB.Size = new System.Drawing.Size(99, 24);
            this.etunimiLB.TabIndex = 1;
            this.etunimiLB.Text = "ETUNIMI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "SUKUNIMI:";
            // 
            // puhelinLB
            // 
            this.puhelinLB.AutoSize = true;
            this.puhelinLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puhelinLB.Location = new System.Drawing.Point(421, 18);
            this.puhelinLB.Name = "puhelinLB";
            this.puhelinLB.Size = new System.Drawing.Size(103, 24);
            this.puhelinLB.TabIndex = 3;
            this.puhelinLB.Text = "PUHELIN:";
            // 
            // sahkopostiLB
            // 
            this.sahkopostiLB.AutoSize = true;
            this.sahkopostiLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sahkopostiLB.Location = new System.Drawing.Point(421, 67);
            this.sahkopostiLB.Name = "sahkopostiLB";
            this.sahkopostiLB.Size = new System.Drawing.Size(147, 24);
            this.sahkopostiLB.TabIndex = 4;
            this.sahkopostiLB.Text = "SÄHKÖPOSTI:";
            // 
            // opiskelijanroLB
            // 
            this.opiskelijanroLB.AutoSize = true;
            this.opiskelijanroLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opiskelijanroLB.Location = new System.Drawing.Point(421, 116);
            this.opiskelijanroLB.Name = "opiskelijanroLB";
            this.opiskelijanroLB.Size = new System.Drawing.Size(220, 24);
            this.opiskelijanroLB.TabIndex = 5;
            this.opiskelijanroLB.Text = "OPISKELIJANUMERO:";
            // 
            // tyhjennaBTN
            // 
            this.tyhjennaBTN.Location = new System.Drawing.Point(13, 173);
            this.tyhjennaBTN.Name = "tyhjennaBTN";
            this.tyhjennaBTN.Size = new System.Drawing.Size(173, 40);
            this.tyhjennaBTN.TabIndex = 6;
            this.tyhjennaBTN.Text = "TYHJENNÄ";
            this.tyhjennaBTN.UseVisualStyleBackColor = true;
            this.tyhjennaBTN.Click += new System.EventHandler(this.tyhjennaBTN_Click);
            // 
            // tallennaBTN
            // 
            this.tallennaBTN.Location = new System.Drawing.Point(244, 173);
            this.tallennaBTN.Name = "tallennaBTN";
            this.tallennaBTN.Size = new System.Drawing.Size(173, 40);
            this.tallennaBTN.TabIndex = 7;
            this.tallennaBTN.Text = "TALLENNA";
            this.tallennaBTN.UseVisualStyleBackColor = true;
            this.tallennaBTN.Click += new System.EventHandler(this.tallennaBTN_Click);
            // 
            // paivitaBTN
            // 
            this.paivitaBTN.Location = new System.Drawing.Point(475, 173);
            this.paivitaBTN.Name = "paivitaBTN";
            this.paivitaBTN.Size = new System.Drawing.Size(173, 40);
            this.paivitaBTN.TabIndex = 8;
            this.paivitaBTN.Text = "PÄIVITÄ";
            this.paivitaBTN.UseVisualStyleBackColor = true;
            this.paivitaBTN.Click += new System.EventHandler(this.paivitaBTN_Click);
            // 
            // poistaBTN
            // 
            this.poistaBTN.Location = new System.Drawing.Point(706, 173);
            this.poistaBTN.Name = "poistaBTN";
            this.poistaBTN.Size = new System.Drawing.Size(173, 40);
            this.poistaBTN.TabIndex = 9;
            this.poistaBTN.Text = "POISTA";
            this.poistaBTN.UseVisualStyleBackColor = true;
            this.poistaBTN.Click += new System.EventHandler(this.poistaBTN_Click);
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(152, 18);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(229, 29);
            this.idTB.TabIndex = 10;
            // 
            // enimiTB
            // 
            this.enimiTB.Location = new System.Drawing.Point(152, 66);
            this.enimiTB.Name = "enimiTB";
            this.enimiTB.Size = new System.Drawing.Size(229, 29);
            this.enimiTB.TabIndex = 11;
            // 
            // snimiTB
            // 
            this.snimiTB.Location = new System.Drawing.Point(152, 114);
            this.snimiTB.Name = "snimiTB";
            this.snimiTB.Size = new System.Drawing.Size(229, 29);
            this.snimiTB.TabIndex = 12;
            // 
            // puhelinTB
            // 
            this.puhelinTB.Location = new System.Drawing.Point(652, 18);
            this.puhelinTB.Name = "puhelinTB";
            this.puhelinTB.Size = new System.Drawing.Size(229, 29);
            this.puhelinTB.TabIndex = 13;
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(652, 65);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(229, 29);
            this.emailTB.TabIndex = 14;
            // 
            // oNroTB
            // 
            this.oNroTB.Location = new System.Drawing.Point(652, 112);
            this.oNroTB.Name = "oNroTB";
            this.oNroTB.Size = new System.Drawing.Size(229, 29);
            this.oNroTB.TabIndex = 15;
            // 
            // tietotauluDG
            // 
            this.tietotauluDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tietotauluDG.Location = new System.Drawing.Point(13, 232);
            this.tietotauluDG.Name = "tietotauluDG";
            this.tietotauluDG.Size = new System.Drawing.Size(868, 392);
            this.tietotauluDG.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 636);
            this.Controls.Add(this.tietotauluDG);
            this.Controls.Add(this.oNroTB);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.puhelinTB);
            this.Controls.Add(this.snimiTB);
            this.Controls.Add(this.enimiTB);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.poistaBTN);
            this.Controls.Add(this.paivitaBTN);
            this.Controls.Add(this.tallennaBTN);
            this.Controls.Add(this.tyhjennaBTN);
            this.Controls.Add(this.opiskelijanroLB);
            this.Controls.Add(this.sahkopostiLB);
            this.Controls.Add(this.puhelinLB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.etunimiLB);
            this.Controls.Add(this.idLB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Opiskelijarekisterin ylläpito";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tietotauluDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLB;
        private System.Windows.Forms.Label etunimiLB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label puhelinLB;
        private System.Windows.Forms.Label sahkopostiLB;
        private System.Windows.Forms.Label opiskelijanroLB;
        private System.Windows.Forms.Button tyhjennaBTN;
        private System.Windows.Forms.Button tallennaBTN;
        private System.Windows.Forms.Button paivitaBTN;
        private System.Windows.Forms.Button poistaBTN;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.TextBox enimiTB;
        private System.Windows.Forms.TextBox snimiTB;
        private System.Windows.Forms.TextBox puhelinTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.TextBox oNroTB;
        private System.Windows.Forms.DataGridView tietotauluDG;
    }
}

