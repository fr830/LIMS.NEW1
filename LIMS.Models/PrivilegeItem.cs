﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.Models
{
    public class PrivilegeItem
    {
        public string Id
        {
            get; set;
        }

        public bool Query
        {
            get; set;
        }

        public bool Operate
        {
            get; set;
        }
    }
}
