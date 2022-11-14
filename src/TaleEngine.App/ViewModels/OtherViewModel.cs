using CommunityToolkit.Mvvm.Input;

namespace TaleEngine.App.ViewModels
{
    public partial class OtherViewModel : BaseViewModel
    {
        IConnectivity _connectivity;

        public OtherViewModel(IConnectivity connectivity)
        {
            Title = "Native APIs";
            _connectivity = connectivity;
        }

        [RelayCommand]
        async Task OpenFilePicker()
        {
            PickOptions options = new();

            try
            {
                var result = await FilePicker.Default.PickAsync(options);
                if (result != null)
                {
                    if (result.FileName.EndsWith("jpg", StringComparison.OrdinalIgnoreCase) ||
                        result.FileName.EndsWith("png", StringComparison.OrdinalIgnoreCase))
                    {
                        await Shell.Current.DisplayAlert("Image selected", "This is an image!", "OK");
                    }
                    else
                    {
                        await Shell.Current.DisplayAlert("Other selected", "This is not an image!", "OK");
                    }
                }
            }
            catch (Exception ex)
            {
                // The user canceled or something went wrong
            }
        }

        [RelayCommand]
        async Task CheckConnectivity()
        {
            if (_connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                await Shell.Current.DisplayAlert("You are connected", "Surf at your own risk", "OK");
            }
            else
            {
                await Shell.Current.DisplayAlert("Oops!", "No connection", "OK");
            }
        }
    }
}
