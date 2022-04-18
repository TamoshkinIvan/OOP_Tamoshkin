using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    /// <summary>
    /// 
    /// </summary>
    public class DiscountPercent: IDiscount
    {
        /// <summary>
        /// 
        /// </summary>
        private float _price;


        /// <summary>
        /// 
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
        /// 
        /// </summary>
        public GoodsType GoodsType { get; set; }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="good"></param>
        /// <param name="discountValue"></param>
        /// <param name="price"></param>
        public DiscountPercent(GoodsType good, float price)
        {
            Price = price;
            GoodsType = good;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public double CalculateDiscount()
        {
            
            switch (GoodsType)
            {
                case GoodsType.Clothes:
                    return (Price * 0.98) ;
                case GoodsType.ChildrenProducts:
                    return Price * 0.95;
                case GoodsType.Food:
                    return Price * 0.8;
                default:
                    throw new ArgumentException("Указан неверный тип продукта");
            }
        }
    }
}
