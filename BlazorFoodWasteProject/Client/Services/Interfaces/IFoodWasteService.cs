using BlazorFoodWasteProject.Shared.Models;

namespace BlazorFoodWasteProject.Client.Services.Interfaces
{
	public interface IFoodWasteService
	{
		Task<List<Root>> GetFoodWasteAsync();
	}
}
