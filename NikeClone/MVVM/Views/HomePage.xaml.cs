using NikeClone.MVVM.ViewModels;

namespace NikeClone.MVVM.Views;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
		BindingContext = new HomePageViewModel();
	}

    private void mode_Clicked(object sender, EventArgs e)
    {
        if (Application.Current.UserAppTheme == AppTheme.Dark)
        {
            Application.Current.UserAppTheme = AppTheme.Light;
        }
        else
        {
            Application.Current.UserAppTheme = AppTheme.Dark;
        }
    }

    private void Product_Clicked(object sender, EventArgs e)
    {

    }

    private void LikeButton_Clicked(object sender, EventArgs e)
    {

    }
}