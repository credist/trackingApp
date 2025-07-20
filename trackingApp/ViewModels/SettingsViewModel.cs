using trackingApp.Services.Interfaces;

namespace trackingApp.ViewModels;

public class SettingsViewModel(ISettingsService sv)
{
    private ISettingsService _settingsService = sv;
}