﻿using System;
using System.Collections.Generic;
using System.Text;
using BookStore.Models;

namespace BookStore.Models
{
    class PercentageDiscount : IDiscount
    {
        public int discoutRate;

        public PercentageDiscount(int rate)
        {
            discoutRate = rate;
        }

        public decimal ApplyDiscount(decimal amount)
        {

            decimal finalPrice = amount;
            return finalPrice;
        }
    }
}
