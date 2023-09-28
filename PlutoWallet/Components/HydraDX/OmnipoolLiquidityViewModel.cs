﻿using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace PlutoWallet.Components.HydraDX
{
	public partial class OmnipoolLiquidityViewModel : ObservableObject
	{
		[ObservableProperty]
		private ObservableCollection<AssetLiquidityInfo> assets;

		[ObservableProperty]
		private string usdSum;

        public OmnipoolLiquidityViewModel()
		{
			usdSum = "Loading";
		}

		public async Task GetLiquidityAmount()
		{
            UsdSum = "Loading";

            var omnipoolLiquidities = await Model.HydraDX.OmnipoolModel.GetOmnipoolLiquidityAmount();

            double tempUsdSum = 0;

			Assets = new ObservableCollection<AssetLiquidityInfo>();

			foreach (var omnipoolLiquidity in omnipoolLiquidities) {
				double usdRatio = 0;

				double usdValue = usdRatio * omnipoolLiquidity.Amount;

				tempUsdSum += usdValue;

                Assets.Add(new AssetLiquidityInfo {
					Amount = String.Format("{0:0.00}", omnipoolLiquidity.Amount),
					Symbol = omnipoolLiquidity.Symbol,
					UsdValue = String.Format("{0:0.00}", usdValue) + " USD",
				});
			} 

			UsdSum = String.Format("{0:0.00}", tempUsdSum) + " USD";
        }
    }

	public class AssetLiquidityInfo
	{
		public string Amount { get; set; }
		public string Symbol { get; set; }
		public string UsdValue { get; set; }
	}
}

