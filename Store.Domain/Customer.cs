﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain
{
    #nullable disable annotations
    public class Customer : User
    {
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
