using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ItemAnalyzer
{
	/// <summary>
	/// 店舗情報を表すクラスDEATH。主に税金。
	/// </summary>
	public partial class ShopInfo : Form
	{
		public static int Tax;

		public ShopInfo()
		{
			InitializeComponent();
			ShopInfo.Tax = 7;
		}

		private void BtnSave_Click(object sender, EventArgs e)
		{
			ShopInfo.Tax = int.Parse(TBTax.Text);
			this.Close();
		}

		private void ShopInfo_Load(object sender, EventArgs e)
		{
			TBTax.Text = ShopInfo.Tax.ToString();
		}
	}
}
