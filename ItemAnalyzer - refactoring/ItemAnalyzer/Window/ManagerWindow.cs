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
	public partial class ManagerWindow : Form
	{
		public ManagerWindow()
		{
			InitializeComponent();
		}

		private void ManagerInfo_Load(object sender, EventArgs e)
		{

		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			//リンク先に移動したことにする
			linkLabel1.LinkVisited = true;
			//ブラウザで開く
			System.Diagnostics.Process.Start("https://twitter.com/bluecity_kaja");
		}
	}
}
