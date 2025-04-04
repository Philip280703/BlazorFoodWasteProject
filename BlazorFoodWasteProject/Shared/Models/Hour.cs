using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorFoodWasteProject.Shared.Models
{
	public class Hour
	{
		[JsonProperty("date")]
		public string Date { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("open")]
		public DateTime Open { get; set; }

		[JsonProperty("close")]
		public DateTime Close { get; set; }

		[JsonProperty("closed")]
		public bool Closed { get; set; }

		[JsonProperty("customerFlow")]
		public List<double> CustomerFlow { get; set; }
	}
}
