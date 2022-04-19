using System;

namespace ModelLab3
{
    /// <summary>
    /// Класс скидки по купону
    /// </summary>
    public class DiscountCoupon : DiscountBase
    {
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
                        "Повторите ввод. Скидка должна быть больше нуля и " +
                        "не больше максимально допустимой суммы.");
                }
                _discount = value;
            }
        }
        
        /// <summary>
        /// Конструктор товара
        /// </summary>
        /// <param name="goodType"></param>
        /// <param name="price"></param>
        /// <param name="discount"></param>
        public DiscountCoupon(GoodsType goodType, float price, float discount)
            : base(goodType, price)
        {
            Discount = discount;
        }

        /// <summary>
        /// Метод расчета итоговой стоимости
        /// </summary>
        /// <returns>Итоговая стоимость</returns>
        public override double CalculateDiscount()
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

        //TODO: duplication
        /// <summary>
        /// Метод печати чека
        /// </summary>
        /// <returns></returns>
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
