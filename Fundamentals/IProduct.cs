using System;

namespace Cs.Bases.Fundamentals;

public interface IProduct
{
    void ApplyDiscount(decimal percentage);
    string GetDescription();
    string Name { get; }
    decimal Price { get; }
    DateTime ExpirationDate { get; }
}
