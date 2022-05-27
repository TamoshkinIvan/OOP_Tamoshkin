using System;
using System.Xml.Serialization;

namespace Model
{
    /// <summary>
    /// Реализация класса Discount
    /// </summary>
    [XmlInclude(typeof(DiscountCoupon))]
    [XmlInclude(typeof(DiscountPercent))]
    public abstract class DiscountBase
    {
        /// <summary>
        /// Сумма покупки указанной категории товара
        /// </summary>
        private double  _price;

        /// <summary>
        /// Цена указанной категории товара
        /// </summary>
        public double Price
        {
            get => _price;
            set
            {
                if (value <= 0 || double.IsNaN(value) )
                {
                    throw new ArgumentException(
                        "Сумма покупки должна быть больше нуля. Повторите ввод.");
                }
                _price = value;
            }
        }

        /// <summary>
        /// Сумма с учетом скидки
        /// </summary>
        public  double FinalPrice
        {
            get => CalculateDiscount(); 
            set => CalculateDiscount();
        }


        private double _discount;

        public double CalculatedDiscount
        {
            get => Price - FinalPrice;
            set => _discount = value;
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
        protected DiscountBase(GoodsType good, double price)
        {
            Price = price;
            GoodsType = good;
        }


        /// <summary>
        /// XMl конструктор
        /// </summary>
        protected DiscountBase()
        {}

        /// <summary>
        /// Метод расчета цены с учетом скидки
        /// </summary>
        /// <returns></returns>
        public abstract double CalculateDiscount();

        /// <summary>
        /// Тип скидки
        /// </summary>
        public abstract DiscountType DiscountType { get; }
    }
}
