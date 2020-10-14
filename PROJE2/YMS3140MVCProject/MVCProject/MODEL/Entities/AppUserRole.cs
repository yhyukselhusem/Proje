﻿using CORE.CoreEntity;
using CORE.CoreEntity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Entities
{
    public  class AppUserRole : EntityRepository
    {
        public AppUser appUser { get; set; }
        public Role Role { get; set; }        
    }
}
