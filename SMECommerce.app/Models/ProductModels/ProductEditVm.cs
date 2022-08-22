using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using SMECommerce.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SMECommerce.app.Models.ProductModels
{
    public class ProductEditVm
    {
       
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        //public Category Category { get; set; }
        public int? CategoryId { get; set; }
        public SelectList Categories { get; set; }
        public double Price { get; set; }
        public DateTime ManufacturerDate { get; set; }
        public string ProductPhotoUrl { get; set; }
        public IFormFile ProductPhoto { get; set; }
    }
}
