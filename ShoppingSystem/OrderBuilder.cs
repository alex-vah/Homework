namespace ShoppingSystem;

public class OrderBuilder
{ 
    private List<Product> products;
    public OrderBuilder AddProduct(Product product)
    {
        products.Add(product); 
        return this;
    }

    public List<Product> GetProducts()
    {
        return products;
    }
}