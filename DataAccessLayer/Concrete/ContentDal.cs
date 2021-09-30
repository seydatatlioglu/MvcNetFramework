using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete
{
    public class ContentDal : GenericRepository<Content>, IContentDal
    {
    }
   
}
