using NikeClone.MVVM.ViewModels;

namespace NikeClone.MVVM.Views;

public partial class FavoritesPage : ContentPage
{
	public FavoritesPage()
	{
		InitializeComponent();
		BindingContext = new FavouritesPageViewModel();
	}
}