using System;
using ClassLibrary3;



namespace LB3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //IDiscount coupon = new DiscountCoupon();
            //Console.WriteLine(coupon.CalculateDiscount());
            IDiscount percent = new DiscountPercent(GoodsType.Food, 982);
            Console.WriteLine(percent.CalculateDiscount());

            
            percent.Price = 500;
            Console.WriteLine(percent.CalculateDiscount());
            Console.ReadKey();

        }
    }
}
