// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using EntityFrameworkStarting.DataAccessLayer;
using (var _context = new AppDbContext())
{
	var products = _context.Products.ToList();


    foreach (var item in products)
    {
        Console.WriteLine($"{item.Id}    {item.Name}    {item.Price}");
    }

}



