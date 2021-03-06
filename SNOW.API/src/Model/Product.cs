﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SNOW.API.Core.Model
{
    public class Product : AuditableEntity<Product>
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
