
namespace Metotlar1
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.s1txt = new System.Windows.Forms.TextBox();
            this.islem = new System.Windows.Forms.Label();
            this.s2txt = new System.Windows.Forms.TextBox();
            this.esittir = new System.Windows.Forms.Label();
            this.sonuctxt = new System.Windows.Forms.TextBox();
            this.deger1 = new System.Windows.Forms.Label();
            this.deger2 = new System.Windows.Forms.Label();
            this.sonuc = new System.Windows.Forms.Label();
            this.geri = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(167, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yapmak İstediğiniz İşlemi Seçiniz:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 59);
            this.button1.TabIndex = 1;
            this.button1.Text = "Toplama";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(172, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 59);
            this.button2.TabIndex = 2;
            this.button2.Text = "Çıkarma";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(294, 117);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 59);
            this.button3.TabIndex = 3;
            this.button3.Text = "Çarpma";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(418, 117);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 59);
            this.button4.TabIndex = 4;
            this.button4.Text = "Bölme";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(540, 117);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(99, 59);
            this.button5.TabIndex = 5;
            this.button5.Text = "Kalan Bulma";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // s1txt
            // 
            this.s1txt.Location = new System.Drawing.Point(220, 207);
            this.s1txt.Name = "s1txt";
            this.s1txt.Size = new System.Drawing.Size(56, 29);
            this.s1txt.TabIndex = 6;
            this.s1txt.Text = "00.00";
            this.s1txt.Visible = false;
            // 
            // islem
            // 
            this.islem.AutoSize = true;
            this.islem.Location = new System.Drawing.Point(282, 210);
            this.islem.Name = "islem";
            this.islem.Size = new System.Drawing.Size(18, 22);
            this.islem.TabIndex = 7;
            this.islem.Text = "+";
            this.islem.Visible = false;
            // 
            // s2txt
            // 
            this.s2txt.Location = new System.Drawing.Point(306, 207);
            this.s2txt.Name = "s2txt";
            this.s2txt.Size = new System.Drawing.Size(56, 29);
            this.s2txt.TabIndex = 8;
            this.s2txt.Text = "00.00";
            this.s2txt.Visible = false;
            // 
            // esittir
            // 
            this.esittir.AutoSize = true;
            this.esittir.Location = new System.Drawing.Point(371, 210);
            this.esittir.Name = "esittir";
            this.esittir.Size = new System.Drawing.Size(18, 22);
            this.esittir.TabIndex = 9;
            this.esittir.Text = "=";
            this.esittir.Visible = false;
            // 
            // sonuctxt
            // 
            this.sonuctxt.Location = new System.Drawing.Point(395, 207);
            this.sonuctxt.Name = "sonuctxt";
            this.sonuctxt.Size = new System.Drawing.Size(56, 29);
            this.sonuctxt.TabIndex = 10;
            this.sonuctxt.Text = "00.00";
            this.sonuctxt.Visible = false;
            // 
            // deger1
            // 
            this.deger1.AutoSize = true;
            this.deger1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deger1.Location = new System.Drawing.Point(221, 175);
            this.deger1.Name = "deger1";
            this.deger1.Size = new System.Drawing.Size(57, 18);
            this.deger1.TabIndex = 11;
            this.deger1.Text = "1.Değer";
            this.deger1.Visible = false;
            // 
            // deger2
            // 
            this.deger2.AutoSize = true;
            this.deger2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deger2.Location = new System.Drawing.Point(305, 175);
            this.deger2.Name = "deger2";
            this.deger2.Size = new System.Drawing.Size(57, 18);
            this.deger2.TabIndex = 12;
            this.deger2.Text = "2.Değer";
            this.deger2.Visible = false;
            // 
            // sonuc
            // 
            this.sonuc.AutoSize = true;
            this.sonuc.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonuc.Location = new System.Drawing.Point(399, 175);
            this.sonuc.Name = "sonuc";
            this.sonuc.Size = new System.Drawing.Size(46, 18);
            this.sonuc.TabIndex = 13;
            this.sonuc.Text = "Sonuç";
            this.sonuc.Visible = false;
            // 
            // geri
            // 
            this.geri.Location = new System.Drawing.Point(540, 312);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(114, 37);
            this.geri.TabIndex = 14;
            this.geri.Text = "⇐Geri";
            this.geri.UseVisualStyleBackColor = true;
            this.geri.Visible = false;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(348, 242);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(103, 30);
            this.button6.TabIndex = 15;
            this.button6.Text = "Hesapla";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(531, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Not: Küsuratlı girmek istediğiniz değeri \",\" işareti ile giriniz.";
            this.label2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(696, 403);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.sonuc);
            this.Controls.Add(this.deger2);
            this.Controls.Add(this.deger1);
            this.Controls.Add(this.sonuctxt);
            this.Controls.Add(this.esittir);
            this.Controls.Add(this.s2txt);
            this.Controls.Add(this.islem);
            this.Controls.Add(this.s1txt);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox s1txt;
        private System.Windows.Forms.Label islem;
        private System.Windows.Forms.TextBox s2txt;
        private System.Windows.Forms.Label esittir;
        private System.Windows.Forms.TextBox sonuctxt;
        private System.Windows.Forms.Label deger1;
        private System.Windows.Forms.Label deger2;
        private System.Windows.Forms.Label sonuc;
        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
    }
}

