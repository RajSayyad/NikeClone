using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NikeClone.MVVM.Models;

namespace NikeClone.MVVM.ViewModels
{
    public class HomePageViewModel
    {
        public ProductViewModel PVMobj {  get; set; } = new ProductViewModel();
        public UserViewModel UVMobj { get; set; } = new UserViewModel();

        public User CurrentUser { get; set; }
        public List<Product> BestSellers { get; set; } = new List<Product>();

        public HomePageViewModel() { 

            BestSellers = PVMobj.ProductList.Where(p=> p.IsBestseller==true).ToList();

            CurrentUser = UVMobj.CurrentUser;
            
        }
    }
}
