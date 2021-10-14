using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.concrete;

namespace Business.Abstract
{
   public interface IContentService
   {
       List<Content> getList();
       List<Content> getListByID(int id);
       void ContentAdd(Content content);
       Content getByID(int id);
       void ContentDelete(Content content);
       void ContentUpdate(Content content);

    }
}
