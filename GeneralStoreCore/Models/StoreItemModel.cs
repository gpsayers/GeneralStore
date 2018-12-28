using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralStoreCore.Models
{
	public class StoreItemModel
	{
		public int itemId { get; set; }

		public int itemPrice { get; set; }

		public int itemQuantity { get; set; }

		public int itemQuantityForSale { get; set; }

		public int totalCost { get; set; }

		public int totalRevenue { get; set; }

		public int totalEverOwned { get; set; }

		public int totalEverSold { get; set; }
	}


	public class StoreModel
	{
		public int itemId { get; set; }

		public int itemPrice { get; set; }

		public int itemQuantity { get; set; }

		public int itemQuantityForSale { get; set; }

		public int totalCost { get; set; }

		public int totalRevenue { get; set; }

		public int totalEverOwned { get; set; }

		public int totalEverSold { get; set; }
	}
}
