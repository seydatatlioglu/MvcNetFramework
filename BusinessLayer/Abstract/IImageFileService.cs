using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface IImageFileService
    {
        List<ImageFile> GetList();
        void ImageAdd(ImageFile imageFile);
        void ImageDelete(ImageFile imageFile);
        void ImageUpdate(ImageFile imageFile);
        ImageFile GetById(int id);
    }
}
