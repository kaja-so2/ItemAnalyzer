using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ItemAnalyzer.DataInfo;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ItemAnalyzer.Window
{
	[Serializable()]
	public partial class ColorWindow : Form
	{
		/// <summary>
		/// カラーダイアログのカスタムカラー配列
		/// </summary>
		private int[] customColors = new int[0];

		/// <summary>
		/// カスタムカラーの保存場所
		/// </summary>
		[NonSerialized()]
		private const string path = "CustomColors.bin";

		public ColorWindow()
		{
			InitializeComponent();
		}

		/// <summary>
		/// フォームロード
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ColorWindow_Load(object sender, EventArgs e)
		{
			var backColor = RegistryAccessor.GetRegistryValue(RegistryAccessor.KeyName.BackColor);
			var btnColor = RegistryAccessor.GetRegistryValue(RegistryAccessor.KeyName.BtnColor);
			var strColor = RegistryAccessor.GetRegistryValue(RegistryAccessor.KeyName.StrColor);

			this.BackColor = backColor;
			this.ForeColor = strColor;
			BtnBackClr.BackColor = btnColor;
			BtnBtnClr.BackColor = btnColor;
			BtnStrClr.BackColor = btnColor;
			BtnOK.BackColor = btnColor;
			BtnCancel.BackColor = btnColor;
			ReadCustomColors();
		}

		/// <summary>
		/// 背景色の変更ボタンのイベントハンドラ
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnBackClr_Click(object sender, EventArgs e)
		{
			var clrDlg = CallColorDialog(this.BackColor);

			if (clrDlg.ShowDialog() == DialogResult.OK)
			{
				this.BackColor = clrDlg.Color;
				customColors = clrDlg.CustomColors;
			}
		}

		/// <summary>
		/// ボタン色の変更ボタンのイベントハンドラ
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnBtnClr_Click(object sender, EventArgs e)
		{
			var clrDlg = CallColorDialog(BtnBtnClr.BackColor);

			if (clrDlg.ShowDialog() == DialogResult.OK)
			{
				BtnBackClr.BackColor = clrDlg.Color;
				BtnBtnClr.BackColor = clrDlg.Color;
				BtnStrClr.BackColor = clrDlg.Color;
				BtnOK.BackColor = clrDlg.Color;
				BtnCancel.BackColor = clrDlg.Color;
				customColors = clrDlg.CustomColors;
			}
		}

		/// <summary>
		/// 文字色の変更ボタンのイベントハンドラ
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnStrClr_Click(object sender, EventArgs e)
		{
			var clrDlg = CallColorDialog(this.ForeColor);

			if (clrDlg.ShowDialog() == DialogResult.OK)
			{
				this.ForeColor = clrDlg.Color;
				customColors = clrDlg.CustomColors;
			}
		}

		/// <summary>
		/// カラーダイアログの呼び出し
		/// </summary>
		/// <param name="setColor"></param>
		/// <returns></returns>
		private ColorDialog CallColorDialog(Color setColor)
		{
			ColorDialog clrDlg = new ColorDialog();
			clrDlg.Color = setColor;
			clrDlg.AnyColor = true;
			clrDlg.CustomColors = customColors;
			clrDlg.FullOpen = true;
			return clrDlg;
		}

		/// <summary>
		/// OKボタンのイベントハンドラ
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnOK_Click(object sender, EventArgs e)
		{
			RegistryAccessor.SetRegistryValue(this.BackColor, RegistryAccessor.KeyName.BackColor);
			RegistryAccessor.SetRegistryValue(BtnBtnClr.BackColor, RegistryAccessor.KeyName.BtnColor);
			RegistryAccessor.SetRegistryValue(this.ForeColor, RegistryAccessor.KeyName.StrColor);
			WriteCustomColors();
			this.Close();
		}

		/// <summary>
		/// キャンセルボタンのイベントハンドラ
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		/// <summary>
		/// ファイルのカスタムカラーを読み込む
		/// </summary>
		private void ReadCustomColors()
		{
			using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
			{
				if (fs.Length == 0) return;

				BinaryFormatter bf = new BinaryFormatter();
				customColors = (int[])bf.Deserialize(fs);
			}
		}

		/// <summary>
		/// ファイルにカスタムカラーを書き込む
		/// </summary>
		private void WriteCustomColors()
		{
			using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
			{
				BinaryFormatter bf = new BinaryFormatter();
				bf.Serialize(fs, customColors);
			}
		}
	}
}
