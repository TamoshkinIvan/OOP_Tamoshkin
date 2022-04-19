using System;
using System.Collections.Generic;
using ModelLab3;



namespace LB3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            
            var discountList = new List<DiscountBase>()
            {
                new DiscountCoupon(GoodsType.Food, 3000, 250),
                new DiscountPercent(GoodsType.Food, 982)

            };

            foreach (var discount in discountList)
            {
                Console.WriteLine(discount.CalculateDiscount());
            }

            Console.ReadKey();
        }
    }
}
