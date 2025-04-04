using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using Newtonsoft.Json;

namespace BlazorFoodWasteProject.Shared.Models
{
	public class Root
	{
		[JsonProperty("clearances")]
		public List<Clearance> Clearances { get; set; }

		[JsonProperty("store")]
		public Store Store { get; set; }
	}
}
