
namespace USteuerbetrag
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.txtGehalt = new System.Windows.Forms.TextBox();
			this.btnBerechnen = new System.Windows.Forms.Button();
			this.lblSteuerbetrag = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Gehalt:";
			// 
			// txtGehalt
			// 
			this.txtGehalt.Location = new System.Drawing.Point(13, 30);
			this.txtGehalt.Name = "txtGehalt";
			this.txtGehalt.Size = new System.Drawing.Size(100, 20);
			this.txtGehalt.TabIndex = 1;
			// 
			// btnBerechnen
			// 
			this.btnBerechnen.Location = new System.Drawing.Point(13, 65);
			this.btnBerechnen.Name = "btnBerechnen";
			this.btnBerechnen.Size = new System.Drawing.Size(100, 23);
			this.btnBerechnen.TabIndex = 2;
			this.btnBerechnen.Text = "Berechnen";
			this.btnBerechnen.UseVisualStyleBackColor = true;
			this.btnBerechnen.Click += new System.EventHandler(this.btnBerechnen_Click);
			// 
			// lblSteuerbetrag
			// 
			this.lblSteuerbetrag.AutoSize = true;
			this.lblSteuerbetrag.Location = new System.Drawing.Point(139, 36);
			this.lblSteuerbetrag.Name = "lblSteuerbetrag";
			this.lblSteuerbetrag.Size = new System.Drawing.Size(35, 13);
			this.lblSteuerbetrag.TabIndex = 3;
			this.lblSteuerbetrag.Text = "label2";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(317, 104);
			this.Controls.Add(this.lblSteuerbetrag);
			this.Controls.Add(this.btnBerechnen);
			this.Controls.Add(this.txtGehalt);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Steuerbetrag berechnen";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtGehalt;
		private System.Windows.Forms.Button btnBerechnen;
		private System.Windows.Forms.Label lblSteuerbetrag;
	}
}

