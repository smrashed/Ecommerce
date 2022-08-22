using SMECommerce.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SMECommerce.Services.Abstractions
{
    public interface IProductService
    {
        bool Add(Item item);
        bool Update(Item item);
        bool Remove(Item item);
        ICollection<Item> GetAll();
        Item GetById(int id);
    }
}
