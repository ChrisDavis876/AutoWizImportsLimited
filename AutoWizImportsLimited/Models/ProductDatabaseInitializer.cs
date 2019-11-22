using System.Collections.Generic;
using System.Data.Entity;

namespace AutoWizImportsLimited.Models
{
  public class ProductDatabaseInitializer : DropCreateDatabaseAlways<ProductContext>
  {
    protected override void Seed(ProductContext context)
    {
      GetCategories().ForEach(c => context.Categories.Add(c));
      GetProducts().ForEach(p => context.Products.Add(p));
    }

    private static List<Category> GetCategories()
    {
      var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Accessories"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Engine/ Body"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Suspension Parts"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Electrical Parts"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Servicing Parts"
                },
            };

      return categories;
    }

    private static List<Product> GetProducts()
    {
      var products = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Air Freshners",
                    Description = "The scent dial puts you in the driver's seat, allowing you to select the perfect amount of freshness for you and your passengers. " + 
                                  "Enhance the scent in your car!", 
                    ImagePath="febreze.jpg",
                    UnitPrice = 622.50,
                    CategoryID = 1
               },
                new Product 
                {
                    ProductID = 2,
                    ProductName = "Boss Audio Systems",
                    Description = "Get more digital music options with the Boss Audio BV9358B DVD Player with a 6.2-inch Digital LED Touchscreen",
                    ImagePath="boss.jpg",
                    UnitPrice = 14999.95,
                     CategoryID = 1
               },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Leather Seat Covers",
                    Description = "Enhance the look and feel of your car with these leather seat wraps.",
                    ImagePath="seatcover.jpg",
                    UnitPrice = 20222.99,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Wiper Blades",
                    Description = "Provides a smooth, clean, streak-free wipe due to multiple press points that conform to your windshield",
                    ImagePath="wipers.jpeg",
                    UnitPrice = 950.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Bulbs",
                    Description = "The light LED is clear, clean and bright, effectively turning the night into daylight." + 
                                  "No batteries required.",
                    ImagePath="bulbs.jpg",
                    UnitPrice = 4500.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Auto Mats",
                    Description = "Constructed from high-quality heat, weather, and stain-resistant carpet with reinforced seams.",
                    ImagePath="mats.jpeg",
                    UnitPrice = 6350.00,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Air Filter",
                    Description = "This air filter ensures that your vehicle’s engine gets the clean and efficient air flow it needs for optimal performance.",
                    ImagePath="airfilter.jpeg",
                    UnitPrice = 1050.95,
                    CategoryID = 5
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "Botch Disc Pads",
                    Description = "Bosch dedicated engineering to platform specific premium materials, ensuring exceptional stopping power and quiet operation with low dust.",
                    ImagePath="brakepad.jpg",
                    UnitPrice = 3500.95,
                    CategoryID = 5
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "Iridium Sparks Plug",
                    Description = "Bosch Double Iridium Spark Plugs are engineered to deliver both high performance and long life, representing the best of OE spark plug technology.",
                    ImagePath="iridium.jpg",
                    UnitPrice = 8700.95,
                    CategoryID = 5
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "Botch Oil Filter",
                    Description = "Bosch Premium FILTECH Oil Filter provides superior oil filtration for increased engine protection.",
                    ImagePath="oilfilter1.jpg",
                    UnitPrice = 670.00,
                    CategoryID = 5
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "Disc Wheel",
                    Description = "Keep your brakes sharp and ready for adversities on the road",
                    ImagePath="discwheel.jpg",
                    UnitPrice = 9450.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "Fender",
                    Description = "Fits your car like it`s just out the factory. Easy installation and ready to go",
                    ImagePath="fender.jpg",
                    UnitPrice = 3200.40,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 13,
                    ProductName = "Shell Helix Motor Oil",
                    Description = "Dont drive around with dirty oil in your vehicle engine. Get the shell Helix for high proformance",
                    ImagePath="oil2.jpg",
                    UnitPrice = 765.00,
                    CategoryID = 5
                },
           
            };

      return products;
    }
  }
}