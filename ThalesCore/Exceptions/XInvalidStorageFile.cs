﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThalesCore.Exceptions
{
    class XInvalidStorageFile: Exception
    {
        public XInvalidStorageFile(string description) : base(description)
        { }
    }
}
