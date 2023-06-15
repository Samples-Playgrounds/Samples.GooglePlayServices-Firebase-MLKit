namespace ReproSample.Issue580.GPS.Base;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
