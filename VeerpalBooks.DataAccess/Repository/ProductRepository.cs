using VeerpalBooks.DataAccess.Repository.IRepository;
using VeerpalBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeerpalKaurBookStore.DataAccess.Data;

namespace VeerpalBooks.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(Product product)
        {
            var objFromDb = _db.Products.FirstOrDefault(s => s.ID == product.ID);
            if (objFromDb!= null) // save changes if not null
            {
                if (product.ImageUrl != null)
                {


                    objFromDb.ImageUrl = product.ImageUrl;
                }

                // add the check
                objFromDb.Title = product.Title;
                objFromDb.Description = product.Description;
                objFromDb.ISBN = product.ISBN;
                objFromDb.Author = product.Author;
                objFromDb.ListPrice = product.ListPrice;
                objFromDb.Price = product.Price;
                objFromDb.Price50 = product.Price50;
                objFromDb.Price100 = product.Price100;
                objFromDb.CategoryId = product.CategoryId;
                objFromDb.CoverTypeId = product.CoverTypeId;
            }
        }




    }
}