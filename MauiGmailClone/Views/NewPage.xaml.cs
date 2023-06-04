
using MauiGmailClone.ViewModels;

namespace MauiGmailClone.Views;

public partial class NewPage : ContentPage
{
	public NewPage(NewViewModel vm)
	{
		InitializeComponent();

        BindingContext = vm;
    }
}