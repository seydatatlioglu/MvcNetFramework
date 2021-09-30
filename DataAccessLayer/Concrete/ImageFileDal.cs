using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete
{
    public class ImageFileDal : GenericRepository<ImageFile>, IImageFileDal
    {
    }

}
