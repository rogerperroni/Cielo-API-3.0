﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cielo.Configurations
{
    public interface IEnvironment
    {
        string TransactionUrl { get; set; }

        string QueryUrl { get; set; }
    }
}
