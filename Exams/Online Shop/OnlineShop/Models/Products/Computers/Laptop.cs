﻿
namespace OnlineShop.Models.Products.Computers
{
    public class Laptop:Computer
    {
        private const double OveralPerformance = 10;
        public Laptop(int id, string manufacturer, string model, decimal price) 
            : base(id, manufacturer, model, price, OveralPerformance)
        {
        }
    }
}
