using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.concrete;

namespace Business.Abstract
{
    public interface IAboutService
    {
        List<About> getList();
        void CategoryAdd(About about);
        About GetByID(int id);
        void AboutDelete(About about);
        void AboutUpdate(About about);
    }
}
