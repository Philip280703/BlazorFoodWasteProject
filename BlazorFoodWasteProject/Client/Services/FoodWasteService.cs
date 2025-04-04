using BlazorFoodWasteProject.Shared.Models;
using BlazorFoodWasteProject.Client.Services.Interfaces;
using Newtonsoft.Json;

namespace BlazorFoodWasteProject.Client.Services
{
	public class FoodWasteService : IFoodWasteService
	{
		private readonly HttpClient _httpClient;

		public FoodWasteService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		public async Task<List<Root>> GetFoodWasteAsync()
		{
			var response = await _httpClient.GetAsync("api/FoodWaste");

			if (!response.IsSuccessStatusCode)
			{
				throw new HttpRequestException($"API-kald fejlede med statuskode: {response.StatusCode}");
			}

			var json = await response.Content.ReadAsStringAsync();
			var data = JsonConvert.DeserializeObject<List<Root>>(json);
			return data;
		}
	}
}
