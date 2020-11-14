namespace ItemAnalyzer.Window
{
	partial class ColorWindow
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
			this.BtnCancel = new System.Windows.Forms.Button();
			this.BtnOK = new System.Windows.Forms.Button();
			this.BtnBackClr = new System.Windows.Forms.Button();
			this.BtnBtnClr = new System.Windows.Forms.Button();
			this.BtnStrClr = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 50);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "背景色";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 120);
			this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 12);
			this.label2.TabIndex = 0;
			this.label2.Text = "ボタン色";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(15, 190);
			this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 12);
			this.label3.TabIndex = 0;
			this.label3.Text = "文字色";
			// 
			// BtnCancel
			// 
			this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnCancel.Location = new System.Drawing.Point(175, 242);
			this.BtnCancel.Name = "BtnCancel";
			this.BtnCancel.Size = new System.Drawing.Size(96, 34);
			this.BtnCancel.TabIndex = 2;
			this.BtnCancel.Text = "キャンセル";
			this.BtnCancel.UseVisualStyleBackColor = true;
			this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// BtnOK
			// 
			this.BtnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnOK.Location = new System.Drawing.Point(12, 242);
			this.BtnOK.Name = "BtnOK";
			this.BtnOK.Size = new System.Drawing.Size(96, 34);
			this.BtnOK.TabIndex = 3;
			this.BtnOK.Text = "OK";
			this.BtnOK.UseVisualStyleBackColor = true;
			this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
			// 
			// BtnBackClr
			// 
			this.BtnBackClr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnBackClr.Location = new System.Drawing.Point(175, 39);
			this.BtnBackClr.Name = "BtnBackClr";
			this.BtnBackClr.Size = new System.Drawing.Size(96, 34);
			this.BtnBackClr.TabIndex = 4;
			this.BtnBackClr.Text = "色の変更";
			this.BtnBackClr.UseVisualStyleBackColor = true;
			this.BtnBackClr.Click += new System.EventHandler(this.BtnBackClr_Click);
			// 
			// BtnBtnClr
			// 
			this.BtnBtnClr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnBtnClr.Location = new System.Drawing.Point(175, 109);
			this.BtnBtnClr.Name = "BtnBtnClr";
			this.BtnBtnClr.Size = new System.Drawing.Size(96, 34);
			this.BtnBtnClr.TabIndex = 5;
			this.BtnBtnClr.Text = "色の変更";
			this.BtnBtnClr.UseVisualStyleBackColor = true;
			this.BtnBtnClr.Click += new System.EventHandler(this.BtnBtnClr_Click);
			// 
			// BtnStrClr
			// 
			this.BtnStrClr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnStrClr.Location = new System.Drawing.Point(175, 179);
			this.BtnStrClr.Name = "BtnStrClr";
			this.BtnStrClr.Size = new System.Drawing.Size(96, 34);
			this.BtnStrClr.TabIndex = 6;
			this.BtnStrClr.Text = "色の変更";
			this.BtnStrClr.UseVisualStyleBackColor = true;
			this.BtnStrClr.Click += new System.EventHandler(this.BtnStrClr_Click);
			// 
			// ColorWindow
			// 
			this.AcceptButton = this.BtnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.BtnCancel;
			this.ClientSize = new System.Drawing.Size(283, 286);
			this.Controls.Add(this.BtnStrClr);
			this.Controls.Add(this.BtnBtnClr);
			this.Controls.Add(this.BtnBackClr);
			this.Controls.Add(this.BtnOK);
			this.Controls.Add(this.BtnCancel);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("BIZ UDゴシック", 9F);
			this.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
			this.Name = "ColorWindow";
			this.Text = "色の変更";
			this.Load += new System.EventHandler(this.ColorWindow_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button BtnCancel;
		private System.Windows.Forms.Button BtnOK;
		private System.Windows.Forms.Button BtnBackClr;
		private System.Windows.Forms.Button BtnBtnClr;
		private System.Windows.Forms.Button BtnStrClr;

	}
}