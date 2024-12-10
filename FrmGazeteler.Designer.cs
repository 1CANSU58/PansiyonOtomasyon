namespace PansiyonOtomasyon
{
    partial class FrmGazeteler
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnHurriyet1 = new System.Windows.Forms.Button();
            this.btnMilliyet1 = new System.Windows.Forms.Button();
            this.btnSozcu1 = new System.Windows.Forms.Button();
            this.btnHaberTurk1 = new System.Windows.Forms.Button();
            this.btnFanatik1 = new System.Windows.Forms.Button();
            this.btnOnedio1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 54);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(822, 500);
            this.webBrowser1.TabIndex = 0;
            // 
            // btnHurriyet1
            // 
            this.btnHurriyet1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHurriyet1.Location = new System.Drawing.Point(32, 12);
            this.btnHurriyet1.Name = "btnHurriyet1";
            this.btnHurriyet1.Size = new System.Drawing.Size(125, 36);
            this.btnHurriyet1.TabIndex = 1;
            this.btnHurriyet1.Text = "Hürriyet";
            this.btnHurriyet1.UseVisualStyleBackColor = true;
            this.btnHurriyet1.Click += new System.EventHandler(this.btnHurriyet1_Click);
            // 
            // btnMilliyet1
            // 
            this.btnMilliyet1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMilliyet1.Location = new System.Drawing.Point(163, 12);
            this.btnMilliyet1.Name = "btnMilliyet1";
            this.btnMilliyet1.Size = new System.Drawing.Size(125, 36);
            this.btnMilliyet1.TabIndex = 2;
            this.btnMilliyet1.Text = "Milliyet";
            this.btnMilliyet1.UseVisualStyleBackColor = true;
            this.btnMilliyet1.Click += new System.EventHandler(this.btnMilliyet1_Click);
            // 
            // btnSozcu1
            // 
            this.btnSozcu1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSozcu1.Location = new System.Drawing.Point(294, 12);
            this.btnSozcu1.Name = "btnSozcu1";
            this.btnSozcu1.Size = new System.Drawing.Size(125, 36);
            this.btnSozcu1.TabIndex = 3;
            this.btnSozcu1.Text = "Sözcü";
            this.btnSozcu1.UseVisualStyleBackColor = true;
            this.btnSozcu1.Click += new System.EventHandler(this.btnSozcu1_Click);
            // 
            // btnHaberTurk1
            // 
            this.btnHaberTurk1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHaberTurk1.Location = new System.Drawing.Point(425, 12);
            this.btnHaberTurk1.Name = "btnHaberTurk1";
            this.btnHaberTurk1.Size = new System.Drawing.Size(125, 36);
            this.btnHaberTurk1.TabIndex = 4;
            this.btnHaberTurk1.Text = "HaberTürk";
            this.btnHaberTurk1.UseVisualStyleBackColor = true;
            this.btnHaberTurk1.Click += new System.EventHandler(this.btnHaberTurk1_Click);
            // 
            // btnFanatik1
            // 
            this.btnFanatik1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFanatik1.Location = new System.Drawing.Point(556, 12);
            this.btnFanatik1.Name = "btnFanatik1";
            this.btnFanatik1.Size = new System.Drawing.Size(125, 36);
            this.btnFanatik1.TabIndex = 5;
            this.btnFanatik1.Text = "Fanatik";
            this.btnFanatik1.UseVisualStyleBackColor = true;
            this.btnFanatik1.Click += new System.EventHandler(this.btnFanatik1_Click);
            // 
            // btnOnedio1
            // 
            this.btnOnedio1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnedio1.Location = new System.Drawing.Point(687, 12);
            this.btnOnedio1.Name = "btnOnedio1";
            this.btnOnedio1.Size = new System.Drawing.Size(125, 36);
            this.btnOnedio1.TabIndex = 6;
            this.btnOnedio1.Text = "Onedio";
            this.btnOnedio1.UseVisualStyleBackColor = true;
            this.btnOnedio1.Click += new System.EventHandler(this.btnOnedio1_Click);
            // 
            // FrmGazeteler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(846, 566);
            this.Controls.Add(this.btnOnedio1);
            this.Controls.Add(this.btnFanatik1);
            this.Controls.Add(this.btnHaberTurk1);
            this.Controls.Add(this.btnSozcu1);
            this.Controls.Add(this.btnMilliyet1);
            this.Controls.Add(this.btnHurriyet1);
            this.Controls.Add(this.webBrowser1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGazeteler";
            this.Text = "Gazeteler";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnHurriyet1;
        private System.Windows.Forms.Button btnMilliyet1;
        private System.Windows.Forms.Button btnSozcu1;
        private System.Windows.Forms.Button btnHaberTurk1;
        private System.Windows.Forms.Button btnFanatik1;
        private System.Windows.Forms.Button btnOnedio1;
    }
}