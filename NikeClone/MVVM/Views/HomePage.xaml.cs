using NikeClone.MVVM.Models;
using NikeClone.MVVM.ViewModels;

namespace NikeClone.MVVM.Views
{

    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            BindingContext = new HomePageViewModel();
        }

        private void mode_Clicked(object sender, EventArgs e)
        {
        }

        private void Product_Clicked(object sender, EventArgs e)
        {
            var prodi = (ImageButton)sender;
            var selectedItem = prodi.BindingContext as Product;
            if (selectedItem != null)
            {
                Navigation.PushAsync(new ProductPage(selectedItem));
            }

        }
    }
}