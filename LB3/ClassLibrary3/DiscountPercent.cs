using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLab3
{
    /// <summary>
    /// Класс процентной скидки
    /// </summary>
    public class DiscountPercent: DiscountBase
    {
        /// <summary>
        /// Конструктор категории товара
        /// </summary>
        /// <param name="good">Категория товара</param>
        /// <param name="price">Цена</param>
        public DiscountPercent(GoodsType good, float price): base(good, price){}

        /// <summary>
        /// Метод расчета конечной цены
        /// </summary>
        /// <returns>Конечная цена</returns>
        public override double CalculateDiscount()
        {
            switch (GoodsType)
            {
                case GoodsType.Clothes:
                    return Price * 0.98;
                case GoodsType.ChildrenProducts:
                    return Price * 0.95;
                case GoodsType.Food:
                    return Price * 0.8;
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
                   $"\n Тип скидки: Скидка на выбранную категорию товара." +
                   $"\n Цена без учета скидки: {Price} руб." +
                   $"\n Цена с учетом скидки: {CalculateDiscount()} руб." +
                   $"\n Сумма скидки: {Price - CalculateDiscount()} руб." +
                   "\n*************\n";
        }
    }
}
