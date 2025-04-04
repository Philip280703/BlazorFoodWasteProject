using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BlazorFoodWasteProject.Shared.Models
{
	public class Store
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("address")]
		public Address Address { get; set; }

		[JsonProperty("brand")]
		public string Brand { get; set; }

		[JsonProperty("coordinates")]
		public List<double> Coordinates { get; set; }

		[JsonProperty("hours")]
		public List<Hour> Hours { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }
	}
}
