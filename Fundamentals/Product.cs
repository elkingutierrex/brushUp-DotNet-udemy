using Cs.Bases.Fundamentals;

public class Product : IProduct
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public bool IsAvailable { get; set; }
    public DateTime CreatedAt { get; set; }
    public Guid UniqueCode { get; set; }

    public DateTime ExpirationDate => throw new NotImplementedException();

    public Product(string name, decimal price, bool isAvailable)
    {
        Name = name;
        Price = price;
        IsAvailable = isAvailable;
        CreatedAt = DateTime.Now;
        UniqueCode = Guid.NewGuid();
    }

    public void ApplyDiscount(decimal percentage)
    {
        if (percentage < 0 || percentage > 100)
        {
            throw new ArgumentOutOfRangeException(nameof(percentage), "Percentage must be between 0 and 100.");
        }

        Price -= Price * (percentage / 100);
    }

    public virtual string GetDescription()
    {
        return $"Product: {Name}, Price: {Price:C}, Available: {IsAvailable}, Created At: {CreatedAt}, Unique Code: {UniqueCode}";
    }

    class ServiceProduct : Product
    {
        public int DurationInDays { get; set; }
        public ServiceProduct(string name, decimal price, bool isAvailable, int duration) : base(name, price, isAvailable)
        {
            DurationInDays = duration;
        }



        public override string GetDescription()
        {
            return $"{base.GetDescription()} - Duration: {DurationInDays} days";

        }
    }




}