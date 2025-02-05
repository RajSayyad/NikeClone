using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NikeClone.MVVM.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public string[] ImageURL { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public bool IsBestseller {  get; set; }

    }
}
