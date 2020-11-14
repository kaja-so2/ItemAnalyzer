using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using ItemAnalyzer.DataInfo;
using System.Runtime.InteropServices;

namespace ItemAnalyzer
{
	public partial class MainWindow : Form
	{
		#region プロパティ

		/// <summary>
		/// 商品情報のリスト
		/// </summary>
		public static List<ItemInfo> ItemList = new List<ItemInfo>();

		private readonly ItemInfo item = new ItemInfo();

		/// <summary>
		/// 現在表示中のレコード
		/// </summary>
		private int nowRecord = 0;

		/// <summary>
		/// データが、開く/新規作成/保存 の直後と違うデータになっているか
		/// </summary>
		private bool isDataChange = false;

		/// <summary>
		/// 起動直後かどうか
		/// </summary>
		private bool isStartUp = true;

		/// <summary>
		/// 新規作成直後か
		/// </summary>
		private bool isNewInfo = false;

		#endregion

		#region 定数

		/// <summary>
		/// 入力系エラーのタイトル
		/// </summary>
		private const string ERR_TITLE_INPUT = "入力エラー";

		/// <summary>
		/// ファイル読み込みエラーのタイトル
		/// </summary>
		private const string ERR_TITLE_OPEN = "ファイル読み込みエラー";

		/// <summary>
		/// ファイル保存エラーのタイトル
		/// </summary>
		private const string ERR_TITLE_SAVE = "ファイル保存エラー";

		/// <summary>
		/// メモリが漏れたときのエラーのタイトル
		/// </summary>
		private const string ERR_TITLE_MEMORY = "重大なエラー";

		/// <summary>
		/// ファイル読み込みエラーのエラーメッセージ
		/// </summary>
		private const string ERR_MSG_OPEN = "ファイルの読み込みに失敗しました。";

		/// <summary>
		/// ファイル保存エラーのエラーメッセージ
		/// </summary>
		private const string ERR_MSG_SAVE = "ファイルの保存に失敗しました。";

		/// <summary>
		/// メモリ漏れエラーのエラーメッセージ
		/// </summary>
		private const string ERR_MSG_MEMORY = "メモリが溢れています。ｱﾊﾞﾊﾞﾊﾞﾊﾞﾊﾞﾊﾞﾊﾞb\r\nアプリケーションを終了します。";

		/// <summary>
		/// (必須項目)エラーメッセージ
		/// </summary>
		private const string ERR_MSG_REQUIRED = "未入力項目があります";

		/// <summary>
		/// (CSV保存)エラーメッセージ
		/// </summary>
		private const string ERR_MSG_CSV = "CSVファイルではカンマ、ダブルクォーテーションは不正な文字です。\r\n(処理かくの面倒だったなんて言えない)";

		/// <summary>
		/// (保存確認ダイアログ)エラータイトル
		/// </summary>
		private const string COMFIRM_TITLE_SAVE = "ファイル保存確認";

		/// <summary>
		/// (保存確認ダイアログ)エラーメッセージ
		/// </summary>
		private const string COMFIRM_MSG_SAVE = "解析情報を保存しますか？";

		/// <summary>
		/// 上書き保存成功時のダイアログタイトル
		/// </summary>
		private const string SUCCESS_TITLE_OVERSAVE = "Information";

		/// <summary>
		/// 上書き保存成功時のダイアログメッセージ
		/// </summary>
		private const string SUCCESS_MSG_OVERSAVE = "上書き保存が成功しました。";

		/// <summary>
		/// 表示させる単位(％)
		/// </summary>
		private const string UNIT_PER = "%";

		/// <summary>
		/// 改行コード
		/// </summary>
		private const string BREAK_LINE = "\r\n";

		#endregion

		#region コンストラクタ、フォームロード

		public MainWindow()
		{
			InitializeComponent();
			ShopInfo.Tax = 7;
		}

		private void MainWindow_Load(object sender, EventArgs e)
		{
			DisableBtn_Load();
			SetColor();
			ShowShopInfo();
			isStartUp = true;
		}

		#endregion

		#region イベントハンドラ

		#region 普通のボタンのイベントハンドラ

		/// <summary>
		/// 解析ボタンのイベントハンドラ
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnAnalyze_Click(object sender, EventArgs e)
		{
			if (RequiredCheck() == false) return;
			SaveNowInfo();
			ShowAnalyze();
		}

		/// <summary>
		/// 店舗情報の編集ボタンのイベントハンドラ
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnShopInfo_Click(object sender, EventArgs e)
		{
			ShopInfo shop = new ShopInfo();
			shop.ShowDialog();
			LblTax.Text = "税率(%):" + ShopInfo.Tax.ToString() + UNIT_PER;
		}

		/// <summary>
		/// 前ボタンのイベントハンドラ
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnPrevious_Click(object sender, EventArgs e)
		{
			if (RequiredCheck() == false) return;
			SaveNowInfo();
			nowRecord--;
			ShowInfo();
			ShowAnalyze();
			EnableBtn_PreNextDel();
		}

		/// <summary>
		/// 次ボタンのイベントハンドラ
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnNext_Click(object sender, EventArgs e)
		{
			if (RequiredCheck() == false) return;
			SaveNowInfo();
			nowRecord++;
			ShowInfo();
			ShowAnalyze();
			EnableBtn_PreNextDel();
		}

		private void BtnAdd_Click(object sender, EventArgs e)
		{
			ItemList.Add(new ItemInfo(this));
			nowRecord++;
			ShowInfo();
			EnableBtn_PreNextDel();
		}

		private void BtnAddCopy_Click(object sender, EventArgs e)
		{
			ItemList.Add(ItemList[nowRecord]);
			nowRecord++;
			ShowInfo();
			EnableBtn_PreNextDel();
		}

		private void BtnDelete_Click(object sender, EventArgs e)
		{
			ItemList.RemoveAt(nowRecord);
			if (ItemList.Count == nowRecord)
			{
				nowRecord--;
			}
			ShowInfo();
			EnableBtn_PreNextDel();
			isDataChange = true;
		}

		#endregion

		#region ToolStripのボタンのイベントハンドラ

		/// <summary>
		/// 開くボタンのイベントハンドラ
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TSBtn_Open_Click(object sender, EventArgs e)
		{
			if (SaveChecker(sender, e) == DialogResult.Cancel)
				return;

			OpenFileDialog openDlg = new OpenFileDialog();
			openDlg.Filter = "解析データファイル(*.so;*.csv;*.json)|*.so;*.csv;*.json";
			DialogResult dlg = openDlg.ShowDialog();
			if (dlg == DialogResult.Cancel) return;

			if (dlg == DialogResult.OK)
			{
				try
				{
					string path = Path.GetExtension(openDlg.FileName);
					if (path.Equals(".so"))
						item.OpenSo(openDlg.FileName);
					else if (path.Equals(".csv"))
						item.OpenCsv(openDlg.FileName);
					else
						item.OpenJson(openDlg.FileName);

					nowRecord = 0;
					ShowInfo();
					ShowAnalyze();
				}
				catch (Exception ex)
				{
					System.Diagnostics.Debug.WriteLine(ex.StackTrace);
					if (ex is ArgumentException || ex is IOException || ex is FormatException || ex is Newtonsoft.Json.JsonReaderException)
					{
						MessageBox.Show(this, ERR_MSG_OPEN, ERR_TITLE_OPEN, MessageBoxButtons.OK, MessageBoxIcon.Error);
						ItemList = new List<ItemInfo>();
						DisableBtn_Load();
						ClearAllControl();
						return;
					}
					throw;
				}
				ShowFilePath(openDlg.FileName);
				EnableBtn_OpenOrCreate();
				RemoveFilePath();
				isDataChange = false;
				isStartUp = false;
				isNewInfo = false;
			}
		}

		/// <summary>
		/// 上書き保存ボタンのイベントハンドラ
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TSBtn_OverSave_Click(object sender, EventArgs e)
		{
			if (isNewInfo)
			{
				TSBtn_NamedSave_Click(sender, e);
				return;
			}

			if (RequiredCheck() == false) return;

			try
			{
				string path = Path.GetExtension(LblFilePath.Text);
				ItemInfo item = new ItemInfo(this);

				if (path.Equals(".so"))
					item.SaveSo(ToolTipFullPath.GetToolTip(LblFilePath));
				else if (path.Equals(".csv"))
					item.SaveCsv(ToolTipFullPath.GetToolTip(LblFilePath));
				else if (path.Equals(".json"))
					item.SaveJson(ToolTipFullPath.GetToolTip(LblFilePath));

				RemoveFilePath();
			}
			catch (Exception ex)
			{
				System.Diagnostics.Debug.WriteLine(ex.StackTrace);
				if (ex is ArgumentException || ex is IOException || ex is FormatException)
				{
					MessageBox.Show(
						this, ERR_MSG_SAVE, ERR_TITLE_SAVE, MessageBoxButtons.OK, MessageBoxIcon.Error);
					AddFileAsterisk();
				}
				else
					throw;
			}
			isDataChange = false;
			isNewInfo = false;
			MessageBox.Show(this, SUCCESS_MSG_OVERSAVE, SUCCESS_TITLE_OVERSAVE, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		/// <summary>
		/// 名前を付けて保存ボタンのイベントハンドラ
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TSBtn_NamedSave_Click(object sender, EventArgs e)
		{
			if (RequiredCheck() == false) return;

			SaveFileDialog saveDlg = new SaveFileDialog();
			saveDlg.Filter = "解析データファイル(*.so)|*.so";
			DialogResult dlg = saveDlg.ShowDialog();
			if (dlg == DialogResult.Cancel) return;

			if (dlg == DialogResult.OK)
			{
				try
				{
					item.SaveSo(saveDlg.FileName);
				}
				catch (IOException)
				{
					MessageBox.Show(
						this, ERR_MSG_SAVE, ERR_TITLE_SAVE, MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				isDataChange = false;
				isNewInfo = false;
			}
			ShowFilePath(saveDlg.FileName);
		}

		/// <summary>
		/// 新規作成ボタンのイベントハンドラ
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TSBtn_NewInfo_Click(object sender, EventArgs e)
		{
			if (SaveChecker(sender, e) == DialogResult.Cancel)
				return;

			ItemList = new List<ItemInfo>();
			ItemList.Add(new ItemInfo(this));

			nowRecord = 0;
			ShowInfo();
			ShowAnalyze();

			EnableBtn_OpenOrCreate();
			isDataChange = false;
			isStartUp = false;
			isNewInfo = true;
		}

		private void TSMenu_Help_Click(object sender, EventArgs e)
		{
			HelpWindow help = new HelpWindow();
			help.Show();
		}

		private void TSMenu_Manager_Click(object sender, EventArgs e)
		{
			ManagerWindow manager = new ManagerWindow();
			manager.Show();
		}

		private void TSMenu_ConvertToCsv_Click(object sender, EventArgs e)
		{
			if (!RegexTextBox(TBItemName) || !RegexDataGridView())
			{
				MessageBox.Show(
					this, "カンマ、ダブルクォーテーションは不正な文字です。\r\n(処理かくの面倒だったなんて言えない)",
					ERR_TITLE_INPUT, MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			SaveFileDialog saveDlg = new SaveFileDialog();
			saveDlg.Filter = "解析データファイル(*.csv)|*.csv";
			if (saveDlg.ShowDialog() == DialogResult.OK)
			{
				try
				{
					item.SaveCsv(saveDlg.FileName);
				}
				catch (IOException)
				{
					MessageBox.Show(
						this, ERR_MSG_SAVE, ERR_TITLE_SAVE, MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}
		}

		private void TSMenuItem_Previous_Click(object sender, EventArgs e)
		{
			BtnPrevious_Click(sender, e);
		}

		private void TSMenuItem_Next_Click(object sender, EventArgs e)
		{
			BtnNext_Click(sender, e);
		}

		#endregion

		#region ボタン以外のイベントハンドラ

		private void DgvMaterial_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			DgvDataChange();
		}

		/// <summary>
		/// isDataChangeフラグ(保存確認ダイアログに使われる)の処理
		/// </summary>
		/// <param name="tb"></param>
		/// <param name="listText"></param>
		/// <returns></returns>
		private bool CheckTextChanged(TextBox tb, string listText)
		{
			if (RegexTextBox(tb) == false || ItemList.Count == 0) return false;

			if (!tb.Text.Equals(listText))
			{
				AddFileAsterisk();
				isDataChange = true;
				return true;
			}
			return false;
		}

		private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (SaveChecker(sender, e) == DialogResult.Cancel)
			{
				e.Cancel = true;
			}
		}

		#region テキストボックスのイベントハンドラ

		private void TBItemName_TextChanged(object sender, EventArgs e)
		{
			if (ItemList.Count == 0) return;
			CheckTextChanged(TBItemName, ItemList[nowRecord].Name);
		}

		private void TBPrice_TextChanged(object sender, EventArgs e)
		{
			if (ItemList.Count == 0) return;
			CheckTextChanged(TBPrice, ItemList[nowRecord].Price.ToString());
		}

		private void TBAmount_TextChanged(object sender, EventArgs e)
		{
			if (ItemList.Count == 0) return;
			CheckTextChanged(TBAmount, ItemList[nowRecord].Amount.ToString());
		}

		private void TBProductSpeed_TextChanged(object sender, EventArgs e)
		{
			if (ItemList.Count == 0) return;
			CheckTextChanged(TBProductSpeed, ItemList[nowRecord].ProductSpeed.ToString());
		}

		private void TBProductTime_TextChanged(object sender, EventArgs e)
		{
			if (ItemList.Count == 0) return;
			CheckTextChanged(TBProductTime, ItemList[nowRecord].ProductTime.ToString());
		}

		private void TBRoyality_TextChanged(object sender, EventArgs e)
		{
			if (ItemList.Count == 0) return;
			CheckTextChanged(TBRoyality, ItemList[nowRecord].Royality.ToString());
		}

		#endregion

		#endregion

		#endregion

		#region コントロール操作

		#region Control_Enable/Disable

		/// <summary>
		/// ロード時のコントロール状態に戻す処理
		/// </summary>
		private void DisableBtn_Load()
		{
			//ToolStrip
			TSMenu_OverSave.Enabled = false;
			TSMenu_NamedSave.Enabled = false;
			TSMenu_Conversion.Enabled = false;
			TSMenu_AddInfo.Enabled = false;
			TSMenu_CopyAdd.Enabled = false;
			TSMenu_Delete.Enabled = false;
			TSMenu_EditShopInfo.Enabled = false;
			TSMenu_Previous.Enabled = false;
			TSMenu_Next.Enabled = false;
			TSMenu_Analyze.Enabled = false;

			//ToolStripBtn
			TSBtn_NamedSave.Enabled = false;
			TSBtn_OverSave.Enabled = false;

			//Btn
			BtnAnalyze.Enabled = false;
			BtnShopInfo.Enabled = false;
			BtnAdd.Enabled = false;
			BtnAddCopy.Enabled = false;
			BtnDelete.Enabled = false;
			BtnNext.Enabled = false;
			BtnPrevious.Enabled = false;

			//TextBox
			TBItemName.Enabled = false;
			TBAmount.Enabled = false;
			TBPrice.Enabled = false;
			TBProductSpeed.Enabled = false;
			TBProductTime.Enabled = false;
			TBRoyality.Enabled = false;
			TBProfit.Enabled = false;
			TBProfitPer.Enabled = false;
			TBCost.Enabled = false;
			TBCostPer.Enabled = false;
			TBProfitPerItem.Enabled = false;
			TBCostPerItem.Enabled = false;
			TBPerTime.Enabled = false;

			DgvMaterial.Enabled = false;
		}

		/// <summary>
		/// 開く/新規作成したときのコントロール状態にする処理
		/// </summary>
		private void EnableBtn_OpenOrCreate()
		{
			//ToolStrip
			TSMenu_OverSave.Enabled = true;
			TSMenu_NamedSave.Enabled = true;
			TSMenu_Conversion.Enabled = true;
			TSMenu_AddInfo.Enabled = true;
			TSMenu_CopyAdd.Enabled = true;
			TSMenu_Delete.Enabled = true;
			TSMenu_EditShopInfo.Enabled = true;
			TSMenu_Analyze.Enabled = true;

			//ToolStripBtn
			TSBtn_NamedSave.Enabled = true;
			TSBtn_OverSave.Enabled = true;

			//Btn
			BtnAnalyze.Enabled = true;
			BtnShopInfo.Enabled = true;
			BtnAdd.Enabled = true;
			BtnAddCopy.Enabled = true;
			BtnDelete.Enabled = true;
			EnableBtn_PreNextDel();

			//TextBox
			TBItemName.Enabled = true;
			TBAmount.Enabled = true;
			TBPrice.Enabled = true;
			TBProductSpeed.Enabled = true;
			TBProductTime.Enabled = true;
			TBRoyality.Enabled = true;
			TBProfit.Enabled = true;
			TBProfitPer.Enabled = true;
			TBCost.Enabled = true;
			TBCostPer.Enabled = true;
			TBProfitPerItem.Enabled = true;
			TBCostPerItem.Enabled = true;
			TBPerTime.Enabled = true;

			DgvMaterial.Enabled = true;
		}

		/// <summary>
		/// 前/次/削除ボタンのコントロール状態を決める処理
		/// </summary>
		private void EnableBtn_PreNextDel()
		{
			if (nowRecord == 0)
			{
				BtnPrevious.Enabled = false;
				TSMenu_Previous.Enabled = false;

				//レコードが1つのとき(0 == ItemList.Count - 1)
				if (nowRecord == ItemList.Count - 1)
				{
					TSMenu_Delete.Enabled = false;
					BtnDelete.Enabled = false;
				}
				else
				{
					TSMenu_Delete.Enabled = true;
					BtnDelete.Enabled = true;
				}
			}
			else
			{
				BtnPrevious.Enabled = true;
				TSMenu_Previous.Enabled = true;
				BtnDelete.Enabled = true;
				TSMenu_Delete.Enabled = true;
			}

			//最後のレコードのとき
			if (nowRecord == ItemList.Count - 1)
			{
				BtnNext.Enabled = false;
				TSMenu_Next.Enabled = false;
			}
			else
			{
				BtnNext.Enabled = true;
				TSMenu_Next.Enabled = true;
			}
		}

		#endregion

		/// <summary>
		/// ファイルパス表示から「*」を消す処理
		/// </summary>
		private void RemoveFilePath()
		{
			if (isDataChange)
			{
				string path = LblFilePath.Text;
				if (path.EndsWith("*"))
				{
					path = path.Substring(0, path.Length - 1);
					LblFilePath.Text = path;
				}
			}
		}

		/// <summary>
		/// ファイルパス表示に「*」を付加する処理
		/// </summary>
		private void AddFileAsterisk()
		{
			string path = LblFilePath.Text;
			if (!path.EndsWith("*"))
			{
				LblFilePath.Text += "*";
			}
		}

		/// <summary>
		/// 必須項目を設定する。
		/// 必須項目が抜けている場合は、エラーダイアログが表示される。
		/// </summary>
		/// <returns></returns>
		private bool RequiredCheck()
		{
			//必須項目はこの5つ。
			if (TBItemName.Text.Equals(string.Empty) || TBAmount.Text.Equals(string.Empty) ||
				TBPrice.Text.Equals(string.Empty) || TBProductSpeed.Text.Equals(string.Empty) ||
				TBProductTime.Text.Equals(string.Empty))
			{
				MessageBox.Show(
					this, ERR_MSG_REQUIRED, ERR_TITLE_INPUT,
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			for (int i = 0; i < DgvMaterial.RowCount; i++)
			{
				//新規行は常に最終行
				if (DgvMaterial.Rows[i].IsNewRow) return true;

				if (DgvMaterial.Rows[i].Cells[0].Value == null ||
					DgvMaterial.Rows[i].Cells[1].Value == null ||
					DgvMaterial.Rows[i].Cells[2].Value == null ||
					DgvMaterial.Rows[i].Cells[3].Value == null)
				{
					MessageBox.Show(
						this, ERR_MSG_REQUIRED, ERR_TITLE_INPUT,
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
			}
			return true;
		}

		/// <summary>
		/// コントロールに現在の情報を表示する
		/// </summary>
		private void ShowInfo()
		{
			TBItemName.Text = ItemList[nowRecord].Name;
			TBPrice.Text = ItemList[nowRecord].Price.ToString();
			TBAmount.Text = ItemList[nowRecord].Amount.ToString();
			TBProductSpeed.Text = ItemList[nowRecord].ProductSpeed.ToString();
			TBProductTime.Text = ItemList[nowRecord].ProductTime.ToString();
			TBRoyality.Text = ItemList[nowRecord].Royality.ToString();

			ShowMaterial();
			ShowShopInfo();
			ShowRecord();
		}

		/// <summary>
		/// コントロールに現在の材料情報を表示する。
		/// </summary>
		private void ShowMaterial()
		{
			//DgvMaterialで選択されているすべての行を削除する
			DgvMaterial.SelectAll();
			foreach (DataGridViewRow r in DgvMaterial.SelectedRows)
			{
				if (!r.IsNewRow)
				{
					DgvMaterial.Rows.Remove(r);
				}
			}

			//行追加
			int i = 0;
			foreach (MaterialInfo material in ItemList[nowRecord].MaterialList)
			{
				DgvMaterial.Rows.Add();
				DgvMaterial.Rows[i].Cells[0].Value = material.MaterialName;
				DgvMaterial.Rows[i].Cells[1].Value = material.BuyPrice;
				DgvMaterial.Rows[i].Cells[2].Value = material.RequiredAmount;
				DgvMaterial.Rows[i].Cells[3].Value = MaterialInfo.GetMaterialString(material.Type);
				i++;
			}
		}

		private void ShowAnalyze()
		{
			//ToString("F")は、小数点以下第二位を四捨五入する(多分)
			AnalyzeInfo analyze = AnalyzeInfo.DoAnalyze(ItemList[nowRecord]);
			TBProfit.Text = analyze.Profit.ToString("F");
			TBProfitPer.Text = analyze.ProfitPer.ToString("F");
			TBCost.Text = analyze.Cost.ToString("F");
			TBCostPer.Text = analyze.CostPer.ToString("F");
			TBProfitPerItem.Text = analyze.ProfitPerItem.ToString("F");
			TBCostPerItem.Text = analyze.CostPerItem.ToString("F");
			TBPerTime.Text = analyze.PerTime.ToString("F");
		}

		/// <summary>
		/// 税率を表示する
		/// </summary>
		private void ShowShopInfo()
		{
			LblTax.Text = "税率(%):" + ShopInfo.Tax.ToString() + UNIT_PER;
		}

		/// <summary>
		/// レコードを表示する
		/// </summary>
		private void ShowRecord()
		{
			LblRecord.Text = (nowRecord + 1).ToString() + "/" + ItemList.Count.ToString();
		}

		/// <summary>
		/// ファイルパスを表示する
		/// </summary>
		/// <param name="fullPath"></param>
		private void ShowFilePath(string fullPath)
		{
			LblFilePath.Text = Path.GetFileName(fullPath);
			ToolTipFullPath.SetToolTip(LblFilePath, fullPath);
		}

		/// <summary>
		/// 全てのコントロールの文字列をクリアする
		/// </summary>
		private void ClearAllControl()
		{
			TBItemName.Clear();
			TBAmount.Clear();
			TBPrice.Clear();
			TBProductSpeed.Clear();
			TBProductTime.Clear();
			TBRoyality.Clear();
			TBProfit.Clear();
			TBProfitPer.Clear();
			TBProfitPerItem.Clear();
			TBCost.Clear();
			TBCostPer.Clear();
			TBCostPerItem.Clear();
			TBPerTime.Clear();
			LblRecord.Text = "0/0";

			DgvMaterial.SelectAll();
			foreach (DataGridViewRow r in DgvMaterial.SelectedRows)
			{
				if (!r.IsNewRow)
					DgvMaterial.Rows.Remove(r);
			}
		}

		#endregion

		#region 内部データ保存

		public void SaveNowInfo()
		{
			try
			{
				ItemInfo item = new ItemInfo(this);
				item.Name = TBItemName.Text;
				item.Price = double.Parse(TBPrice.Text);
				item.Amount = double.Parse(TBAmount.Text);
				item.ProductSpeed = int.Parse(TBProductSpeed.Text);
				item.ProductTime = int.Parse(TBProductTime.Text);
				item.MaterialList = new List<MaterialInfo>();
				if (TBRoyality.Text.Equals(string.Empty))
					item.Royality = 0;
				else
					item.Royality = int.Parse(TBRoyality.Text);

				ItemList[nowRecord] = item;
				SaveMaterial();
			}
			catch (FormatException ex)
			{
				System.Diagnostics.Debug.WriteLine(ex);
				MessageBox.Show(this, ex.ToString(), "ERROR1、フォーマットエラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
				throw ex;
			}
		}

		private void SaveMaterial()
		{
			//編集終了することで、表の内容が確定する。
			DgvMaterial.EndEdit();
			int row = DgvMaterial.RowCount;

			ItemInfo item = ItemList[nowRecord];
			item.MaterialList = new List<MaterialInfo>();

			for (int i = 0; i < row - 1; i++)
			{
				if (DgvMaterial.Rows[i].IsNewRow) continue;
				if (DgvMaterial.Rows[i] == null) continue; //この行は要らないかもしれない

				ItemList[nowRecord].MaterialList.Add(new MaterialInfo());

				MaterialInfo material = ItemList[nowRecord].MaterialList[i];
				material.MaterialName = DgvMaterial.Rows[i].Cells[0].Value.ToString();
				material.BuyPrice = int.Parse(DgvMaterial.Rows[i].Cells[1].Value.ToString());
				material.RequiredAmount = double.Parse(DgvMaterial.Rows[i].Cells[2].Value.ToString());
				material.Type = MaterialInfo.GetMaterialType(DgvMaterial.Rows[i].Cells[3].Value.ToString());

				ItemList[nowRecord].MaterialList[i] = material;
			}
		}

		#endregion

		#region データチェッカー

		private void DgvDataChange()
		{
			if (isDataChange || isStartUp) return;
			DgvMaterial.EndEdit();
			int i = 0;
			foreach (MaterialInfo material in ItemList[nowRecord].MaterialList)
			{
				if (
					!DgvMaterial.Rows[i].Cells[0].Value.Equals(material.MaterialName) ||
					DgvMaterial.Rows[i].Cells[1].Value.ToString() != (material.BuyPrice.ToString()) ||
					DgvMaterial.Rows[i].Cells[2].Value.ToString() != (material.RequiredAmount.ToString()) ||
					!DgvMaterial.Rows[i].Cells[3].Value.Equals(MaterialInfo.GetMaterialString(material.Type))
				)
				{
					AddFileAsterisk();
					isDataChange = true;
					return;
				}
				i++;
			}
		}

		/// <summary>
		/// 状況に応じて保存確認ダイアログを出します。
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		/// <returns></returns>
		private DialogResult SaveChecker(object sender, EventArgs e)
		{
			if (isDataChange)
			{
				DialogResult dlg = MessageBox.Show(
					this, COMFIRM_MSG_SAVE, COMFIRM_TITLE_SAVE,
					MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

				switch (dlg)
				{
					case DialogResult.Yes:
						TSBtn_NamedSave_Click(sender, e);
						break;

					case DialogResult.No:
						break;

					case DialogResult.Cancel:
						break;

					default:
						break;
				}
				return dlg;
			}
			// ダイアログを出さない場合はNoとする
			return DialogResult.No;
		}

		/// <summary>
		/// テキストボックスの正規表現
		/// </summary>
		/// <param name="tb"></param>
		/// <returns></returns>
		private bool RegexTextBox(TextBox tb)
		{
			if (tb.Text.Equals(string.Empty)) return true;
			if (Regex.IsMatch(tb.Text, "[,\"]+"))
			{
				MessageBox.Show(
					this, ERR_MSG_CSV, ERR_TITLE_INPUT, MessageBoxButtons.OK, MessageBoxIcon.Error);
				tb.Focus();
				return false;
			}
			return true;
		}

		/// <summary>
		/// データグリッドビューの正規表現
		/// </summary>
		/// <returns></returns>
		private bool RegexDataGridView()
		{
			string regexStr = "[,\"]+";
			int i = 0;
			foreach (MaterialInfo material in ItemList[nowRecord].MaterialList)
			{
				if (
					Regex.IsMatch(DgvMaterial.Rows[i].Cells[0].Value.ToString(), regexStr) ||
					Regex.IsMatch(DgvMaterial.Rows[i].Cells[1].Value.ToString(), regexStr) ||
					Regex.IsMatch(DgvMaterial.Rows[i].Cells[2].Value.ToString(), regexStr) ||
					Regex.IsMatch(DgvMaterial.Rows[i].Cells[3].Value.ToString(), regexStr)
				)
				{
					MessageBox.Show(
						this, ERR_MSG_CSV, ERR_TITLE_INPUT, MessageBoxButtons.OK, MessageBoxIcon.Error);
					DgvMaterial.Focus();
					return false;
				}
				i++;
			}
			return true;
		}

		#endregion

		#region 色の変更

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TSMenu_Color_Click(object sender, EventArgs e)
		{
			var clrDlg = new ColorDialog();

			if (clrDlg.ShowDialog() == DialogResult.OK)
			{
				this.BackColor = clrDlg.Color;
				RegistryAccessor.SetRegistryValue(clrDlg.Color, RegistryAccessor.KeyName.BackColor);
			}
		}

		private void TSMenu_BtnColor_Click(object sender, EventArgs e)
		{
			var clrDlg = new ColorDialog();

			if (clrDlg.ShowDialog() == DialogResult.OK)
			{
				BtnAnalyze.BackColor = clrDlg.Color;
				BtnShopInfo.BackColor = clrDlg.Color;
				BtnDelete.BackColor = clrDlg.Color;
				BtnAdd.BackColor = clrDlg.Color;
				BtnAddCopy.BackColor = clrDlg.Color;
				BtnPrevious.BackColor = clrDlg.Color;
				BtnNext.BackColor = clrDlg.Color;

				RegistryAccessor.SetRegistryValue(clrDlg.Color, RegistryAccessor.KeyName.BtnColor);
			}
		}

		private void SetColor()
		{
			var backColor = RegistryAccessor.GetRegistryValue(RegistryAccessor.KeyName.BackColor);
			this.BackColor = backColor;
			DgvMaterial.BackgroundColor = backColor;
			//DgvMaterial[0, 0].Style.BackColor = backColor;

			Color btnColor = RegistryAccessor.GetRegistryValue(RegistryAccessor.KeyName.BtnColor);
			BtnAnalyze.BackColor = btnColor;
			BtnShopInfo.BackColor = btnColor;
			BtnDelete.BackColor = btnColor;
			BtnAdd.BackColor = btnColor;
			BtnAddCopy.BackColor = btnColor;
			BtnPrevious.BackColor = btnColor;
			BtnNext.BackColor = btnColor;

			var strColor = RegistryAccessor.GetRegistryValue(RegistryAccessor.KeyName.StrColor);
			this.ForeColor = strColor;
			DgvMaterial.ForeColor = Color.Black;
			BtnAnalyze.ForeColor = strColor;
			BtnShopInfo.ForeColor = strColor;
			BtnDelete.ForeColor = strColor;
			BtnAdd.ForeColor = strColor;
			BtnAddCopy.ForeColor = strColor;
			BtnPrevious.ForeColor = strColor;
			BtnNext.ForeColor = strColor;
			ToolStripMenuItem_File.ForeColor = Color.Black;
			ToolStripMenuItem_Edit.ForeColor = Color.Black;
			ToolStripMenuItem_Visual.ForeColor = Color.Black;
			ToolStripMenuItem_Analyze.ForeColor = Color.Black;
			ToolStripMenuItem_Help.ForeColor = Color.Black;
		}

		private void TSMenu_ChangeColor_Click(object sender, EventArgs e)
		{
			var colorWin = new Window.ColorWindow();
			colorWin.ShowDialog();
			SetColor();
		}

		#endregion

		/// <summary>
		/// テキストボックスの入力制限
		/// (イベントハンドラ)
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TB_Number_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((e.KeyChar < '0' || '9' < e.KeyChar) && !char.IsControl(e.KeyChar) && !e.KeyChar.Equals('.'))
			{
				e.Handled = true;
			}

			if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') == 1))
			{
				e.Handled = true;
			}
		}

		/// <summary>
		/// データグリッドビューの入力制限
		/// (イベントハンドラ)
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DgvMaterial_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			if (e.Control is DataGridViewTextBoxEditingControl)
			{
				DataGridView dgv = (DataGridView)sender;

				//編集のために表示されているコントロールを取得
				var tb = (DataGridViewTextBoxEditingControl)e.Control;
				//次のようにしてもよい
				//TextBox tb = (TextBox)e.Control;

				//イベントハンドラを削除
				tb.KeyPress -= new KeyPressEventHandler(TB_Number_KeyPress);

				//2つの列に適用
				if (dgv.CurrentCell.OwningColumn.Name == "ClmAmount" ||
					dgv.CurrentCell.OwningColumn.Name == "ClmPrice")
				{
					//KeyPressイベントハンドラを追加
					tb.KeyPress += new KeyPressEventHandler(TB_Number_KeyPress);
				}
			}
		}

		/// <summary>
		/// Jsonファイルへ変換のイベントハンドラ
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TsMenu_ConvertToJson_Click(object sender, EventArgs e)
		{
			var saveDlg = new SaveFileDialog();
			saveDlg.Filter = "解析データファイル(*.json)|*.json";
			if (saveDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				item.SaveJson(saveDlg.FileName);
				//flag
				isDataChange = false;
				isNewInfo = false;
			}
		}
	}
}
