using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMECommerce.app.Models.ProductModels
{
    public class ProductDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public DateTime ManufactureDate { get; set; }
        public string CategoryName { get; set; }
        public int? CategoryId { get; set; }
        public string ProductPhotoUrl { get; set; }
    }
}
