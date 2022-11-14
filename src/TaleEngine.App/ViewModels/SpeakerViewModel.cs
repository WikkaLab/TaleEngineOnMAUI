using System.Collections.ObjectModel;
using System.Diagnostics;
using TaleEngine.App.Models;
using TaleEngine.App.Services;

namespace TaleEngine.App.ViewModels
{
    public partial class SpeakerViewModel : BaseViewModel
    {
        EventService _service;
        public ObservableCollection<Speaker> Speakers { get; } = new();

        public SpeakerViewModel()
        {
            _service = new EventService();
            Title = "All the speakers";
            GetSpeakers();
        }

        void GetSpeakers()
        {
            if (IsBusy) return;

            try
            {
                IsBusy = true;
                var speakers = _service.GetSpeakers();

                if (Speakers.Count != 0)
                {
                    Speakers.Clear();
                }

                foreach (var s in speakers)
                {
                    Speakers.Add(s);
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
    }
}
