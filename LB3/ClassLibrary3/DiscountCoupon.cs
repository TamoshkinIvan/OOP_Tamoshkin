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
        /// <param name="goodType">Тип товара</param>
        /// <param name="price">Цена</param>
        /// <param name="discount">Размер скидки</param>
        public DiscountCoupon(GoodsType goodType, float price, float discount)
            : base(goodType, price)
        {
            Discount = discount;
        }

        /// <summary>
        /// Расчета итоговой стоимости
        /// </summary>
        /// <returns>Итоговая стоимость</returns>
        public override double CalculateDiscount
        {
            get
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
}
