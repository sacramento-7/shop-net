
using API.Entities;
using Microsoft.AspNetCore.Identity;

namespace API.Data
{
    public static class DbInitializer
    {
        public static async Task Initialize(StoreContext context, UserManager<User> userManager){

            if(!userManager.Users.Any())
            {
                var user = new User
                {
                    UserName = "bob",
                    Email = "bob@test.com"
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
                await userManager.AddToRoleAsync(user, "Member");

                var admin = new User
                {
                    UserName = "Admin",
                    Email = "admin@test.com"
                };

                await userManager.CreateAsync(admin, "Pa$$w0rd");
                await userManager.AddToRolesAsync(admin, new[] {"Member", "Admin"});
            }

            if(context.Products.Any()) return;

            var products = new List<Product>
            {
                new Product
                {
                    Name= "nike shoes1",
                    Description= "test text lorem ipsum for that product is a function that help us for testing our website and production",
                    Price= 20000,
                    PictureUrl= "/images/products/nike1.jpg",
                    Brand= "Nike",
                    Type= "Shoes",
                    QuantityInStock= 100
                },
                new Product
                {
                    Name= "nike shoes2",
                    Description= "test text lorem ipsum for that product is a function that help us for testing our website and production",
                    Price= 30000,
                    PictureUrl= "/images/products/nike2.jpg",
                    Brand= "Nike",
                    Type= "Shoes",
                    QuantityInStock= 100
                },
                new Product
                {
                    Name= "nike shoes3",
                    Description= "test text lorem ipsum for that product is a function that help us for testing our website and production lorem ipasum",
                    Price= 20000,
                    PictureUrl= "/images/products/nike3.jpg",
                    Brand= "Nike",
                    Type= "Shoes",
                    QuantityInStock= 100
                },
                new Product
                {
                    Name= "nike shoes4",
                    Description= "test text lorem ipsum for that product is a function that help us for testing our website lorem ipsum and production lorem ipasum",
                    Price= 25000,
                    PictureUrl= "/images/products/nike4.jpg",
                    Brand= "Nike",
                    Type= "Shoes",
                    QuantityInStock= 100
                },
                new Product
                {
                    Name= "nike shoes5",
                    Description= "test text lorem ipsum for that product is a function that help us for testing our website and app lorem and production lorem ipasum",
                    Price= 23000,
                    PictureUrl= "/images/products/nike5.jpg",
                    Brand= "Nike",
                    Type= "Shoes",
                    QuantityInStock= 100
                },
                new Product
                {
                    Name= "nike shoes6",
                    Description= "test text lorem ipsum for that product is a function that help us for testing our website shirt and ashoes and production lorem ipasum",
                    Price= 20000,
                    PictureUrl= "/images/products/nike6.jpg",
                    Brand= "Nike",
                    Type= "Shoes",
                    QuantityInStock= 100
                },
                new Product
                {
                    Name= "nike shoes7",
                    Description= "test text lorem ipsum for that product is a function that help us for testing our website and app for lorem ipsum production lorem ipasum",
                    Price= 20000,
                    PictureUrl= "/images/products/nike7.jpg",
                    Brand= "Nike",
                    Type= "Shoes",
                    QuantityInStock= 100
                },
                new Product
                {
                    Name= "puma shoes1",
                    Description= "test text lorem ipsum for that product is a function that help us for testing our website puma lorem and production lorem ipasum",
                    Price= 20000,
                    PictureUrl= "/images/products/puma1.jpg",
                    Brand= "Puma",
                    Type= "Shoes",
                    QuantityInStock= 100
                },
                new Product
                {
                    Name= "puma shoes2",
                    Description= "test text lorem ipsum for that product is a function that help us for testing our website puma and other brand lorem and production lorem ipasum",
                    Price= 29000,
                    PictureUrl= "/images/products/puma2.jpg",
                    Brand= "Puma",
                    Type= "Shoes",
                    QuantityInStock= 100
                },
                new Product
                {
                    Name= "puma shoes3",
                    Description= "test text lorem ipsum for that product is a function that help us for testing our website puma lorem and production lorem ipasum",
                    Price= 24000,
                    PictureUrl= "/images/products/puma3.jpg",
                    Brand= "Puma",
                    Type= "Shoes",
                    QuantityInStock= 100
                },
                new Product
                {
                    Name= "puma shoes4",
                    Description= "test text lorem ipsum for that product is a function that help us for testing our website puma lorem and production lorem ipasum",
                    Price= 350000,
                    PictureUrl= "/images/products/puma4.jpg",
                    Brand= "Puma",
                    Type= "Shoes",
                    QuantityInStock= 100
                },
                new Product
                {
                    Name= "puma shirt1",
                    Description= "test text lorem ipsum for that product is a function that help us for testing our website puma shirt lorem and production lorem ipasum",
                    Price= 5000,
                    PictureUrl= "/images/products/puma-shirt1.jpg",
                    Brand= "Puma",
                    Type= "Shirt",
                    QuantityInStock= 100
                },
                new Product
                {
                    Name= "puma shirt2",
                    Description= "test text lorem ipsum for that product is a function that help us for testing our website puma shirt lorem and production lorem ipasum",
                    Price= 55000,
                    PictureUrl= "/images/products/puma-shirt2.jpg",
                    Brand= "Puma",
                    Type= "Shirt",
                    QuantityInStock= 100
                },
                new Product
                {
                    Name= "puma shirt3",
                    Description= "test text lorem ipsum for that product is a function that help us for testing our website puma shirt lorem and production lorem ipasum",
                    Price= 55500,
                    PictureUrl= "/images/products/puma-shirt3.jpg",
                    Brand= "Puma",
                    Type= "Shirt",
                    QuantityInStock= 100
                },
                new Product
                {
                    Name= "puma hoodi1",
                    Description= "test text lorem ipsum for that product is a function that help us for testing our website puma shirt lorem and production lorem ipasum",
                    Price= 52000,
                    PictureUrl= "/images/products/puma-hoodi1.jpg",
                    Brand= "Puma",
                    Type= "Hoody",
                    QuantityInStock= 100
                },
                new Product
                {
                    Name= "puma hoodi2",
                    Description= "test text lorem ipsum for that product is a function that help us for testing our website puma shirt lorem and production lorem ipasum",
                    Price= 52800,
                    PictureUrl= "/images/products/puma-hoodi2.jpg",
                    Brand= "Puma",
                    Type= "Hoody",
                    QuantityInStock= 100
                },
                new Product
                {
                    Name= "puma hoodi3",
                    Description= "test text lorem ipsum for that product is a function that help us for testing our website puma hoodi and lorem shirt lorem and production lorem ipasum",
                    Price= 52800,
                    PictureUrl= "/images/products/puma-hoodi3.jpg",
                    Brand= "Puma",
                    Type= "Hoody",
                    QuantityInStock= 100
                },
                new Product
                {
                    Name= "puma pants1",
                    Description= "test text lorem ipsum for that product is a function that help us for testing our website puma pant and shirt lorem and production lorem ipasum",
                    Price= 52000,
                    PictureUrl= "/images/products/puma-pants1.jpg",
                    Brand= "Puma",
                    Type= "Pants",
                    QuantityInStock= 100
                },
                new Product
                {
                    Name= "puma pants2",
                    Description= "test text lorem ipsum for that product is a function that help us for testing our website puma pant and shirt lorem and production lorem ipasum",
                    Price= 52000,
                    PictureUrl= "/images/products/puma-pants2.jpg",
                    Brand= "Puma",
                    Type= "Pants",
                    QuantityInStock= 100
                },

                
            };

            //context.Products.AddRange(products);

            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();
        }
    }
}