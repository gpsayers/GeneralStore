using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralStoreCore.Models
{
	public class ItemModel
	{
		public ItemModel(string Name, double startingPrice, int id, ItemType type, ItemElement element)
		{
			itemName = Name;
			itemId = id;
			demand = 1;
			basePrice = startingPrice;
		}

		public int itemId { get; set; }
		public string itemName { get; set; }
		public double basePrice { get; set; }
		public double demand { get; set; }
		public double currentModifiedPrice { get; set; }

		public ItemType type { get; set; }

		public ItemElement element { get; set; }
	}

	public enum ItemType
	{
		Consumable = 1,
		Weapon = 2,
		Armor = 3,
		Ammo = 4,
		Equipment = 5,
		Multipurpose = 6,
		Treasure = 7
	}

	public enum ItemElement
	{
		Metal = 1,
		Wood = 2,
		Cloth = 3,
		Hemp = 4,
		Gold = 5,
		Liquid = 6,
		Food = 7,
		Leather = 8,
		Glass = 9,
		Stone = 10
	}
}
