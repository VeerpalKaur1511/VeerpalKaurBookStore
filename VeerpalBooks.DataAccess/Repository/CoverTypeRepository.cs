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
   public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepositry
    {
        private readonly ApplicationDbContext _db;
        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
