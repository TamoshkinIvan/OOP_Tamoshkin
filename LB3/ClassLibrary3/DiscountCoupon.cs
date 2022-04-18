using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                if (value <= 0)
                {
                    throw new ArgumentException(
                        "Повторите ввод. Скидка должна быть больше нуля.");
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
            throw new NotImplementedException();
        }

        /// <summary>
        /// Метод печати чека
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public string GetTax()
        {
            throw new NotImplementedException();
        }
    }
}
