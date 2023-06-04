using MauiGmailClone.ViewModels;

namespace MauiGmailClone.Views;

public partial class MainPage : ContentPage
{

	private readonly MainViewModel _viewModel;

	public MainPage(MainViewModel vm)
	{
		InitializeComponent();

		_viewModel= vm;
		BindingContext = _viewModel;
	}

    /// <summary>
    /// Runs on page appearing
    /// </summary>
    protected override async void OnAppearing()
	{
		base.OnAppearing();

        // Updates list of emails on startup
        if (_viewModel.Emails.Count==0) 
			await _viewModel.GetEmailsCommand.ExecuteAsync("Primary");
	}
}

