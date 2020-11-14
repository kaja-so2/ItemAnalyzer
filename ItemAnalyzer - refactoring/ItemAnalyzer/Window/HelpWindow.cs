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
	public partial class HelpWindow : Form
	{
		public HelpWindow()
		{
			InitializeComponent();
		}

		private void HelpWindow_Load(object sender, EventArgs e)
		{
			richTextBox1.Text = "未実装";
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
