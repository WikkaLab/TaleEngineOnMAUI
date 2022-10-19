using TaleEngine.App.ViewModels;

namespace TaleEngine.App.Views;

public partial class SpeakersPage : ContentPage
{
	public SpeakersPage(SpeakerViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}