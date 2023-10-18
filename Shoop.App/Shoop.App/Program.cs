using Shoop.Core.Models;

Product[] products = { };

Console.WriteLine("1.Creat Product");
Console.WriteLine("1.Show Products");
Console.WriteLine("0.Close");
string request = Console.ReadLine();

while (request != "0")
{
    switch (request)
    {
        case "1":
            CreateProduct();
            break;
        case "2":
            ShowProducts();
            break;
        default:
            Console.WriteLine("please add valid option");
            break;
    }
    Console.WriteLine("1.Create student");
    Console.WriteLine("2.Show students");
    Console.WriteLine("0.close");
    request = Console.ReadLine();


    void CreateProduct()
    {
        Console.WriteLine("Name :");
        string Name = Console.ReadLine();
        Console.WriteLine("Price :");
        double Price = double.Parse(Console.ReadLine());
        Console.WriteLine("Category :");
        string Category = Console.ReadLine();
        Console.WriteLine("StockCount :");
        string StockCount = Console.ReadLine();
        Array.Resize(ref products, products.Length + 1);
        products[products.Length - 1] = products[0];
        Console.WriteLine("Products created succesfuly");
    }

    void ShowProducts()
    {
        foreach (Product product in products)
        {
            Console.WriteLine(product.GetFullInfo());
        }

    }

    string ValidateString(string data)
    {
        while (string.IsNullOrWhiteSpace(data))
        {
            Console.WriteLine("pleasa add valid value");
            data = Console.ReadLine();
        }
        return data;
    }

}