namespace MauiProfileClockSample1;

public partial class MainPage : ContentPage
{
	int count = 0;
	static MainPage _mainPage = null;
	MainActivity _mainActivity = null;

	public MainPage()
	{
		InitializeComponent();
		_mainPage = this;
    }

	public static MainPage getInstance()
	{
        return _mainPage;
	}

	public void setMainActivity(MainActivity mainActivity)
	{
        _mainPage._mainActivity = mainActivity;
    }

    private void onSetClockClicked(object sender, EventArgs e)
    {
		_mainActivity.onClickSetProfile(txtTimeZone.Text, txtDate.Text, txtTime.Text);
    }

	public void updateStatusText(string message)
	{
        lblStatus.Text = "Status: " + message;
    }
}

