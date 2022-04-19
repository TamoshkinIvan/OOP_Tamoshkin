using System;
using ModelLab3;



namespace LB3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //TODO:
            IDiscount coupon = new DiscountCoupon(GoodsType.Food, 3000, 3000);
            IDiscount percent = new DiscountPercent(GoodsType.Food, 982);

            Console.WriteLine(percent.GetTax());
            Console.WriteLine(coupon.GetTax());
            Console.ReadKey();
        }
    }
}
