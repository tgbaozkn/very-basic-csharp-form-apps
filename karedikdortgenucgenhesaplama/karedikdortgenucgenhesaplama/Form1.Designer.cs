namespace karedikdortgenucgenhesaplama
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kare = new System.Windows.Forms.Button();
            this.ucgen = new System.Windows.Forms.Button();
            this.daire = new System.Windows.Forms.Button();
            this.hesapla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Alan = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.kenar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.yukseklik = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // kare
            // 
            this.kare.BackColor = System.Drawing.Color.HotPink;
            this.kare.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kare.ForeColor = System.Drawing.Color.LavenderBlush;
            this.kare.Location = new System.Drawing.Point(24, 37);
            this.kare.Name = "kare";
            this.kare.Size = new System.Drawing.Size(116, 50);
            this.kare.TabIndex = 0;
            this.kare.Text = "Kare";
            this.kare.UseVisualStyleBackColor = false;
            this.kare.Click += new System.EventHandler(this.kare_Click);
            // 
            // ucgen
            // 
            this.ucgen.BackColor = System.Drawing.Color.HotPink;
            this.ucgen.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ucgen.ForeColor = System.Drawing.Color.LavenderBlush;
            this.ucgen.Location = new System.Drawing.Point(185, 37);
            this.ucgen.Name = "ucgen";
            this.ucgen.Size = new System.Drawing.Size(94, 50);
            this.ucgen.TabIndex = 1;
            this.ucgen.Text = "Üçgen";
            this.ucgen.UseVisualStyleBackColor = false;
            this.ucgen.Click += new System.EventHandler(this.button2_Click);
            // 
            // daire
            // 
            this.daire.BackColor = System.Drawing.Color.HotPink;
            this.daire.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.daire.ForeColor = System.Drawing.Color.LavenderBlush;
            this.daire.Location = new System.Drawing.Point(313, 37);
            this.daire.Name = "daire";
            this.daire.Size = new System.Drawing.Size(109, 50);
            this.daire.TabIndex = 2;
            this.daire.Text = "Daire";
            this.daire.UseVisualStyleBackColor = false;
            this.daire.Click += new System.EventHandler(this.daire_Click);
            // 
            // hesapla
            // 
            this.hesapla.BackColor = System.Drawing.Color.HotPink;
            this.hesapla.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hesapla.ForeColor = System.Drawing.Color.LavenderBlush;
            this.hesapla.Location = new System.Drawing.Point(77, 255);
            this.hesapla.Name = "hesapla";
            this.hesapla.Size = new System.Drawing.Size(99, 33);
            this.hesapla.TabIndex = 3;
            this.hesapla.Text = "hesapla";
            this.hesapla.UseVisualStyleBackColor = false;
            this.hesapla.Click += new System.EventHandler(this.hesapla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(215, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Alan
            // 
            this.Alan.AutoSize = true;
            this.Alan.Location = new System.Drawing.Point(29, 308);
            this.Alan.Name = "Alan";
            this.Alan.Size = new System.Drawing.Size(28, 13);
            this.Alan.TabIndex = 5;
            this.Alan.Text = "Alan";
            this.Alan.Click += new System.EventHandler(this.Alan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Çevre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(85, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(85, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "label5";
            // 
            // kenar
            // 
            this.kenar.Location = new System.Drawing.Point(121, 229);
            this.kenar.Name = "kenar";
            this.kenar.Size = new System.Drawing.Size(128, 20);
            this.kenar.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kenar uzunlugu girin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Yukseklik girin";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // yukseklik
            // 
            this.yukseklik.Location = new System.Drawing.Point(340, 229);
            this.yukseklik.Name = "yukseklik";
            this.yukseklik.Size = new System.Drawing.Size(128, 20);
            this.yukseklik.TabIndex = 11;
            this.yukseklik.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(523, 429);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.yukseklik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kenar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Alan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hesapla);
            this.Controls.Add(this.daire);
            this.Controls.Add(this.ucgen);
            this.Controls.Add(this.kare);
            this.Name = "Form1";
            this.Text = "Calculating Area and ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kare;
        private System.Windows.Forms.Button ucgen;
        private System.Windows.Forms.Button daire;
        private System.Windows.Forms.Button hesapla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Alan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox kenar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox yukseklik;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

