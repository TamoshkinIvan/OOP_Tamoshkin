using System;

namespace ClassLibrary3
{
    /// <summary>
    /// Класс скидки по купону
    /// </summary>
    public class DiscountCoupon : IDiscount
    {
        /// <summary>
        /// Цена выбранной категории товара
        /// </summary>
        private float _price;
        
        /// <summary>
        /// Сумма списываемых рублей по купону
        /// </summary>
        private float _discount;

        /// <summary>
        /// Сумма списываемых рублей по купону
        /// </summary>
        public float Discount
        {
            get => _discount;
            set
            {
                if (value <= 0 || value >= 1000)
                {
                    throw new ArgumentException(
                        "Повторите ввод. Скидка должна быть больше нуля и" +
                        "не больше максимально допустимой суммы.");
                }
                _discount = value;
            }
        }

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
        /// <param name="goodType">Категория товара</param>
        /// <param name="price">Цена указанной категории товара</param>
        /// <param name="discount">Сумма списываемых рублей</param>
        public DiscountCoupon(GoodsType goodType, float price, float discount)
        {
            GoodsType = goodType;
            Price = price;
            Discount = discount;
        }

        /// <summary>
        /// Метод расчета итоговой стоимости
        /// </summary>
        /// <returns>Итоговая стоимость</returns>
        /// <exception cref="NotImplementedException"></exception>
        public double CalculateDiscount()
        {
            switch (GoodsType)
            {
                case GoodsType.Food when Price >= 2000:
                    return Price - Discount;
                case GoodsType.ChildrenProducts when Price >= 3000:
                    return Price - Discount;
                case GoodsType.Clothes when Price >= 5000:
                    return Price - Discount;
                default:
                    return Price;
            }
        }

        /// <summary>
        /// Метод печати чека
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public string GetTax()
        {
            return "*************" +
                   $"\n Выбранная категория товара {GoodsType} руб." +
                   $"\n Тип скидки: Скидка по купону на весь чек." +
                   $"\n Цена без учета скидки: {Price} руб." +
                   $"\n Цена с учетом скидки: {CalculateDiscount()} руб." +
                   $"\n Сумма скидки: {Price - CalculateDiscount()} руб." +
                   "\n*************\n";
        }
    }
}
