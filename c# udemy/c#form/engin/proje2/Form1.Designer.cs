
namespace proje2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Sıfatlar = new System.Windows.Forms.ComboBox();
            this.Ekle = new System.Windows.Forms.Button();
            this.B = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Sıfatlar
            // 
            this.Sıfatlar.FormattingEnabled = true;
            this.Sıfatlar.Items.AddRange(new object[] {
            "sikik",
            "pezevenk",
            "orospu çocuğu",
            "kaşar",
            "anası kevaşe",
            "götten yemeyi seven"});
            this.Sıfatlar.Location = new System.Drawing.Point(216, 48);
            this.Sıfatlar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Sıfatlar.Name = "Sıfatlar";
            this.Sıfatlar.Size = new System.Drawing.Size(138, 26);
            this.Sıfatlar.TabIndex = 0;
            // 
            // Ekle
            // 
            this.Ekle.Location = new System.Drawing.Point(141, 219);
            this.Ekle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(100, 26);
            this.Ekle.TabIndex = 1;
            this.Ekle.Text = "Ekle";
            this.Ekle.UseVisualStyleBackColor = true;
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.Location = new System.Drawing.Point(9, 191);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(126, 18);
            this.B.TabIndex = 2;
            this.B.Text = "Başka Sıfatlar Ekle:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 188);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 23);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Engin\'e Ait Bazı Sıfatlar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(747, 383);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.B);
            this.Controls.Add(this.Ekle);
            this.Controls.Add(this.Sıfatlar);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Engin Sıfat Ekleyici";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Sıfatlar;
        private System.Windows.Forms.Button Ekle;
        private System.Windows.Forms.Label B;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

