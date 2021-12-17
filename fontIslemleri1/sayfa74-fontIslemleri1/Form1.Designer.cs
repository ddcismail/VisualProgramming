
namespace sayfa74_fontIslemleri1
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ustucizik = new System.Windows.Forms.Button();
            this.btn_alticizik = new System.Windows.Forms.Button();
            this.btn_egik = new System.Windows.Forms.Button();
            this.btn_kalin = new System.Windows.Forms.Button();
            this.txt_yazi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(607, 252);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown1.TabIndex = 13;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(537, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Font Boyutu";
            // 
            // btn_ustucizik
            // 
            this.btn_ustucizik.Location = new System.Drawing.Point(439, 252);
            this.btn_ustucizik.Name = "btn_ustucizik";
            this.btn_ustucizik.Size = new System.Drawing.Size(75, 23);
            this.btn_ustucizik.TabIndex = 11;
            this.btn_ustucizik.Text = "Üstü Çizili";
            this.btn_ustucizik.UseVisualStyleBackColor = true;
            this.btn_ustucizik.Click += new System.EventHandler(this.btn_ustucizik_Click);
            // 
            // btn_alticizik
            // 
            this.btn_alticizik.Location = new System.Drawing.Point(328, 252);
            this.btn_alticizik.Name = "btn_alticizik";
            this.btn_alticizik.Size = new System.Drawing.Size(75, 23);
            this.btn_alticizik.TabIndex = 10;
            this.btn_alticizik.Text = "Altı Çizili";
            this.btn_alticizik.UseVisualStyleBackColor = true;
            this.btn_alticizik.Click += new System.EventHandler(this.btn_alticizik_Click);
            // 
            // btn_egik
            // 
            this.btn_egik.Location = new System.Drawing.Point(222, 252);
            this.btn_egik.Name = "btn_egik";
            this.btn_egik.Size = new System.Drawing.Size(75, 23);
            this.btn_egik.TabIndex = 9;
            this.btn_egik.Text = "Eğik";
            this.btn_egik.UseVisualStyleBackColor = true;
            this.btn_egik.Click += new System.EventHandler(this.btn_egik_Click);
            // 
            // btn_kalin
            // 
            this.btn_kalin.Location = new System.Drawing.Point(119, 252);
            this.btn_kalin.Name = "btn_kalin";
            this.btn_kalin.Size = new System.Drawing.Size(75, 23);
            this.btn_kalin.TabIndex = 8;
            this.btn_kalin.Text = "Kalın";
            this.btn_kalin.UseVisualStyleBackColor = true;
            this.btn_kalin.Click += new System.EventHandler(this.btn_kalin_Click);
            // 
            // txt_yazi
            // 
            this.txt_yazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_yazi.Location = new System.Drawing.Point(119, 108);
            this.txt_yazi.Multiline = true;
            this.txt_yazi.Name = "txt_yazi";
            this.txt_yazi.Size = new System.Drawing.Size(535, 138);
            this.txt_yazi.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 298);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ustucizik);
            this.Controls.Add(this.btn_alticizik);
            this.Controls.Add(this.btn_egik);
            this.Controls.Add(this.btn_kalin);
            this.Controls.Add(this.txt_yazi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ustucizik;
        private System.Windows.Forms.Button btn_alticizik;
        private System.Windows.Forms.Button btn_egik;
        private System.Windows.Forms.Button btn_kalin;
        private System.Windows.Forms.TextBox txt_yazi;
    }
}

