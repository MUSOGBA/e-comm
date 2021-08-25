using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrnekSite.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category() {Name="KAMERA",Description="KAMERA ÜRÜNLERİ"},
                new Category() {Name="TELEFON",Description="TELEFON ÜRÜNLERİ"},
                new Category() {Name="BİLGİSAYAR",Description="BİLGİSAYAR ÜRÜNLERİ"}
            };

            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();

            var ürünler = new List<Product>()
            {
                new Product() {Name="CANON",Description="KAMERA ÜRÜNLERİ",Price=1250,Stock=100,IsHome=true,IsApproved=true,IsFeatured=true,Slider=true,CategoryId=1,Image="1.jpg"},
                new Product() {Name="SONY",Description="KAMERA ÜRÜNLERİ",Price=2500,Stock=150,IsHome=true,IsApproved=false,IsFeatured=true,Slider=true,CategoryId=1,Image="2.jpg"},
                new Product() {Name="ASUS",Description="BİLGİSAYAR ÜRÜNLERİ",Price=5000,Stock=150,IsHome=true,IsApproved=true,IsFeatured=false,Slider=true,CategoryId=3,Image="3.jpg"},
                new Product() {Name="İPHONE X",Description="TELEFON ÜRÜNLERİ",Price=8000,Stock=150,IsHome=false,IsApproved=true,IsFeatured=true,Slider=true,CategoryId=2,Image="4.jpg"}
            };
            foreach (var ürün in ürünler)
            {
                context.Products.Add(ürün);
            }
            context.SaveChanges();

            base.Seed(context); 
        }
    }
}