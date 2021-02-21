
namespace Egitimlerim
{
	partial class Form1
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
			this.btnEgitimOlustur = new System.Windows.Forms.Button();
			this.btnEgitimlerimeGit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnEgitimOlustur
			// 
			this.btnEgitimOlustur.Location = new System.Drawing.Point(30, 33);
			this.btnEgitimOlustur.Name = "btnEgitimOlustur";
			this.btnEgitimOlustur.Size = new System.Drawing.Size(100, 63);
			this.btnEgitimOlustur.TabIndex = 0;
			this.btnEgitimOlustur.Text = "Eğitim Oluştur";
			this.btnEgitimOlustur.UseVisualStyleBackColor = true;
			this.btnEgitimOlustur.Click += new System.EventHandler(this.btnEgitimOlustur_Click);
			// 
			// btnEgitimlerimeGit
			// 
			this.btnEgitimlerimeGit.Location = new System.Drawing.Point(220, 33);
			this.btnEgitimlerimeGit.Name = "btnEgitimlerimeGit";
			this.btnEgitimlerimeGit.Size = new System.Drawing.Size(105, 63);
			this.btnEgitimlerimeGit.TabIndex = 1;
			this.btnEgitimlerimeGit.Text = "Eğitimlerime Git";
			this.btnEgitimlerimeGit.UseVisualStyleBackColor = true;
			this.btnEgitimlerimeGit.Click += new System.EventHandler(this.btnEgitimlerimeGit_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(356, 146);
			this.Controls.Add(this.btnEgitimlerimeGit);
			this.Controls.Add(this.btnEgitimOlustur);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnEgitimOlustur;
		private System.Windows.Forms.Button btnEgitimlerimeGit;
	}
}

