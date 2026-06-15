using CsBases.Fundamentals;
using static System.Console;

class Program
{
    static async Task Main()
    {
        var product = new Product("Smartphone", 499.99m, true);


        // Adapter pattern example
        var productDto = ProductAdapter.ToDto(product);
        WriteLine($"Product DTO - Name: {productDto.Name}, Price: {productDto.Price}, Code: {productDto.Code}");

        // Dependency Injection example
        ILabelServices labelService = new LabelService();
        var manager = new ProductManager(labelService);
        var installation = new ServiceProduct("Reparacion", 200, true, 30);

        manager.PrintLabel(product);
        manager.PrintLabel(installation);

        var firstProduct = await new ProductRepository().GetProduct(1);
        firstProduct.Description = "Product description";
        AttributeProcessor.ApplyUpperCase(firstProduct);
        WriteLine($"CCCCCC: {firstProduct.Name} - {firstProduct.Description} ");
    }
}