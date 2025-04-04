using BlazorFoodWasteProject.Server.API;
using Microsoft.AspNetCore.Mvc;

namespace BlazorFoodWasteProject.Server.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class FoodWasteController : ControllerBase
	{
		private readonly FoodWasteAPI _foodWasteAPI;

		public FoodWasteController(FoodWasteAPI foodWasteAPI)
		{
			_foodWasteAPI = foodWasteAPI;
		}

		[HttpGet]
		public async Task<IActionResult> Get()
		{
			var result = await _foodWasteAPI.GetFoodWasteAsync();
			return Ok(result);
		}
	}


}
