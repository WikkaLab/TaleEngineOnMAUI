using System.Collections.ObjectModel;
using System.Diagnostics;
using TaleEngine.App.Models;
using TaleEngine.App.Services;

namespace TaleEngine.App.ViewModels
{
    public partial class RoomViewModel : BaseViewModel
    {
        EventService _service;
        public ObservableCollection<Room> Rooms { get; } = new();

        public RoomViewModel()
        {
            _service = new EventService();
            Title = "Where magic happens";
            GetRooms();
        }

        void GetRooms()
        {
            if (IsBusy) return;

            try
            {
                IsBusy = true;
                var rooms = _service.GetRooms();

                if (Rooms.Count != 0)
                {
                    Rooms.Clear();
                }

                foreach (var s in rooms)
                {
                    Rooms.Add(s);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                Shell.Current.DisplayAlert("Error",
                    "Something wrong happened on getting rooms!",
                    "OK :(");
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
