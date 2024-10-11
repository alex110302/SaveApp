namespace SaveStuff;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void btnSave_OnClicked(object sender, EventArgs e)
    {
        Preferences.Set("Username", txtUsername.Text); // saves the text of the username text box in a key value pair
    }

    private void btnRead_OnClicked(object sender, EventArgs e)
    {
        txtUsername.Text = Preferences.Get("Username", "");
    }

    private void btnClear_OnClicked(object sender, EventArgs e)
    {
        txtUsername.Text = string.Empty;
    }
}