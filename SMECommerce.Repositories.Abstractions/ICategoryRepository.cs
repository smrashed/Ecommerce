﻿using SMECommerce.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SMECommerce.Repositories.Abstractions
{
    public interface ICategoryRepository:IRepository<Category>
    {
        Category CategoryName(int id);
        

    }
}
