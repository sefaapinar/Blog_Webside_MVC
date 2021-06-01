using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Concrete.Repositories;
using Entity.concrete;

namespace Business.Concrete
{
    public class CategoryManager
    {
        private GenericRepository<Category> repo = new GenericRepository<Category>();

        public List<Category> GetAll()
        {
            return repo.List();
        }

        public void CategoryAddB(Category p)
        {
            if (p.CategoryName == " " || p.CategoryName.Length <= 3 || p.CategoryDescription == " " ||
                p.CategoryName.Length >= 51)
            {
                //hata mesaj buraya gelir.
            }
            else
            {
                repo.Insert(p);
            }
        }



    }
}
