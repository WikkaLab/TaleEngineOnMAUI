using TaleEngine.App.ViewModels;

namespace TaleEngine.App.Views;

public partial class TalkDetailPage : ContentPage
{
    public TalkDetailPage(TalkDetailViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}