using TaleEngine.App.ViewModels;

namespace TaleEngine.App.Views;

public partial class MainPage : ContentPage
{
	public MainPage(TalkViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}

