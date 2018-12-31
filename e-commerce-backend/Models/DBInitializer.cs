using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce_backend.Models
{
    public class DBInitializer
    {
        public static void Seed(EcommerceContext context)
        {
            context.Database.EnsureCreated();

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                new Product
                {
                    Name = "Chair",
                    Code = "CH0001",
                    Price = 12.75,
                    ImageUrl = "an url"
                },
                new Product
                {
                    Name = "Table",
                    Code = "TB0001",
                    Price = 15,
                    ImageUrl = "an url"
                },
                new Product
                {
                    Name = "Door",
                    Code = "D0001",
                    Price = 17.25,
                    ImageUrl = "an url"
                }
                );
            }
            context.SaveChanges();
        }
    }
}
