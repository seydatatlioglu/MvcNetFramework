using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete
{
    public class CategoryDal : GenericRepository<Category>, ICategoryDal
    {
    }
   
}
