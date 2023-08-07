namespace SearchBarTest;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    void SearchBar_Focused(System.Object sender, Microsoft.Maui.Controls.FocusEventArgs e)
    {
        DisplayAlert("Focused", "Focused", "OK");
    }

    void SearchBar_Unfocused(System.Object sender, Microsoft.Maui.Controls.FocusEventArgs e)
    {
        DisplayAlert("Unfocused", "Unfocused", "OK");
    }
}


