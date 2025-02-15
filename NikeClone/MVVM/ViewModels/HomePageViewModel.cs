using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NikeClone.MVVM.Models;
using NikeClone.DataBase;

namespace NikeClone.MVVM.ViewModels
{
    public class HomePageViewModel
    {
        public ProductViewModel PVMobj {  get; set; } = new ProductViewModel();
        public UserViewModel UVMobj { get; set; } = new UserViewModel();

        public User CurrentUser { get; set; }
        public List<Product> BestSellers { get; set; } = new List<Product>();

        public List<Product> CategoryData { get; set; }

        public List<Product> NikeAir { get; set; }

        public List<Product> NikeJordan { get; set; }

        public List<Product> Adidas { get; set; }


        public HomePageViewModel() { 

            BestSellers = PVMobj.ProductList.Where(p=> p.IsBestseller==true).ToList();

            CurrentUser = new User() { Name = "Raj" };

            CategoryData = new List<Product>() {
                new Product(){Name = "HighTop", ImageURL=["cat1.png"]},
                new Product(){Name = "Retro", ImageURL=["cat2.png"]},
                new Product(){Name = "Lows", ImageURL=["cat3.png"]},
                new Product(){Name = "Women", ImageURL=["cat4.png"]}
            };
            NikeAir = new List<Product>() {
                new Product(){ImageURL=["nikeair1.jpg"]},
                new Product(){ImageURL=["nikeair2.jpg"]}
            };
            NikeJordan = new List<Product>() {
                new Product(){ImageURL=["nikejordan1.jpg"]},
                new Product(){ImageURL=["nikejordan2.jpg"]},
                new Product(){ImageURL=["nikejordan3.jpg"]}
            };
            Adidas = new List<Product>() {
                new Product(){ImageURL=["adidas1.jpg"]},
                new Product(){ImageURL=["adidas2.jpg"]}
            };
        }


    }
}
}
