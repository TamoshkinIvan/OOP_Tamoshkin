using System;

namespace Model
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
        /// Тип скидки
        /// </summary>
        public override DiscountType DiscountType
        {
            get => DiscountType.Coupon;
        
        }

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
        /// <param name="goodType">Тип товара</param>
        /// <param name="price">Цена</param>
        /// <param name="finalPrice">Сумма с учетом скидки</param>
        /// <param name="discount">Размер скидки</param>
        public DiscountCoupon(GoodsType goodType, float price, float discount)
            : base(goodType, price)
        {
            Discount = discount;
        }

        /// <summary>
        /// XLM конструктор
        /// </summary>
        protected DiscountCoupon()
        {

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
    }
}
