﻿using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfImageFileDal:GenericRepository<ImageFile>, IImageFileDal
    {

    }

}
