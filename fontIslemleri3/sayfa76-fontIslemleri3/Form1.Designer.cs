
namespace sayfa76_fontIslemleri3
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
            this.txt_yazi = new System.Windows.Forms.TextBox();
            this.listBox_fontlar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txt_yazi
            // 
            this.txt_yazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_yazi.Location = new System.Drawing.Point(211, 145);
            this.txt_yazi.Multiline = true;
            this.txt_yazi.Name = "txt_yazi";
            this.txt_yazi.Size = new System.Drawing.Size(305, 92);
            this.txt_yazi.TabIndex = 3;
            this.txt_yazi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listBox_fontlar
            // 
            this.listBox_fontlar.FormattingEnabled = true;
            this.listBox_fontlar.Location = new System.Drawing.Point(35, 25);
            this.listBox_fontlar.Name = "listBox_fontlar";
            this.listBox_fontlar.Size = new System.Drawing.Size(154, 407);
            this.listBox_fontlar.TabIndex = 2;
            this.listBox_fontlar.SelectedIndexChanged += new System.EventHandler(this.listBox_fontlar_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_yazi);
            this.Controls.Add(this.listBox_fontlar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_yazi;
        private System.Windows.Forms.ListBox listBox_fontlar;
    }
}

