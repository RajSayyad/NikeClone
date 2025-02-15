using NikeClone.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NikeClone.TempDBS
{
    public class ProductViewModel
    {
        public List<Product> ProductList { get; set; }
        public ProductViewModel() {

            ProductList = new List<Product>() {
                new Product() {Id="1", Name="Air Force 1",Price=12000, ImageURL=["airforce1.jpg" ,"airforce2.jpg","airforce3.jpg"], Description="LowTop", Category="Men", IsBestseller=true},
                new Product(){Id="2",Name="Air Max",Price = 6500, ImageURL = ["airmax1.jpg","airmax2.jpg", "airmax3.jpg"], Description="Max Ishod", Category="Men", IsBestseller=true},
                new Product(){Id = "3", Name = "Court Vision", Price = 6500, ImageURL =["courtvision1.jpg", "courtvision2.jpg", "courtvision3.jpg"], Description="CourtVision", Category="Men", IsBestseller=true},
                new Product(){Id = "4", Name = "Court Vision Low", Price = 6500, ImageURL =["courtvisionlow1.jpg", "courtvisionlow2.jpg", "courtvisionlow3.jpg"], Description = "Low", Category = "Men", IsBestseller = true},
                new Product() {Id="5",Name = "FlyEase", Price=12000, ImageURL =["flyease1.jpg", "flyease2.jpg", "flyease3.jpg"], Description="Easys", Category="Women", IsBestseller=false},
                new Product(){Id = "6", Name = "Golf Shoe", Price = 6500, ImageURL =["golfshoe1.jpg", "golfshoe2.jpg", "golfshoe3.jpg"], Description="Golf Shoe", Category="Mens", IsBestseller=true},
                new Product(){Id = "7", Name = "Retro 4", Price = 6500, ImageURL =["retro4_1.jpg", "retro4_2.jpg.jpg", "retro4_3.jpg.jpg"], Description = "Retro", Category = "Mens", IsBestseller = true},
                new Product(){Id = "8", Name = "Jordan Mvp", Price = 6500, ImageURL =["jordanmvp1.jpg", "jordanmvp2.jpg", "jordanmvp3.jpg"], Description = "HighTop", Category = "Mens", IsBestseller = true},
                new Product(){Id="9", Name = "Air Jordan 1", Price = 6500, ImageURL = ["airjordan1.jpg",  "airjordan2.jpg"], Description = "LowTop", Category = "Kids", IsBestseller = true},
                new Product(){Id ="10", Name = "Adidas Forum Low", Price = 6500, ImageURL =["adidasforumlow1.jpg", "adidasforumlow2.jpg", "adidasforumlow3.jpg"], Description = "Adidas", Category = "Mens", IsBestseller = false}

            };

        }
    }
}
