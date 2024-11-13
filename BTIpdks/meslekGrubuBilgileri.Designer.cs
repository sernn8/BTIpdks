namespace BTIpdks
{
    partial class meslekGrubuBilgileri
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGrupEkle = new System.Windows.Forms.Button();
            this.btnGrupSil = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1040, 523);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnGrupEkle
            // 
            this.btnGrupEkle.Location = new System.Drawing.Point(27, 586);
            this.btnGrupEkle.Name = "btnGrupEkle";
            this.btnGrupEkle.Size = new System.Drawing.Size(224, 53);
            this.btnGrupEkle.TabIndex = 1;
            this.btnGrupEkle.Text = "Yeni Meslek Grubu Ekle";
            this.btnGrupEkle.UseVisualStyleBackColor = true;
            // 
            // btnGrupSil
            // 
            this.btnGrupSil.Location = new System.Drawing.Point(285, 586);
            this.btnGrupSil.Name = "btnGrupSil";
            this.btnGrupSil.Size = new System.Drawing.Size(224, 53);
            this.btnGrupSil.TabIndex = 2;
            this.btnGrupSil.Text = "Meslek Grubu Sil";
            this.btnGrupSil.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(546, 586);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(224, 53);
            this.button3.TabIndex = 3;
            this.button3.Text = "Meslek Grubu Güncelle";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(807, 586);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(224, 53);
            this.button4.TabIndex = 4;
            this.button4.Text = "Meslek Gruplarını Listele";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // meslekGrubuBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 721);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnGrupSil);
            this.Controls.Add(this.btnGrupEkle);
            this.Controls.Add(this.dataGridView1);
            this.Name = "meslekGrubuBilgileri";
            this.Text = "meslekGrubuBilgileri";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGrupEkle;
        private System.Windows.Forms.Button btnGrupSil;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}