using CsBases.Fundamentals;
public class ProductRepository
{
    // public async Task<Product> GetProductAsync(int id)
    // {
    //     await Task.Delay(2000);
    //     return new Product("Smartphone", 499.99m, true);
    // }

    public async Task<Product> GetProduct(int id)
    {
        WriteLine("Buscando .....producto");
        await Task.Delay(2000);
        return new Product("MMMMMMMMMMM SIMULADO", 499.99m, true);


    }
}