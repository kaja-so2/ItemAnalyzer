using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace ItemAnalyzer
{
	/// <summary>
	/// 商品情報を表すクラスDEATH。
	/// 全てのデータの大元だよ。
	/// </summary>
	public class ItemInfo
	{
		#region プロパティ

		public string Name;
		public double Price;
		public double Amount;
		public int ProductSpeed;
		public int ProductTime;
		public int Royality;
		public List<MaterialInfo> MaterialList;

		/// <summary>
		/// 解析情報。CSVファイル出力時のみの使用。
		/// </summary>
		public AnalyzeInfo Analyze;

		/// <summary>
		/// メインフォームのインスタンス。
		/// メインフォームのSaveNowInfoを実行する際に必要。
		/// </summary>
		private static MainWindow main;

		#endregion

		#region コンストラクタ

		/// <summary>
		/// 標準コンストラクタ
		/// </summary>
		public ItemInfo()
		{
			Name = string.Empty;
			Price = 1;
			Amount = 1;
			ProductSpeed = 100;
			ProductTime = 1;
			Royality = 0;
			MaterialList = new List<MaterialInfo>();
			Analyze = new AnalyzeInfo();
		}

		/// <summary>
		/// フォームのインスタンスの受け渡しをするためのコンストラクタ
		/// </summary>
		/// <param name="mainForm"></param>
		public ItemInfo(MainWindow mainForm)
		{
			main = mainForm;
			Name = string.Empty;
			Price = 1;
			Amount = 1;
			ProductSpeed = 100;
			ProductTime = 1;
			Royality = 0;
			MaterialList = new List<MaterialInfo>();
			Analyze = new AnalyzeInfo();
		}

		#endregion

		#region .soファイル

		public void OpenSo(string fileName)
		{
			MainWindow.ItemList = new List<ItemInfo>();
			using (FileStream fs = new FileStream(fileName, FileMode.Open))
			using (BinaryReader br = new BinaryReader(fs, Encoding.UTF8))
			{
				try
				{
					ShopInfo.Tax = br.ReadInt32();
					// 改行を読む
					br.ReadString();

					while (true)
					{
						ItemInfo item = new ItemInfo();
						item.Name = br.ReadString();
						item.Price = br.ReadDouble();
						item.Amount = br.ReadDouble();
						item.ProductSpeed = br.ReadInt32();
						item.ProductTime = br.ReadInt32();
						item.Royality = br.ReadInt32();
						// 改行
						br.ReadString();
						do
						{
							MaterialInfo material = new MaterialInfo();

							material.MaterialName = br.ReadString();
							if (material.MaterialName == "\r\n")
								break;

							material.BuyPrice = br.ReadInt32();
							material.RequiredAmount = br.ReadDouble();
							material.Type = MaterialInfo.GetMaterialType(br.ReadString());
							item.MaterialList.Add(material);
						} while (true);
						MainWindow.ItemList.Add(item);
					}
				}
				catch (EndOfStreamException)
				{
					// 処理なし、通常ルート
				}
			}
		}

		/// <summary>
		/// .soファイルを保存する処理
		/// </summary>
		/// <param name="fileName"></param>
		public void SaveSo(string fileName)
		{
			main.SaveNowInfo();
			using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
			using (BinaryWriter bw = new BinaryWriter(fs, Encoding.UTF8))
			{
				bw.Write(ShopInfo.Tax);
				bw.Write("\r\n");
				foreach (ItemInfo item in MainWindow.ItemList)
				{
					bw.Write(item.Name);
					bw.Write(item.Price); //double 8
					bw.Write(item.Amount); //double 8
					bw.Write(item.ProductSpeed); //int 4
					bw.Write(item.ProductTime); //int 4
					bw.Write(item.Royality);
					bw.Write("\r\n");
					foreach (MaterialInfo material in item.MaterialList)
					{
						bw.Write(material.MaterialName);
						bw.Write(material.BuyPrice); //int 4
						bw.Write(material.RequiredAmount); //double 8
						bw.Write(MaterialInfo.GetMaterialString(material.Type));
					}
					bw.Write("\r\n");
				}
			}
		}

		#endregion

		#region .csvファイル

		/// <summary>
		/// CSVファイルを開く処理
		/// </summary>
		/// <param name="fileName">ファイル名(フルパス)</param>
		public void OpenCsv(string fileName)
		{
			MainWindow.ItemList = new List<ItemInfo>();
			using (FileStream fs = new FileStream(fileName, FileMode.Open))
			using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
			{
				try
				{
					string[] tax = sr.ReadLine().Split(',');
					ShopInfo.Tax = int.Parse(tax[1]);

					sr.ReadLine();

					while (!sr.EndOfStream)
					{
						string line = sr.ReadLine();
						string[] data = line.Split(',');
						ItemInfo item = new ItemInfo();
						item.Name = data[0];
						item.Price = double.Parse(data[1]);
						item.Amount = double.Parse(data[2]);
						item.ProductSpeed = int.Parse(data[3]);
						item.ProductTime = int.Parse(data[4]);
						item.Royality = int.Parse(data[5]);

						// data[6]~[12]は解析情報
						for (int j = 13; j + 3 < data.Length; j += 4)
						{
							MaterialInfo material = new MaterialInfo();
							material.MaterialName = data[j];
							material.BuyPrice = int.Parse(data[j + 1]);
							material.RequiredAmount = double.Parse(data[j + 2]);
							material.Type = MaterialInfo.GetMaterialType(data[j + 3]);
							item.MaterialList.Add(material);
						}
						MainWindow.ItemList.Add(item);
					}
				}
				catch (OutOfMemoryException)
				{
					//MessageBox.Show(this, ERR_TITLE_MEMORY, ERR_MSG_MEMORY, MessageBoxButtons.OK, MessageBoxIcon.Error);
					//this.Close();
					//return;
					throw;
				}
			}
		}

		/// <summary>
		/// CSVファイルを保存する処理
		/// </summary>
		/// <param name="fileName"></param>
		public void SaveCsv(string fileName)
		{
			main.SaveNowInfo();
			//using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write))
			using (StreamWriter sw = new StreamWriter(fileName, false, Encoding.UTF8))
			{
				sw.WriteLine("Tax," + ShopInfo.Tax);
				sw.Write("Name,Price,Amount,ProductSpeed,ProductTime,Royality,");
				sw.Write("Profit,ProfitPercent,Cost,CostPercent,ProfitPerItem,CostPerItem,ProfitPerHour,");
				sw.WriteLine("MaterialName,BuyPrice,RequiredAmount,MaterialType");
				foreach (ItemInfo item in MainWindow.ItemList)
				{
					sw.Write(item.Name + "," + item.Price.ToString() + "," + item.Amount.ToString() + ",");
					sw.Write(item.ProductSpeed.ToString() + "," + item.ProductTime.ToString() + "," + item.Royality.ToString() + ",");
					item.Analyze = AnalyzeInfo.DoAnalyze(item);
					sw.Write(item.Analyze.Profit.ToString() + "," + item.Analyze.ProfitPer.ToString() + ",");
					sw.Write(item.Analyze.Cost.ToString() + "," + item.Analyze.CostPer.ToString() + ",");
					sw.Write(item.Analyze.ProfitPerItem.ToString() + "," + item.Analyze.CostPerItem.ToString() + ",");
					sw.Write(item.Analyze.PerTime.ToString() + ",");
					sw.Flush();
					int i = 1;
					foreach (MaterialInfo material in item.MaterialList)
					{
						sw.Write(material.MaterialName + "," + material.BuyPrice.ToString() + ",");
						sw.Write(material.RequiredAmount.ToString() + "," + MaterialInfo.GetMaterialString(material.Type));
						if (item.MaterialList.Count == i)
							break;
						else
							sw.Write(",");
						i++;
						sw.Flush();
					}
					sw.Flush();
					sw.WriteLine();
					sw.Flush();
				}
			}
		}

		#endregion

		#region .jsonファイル

		internal  void OpenJson(string fileName)
		{
			string json = File.ReadAllText(fileName, Encoding.UTF8);
			var deserialize = JsonConvert.DeserializeObject<List<ItemInfo>>(json);
			MainWindow.ItemList = deserialize;
		}

		internal  void SaveJson(string fileName)
		{
			main.SaveNowInfo();

			for (int i = 0; i < MainWindow.ItemList.Count; i++)
			{
				MainWindow.ItemList[i].Analyze = AnalyzeInfo.DoAnalyze(MainWindow.ItemList[i]);
			}

			//var setting = new JsonSerializerSettings();
			//setting.
			var json = JsonConvert.SerializeObject(MainWindow.ItemList, Formatting.Indented);
			using (StreamWriter sw = new StreamWriter(fileName, false, Encoding.UTF8))
			//using (var jw = new JsonTextWriter(sw))
			{
				sw.Write(json);
				//jw.Formatting = Formatting.Indented;
				//jw.IndentChar = '\t';
				//jw.WriteRaw(JObject.Parse(?????????));
			}
		}
		#endregion
	}
}
