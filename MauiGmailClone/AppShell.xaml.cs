using MauiGmailClone.ViewModels;
using MauiGmailClone.Views;

namespace MauiGmailClone;

public partial class AppShell : Shell
{
	public AppShell(MainViewModel vm)
	{
		InitializeComponent();

		BindingContext = vm;

		//Register routes
		Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
		Routing.RegisterRoute(nameof(DetailsPage), typeof(DetailsPage));
		Routing.RegisterRoute(nameof(NewPage), typeof(NewPage));
		Routing.RegisterRoute(nameof(TODOPage), typeof(TODOPage));

    }
}
