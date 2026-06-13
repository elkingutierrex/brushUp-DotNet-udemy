class Program
{
    static void Main(string[] args)
    {
        // // Explicitly declarration of variable with type
        // string name = "John Doe";
        // // Implicitly declarration of variable with var keyword
        // int age = 30;
        // // Implicitly declarration of variable with var keyword and type inference
        // decimal score = 85.5m;
        // // Using var with type inference for a collection
        // var numbers = new List<int> { 1, 2, 3, 4, 5 };
        // // Output the values to the console
        // Console.WriteLine($"Name: {name}, Age: {age}, Score: {score}");
        // Console.WriteLine("Numbers:");
        // foreach (var number in numbers)
        // {
        //     Console.WriteLine(number);
        // }

        // // var declaration
        // var declaration = "This is a var declaration example.";
        // Console.WriteLine(declaration);

        // // var declaration with lambda expression
        // var square = (int x) => x * x;
        // Console.WriteLine($"Square of 5: {square(5)}");

        // // var declaration with anonymous type
        // var person = new { Name = "Jane Doe", Age = 28 };
        // Console.WriteLine($"Person: {person.Name}, Age: {person.Age}");

        // // var declaration with tuple
        // var result = (true, "Success");
        // Console.WriteLine($"Result: {result.Item1}, Message: {result.Item2}");

        var laptop = new Product("Laptop", 999.99m, true);
        WriteLine(laptop.GetDescription());
        var soporte = new Product("Soporte Técnico", 199.99m, true);
        WriteLine(soporte.GetDescription());

    }
}