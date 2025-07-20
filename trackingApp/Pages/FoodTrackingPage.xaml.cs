using trackingApp.ViewModels;

namespace trackingApp.Pages;

public partial class FoodTrackingPage : ContentPage
{
    public FoodTrackingPage(FoodTrackingViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}