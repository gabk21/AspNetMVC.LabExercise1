using System.Collections.Generic;
using AspNetMVC.LabExercise1.Models;

namespace AspNetMVC.LabExercise1.Services
{
    public class ProductService
    {
        private List<Product> products;

        public ProductService()
        {
            products = new List<Product>();

            products.Add(new Product()
            {
                Id = 1,
                Name = "Nescafe",
                Description = "Babangon tayo!",
                Quantity = 10,
                Price = 10
            });

            products.Add(new Product()
            {
                Id = 2,
                Name = "Kopiko Blanca",
                Description = "Boom! Gising!",
                Quantity = 15,
                Price = 8
            });

            products.Add(new Product()
            {
                Id = 3,
                Name = "San Mig Coffee",
                Description = "My sugar-free, guilt-free coffee",
                Quantity = 20,
                Price = 9
            });

            products.Add(new Product()
            {
                Id = 4,
                Name = "Great Taste Coffee",
                Description = "Tikman ang sarap ng tamang timpla!",
                Quantity = 5,
                Price = 12
            });

            products.Add(new Product()
            {
                Id = 5,
                Name = "Cafe Puro",
                Description = "The delicious taste of ground coffee",
                Quantity = 25,
                Price = 13
            });

        }
        public List<Product> GetCatalog()
        {
            return products;
        }

        public decimal GetGrandTotal()
        {
            decimal total = 0;
            foreach (var product in products)
            {
                total += product.TotalAmount;
            }
            return total;
        }
    }
}
