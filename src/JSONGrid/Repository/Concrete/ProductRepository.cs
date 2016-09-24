using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JSONGrid.Repository.Abstract;
using JSONGrid.Models;
using Newtonsoft.Json;
using System.IO;
using JSONGrid.ViewModels.Products;

namespace JSONGrid.Repository.Concrete
{
    public class ProductRepository : IProductRepository
    {
        public void GenerateJson()
        {
            List<Product> ProductList = new List<Product>();
            ProductList.Add(new Product { Id = "1", FullDescription = "Green Tea with Fruits", Name = "Green Tea with Fruit", ImgSrc = "images/img01.jpg", Price = "10.00$" });
            ProductList.Add(new Product { Id = "2", FullDescription = "Mixed Berries Tea", Name = "Mixed Berries Tea", ImgSrc = "images/img02.jpg", Price = "10.00$" });
            ProductList.Add(new Product { Id = "3", FullDescription = "Red Dragon Tea", Name = "Red Dragon Tea", ImgSrc = "images/img03.jpg", Price = "7.00$" });
            ProductList.Add(new Product { Id = "4", FullDescription = "Earl Grey Tea", Name = "Earl Grey Tea", ImgSrc = "images/img04.jpg", Price = "3.50$" });
            ProductList.Add(new Product { Id = "5", FullDescription = "Masala Tea", Name = "Masala Tea", ImgSrc = "images/img05.jpg", Price = "2.75$" });
            ProductList.Add(new Product { Id = "6", FullDescription = "Green Tea with Jasmine", Name = "Green Tea with Jasmine", ImgSrc = "images/img06.jpg", Price = "4.50$" });
            ProductsViewModel ProductsViewModel = new ProductsViewModel() { Products = ProductList };
            string json = JsonConvert.SerializeObject(ProductsViewModel, Formatting.Indented);
            File.WriteAllText(@"Products.json", json);
        }
    }
}
