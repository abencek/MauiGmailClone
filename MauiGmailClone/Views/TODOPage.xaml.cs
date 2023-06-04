using CommunityToolkit.Mvvm.Input;
using MauiGmailClone.ViewModels;

namespace MauiGmailClone.Views;

public partial class TODOPage : ContentPage
{
	public TODOPage(TODOViewModel vm)
	{
		InitializeComponent();

        BindingContext = vm;
	}
}