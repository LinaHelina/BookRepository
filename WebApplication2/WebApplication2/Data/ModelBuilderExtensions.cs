using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public static class ModelBuilderExtensions
    {

        public static void SeedProducts(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>().HasData(
                new Products
                {
                    ProductId = 1,
                    ProductName = "Dell XPS 15",
                    ProductPrice = 1399,
                    ProductImageUrl = "https://i.dell.com/sites/csimages/Video_Imagery/all/xps_7590_touch.png",
                    ProductAuthor = "The world’s smallest 15.6-inch performance laptop with a stunning OLED display option. Now featuring 9th Gen Intel® Core™ processors.",
                },
                new Products
                {
                    ProductId = 2,
                    ProductName = "Macbook Pro 2020",
                    ProductPrice = 1999,
                    ProductImageUrl = "http://pngimg.com/uploads/macbook/macbook_PNG76.png",
                    ProductAuthor = "The world’s smallest 15.6-inch performance laptop with a stunning OLED display option. Now featuring 9th Gen Intel® Core™ processors.",

                },
                new Products
                {
                    ProductId = 3,
                    ProductName = "HP Spectre X360 15",
                    ProductPrice = 1849,
                    ProductImageUrl = "https://i.ibb.co/8Kx8JkM/spectre.png",
                    ProductAuthor = "The world’s smallest 15.6-inch performance laptop with a stunning OLED display option. Now featuring 9th Gen Intel® Core™ processors.",

                },
                new Products
                {
                    ProductId = 4,
                    ProductName = "ASUS GL702 Gamming",
                    ProductPrice = 1499,
                    ProductImageUrl = "https://i.ibb.co/pvv6H0G/asus.png",
                    ProductAuthor = "The world’s smallest 15.6-inch performance laptop with a stunning OLED display option. Now featuring 9th Gen Intel® Core™ processors.",

                },
                new Products
                {
                    ProductId = 5,
                    ProductName = "HP Gaming Pavilion",
                    ProductPrice = 999,
                    ProductImageUrl = "https://i.ibb.co/cD5QTZ5/hpgame.png",
                    ProductAuthor = "The world’s smallest 15.6-inch performance laptop with a stunning OLED display option. Now featuring 9th Gen Intel® Core™ processors.",

                },
                new Products
                {
                    ProductId = 6,
                    ProductName = "Acer Swift 7",
                    ProductPrice = 1799,
                    ProductImageUrl = "https://static.acer.com/up/Resource/Acer/Laptops/Swift_7/Photogallery/20190322/Acer-Swift-7-SF714-52T-Black-photogallery-02.png",
                    ProductAuthor = "The world’s smallest 15.6-inch performance laptop with a stunning OLED display option. Now featuring 9th Gen Intel® Core™ processors.",

                },
                new Products
                {
                    ProductId = 7,
                    ProductName = "Dell Alienware 17",
                    ProductPrice = 2999,
                    ProductImageUrl = "https://i.ibb.co/zxf2JHh/alien.png",
                    ProductAuthor = "The world’s smallest 15.6-inch performance laptop with a stunning OLED display option. Now featuring 9th Gen Intel® Core™ processors.",

                },
                new Products
                {
                    ProductId = 8,
                    ProductName = "Macbook Air 13",
                    ProductPrice = 1299,
                    ProductImageUrl = "https://i.ibb.co/4gypLd8/macair.png",
                    ProductAuthor = "The world’s smallest 15.6-inch performance laptop with a stunning OLED display option. Now featuring 9th Gen Intel® Core™ processors.",

                },
                new Products
                {
                    ProductId = 9,
                    ProductName = "LENOVO Thinkpad X1",
                    ProductPrice = 1719,
                    ProductImageUrl = "https://i.ibb.co/Cm5F0fD/lenovo.png",
                    ProductAuthor = "The world’s smallest 15.6-inch performance laptop with a stunning OLED display option. Now featuring 9th Gen Intel® Core™ processors.",

                }
            );
        }

        
    }
}