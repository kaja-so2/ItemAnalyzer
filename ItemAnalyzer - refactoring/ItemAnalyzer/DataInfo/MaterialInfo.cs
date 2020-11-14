using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ItemAnalyzer
{
	/// <summary>
	/// 材料を表すクラスDEATH。
	/// </summary>
	public class MaterialInfo
	{
		public string MaterialName;
		public int BuyPrice;
		public double RequiredAmount;
		public MaterialType Type;
		public enum MaterialType
		{
			Material,
			Tool
		}

		public MaterialInfo()
		{
			MaterialName = string.Empty;
			BuyPrice = 1;
			RequiredAmount = 1;
			Type = MaterialType.Material;
		}

		/// <summary>
		/// 文字列から、対応した専用列挙型を返します。
		/// </summary>
		/// <param name="typeStr">捜索元文字列(材料か道具)</param>
		/// <returns></returns>
		public static MaterialInfo.MaterialType GetMaterialType(string typeStr)
		{
			switch (typeStr)
			{
				case "材料":
					return MaterialInfo.MaterialType.Material;

				case "道具":
					return MaterialInfo.MaterialType.Tool;
			}

			// デフォルト
			return MaterialInfo.MaterialType.Material;
		}

		/// <summary>
		/// 専用列挙型から、文字列を取得します。
		/// </summary>
		/// <param name="type"></param>
		/// <returns></returns>
		public static string GetMaterialString(MaterialInfo.MaterialType type)
		{
			switch (type)
			{
				case MaterialInfo.MaterialType.Material:
					return "材料";

				case MaterialInfo.MaterialType.Tool:
					return "道具";
			}

			// デフォルト　到達不可能コード
			return "材料";
		}
	}
}
