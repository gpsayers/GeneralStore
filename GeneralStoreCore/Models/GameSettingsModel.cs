using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GeneralStoreCore.Models
{
	public class GameSettingsModel
	{
		[Display(Name = "Store Name")]
		public string storeName { get; set; }

		[Display(Name = "Store Owner")]
		public string storeOwner { get; set; }
	}
}
