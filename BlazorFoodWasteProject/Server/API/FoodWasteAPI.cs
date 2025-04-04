using BlazorFoodWasteProject.Shared.Models;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace BlazorFoodWasteProject.Server.API
{
	public class FoodWasteAPI
	{
		private readonly HttpClient _httpClient;

		public FoodWasteAPI(HttpClient httpClient, IOptions<FoodWasteApiOptions> options)
		{
			_httpClient = httpClient;
			_httpClient.BaseAddress = new Uri("https://api.sallinggroup.com/v1/food-waste/");
			_httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", options.Value.ApiKey);
		}

		public async Task<List<Root>> GetFoodWasteAsync()
		{
			var response = await _httpClient.GetAsync("clearances");

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
