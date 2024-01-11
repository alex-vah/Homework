using System;
using System.Collections.Generic;
using ShoppingSystem;

public delegate double DiscountCalculator(double totalAmount);

class Program
{
    static double RegularCustomerDiscount(double totalAmount)
    {
        // We can assign a symbolic value of 10% to the discount percentage
        double discountPercentage = 0.1;
        return totalAmount - (totalAmount * discountPercentage);
    }

    static double VipCustomerDiscount(double totalAmount)
    {
        // Another symbolic discount percentage assignment
        double discountPercentage = 0.2;
        return totalAmount - (totalAmount * discountPercentage);
    }

    static double SaleDiscount(double totalAmount)
    {
        // Another symbolic discount percentage assignment
        double discountPercentage = 0.15;
        return totalAmount - (totalAmount * discountPercentage);
    }
    static void Main(string[] args)
    {
        DiscountCalculator regularCustomerDiscount = RegularCustomerDiscount;
        DiscountCalculator vipCustomerDiscount = VipCustomerDiscount;
        DiscountCalculator saleDiscount = SaleDiscount;

        ProductBuilder productBuilder = new ProductBuilder();
        Product product1 = productBuilder.SetName("Product 1").SetPrice(50.0).SetDescription("Description 1").Build();
        Product product2 = productBuilder.SetName("Product 2").SetPrice(75.0).SetDescription("Description 2").Build();

        ShoppingCart shoppingCart = new ShoppingCart();
        shoppingCart.AddProduct(product1).AddProduct(product2);

        OrderBuilder orderBuilder = shoppingCart.Checkout(vipCustomerDiscount);//Same for the other discounts

        Console.WriteLine("\n Order Details:");
        foreach (var product in orderBuilder.GetProducts())
        {
            Console.WriteLine($"Product: {product.Name}, Price: ${product.Price}, Description: {product.Description}");
        }
    }
}
