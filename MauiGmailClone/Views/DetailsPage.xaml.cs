using MauiGmailClone.ViewModels;

namespace MauiGmailClone.Views;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(DetailsViewModel vm)
	{
		InitializeComponent();

		BindingContext= vm;
	}
}