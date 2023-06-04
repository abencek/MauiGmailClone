using MauiGmailClone.ViewModels;

namespace MauiGmailClone;

public partial class App : Application
{
	public App(MainViewModel vm)
	{
		InitializeComponent();

        MainPage = new AppShell(vm);
	}

    /// <summary>
    /// Sets window size for application running on Windows
    /// </summary>
    /// <param name="activationState"></param>
    /// <returns></returns>
    protected override Window CreateWindow(IActivationState activationState)
    {
        var window = base.CreateWindow(activationState);

        const int windowWidth = 400;
        const int windowHeight = 600;

        window.Width = windowWidth;
        window.Height = windowHeight;

        window.MaximumWidth= windowWidth;
        window.MaximumHeight= windowHeight;

        return window;
    }

}
