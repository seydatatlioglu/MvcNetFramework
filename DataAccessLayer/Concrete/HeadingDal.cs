using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete
{
    public class HeadingDal : GenericRepository<Heading>, IHeadingDal
    {
    }
   
}
