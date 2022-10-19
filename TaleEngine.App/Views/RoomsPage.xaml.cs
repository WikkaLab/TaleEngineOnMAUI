using TaleEngine.App.ViewModels;

namespace TaleEngine.App.Views;

public partial class RoomsPage : ContentPage
{
	public RoomsPage(RoomViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}