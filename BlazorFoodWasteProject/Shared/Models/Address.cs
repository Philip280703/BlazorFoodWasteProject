using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorFoodWasteProject.Shared.Models
{
	public class Address
	{
		[JsonProperty("city")]
		public string City { get; set; }

		[JsonProperty("country")]
		public string Country { get; set; }

		[JsonProperty("extra")]
		public string Extra { get; set; }

		[JsonProperty("street")]
		public string Street { get; set; }

		[JsonProperty("zip")]
		public string Zip { get; set; }
	}
}
