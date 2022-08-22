using System;
using System.Collections.Generic;
using System.Text;

namespace SMECommerce.Models.EntityModels
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descripton { get; set; }
        public ICollection<Item> Products { get; set; }
    }
}
