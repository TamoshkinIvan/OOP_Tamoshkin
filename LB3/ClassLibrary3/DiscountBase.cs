using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    /// <summary>
    /// Discount base class
    /// </summary>
    public abstract class DiscountBase
    {
        /// <summary>
        /// 
        /// </summary>
        private float _price;

        /// <summary>
        /// 
        /// </summary>
        public DiscountType DiscountType { get; set; } 

        /// <summary>
        /// 
        /// </summary>
        private int _discountValue;

        /// <summary>
        /// 
        /// </summary>
        public const int MaxDiscount = 100;

        /// <summary>
        /// 
        /// </summary>
        public const int MinDiscount = 0;

        /// <summary>
        /// 
        /// </summary>
        public const float MinPrice = 0;

        /// <summary>
        /// Discount value
        /// </summary>
        public int DiscountValue
        {
            get => _discountValue;
            set
            {
                if (value <= MinDiscount || value > MaxDiscount)
                {
                    throw new ArgumentException(
                            "Please enter an age in range" +
                            $"between {MinDiscount} and {MaxDiscount}"
                        );
                }
                _discountValue = value;
            }
        }

        public float Price
        {
            get => _price;
            set
            {
                if (value <= MinPrice)
                {
                    throw new ArgumentException(
                        "Price should be more than zero. Please, try again!"
                    );
                }
                _price = value;

            }
        }

        /// <summary>
        /// Instance constructor 
        /// </summary>
        /// <param name="discountType">Discount type</param>
        /// <param name="discountValue">Discount value</param>
        /// <param name="price">Price </param>
        protected DiscountBase(DiscountType discountType, int discountValue, float price)
        {
            DiscountValue = discountValue;
            DiscountType = discountType;
            Price = price;
        }

        /// <summary>
        /// Calculate price with discount
        /// </summary>
        /// <param name="price">Purchase price </param>
        /// <returns></returns>
        protected abstract float CalculateDiscount(float price);


    }
}
