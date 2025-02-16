using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;

public class FavouritesPageViewModel : BindableObject
{
    private ObservableCollection<Product> _favourites = new ObservableCollection<Product>();
    public ObservableCollection<Product> Favourites
    {
        get => _favourites;
        set
        {
            if (_favourites != value)
            {
                _favourites = value;
                OnPropertyChanged(nameof(Favourites));
            }
        }
    }

    public ProductViewModel PVM { get; set; }   // 🔥 Use Singleton

    public FavouritesPageViewModel()
    {
        PVM = ProductViewModel.Instance;
        Debug.WriteLine("📌 Initializing FavouritesPageViewModel");

        // ✅ Populate initial favourites
        UpdateFavourites();

        // ✅ Listen for changes in any product's `isFavourite`
        foreach (var product in PVM.ProductList)
        {
            product.PropertyChanged += Product_PropertyChanged;
        }
    }

    private void Product_PropertyChanged(object sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(Product.isFavourite))
        {
            var product = sender as Product;
            if (product == null) return;

            Debug.WriteLine($"🔥 Product {product.Name} updated isFavourite: {product.isFavourite}");

            // Log all products' status
            Debug.WriteLine("🔍 All products after change:");
            foreach (var p in PVM.ProductList)
            {
                Debug.WriteLine($"📌 {p.Name}: isFavourite = {p.isFavourite}");
            }
        }
    }

    private void UpdateFavourites()
    {
        Debug.WriteLine("🔍 Checking all products and their isFavourite status:");
        foreach (var product in PVM.ProductList)
        {
            Debug.WriteLine($"📌 {product.Name}: isFavourite = {product.isFavourite}");
        }

        var favProducts = PVM.ProductList.Where(p => p.isFavourite).ToList();

        Debug.WriteLine($"🔄 Updating Favourites: {favProducts.Count} items");

        // 🔥 Instead of clearing and re-adding, force full reset
        Favourites = new ObservableCollection<Product>(favProducts);
        OnPropertyChanged(nameof(Favourites));
    }

}
