using trackingApp.Services.Interfaces;

namespace trackingApp.ViewModels;

public class WorkoutTrackingViewModel(IWorkoutService sv)
{
    private IWorkoutService _workoutService = sv;
}