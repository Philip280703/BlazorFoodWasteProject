using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorFoodWasteProject.Shared.Models
{
	public class Product
	{
		[JsonProperty("categories")]
		public Categories Categories { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("ean")]
		public string Ean { get; set; }

		[JsonProperty("image")]
		public string Image { get; set; }
	}
}
