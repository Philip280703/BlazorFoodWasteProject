using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorFoodWasteProject.Shared.Models
{
	public class Clearance
	{
		[JsonProperty("offer")]
		public Offer Offer { get; set; }

		[JsonProperty("product")]
		public Product Product { get; set; }
	}
}
