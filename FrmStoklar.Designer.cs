namespace PansiyonOtomasyon
{
    partial class FrmStoklar
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbMutfak1 = new System.Windows.Forms.GroupBox();
            this.gbFaturalar1 = new System.Windows.Forms.GroupBox();
            this.lblStokkayit2 = new System.Windows.Forms.Label();
            this.btnKayitet3 = new System.Windows.Forms.Button();
            this.txtInternet1 = new System.Windows.Forms.TextBox();
            this.txtSu1 = new System.Windows.Forms.TextBox();
            this.txtElektrik1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblStokkayit1 = new System.Windows.Forms.Label();
            this.btnKayitet2 = new System.Windows.Forms.Button();
            this.txtAtistirmalik1 = new System.Windows.Forms.TextBox();
            this.txtIcecek1 = new System.Windows.Forms.TextBox();
            this.txtGida1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbMutfak1.SuspendLayout();
            this.gbFaturalar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 239);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(380, 199);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Gıdalar";
            this.columnHeader1.Width = 116;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "İçecekler";
            this.columnHeader2.Width = 134;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Atıştırmalıklar";
            this.columnHeader3.Width = 122;
            // 
            // gbMutfak1
            // 
            this.gbMutfak1.Controls.Add(this.label10);
            this.gbMutfak1.Controls.Add(this.label9);
            this.gbMutfak1.Controls.Add(this.label8);
            this.gbMutfak1.Controls.Add(this.lblStokkayit1);
            this.gbMutfak1.Controls.Add(this.btnKayitet2);
            this.gbMutfak1.Controls.Add(this.txtAtistirmalik1);
            this.gbMutfak1.Controls.Add(this.txtIcecek1);
            this.gbMutfak1.Controls.Add(this.txtGida1);
            this.gbMutfak1.Controls.Add(this.label3);
            this.gbMutfak1.Controls.Add(this.label2);
            this.gbMutfak1.Controls.Add(this.label1);
            this.gbMutfak1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbMutfak1.Location = new System.Drawing.Point(12, 12);
            this.gbMutfak1.Name = "gbMutfak1";
            this.gbMutfak1.Size = new System.Drawing.Size(402, 221);
            this.gbMutfak1.TabIndex = 8;
            this.gbMutfak1.TabStop = false;
            this.gbMutfak1.Text = "Mutfak";
            // 
            // gbFaturalar1
            // 
            this.gbFaturalar1.Controls.Add(this.lblStokkayit2);
            this.gbFaturalar1.Controls.Add(this.txtElektrik1);
            this.gbFaturalar1.Controls.Add(this.btnKayitet3);
            this.gbFaturalar1.Controls.Add(this.label7);
            this.gbFaturalar1.Controls.Add(this.txtInternet1);
            this.gbFaturalar1.Controls.Add(this.label6);
            this.gbFaturalar1.Controls.Add(this.txtSu1);
            this.gbFaturalar1.Controls.Add(this.label5);
            this.gbFaturalar1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbFaturalar1.Location = new System.Drawing.Point(420, 12);
            this.gbFaturalar1.Name = "gbFaturalar1";
            this.gbFaturalar1.Size = new System.Drawing.Size(368, 221);
            this.gbFaturalar1.TabIndex = 0;
            this.gbFaturalar1.TabStop = false;
            this.gbFaturalar1.Text = "Faturalar";
            // 
            // lblStokkayit2
            // 
            this.lblStokkayit2.AutoSize = true;
            this.lblStokkayit2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStokkayit2.ForeColor = System.Drawing.Color.Green;
            this.lblStokkayit2.Location = new System.Drawing.Point(181, 185);
            this.lblStokkayit2.Name = "lblStokkayit2";
            this.lblStokkayit2.Size = new System.Drawing.Size(85, 17);
            this.lblStokkayit2.TabIndex = 32;
            this.lblStokkayit2.Text = "Kayıt Eklendi";
            // 
            // btnKayitet3
            // 
            this.btnKayitet3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayitet3.Location = new System.Drawing.Point(143, 144);
            this.btnKayitet3.Name = "btnKayitet3";
            this.btnKayitet3.Size = new System.Drawing.Size(151, 26);
            this.btnKayitet3.TabIndex = 31;
            this.btnKayitet3.Text = "Kayıt Et";
            this.btnKayitet3.UseVisualStyleBackColor = true;
            this.btnKayitet3.Click += new System.EventHandler(this.btnKayitet3_Click);
            // 
            // txtInternet1
            // 
            this.txtInternet1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtInternet1.Location = new System.Drawing.Point(121, 102);
            this.txtInternet1.Name = "txtInternet1";
            this.txtInternet1.Size = new System.Drawing.Size(194, 25);
            this.txtInternet1.TabIndex = 30;
            // 
            // txtSu1
            // 
            this.txtSu1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSu1.Location = new System.Drawing.Point(121, 58);
            this.txtSu1.Name = "txtSu1";
            this.txtSu1.Size = new System.Drawing.Size(194, 25);
            this.txtSu1.TabIndex = 29;
            // 
            // txtElektrik1
            // 
            this.txtElektrik1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtElektrik1.Location = new System.Drawing.Point(121, 18);
            this.txtElektrik1.Name = "txtElektrik1";
            this.txtElektrik1.Size = new System.Drawing.Size(194, 25);
            this.txtElektrik1.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(50, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "İnternet :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(84, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Su :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(53, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Elektrik :";
            // 
            // lblStokkayit1
            // 
            this.lblStokkayit1.AutoSize = true;
            this.lblStokkayit1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStokkayit1.ForeColor = System.Drawing.Color.Green;
            this.lblStokkayit1.Location = new System.Drawing.Point(216, 190);
            this.lblStokkayit1.Name = "lblStokkayit1";
            this.lblStokkayit1.Size = new System.Drawing.Size(85, 17);
            this.lblStokkayit1.TabIndex = 24;
            this.lblStokkayit1.Text = "Kayıt Eklendi";
            // 
            // btnKayitet2
            // 
            this.btnKayitet2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayitet2.Location = new System.Drawing.Point(178, 149);
            this.btnKayitet2.Name = "btnKayitet2";
            this.btnKayitet2.Size = new System.Drawing.Size(151, 26);
            this.btnKayitet2.TabIndex = 23;
            this.btnKayitet2.Text = "Kayıt Et";
            this.btnKayitet2.UseVisualStyleBackColor = true;
            // 
            // txtAtistirmalik1
            // 
            this.txtAtistirmalik1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAtistirmalik1.Location = new System.Drawing.Point(156, 107);
            this.txtAtistirmalik1.Name = "txtAtistirmalik1";
            this.txtAtistirmalik1.Size = new System.Drawing.Size(194, 25);
            this.txtAtistirmalik1.TabIndex = 22;
            // 
            // txtIcecek1
            // 
            this.txtIcecek1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIcecek1.Location = new System.Drawing.Point(156, 63);
            this.txtIcecek1.Name = "txtIcecek1";
            this.txtIcecek1.Size = new System.Drawing.Size(194, 25);
            this.txtIcecek1.TabIndex = 21;
            // 
            // txtGida1
            // 
            this.txtGida1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGida1.Location = new System.Drawing.Point(156, 23);
            this.txtGida1.Name = "txtGida1";
            this.txtGida1.Size = new System.Drawing.Size(194, 25);
            this.txtGida1.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(-144, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Atıştırmalıklar :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(-137, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "İçecek Tutarı : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(-128, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Gıda Tutarı : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(63, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Gıda Tutarı :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(54, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "İçecek Tutarı :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(43, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "Atıştırmalıklar :";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(399, 240);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(389, 198);
            this.listView2.TabIndex = 9;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Elektrik";
            this.columnHeader4.Width = 106;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Su";
            this.columnHeader5.Width = 128;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "İnternet";
            this.columnHeader6.Width = 144;
            // 
            // FrmStoklar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.gbFaturalar1);
            this.Controls.Add(this.gbMutfak1);
            this.Controls.Add(this.listView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStoklar";
            this.Text = "Stoklar & Faturalar";
            this.Load += new System.EventHandler(this.FrmStoklar_Load);
            this.gbMutfak1.ResumeLayout(false);
            this.gbMutfak1.PerformLayout();
            this.gbFaturalar1.ResumeLayout(false);
            this.gbFaturalar1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox gbMutfak1;
        private System.Windows.Forms.GroupBox gbFaturalar1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblStokkayit1;
        private System.Windows.Forms.Button btnKayitet2;
        private System.Windows.Forms.TextBox txtAtistirmalik1;
        private System.Windows.Forms.TextBox txtIcecek1;
        private System.Windows.Forms.TextBox txtGida1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStokkayit2;
        private System.Windows.Forms.TextBox txtElektrik1;
        private System.Windows.Forms.Button btnKayitet3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtInternet1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSu1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}