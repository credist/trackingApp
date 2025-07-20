using trackingApp.Services.Interfaces;

namespace trackingApp.ViewModels;

public class WeightTrackingViewModel(IWeightService sv)
{
    private IWeightService _weightService = sv;
}