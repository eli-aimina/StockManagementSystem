﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using SMS.Repository;
using SMS.Models;

namespace SMS.Bll
{
    public class CategorySetupManager
    {
        CategoryRepository _categorySetup = new CategoryRepository();

        public void SaveCategory(Category category)
        {
            _categorySetup.SaveCategory(category);
        }

        public DataTable ShowCategory()
        {
            return _categorySetup.ShowCategory();
        }
    }
}
