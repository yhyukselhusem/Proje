﻿using CORE.CoreEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Entities
{
    public class Category : EntityRepository
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }

        //Lazy Load
        public virtual List<SubCategory> SubCategories { get; set; }
    }
}
