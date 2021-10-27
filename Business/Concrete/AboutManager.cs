using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entity.concrete;

namespace Business.Concrete
{
    public class AboutManager : IAboutService
    {
         IAboutDal _aboutDal;

         public AboutManager(IAboutDal aboutDal)
         {
             _aboutDal = aboutDal;
         }

        public void AboutDelete(About about)
        {
            throw new NotImplementedException();
        }

        public void AboutUpdate(About about)
        {
            throw new NotImplementedException();
        }

        public void CategoryAdd(About about)
        {
            throw new NotImplementedException();
        }

        public About GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> getList()
        {
            throw new NotImplementedException();
        }
    }
}
