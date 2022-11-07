using TaleEngine.App.ViewModels;

namespace TaleEngine.App.Views;

public partial class OthersPage : ContentPage
{
    public OthersPage(OtherViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}