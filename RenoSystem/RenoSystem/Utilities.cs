﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenoSystem
{
    public static class Utilities
    {
        public static bool IsZeroPositive(int value)
        {
            bool valid = true;
            if(value < 0)
            {
                valid = false;
            }
            return valid;
        }




    }
}
