﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThalesCore.Exceptions
{
    public class XInvalidKeyScheme: Exception
    {
        public XInvalidKeyScheme(string description) : base(description)
        {
            
        }
    }
}
