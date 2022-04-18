using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    public class DiscountCoupon : IDiscount
    {
        private float _price;
        
        private float _discount;
        /// <summary>
        /// 
        /// </summary>
        public float Discount
        {
            get => _discount;
            set
            {
                if (value < 0 || value >= 100)
                {
                    throw new ArgumentException(
                        "Повторите ввод. Скидка должна быть от 0 до 100%");
                }
                _discount = value;
            }
        }

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

        public GoodsType GoodsType { get; set; }



        public double CalculateDiscount()
        {
            throw new NotImplementedException();
        }
    }
}
