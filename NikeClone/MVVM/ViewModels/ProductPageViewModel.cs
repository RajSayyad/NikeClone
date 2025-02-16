using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using NikeClone.TempDBS;
using NikeClone.MVVM.Models;

namespace NikeClone.MVVM.ViewModels
{
    public class ProductPageViewModel : INotifyPropertyChanged
    {
        public ProductViewModel product { get; set; } 
        public UserViewModel user { get; set; } = new UserViewModel();

        private List<Product> _relproduct;
        public List<Product> relproduct
        {
            get => _relproduct;
            set
            {
                _relproduct = value;
                OnPropertyChanged();
            }
        }

        private Product _prod;
        public Product prod
        {
            get => _prod;
            set
            {
                _prod = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(PageTitle)); // Notify that the title changed
            }
        }

        // Property for ContentPage Title Binding
        public string PageTitle => prod?.Name ?? "Product Details";

        public ProductPageViewModel(Product Item)
        {
            product = ProductViewModel.Instance;
            relproduct = product.ProductList.Where(p => p.Category == Item.Category).ToList();
            prod = Item;

        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
