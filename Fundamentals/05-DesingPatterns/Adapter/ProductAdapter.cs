public class ProductAdapter
{
    public static ProductDto ToDto(Product product)
    {
        return new ProductDto
        {
            Name = product.Name ?? "Sin Nombre",
            Price = product.Price,
            Code = $"Product-{product.Id}-{product.UniqueCode.ToString().Substring(0, 8) ?? "00000000"}"
        };
    }


}