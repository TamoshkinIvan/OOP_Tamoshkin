using System;

namespace Model
{
    /// <summary>
    /// Класс процентной скидки
    /// </summary>
    public class DiscountPercent: DiscountBase
    {
        /// <summary>
        /// Тип скидки
        /// </summary>
        public override DiscountType DiscountType
        {
            get => DiscountType.Percent;

        }

        /// <summary>
        /// Конструктор категории товара
        /// </summary>
        /// <param name="good">Категория товара</param>
        /// <param name="price">Цена</param>
        /// <param name="finalPrice">Сумма с учетом скидки</param>
        public DiscountPercent(GoodsType good, float price): base(good, price) {}

        /// <summary>
        /// XML конструктор
        /// </summary>
        protected DiscountPercent(){}


        /// <summary>
        /// Метод расчета конечной цены
        /// </summary>
        /// <returns>Конечная цена</returns>
        public override double CalculateDiscount()
        {
            switch (GoodsType)
            {
                case GoodsType.Clothes:
                    return Math.Round(Price * 0.98, 2);
                case GoodsType.ChildrenProducts:
                    return Math.Round( Price * 0.95, 2);
                case GoodsType.Food:
                    return Math.Round(Price * 0.8, 2);
                default:
                    return Price;
            }
        }
    }
}
