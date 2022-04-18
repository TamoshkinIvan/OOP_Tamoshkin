using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    /// <summary>
    /// Класс процентной скидки
    /// </summary>
    public class DiscountPercent: IDiscount
    {
        /// <summary>
        /// Сумма покупки указанной категории товара
        /// </summary>
        private float _price;

        /// <summary>
        /// Сумма покупки указанной категории товара 
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
        public DiscountPercent(GoodsType good, float price)
        {
            Price = price;
            GoodsType = good;
        }

        /// <summary>
        /// Метод расчета конечной цены
        /// </summary>
        /// <returns>Конечная цена</returns>
        /// <exception cref="ArgumentException"></exception>
        public double CalculateDiscount()
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

        /// <summary>
        /// Метод печати чека
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception
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
