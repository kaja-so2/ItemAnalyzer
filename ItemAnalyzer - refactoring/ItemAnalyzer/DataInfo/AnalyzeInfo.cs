using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ItemAnalyzer
{
	/// <summary>
	/// 解析情報を表すクラスDEATH。
	/// </summary>
	public class AnalyzeInfo
	{
		public double Profit;
		public double ProfitPer;
		public double Cost;
		public double CostPer;
		public double ProfitPerItem;
		public double CostPerItem;
		public double PerTime;

		public AnalyzeInfo()
		{
			Profit = 1;
			ProfitPer = 1;
			Cost = 1;
			CostPer = 1;
			ProfitPerItem = 1;
			CostPerItem = 1;
			PerTime = 1;
		}

		public static AnalyzeInfo DoAnalyze(ItemInfo item)
		{
			double allCash = (item.Price - (item.Price * ((double)ShopInfo.Tax / 100.0))) * item.Amount + item.Royality;

			double cost = 0;
			foreach (MaterialInfo material in item.MaterialList)
			{
				if (material.Type == MaterialInfo.MaterialType.Tool)
					cost += material.BuyPrice * (material.RequiredAmount * 0.2);
				else
					cost += material.BuyPrice * material.RequiredAmount;
			}

			if (item.Royality.Equals(string.Empty) == false)
				cost += item.Royality;

			double productSpeed = (double)item.ProductSpeed / 100;

			double profit = allCash - cost;

			double profitPer = profit / allCash * 100;

			double costPer = cost / allCash * 100;

			double amount = item.Amount;
			double profitPerItem = profit / amount;

			double costPerItem = cost / amount;

			double productTime = item.ProductTime;
			double perTime = profit / (productTime / productSpeed);

			AnalyzeInfo analyze = new AnalyzeInfo();
			analyze.Profit = profit;
			analyze.ProfitPer = profitPer;
			analyze.Cost = cost;
			analyze.CostPer = costPer;
			analyze.ProfitPerItem = profitPerItem;
			analyze.CostPerItem = costPerItem;
			analyze.PerTime = perTime;

			item.Analyze = analyze;
			return analyze;
		}

	}
}
