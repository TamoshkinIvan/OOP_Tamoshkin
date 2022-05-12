using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace View
{
    internal class DiscountEventArgs : EventArgs
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
