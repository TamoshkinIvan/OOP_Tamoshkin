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
            
            return "*************" +
                   $"\n Выбранная категория товара {discount.GoodsType} руб." +
                   "\n Тип скидки: Скидка на выбранную категорию товара." +
                   $"\n Цена без учета скидки: {discount.Price} руб." +
                   $"\n Цена с учетом скидки: {discount.FinalPrice} руб." +
                   $"\n Сумма скидки: {discount.Price - discount.FinalPrice} руб." +
                   "\n*************\n";
        }
    }
}
