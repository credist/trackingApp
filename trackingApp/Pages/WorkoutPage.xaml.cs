using trackingApp.ViewModels;

namespace trackingApp.Pages;

public partial class WorkoutPage : ContentPage
{
    public WorkoutPage(WorkoutTrackingViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}

