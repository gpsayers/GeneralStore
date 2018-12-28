using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralStoreCore.Models
{
	public class CustomerModel
	{
		public string CustomerId { get; set; }
		public string Name { get; set; }
		public int Gold { get; set; }
		public int ItemNeeded { get; set; }
		public List<string> customerHistoryList { get; set; }
	}
}
