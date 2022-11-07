using TaleEngine.App.Views;

namespace TaleEngine.App;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(TalkDetailPage), typeof(TalkDetailPage));
    }
}
