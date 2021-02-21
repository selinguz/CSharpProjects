
namespace Egitimlerim
{
	partial class Form2
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtEgitimBasligi = new System.Windows.Forms.TextBox();
			this.txtEgitimAltBasligi = new System.Windows.Forms.TextBox();
			this.txtSaat = new System.Windows.Forms.TextBox();
			this.txtDakika = new System.Windows.Forms.TextBox();
			this.btnKaydet = new System.Windows.Forms.Button();
			this.btnTemizle = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(29, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Eğitim Başlığı:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(29, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Eğitim Alt Başlığı:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(29, 114);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(101, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Eğitim Süresi (Saat):";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(29, 153);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(113, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Eğitim Süresi (Dakika):";
			// 
			// txtEgitimBasligi
			// 
			this.txtEgitimBasligi.Location = new System.Drawing.Point(148, 26);
			this.txtEgitimBasligi.Name = "txtEgitimBasligi";
			this.txtEgitimBasligi.Size = new System.Drawing.Size(100, 20);
			this.txtEgitimBasligi.TabIndex = 4;
			// 
			// txtEgitimAltBasligi
			// 
			this.txtEgitimAltBasligi.Location = new System.Drawing.Point(148, 64);
			this.txtEgitimAltBasligi.Name = "txtEgitimAltBasligi";
			this.txtEgitimAltBasligi.Size = new System.Drawing.Size(100, 20);
			this.txtEgitimAltBasligi.TabIndex = 5;
			// 
			// txtSaat
			// 
			this.txtSaat.Location = new System.Drawing.Point(148, 106);
			this.txtSaat.Name = "txtSaat";
			this.txtSaat.Size = new System.Drawing.Size(100, 20);
			this.txtSaat.TabIndex = 6;
			// 
			// txtDakika
			// 
			this.txtDakika.Location = new System.Drawing.Point(149, 145);
			this.txtDakika.Name = "txtDakika";
			this.txtDakika.Size = new System.Drawing.Size(100, 20);
			this.txtDakika.TabIndex = 7;
			// 
			// btnKaydet
			// 
			this.btnKaydet.Location = new System.Drawing.Point(149, 197);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(100, 23);
			this.btnKaydet.TabIndex = 8;
			this.btnKaydet.Text = "Kaydet";
			this.btnKaydet.UseVisualStyleBackColor = true;
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
			// 
			// btnTemizle
			// 
			this.btnTemizle.Location = new System.Drawing.Point(148, 237);
			this.btnTemizle.Name = "btnTemizle";
			this.btnTemizle.Size = new System.Drawing.Size(101, 23);
			this.btnTemizle.TabIndex = 9;
			this.btnTemizle.Text = "Temizle";
			this.btnTemizle.UseVisualStyleBackColor = true;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(313, 296);
			this.Controls.Add(this.btnTemizle);
			this.Controls.Add(this.btnKaydet);
			this.Controls.Add(this.txtDakika);
			this.Controls.Add(this.txtSaat);
			this.Controls.Add(this.txtEgitimAltBasligi);
			this.Controls.Add(this.txtEgitimBasligi);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form2";
			this.Text = "Form2";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtEgitimBasligi;
		private System.Windows.Forms.TextBox txtEgitimAltBasligi;
		private System.Windows.Forms.TextBox txtSaat;
		private System.Windows.Forms.TextBox txtDakika;
		private System.Windows.Forms.Button btnKaydet;
		private System.Windows.Forms.Button btnTemizle;
	}
}