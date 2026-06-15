public class ProductManager
{
    private readonly ILabelServices _labelService;

    public ProductManager(ILabelServices labelService)
    {
        _labelService = labelService;
    }
    public void PrintLabel(Product product)
    {
        var label = _labelService.GetLabel(product);
        Console.WriteLine(label);
    }


}