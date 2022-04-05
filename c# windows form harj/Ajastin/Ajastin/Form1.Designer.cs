namespace Ajastin
{
    partial class ajastinForm
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
            this.minuutitLB = new System.Windows.Forms.Label();
            this.sekunnitLB = new System.Windows.Forms.Label();
            this.aikaLB = new System.Windows.Forms.Label();
            this.minuutitCB = new System.Windows.Forms.ComboBox();
            this.sekunnitCB = new System.Windows.Forms.ComboBox();
            this.startBTN = new System.Windows.Forms.Button();
            this.stopBTN = new System.Windows.Forms.Button();
            this.ajastinTMR = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // minuutitLB
            // 
            this.minuutitLB.AutoSize = true;
            this.minuutitLB.Location = new System.Drawing.Point(25, 13);
            this.minuutitLB.Name = "minuutitLB";
            this.minuutitLB.Size = new System.Drawing.Size(94, 25);
            this.minuutitLB.TabIndex = 0;
            this.minuutitLB.Text = "Minuutit:";
            // 
            // sekunnitLB
            // 
            this.sekunnitLB.AutoSize = true;
            this.sekunnitLB.Location = new System.Drawing.Point(152, 13);
            this.sekunnitLB.Name = "sekunnitLB";
            this.sekunnitLB.Size = new System.Drawing.Size(102, 25);
            this.sekunnitLB.TabIndex = 1;
            this.sekunnitLB.Text = "Sekunnit:";
            // 
            // aikaLB
            // 
            this.aikaLB.AutoSize = true;
            this.aikaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aikaLB.Location = new System.Drawing.Point(12, 77);
            this.aikaLB.Name = "aikaLB";
            this.aikaLB.Size = new System.Drawing.Size(284, 108);
            this.aikaLB.TabIndex = 2;
            this.aikaLB.Text = "00:00";
            // 
            // minuutitCB
            // 
            this.minuutitCB.FormattingEnabled = true;
            this.minuutitCB.Location = new System.Drawing.Point(30, 41);
            this.minuutitCB.Name = "minuutitCB";
            this.minuutitCB.Size = new System.Drawing.Size(121, 33);
            this.minuutitCB.TabIndex = 3;
            // 
            // sekunnitCB
            // 
            this.sekunnitCB.FormattingEnabled = true;
            this.sekunnitCB.Location = new System.Drawing.Point(157, 41);
            this.sekunnitCB.Name = "sekunnitCB";
            this.sekunnitCB.Size = new System.Drawing.Size(121, 33);
            this.sekunnitCB.TabIndex = 4;
            // 
            // startBTN
            // 
            this.startBTN.Location = new System.Drawing.Point(30, 188);
            this.startBTN.Name = "startBTN";
            this.startBTN.Size = new System.Drawing.Size(121, 37);
            this.startBTN.TabIndex = 5;
            this.startBTN.Text = "Start";
            this.startBTN.UseVisualStyleBackColor = true;
            this.startBTN.Click += new System.EventHandler(this.startBTN_Click);
            // 
            // stopBTN
            // 
            this.stopBTN.Location = new System.Drawing.Point(157, 188);
            this.stopBTN.Name = "stopBTN";
            this.stopBTN.Size = new System.Drawing.Size(121, 37);
            this.stopBTN.TabIndex = 6;
            this.stopBTN.Text = "Stop";
            this.stopBTN.UseVisualStyleBackColor = true;
            this.stopBTN.Click += new System.EventHandler(this.stopBTN_Click);
            // 
            // ajastinTMR
            // 
            this.ajastinTMR.Interval = 1000;
            this.ajastinTMR.Tick += new System.EventHandler(this.ajastinTMR_Tick);
            // 
            // ajastinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 253);
            this.Controls.Add(this.stopBTN);
            this.Controls.Add(this.startBTN);
            this.Controls.Add(this.sekunnitCB);
            this.Controls.Add(this.minuutitCB);
            this.Controls.Add(this.aikaLB);
            this.Controls.Add(this.sekunnitLB);
            this.Controls.Add(this.minuutitLB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ajastinForm";
            this.Text = "Ajastin";
            this.Load += new System.EventHandler(this.ajastinForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label minuutitLB;
        private System.Windows.Forms.Label sekunnitLB;
        private System.Windows.Forms.Label aikaLB;
        private System.Windows.Forms.ComboBox minuutitCB;
        private System.Windows.Forms.ComboBox sekunnitCB;
        private System.Windows.Forms.Button startBTN;
        private System.Windows.Forms.Button stopBTN;
        private System.Windows.Forms.Timer ajastinTMR;
    }
}

