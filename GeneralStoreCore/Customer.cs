using GeneralStoreCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralStoreCore
{
	public class Customer
	{
		public Customer()
		{

		}


		public int? FindBestDeal(List<StoreModel> storeList, List<ItemModel> itemList)
		{
			int? chosenItem = null;
			double dealratio = int.MaxValue;

			foreach (var storeItem in storeList)
			{

				if (storeItem.itemQuantityForSale > 0)
				{
					var baseItem = itemList.Where(x => x.itemId == storeItem.itemId);

					if (baseItem.Any())
					{
						var diff = (storeItem.itemPrice - baseItem.FirstOrDefault().currentModifiedPrice) / baseItem.FirstOrDefault().currentModifiedPrice;
						if (diff < dealratio)
						{
							dealratio = diff;
							chosenItem = storeItem.itemId;
						}
					}
				}

			}

			return chosenItem;
		}
	}
}
