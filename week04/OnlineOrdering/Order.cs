using System;
using System.Collections.Generic;

namespace OnlineOrdering
{
    public class Order
    {
        private List<Product> _products;
        private Customer _customer;
        public Order(Customer customer)
        {
            _customer = customer;
            _products = new List<Product>();
        }
        public void AddProduct(Product product)
        {
            _products.Add(product);
        }
        public double CalculateTotalCost()
        {
            double totalProductsCost = 0;
            
            foreach (Product product in _products)
            {
                totalProductsCost += product.GetTotalCost();
            }
            double shippingCost = _customer.IsInUSA() ? 5 : 35;
            
            return totalProductsCost + shippingCost;
        }
        public string GetPackingLabel()
        {
            string packingLabel = "";
            
            foreach (Product product in _products)
            {
                packingLabel += $"- {product.GetName()} (ID: {product.GetProductId()})\n";
            }
            
            return packingLabel.Trim();
        }
        public string GetShippingLabel()
        {
            return $"{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
        }
        public List<Product> GetProducts() => _products;
    }
}