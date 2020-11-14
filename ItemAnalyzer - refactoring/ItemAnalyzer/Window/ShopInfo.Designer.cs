namespace ItemAnalyzer
{
	partial class ShopInfo
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
			this.LblTax = new System.Windows.Forms.Label();
			this.TBTax = new System.Windows.Forms.TextBox();
			this.BtnSave = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// LblTax
			// 
			this.LblTax.AutoSize = true;
			this.LblTax.Location = new System.Drawing.Point(15, 47);
			this.LblTax.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.LblTax.Name = "LblTax";
			this.LblTax.Size = new System.Drawing.Size(61, 15);
			this.LblTax.TabIndex = 0;
			this.LblTax.Text = "税率(%)";
			// 
			// TBTax
			// 
			this.TBTax.Location = new System.Drawing.Point(103, 44);
			this.TBTax.Name = "TBTax";
			this.TBTax.Size = new System.Drawing.Size(112, 22);
			this.TBTax.TabIndex = 1;
			// 
			// BtnSave
			// 
			this.BtnSave.Location = new System.Drawing.Point(214, 70);
			this.BtnSave.Name = "BtnSave";
			this.BtnSave.Size = new System.Drawing.Size(106, 29);
			this.BtnSave.TabIndex = 2;
			this.BtnSave.Text = "保存";
			this.BtnSave.UseVisualStyleBackColor = true;
			this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
			// 
			// ShopInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(332, 111);
			this.Controls.Add(this.BtnSave);
			this.Controls.Add(this.TBTax);
			this.Controls.Add(this.LblTax);
			this.Font = new System.Drawing.Font("BIZ UDゴシック", 9F);
			this.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
			this.Name = "ShopInfo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "店舗情報の編集";
			this.Load += new System.EventHandler(this.ShopInfo_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LblTax;
		private System.Windows.Forms.TextBox TBTax;
		private System.Windows.Forms.Button BtnSave;
	}
}