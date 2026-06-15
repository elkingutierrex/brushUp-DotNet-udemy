using CsBases.Fundamentals;
using static System.Console;

class Program
{
    static void Main()
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

    }
}