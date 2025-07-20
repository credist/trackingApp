using trackingApp.Services;
using trackingApp.Services.Interfaces;

namespace trackingApp.ViewModels;

public class FoodTrackingViewModel(IFoodService sv)
{
    private IFoodService _foodService = sv;
}