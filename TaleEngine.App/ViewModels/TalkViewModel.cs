using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Diagnostics;
using TaleEngine.App.Models;
using TaleEngine.App.Services;

namespace TaleEngine.App.ViewModels
{
    public partial class TalkViewModel : BaseViewModel
    {
        EventService _service;
        public ObservableCollection<Talk> Talks { get; } = new();

        public TalkViewModel()
        {
            _service = new EventService();
            Title = "Talks in MonkeyConf";
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

        //[RelayCommand]
        //async Task GoToDetailsAsync(Talk talk)
        //{
        //    if (talk is null) return;

        //    // Method 1
        //    //await Shell.Current.GoToAsync($"{nameof(DetailsPage)}?id={team.Name}");
        //    // Method 2, James Montemagno approves! 👍
        //    await Shell.Current.GoToAsync($"{nameof(DetailsPage)}", true,
        //        new Dictionary<string, object>
        //        {
        //            {nameof(Team), talk}
        //        });
        //}
    }
}
