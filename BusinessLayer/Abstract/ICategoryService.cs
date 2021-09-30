﻿using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetList();
        void  CategoryAdd(Category category);
        void  CategoryDelete(Category category);
        void  CategoryUpdate(Category category);
        Category GetById(int id);
        
    }
}
