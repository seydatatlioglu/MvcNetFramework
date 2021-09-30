using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete
{
    public class ContactDal : GenericRepository<Contact>, IContactDal
    {
    }
   
}
