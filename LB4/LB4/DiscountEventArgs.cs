﻿using System;
using Model;

namespace View
{
    public class DiscountEventArgs : EventArgs
    {
        /// <summary>
        /// Добавление скидки
        /// </summary>
        public DiscountBase Discount { get; }

        /// <summary>
        /// Конструктор DiscountEventArgs
        /// </summary>
        /// <param name="discount"></param>
        public DiscountEventArgs(DiscountBase discount)
        {
            Discount = discount;
        }
    }
}
