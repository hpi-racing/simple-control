namespace WindowsApplication
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
			this.components = new System.ComponentModel.Container();
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.reglerControl6 = new WindowsApplication.ReglerControl();
			this.reglerControl5 = new WindowsApplication.ReglerControl();
			this.reglerControl4 = new WindowsApplication.ReglerControl();
			this.reglerControl3 = new WindowsApplication.ReglerControl();
			this.reglerControl2 = new WindowsApplication.ReglerControl();
			this.reglerControl1 = new WindowsApplication.ReglerControl();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(1043, 528);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(132, 32);
			this.button1.TabIndex = 7;
			this.button1.Text = "Tu was";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 427);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(109, 120);
			this.label3.TabIndex = 6;
			this.label3.Text = "0";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 307);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(336, 120);
			this.label2.TabIndex = 5;
			this.label2.Text = "label2";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 187);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(336, 120);
			this.label1.TabIndex = 4;
			this.label1.Text = "label1";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 50;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// reglerControl6
			// 
			this.reglerControl6.Location = new System.Drawing.Point(982, 12);
			this.reglerControl6.Name = "reglerControl6";
			this.reglerControl6.Size = new System.Drawing.Size(188, 142);
			this.reglerControl6.TabIndex = 13;
			// 
			// reglerControl5
			// 
			this.reglerControl5.Location = new System.Drawing.Point(788, 12);
			this.reglerControl5.Name = "reglerControl5";
			this.reglerControl5.Size = new System.Drawing.Size(188, 142);
			this.reglerControl5.TabIndex = 12;
			// 
			// reglerControl4
			// 
			this.reglerControl4.Location = new System.Drawing.Point(594, 12);
			this.reglerControl4.Name = "reglerControl4";
			this.reglerControl4.Size = new System.Drawing.Size(188, 142);
			this.reglerControl4.TabIndex = 11;
			// 
			// reglerControl3
			// 
			this.reglerControl3.Location = new System.Drawing.Point(400, 12);
			this.reglerControl3.Name = "reglerControl3";
			this.reglerControl3.Size = new System.Drawing.Size(188, 142);
			this.reglerControl3.TabIndex = 10;
			// 
			// reglerControl2
			// 
			this.reglerControl2.Location = new System.Drawing.Point(206, 12);
			this.reglerControl2.Name = "reglerControl2";
			this.reglerControl2.Size = new System.Drawing.Size(188, 142);
			this.reglerControl2.TabIndex = 9;
			// 
			// reglerControl1
			// 
			this.reglerControl1.Location = new System.Drawing.Point(12, 12);
			this.reglerControl1.Name = "reglerControl1";
			this.reglerControl1.Size = new System.Drawing.Size(188, 142);
			this.reglerControl1.TabIndex = 8;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1187, 572);
			this.Controls.Add(this.reglerControl6);
			this.Controls.Add(this.reglerControl5);
			this.Controls.Add(this.reglerControl4);
			this.Controls.Add(this.reglerControl3);
			this.Controls.Add(this.reglerControl2);
			this.Controls.Add(this.reglerControl1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Timer timer1;
		private ReglerControl reglerControl1;
		private ReglerControl reglerControl2;
		private ReglerControl reglerControl3;
		private ReglerControl reglerControl4;
		private ReglerControl reglerControl5;
		private ReglerControl reglerControl6;
	}
}

