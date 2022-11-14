using CommunityToolkit.Mvvm.ComponentModel;
using TaleEngine.App.Models;

namespace TaleEngine.App.ViewModels
{
    [QueryProperty("Talk", "Talk")]
    public partial class TalkDetailViewModel : BaseViewModel
    {
        [ObservableProperty]
        Talk talk;

        public TalkDetailViewModel()
        {
        }
    }
}
