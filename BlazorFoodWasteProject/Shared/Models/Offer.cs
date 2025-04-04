using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorFoodWasteProject.Shared.Models
{
	public class Offer
	{
		[JsonProperty("currency")]
		public string Currency { get; set; }

		[JsonProperty("discount")]
		public double Discount { get; set; }

		[JsonProperty("ean")]
		public string Ean { get; set; }

		[JsonProperty("endTime")]
		public DateTime EndTime { get; set; }

		[JsonProperty("lastUpdate")]
		public DateTime LastUpdate { get; set; }

		[JsonProperty("newPrice")]
		public double NewPrice { get; set; }

		[JsonProperty("originalPrice")]
		public double OriginalPrice { get; set; }

		[JsonProperty("percentDiscount")]
		public double PercentDiscount { get; set; }

		[JsonProperty("startTime")]
		public DateTime StartTime { get; set; }

		[JsonProperty("stock")]
		public int Stock { get; set; }

		[JsonProperty("stockUnit")]
		public string StockUnit { get; set; }
	}
}
