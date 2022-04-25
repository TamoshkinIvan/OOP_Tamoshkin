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
                new DiscountCoupon(GoodsType.Food, 5000, 250),
                new DiscountPercent(GoodsType.Food, 982)
            };

            foreach (var discount in discountList)
            {
                Console.WriteLine(GetTax(discount));
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Метод печати чека
        /// </summary>
        /// <returns></returns>
        public static string GetTax(DiscountBase discount)
        {
            var price = discount.Price;
            var finalPrice = discount.CalculateDiscount;
            return "*************" +
                   $"\n Выбранная категория товара {discount.GoodsType} руб." +
                   $"\n Тип скидки: Скидка на выбранную категорию товара." +
                   $"\n Цена без учета скидки: {price} руб." +
                   $"\n Цена с учетом скидки: {finalPrice} руб." +
                   $"\n Сумма скидки: {price - finalPrice} руб." +
                   "\n*************\n";
             
        }
    }
}
