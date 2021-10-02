using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete
{
    public class AdminDal : GenericRepository<Admin>, IAdminDal
    {
    }

}
