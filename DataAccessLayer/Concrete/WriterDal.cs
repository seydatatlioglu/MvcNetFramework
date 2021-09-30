using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete
{
    public class WriterDal : GenericRepository<Writer>, IWriterDal
    {
    }
   
}
