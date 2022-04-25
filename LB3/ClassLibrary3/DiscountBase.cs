using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLab3
{
    /// <summary>
    /// Реализация интерфейса Discount
    /// </summary>
    public abstract class DiscountBase
    {
        /// <summary>
        /// Сумма покупки указанной категории товара
        /// </summary>
        private float _price;

        /// <summary>
        /// Цена указанной категории товара
        /// </summary>
        public float Price
        {
            get => _price;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(
                        "Сумма покупки должна быть больше нуля. Повторите ввод.");
                }
                _price = value;
            }
        }

        /// <summary>
        /// Категория товара
        /// </summary>
        public GoodsType GoodsType { get; set; }

        /// <summary>
        /// Конструктор категории товара
        /// </summary>
        /// <param name="good">Категория товара</param>
        /// <param name="price">Цена</param>
        protected DiscountBase(GoodsType good, float price)
        {
            Price = price;
            GoodsType = good;
        }
        
        /// <summary>
        /// Метод расчета цены с учетом скидки
        /// </summary>
        /// <returns></returns>
        public abstract double CalculateDiscount { get; }
    }
}
