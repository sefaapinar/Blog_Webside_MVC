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
   public  class ContentManager:IContentService
   {  
       
       IContentDal _contentDal;

       public ContentManager(IContentDal contentDal)
       {
           _contentDal = contentDal;
       }
        public List<Content> getList()
        {
            throw new NotImplementedException();
        }

        public void ContentAdd(Content content)
        {
            throw new NotImplementedException();
        }

        public Content getByID(int id)
        {
            throw new NotImplementedException();
        }

        public void ContentDelete(Content content)
        {
            throw new NotImplementedException();
        }

        public void ContentUpdate(Content content)
        {
            throw new NotImplementedException();
        }

        public List<Content> getListByID(int id)
        {
            return _contentDal.List(x => x.HeadingID == id);
        }
    }
}
