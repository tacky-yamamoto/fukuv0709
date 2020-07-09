namespace fukuv0709
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.ue = new System.Windows.Forms.Button();
            this.migi = new System.Windows.Forms.Button();
            this.hidari = new System.Windows.Forms.Button();
            this.sita = new System.Windows.Forms.Button();
            this.shobon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ue
            // 
            this.ue.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.ue.Location = new System.Drawing.Point(62, 299);
            this.ue.Name = "ue";
            this.ue.Size = new System.Drawing.Size(50, 50);
            this.ue.TabIndex = 0;
            this.ue.Text = "↑";
            this.ue.UseVisualStyleBackColor = true;
            this.ue.Click += new System.EventHandler(this.ue_Click);
            // 
            // migi
            // 
            this.migi.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.migi.Location = new System.Drawing.Point(112, 349);
            this.migi.Name = "migi";
            this.migi.Size = new System.Drawing.Size(50, 50);
            this.migi.TabIndex = 1;
            this.migi.Text = "→";
            this.migi.UseVisualStyleBackColor = true;
            this.migi.Click += new System.EventHandler(this.migi_Click);
            // 
            // hidari
            // 
            this.hidari.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.hidari.Location = new System.Drawing.Point(12, 349);
            this.hidari.Name = "hidari";
            this.hidari.Size = new System.Drawing.Size(50, 50);
            this.hidari.TabIndex = 2;
            this.hidari.Text = "←";
            this.hidari.UseVisualStyleBackColor = true;
            this.hidari.Click += new System.EventHandler(this.hidari_Click);
            // 
            // sita
            // 
            this.sita.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.sita.Location = new System.Drawing.Point(62, 399);
            this.sita.Name = "sita";
            this.sita.Size = new System.Drawing.Size(50, 50);
            this.sita.TabIndex = 3;
            this.sita.Text = "↓";
            this.sita.UseVisualStyleBackColor = true;
            this.sita.Click += new System.EventHandler(this.sita_Click);
            // 
            // shobon
            // 
            this.shobon.AutoSize = true;
            this.shobon.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.shobon.Location = new System.Drawing.Point(172, 150);
            this.shobon.Name = "shobon";
            this.shobon.Size = new System.Drawing.Size(108, 27);
            this.shobon.TabIndex = 4;
            this.shobon.Text = "(´・ω・`)";
            this.shobon.Click += new System.EventHandler(this.shobon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.shobon);
            this.Controls.Add(this.sita);
            this.Controls.Add(this.hidari);
            this.Controls.Add(this.migi);
            this.Controls.Add(this.ue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ue;
        private System.Windows.Forms.Button migi;
        private System.Windows.Forms.Button hidari;
        private System.Windows.Forms.Button sita;
        private System.Windows.Forms.Label shobon;
    }
}

