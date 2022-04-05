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
    public class DiscountPercent: DiscountBase
    {
        /// <summary>
        /// 
        /// </summary>
        private string _clientId;

        /// <summary>
        /// Client Id
        /// </summary>
        public string ClientId
        {
            get => _clientId;
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value));
                }
                _clientId = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="discountType"></param>
        /// <param name="discountValue"></param>
        /// <param name="price"></param>
        /// <param name="clientId"></param>
        public DiscountPercent(DiscountType discountType, int discountValue, float price, string clientId)
            : base(discountType, discountValue, price)
        {
            ClientId = clientId;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
        protected override float CalculateDiscount(float price)
        {
            return price * (1 - DiscountValue / 100);
        }

    }
}
