using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorFoodWasteProject.Shared.Models
{
	public class Categories
	{
		[JsonProperty("da")]
		public string Da { get; set; }

		[JsonProperty("en")]
		public string En { get; set; }
	}
}
