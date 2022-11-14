using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Diagnostics;
using TaleEngine.App.Models;
using TaleEngine.App.Services;
using TaleEngine.App.Views;

namespace TaleEngine.App.ViewModels
{
    public partial class TalkViewModel : BaseViewModel
    {
        EventService _service;
        public ObservableCollection<Talk> Talks { get; } = new();

        public TalkViewModel()
        {
            _service = new EventService();
            Title = "Talks in dotnetmalaga 2022";
            GetTalks();
        }

        void GetTalks()
        {
            if (IsBusy) return;

            try
            {
                IsBusy = true;
                var talks = _service.GetTalks();

                if (Talks.Count != 0)
                {
                    Talks.Clear();
                }

                foreach (var t in talks)
                {
                    Talks.Add(t);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                Shell.Current.DisplayAlert("Error",
                    "Something wrong happened on getting speakers!",
                    "OK :(");
            }
            finally
            {
                IsBusy = false;
            }
        }

        [RelayCommand]
        async Task GoToDetailsAsync(Talk talk)
        {
            if (talk is null) return;

            await Shell.Current.GoToAsync($"{nameof(TalkDetailPage)}", true,
                new Dictionary<string, object>
                {
                    {"Talk", talk}
                });
        }
    }
}
