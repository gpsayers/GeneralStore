using GeneralStoreCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralStoreCore
{
	public class Store
	{
		public Store()
		{

		}

		public List<ItemModel> GetItemModel()
		{
			var startingItemList = new List<ItemModel>();

			startingItemList.Add(new ItemModel("Potion of healing", 50, 1, ItemType.Consumable, ItemElement.Liquid));
			startingItemList.Add(new ItemModel("Torches (10)", 5, 2, ItemType.Equipment, ItemElement.Wood));
			startingItemList.Add(new ItemModel("Alchemist's Fire", 40, 3, ItemType.Multipurpose, ItemElement.Liquid));
			startingItemList.Add(new ItemModel("Arrows (20)", 10, 4, ItemType.Ammo, ItemElement.Wood));
			startingItemList.Add(new ItemModel("Crossbow Bolts (20)", 10, 5, ItemType.Ammo, ItemElement.Metal));
			startingItemList.Add(new ItemModel("Antitoxin", 40, 6, ItemType.Consumable, ItemElement.Liquid));
			startingItemList.Add(new ItemModel("Rations (10)", 5, 7, ItemType.Consumable, ItemElement.Food));
			startingItemList.Add(new ItemModel("Bedroll", 4, 8, ItemType.Equipment, ItemElement.Cloth));
			startingItemList.Add(new ItemModel("Backpack", 4, 9, ItemType.Equipment, ItemElement.Leather));
			startingItemList.Add(new ItemModel("Caltrops (20)", 10, 10, ItemType.Multipurpose, ItemElement.Metal));

			startingItemList.Add(new ItemModel("Climbers Kit", 30, 11, ItemType.Equipment, ItemElement.Metal));
			startingItemList.Add(new ItemModel("Fishing Tackle", 8, 12, ItemType.Equipment, ItemElement.Wood));
			startingItemList.Add(new ItemModel("Grappling hook", 10, 13, ItemType.Equipment, ItemElement.Metal));
			startingItemList.Add(new ItemModel("Healer's Kit", 15, 14, ItemType.Equipment, ItemElement.Food));
			startingItemList.Add(new ItemModel("Chest", 20, 15, ItemType.Equipment, ItemElement.Wood));
			startingItemList.Add(new ItemModel("Holy Water", 25, 16, ItemType.Multipurpose, ItemElement.Liquid));
			startingItemList.Add(new ItemModel("Lantern", 15, 17, ItemType.Equipment, ItemElement.Metal));
			startingItemList.Add(new ItemModel("Shovel", 3, 18, ItemType.Equipment, ItemElement.Wood));
			startingItemList.Add(new ItemModel("Waterskin", 9, 19, ItemType.Equipment, ItemElement.Leather));
			startingItemList.Add(new ItemModel("Magnifying glass", 100, 20, ItemType.Equipment, ItemElement.Glass));

			startingItemList.Add(new ItemModel("Poison", 100, 21, ItemType.Consumable, ItemElement.Liquid));
			startingItemList.Add(new ItemModel("Acid", 30, 22, ItemType.Weapon, ItemElement.Liquid));
			startingItemList.Add(new ItemModel("Sling Bullets (20)", 5, 23, ItemType.Ammo, ItemElement.Stone));
			startingItemList.Add(new ItemModel("Spyglass", 1000, 24, ItemType.Equipment, ItemElement.Glass));
			startingItemList.Add(new ItemModel("Spellbook", 60, 25, ItemType.Equipment, ItemElement.Leather));
			startingItemList.Add(new ItemModel("Lock", 12, 26, ItemType.Equipment, ItemElement.Leather));
			startingItemList.Add(new ItemModel("Burglar's Pack", 16, 27, ItemType.Equipment, ItemElement.Leather));
			startingItemList.Add(new ItemModel("Dungeoneer's Pack", 15, 28, ItemType.Equipment, ItemElement.Leather));
			startingItemList.Add(new ItemModel("Entertainer's Pack", 40, 29, ItemType.Equipment, ItemElement.Leather));
			startingItemList.Add(new ItemModel("Priest's Pack", 19, 30, ItemType.Equipment, ItemElement.Leather));

			startingItemList.Add(new ItemModel("Scholar's Pack", 40, 31, ItemType.Equipment, ItemElement.Food));
			startingItemList.Add(new ItemModel("Book", 25, 32, ItemType.Multipurpose, ItemElement.Leather));
			startingItemList.Add(new ItemModel("Crowbar", 4, 33, ItemType.Equipment, ItemElement.Metal));
			startingItemList.Add(new ItemModel("Hourglass", 25, 34, ItemType.Multipurpose, ItemElement.Leather));
			startingItemList.Add(new ItemModel("Mirror", 10, 35, ItemType.Multipurpose, ItemElement.Metal));
			startingItemList.Add(new ItemModel("Sealing Wax", 12, 36, ItemType.Multipurpose, ItemElement.Liquid));
			startingItemList.Add(new ItemModel("Quiver", 5, 37, ItemType.Equipment, ItemElement.Leather));
			startingItemList.Add(new ItemModel("Flask", 4, 38, ItemType.Multipurpose, ItemElement.Glass));
			startingItemList.Add(new ItemModel("Chain", 7, 39, ItemType.Multipurpose, ItemElement.Metal));
			startingItemList.Add(new ItemModel("Gold Bar", 10000, 40, ItemType.Equipment, ItemElement.Leather));

			startingItemList.Add(new ItemModel("Portable Ram", 6, 41, ItemType.Equipment, ItemElement.Wood));
			startingItemList.Add(new ItemModel("Robe", 4, 42, ItemType.Equipment, ItemElement.Cloth));
			startingItemList.Add(new ItemModel("Sack", 3, 43, ItemType.Equipment, ItemElement.Cloth));
			startingItemList.Add(new ItemModel("Tinderbox", 4, 44, ItemType.Equipment, ItemElement.Wood));
			startingItemList.Add(new ItemModel("Hunting Trap", 10, 45, ItemType.Multipurpose, ItemElement.Metal));
			startingItemList.Add(new ItemModel("Yew Wand", 15, 46, ItemType.Equipment, ItemElement.Wood));
			startingItemList.Add(new ItemModel("Potion of strength", 100, 47, ItemType.Consumable, ItemElement.Liquid));
			startingItemList.Add(new ItemModel("Potion of greater healing", 100, 48, ItemType.Consumable, ItemElement.Liquid));
			startingItemList.Add(new ItemModel("Potion of water breathing", 100, 49, ItemType.Consumable, ItemElement.Liquid));
			startingItemList.Add(new ItemModel("Oil of slipperiness", 100, 50, ItemType.Consumable, ItemElement.Liquid));

			startingItemList.Add(new ItemModel("Potion of love", 100, 51, ItemType.Consumable, ItemElement.Liquid));
			startingItemList.Add(new ItemModel("Potion of climbing", 50, 52, ItemType.Consumable, ItemElement.Liquid));
			startingItemList.Add(new ItemModel("Potion of invisibility", 5000, 53, ItemType.Consumable, ItemElement.Liquid));
			startingItemList.Add(new ItemModel("Potion of gaseous form", 500, 54, ItemType.Consumable, ItemElement.Liquid));
			startingItemList.Add(new ItemModel("Potion of flying", 5000, 55, ItemType.Consumable, ItemElement.Liquid));
			startingItemList.Add(new ItemModel("Potion of heroism", 500, 56, ItemType.Consumable, ItemElement.Liquid));
			startingItemList.Add(new ItemModel("Potion of speed", 5000, 57, ItemType.Consumable, ItemElement.Liquid));
			startingItemList.Add(new ItemModel("Potion of mind reading", 500, 58, ItemType.Consumable, ItemElement.Liquid));
			startingItemList.Add(new ItemModel("Potion of invulnerability", 500, 59, ItemType.Consumable, ItemElement.Liquid));
			startingItemList.Add(new ItemModel("Potion of fire breath", 100, 60, ItemType.Consumable, ItemElement.Liquid));

			startingItemList.Add(new ItemModel("Crossbow, hand", 100, 61, ItemType.Weapon, ItemElement.Wood));
			startingItemList.Add(new ItemModel("Crossbow, light", 50, 62, ItemType.Weapon, ItemElement.Wood));
			startingItemList.Add(new ItemModel("Greatsword", 75, 63, ItemType.Weapon, ItemElement.Metal));
			startingItemList.Add(new ItemModel("Shortsword", 35, 64, ItemType.Weapon, ItemElement.Metal));
			startingItemList.Add(new ItemModel("Longbow", 85, 65, ItemType.Weapon, ItemElement.Wood));
			startingItemList.Add(new ItemModel("Greataxe", 80, 66, ItemType.Weapon, ItemElement.Metal));
			startingItemList.Add(new ItemModel("Warhammer", 40, 67, ItemType.Weapon, ItemElement.Metal));
			startingItemList.Add(new ItemModel("Spear", 25, 68, ItemType.Weapon, ItemElement.Wood));
			startingItemList.Add(new ItemModel("Longsword", 40, 69, ItemType.Weapon, ItemElement.Metal));
			startingItemList.Add(new ItemModel("Sling", 10, 70, ItemType.Weapon, ItemElement.Leather));

			startingItemList.Add(new ItemModel("Dagger", 20, 71, ItemType.Weapon, ItemElement.Metal));
			startingItemList.Add(new ItemModel("Quarterstaff", 15, 72, ItemType.Weapon, ItemElement.Wood));
			startingItemList.Add(new ItemModel("Shield, wooden", 30, 73, ItemType.Armor, ItemElement.Wood));
			startingItemList.Add(new ItemModel("Shield, steel", 50, 74, ItemType.Armor, ItemElement.Metal));
			startingItemList.Add(new ItemModel("Leather Armor", 35, 75, ItemType.Armor, ItemElement.Leather));
			startingItemList.Add(new ItemModel("Breastplate", 400, 76, ItemType.Armor, ItemElement.Metal));
			startingItemList.Add(new ItemModel("Chain shirt", 100, 77, ItemType.Armor, ItemElement.Metal));
			startingItemList.Add(new ItemModel("Plate armor", 1500, 78, ItemType.Armor, ItemElement.Metal));
			startingItemList.Add(new ItemModel("Splint armor", 225, 79, ItemType.Armor, ItemElement.Metal));
			startingItemList.Add(new ItemModel("Half Plate armor", 750, 80, ItemType.Armor, ItemElement.Metal));

			startingItemList.Add(new ItemModel("Golden Idol", 7000, 81, ItemType.Treasure, ItemElement.Gold));
			startingItemList.Add(new ItemModel("Painting", 10000, 82, ItemType.Treasure, ItemElement.Cloth));
			startingItemList.Add(new ItemModel("Crown Jewels", 20000, 83, ItemType.Treasure, ItemElement.Gold));
			startingItemList.Add(new ItemModel("Ruby", 1000, 84, ItemType.Treasure, ItemElement.Stone));
			startingItemList.Add(new ItemModel("Diamond", 5000, 85, ItemType.Treasure, ItemElement.Stone));
			startingItemList.Add(new ItemModel("Topaz", 500, 86, ItemType.Treasure, ItemElement.Stone));
			startingItemList.Add(new ItemModel("Sapphire", 1000, 87, ItemType.Treasure, ItemElement.Stone));
			startingItemList.Add(new ItemModel("Pearl", 500, 88, ItemType.Treasure, ItemElement.Stone));
			startingItemList.Add(new ItemModel("Jade", 100, 89, ItemType.Treasure, ItemElement.Stone));
			startingItemList.Add(new ItemModel("Amber", 100, 90, ItemType.Treasure, ItemElement.Stone));

			return startingItemList;
		}
	}
}
