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
                    Price = 19.95,
                    ImageUrl = "//cdn.shopify.com/s/files/1/1402/6971/products/chair_2_1_1024x1024.jpg?v=1469433474"
                },
                new Product
                {
                    Name = "Armchair",
                    Code = "ARM0001",
                    Price = 32.99,
                    ImageUrl = "//cdn.shopify.com/s/files/1/1402/6971/products/tC9QjpvSQQ_Paddington_Deux_Lounge_Set_large.jpg?v=1469433537"
                },
                new Product
                {
                    Name = "Table",
                    Code = "TB0001",
                    Price = 8.9,
                    ImageUrl = "//cdn.shopify.com/s/files/1/1402/6971/products/table_1_1_1024x1024.jpg?v=1469433534"
                },
                new Product
                {
                    Name = "Play Station 4",
                    Code = "PSN0001",
                    Price = 35.95,
                    ImageUrl = "https://media.playstation.com/is/image/SCEA/playstation-4-slim-vertical-product-shot-01-us-07sep16?$native_t$"
                },
                new Product
                {
                    Name = "Xbox 360",
                    Code = "XBX0001",
                    Price = 30,
                    ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/41God7KwSOL.jpg"
                },
                new Product
                {
                    Name = "Teddy Bear",
                    Code = "TOYS0001",
                    Price = 12,
                    ImageUrl = "https://i5.walmartimages.com/asr/7617e51c-6004-42c1-ae63-006728db4ced_1.e3d0bbf4faa40c0a21af34e4f1d02546.jpeg?odnHeight=450&odnWidth=450&odnBg=FFFFFF"
                }
                );
            }
            context.SaveChanges();
        }
    }
}
