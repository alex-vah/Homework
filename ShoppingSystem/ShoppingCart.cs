namespace ShoppingSystem;

public class ShoppingCart
{
    private List<Product> cart;
    public ShoppingCart AddProduct(Product product)
    {
        cart.Add(product);
        return this;
    }

    public OrderBuilder Checkout(DiscountCalculator discountCalculator)
    {
        double totalAmount = cart.Sum(product => product.Price);
        double discountedAmount = discountCalculator(totalAmount);

        Console.WriteLine($"Total Amount: ${totalAmount}");
        Console.WriteLine($"Discounted Amount: ${discountedAmount}");

        OrderBuilder orderBuilder = new OrderBuilder();
        foreach (var product in cart)
        {
            orderBuilder.AddProduct(product);
        }
        return orderBuilder;
    }
}