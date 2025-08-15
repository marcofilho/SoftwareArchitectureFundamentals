﻿namespace DesignPatterns
{
    public class Order
    {
        public Guid Id { get; set; }
        public decimal Amount { get; set; }
        public List<Product> Products { get; set; }
    }
}