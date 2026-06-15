namespace CsBases.Fundamentals
{
    public class LabelService : ILabelServices
    {
        public string GetLabel(Product product)
        {
            return $"Product: {product.Name}, Price: {product.Price:C} - code: {product.GetType().Name}-{product.GetHashCode()}";
        }
    }
}