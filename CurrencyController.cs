﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Currency_Apps
{
    class CurrencyController
    {
        public string usdToIdr(string nominal)
        {
            var nominalDouble = Convert.ToDouble(nominal);
            var result = nominalDouble * 15000;

            return Convert.ToString(result);
        }
        public Boolean isAllowed(string nominal)
            {
            Regex regex = new Regex("[^0-9.-]+");
            return !regex.IsMatch(nominal);

        }
        }

    }

