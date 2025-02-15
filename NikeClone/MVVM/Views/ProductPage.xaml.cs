using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using NikeClone.MVVM.Models;
using NikeClone.MVVM.ViewModels;
using NikeClone.TempDBS;

namespace NikeClone.MVVM.Views;

public partial class ProductPage : ContentPage
{


    public ProductPage(Product item)
    {
        InitializeComponent();
        BindingContext = new ProductPageViewModel(item);
    }

    private void RelProduct_Clicked(object sender, EventArgs e)
    {
        var productimg = (ImageButton)sender;
        var selectedProduct = productimg.BindingContext as Product;
        if (selectedProduct != null)
        {
            var bindingContext = BindingContext as ProductPageViewModel;
            if (bindingContext != null)
            {
                bindingContext.prod = selectedProduct;
                bindingContext.relproduct = bindingContext.product.ProductList
                                            .Where(p => p.Category == selectedProduct.Category).ToList();
            }
        }
    }

    private void favorite_Clicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        if (button != null)
        {
            button.Text = "Favorited";
        }
        else { button.Text = "Favorite"; }

        likebtn.Source = likebtn.Source.ToString().Contains("hearttrue.png") ? "heart.png" : "hearttrue.png";
    }

    private async void RelProduct1_Clicked(object sender, EventArgs e)
    {
        var productimg = (ImageButton)sender;
        var selectedProduct = productimg.BindingContext as Product;
        if (selectedProduct != null)
        {
            var bindingContext = BindingContext as ProductPageViewModel;
            if (bindingContext != null)
            {
                bindingContext.prod = selectedProduct;
                bindingContext.relproduct = bindingContext.product.ProductList
                                            .Where(p => p.Category == selectedProduct.Category).ToList();
            }

            // Scroll back to the top of the page
            await productScrollView.ScrollToAsync(0, 0, true); // (x, y, animated)
        }
    }

    private void addtobag_Clicked(object sender, EventArgs e)
    {
        if (sender is Button button && button.BindingContext is Product selectedProduct)
        {
            //ProductViewModel.AddToCart(selectedProduct);
            DisplayAlert("Success", $"{selectedProduct.Name} added to bag!", "OK");
        }

    }
}
