﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ImageFileManager : IImageFileService
    {
        IImageFileDal _imageFileDal;

        public ImageFileManager(IImageFileDal imageFileDal)
        {
            _imageFileDal = imageFileDal;
        }

        public ImageFile GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ImageFile> GetList()
        {
            return _imageFileDal.List();
        }

        public void ImageAdd(ImageFile imageFile)
        {
            throw new NotImplementedException();
        }

        public void ImageDelete(ImageFile imageFile)
        {
            throw new NotImplementedException();
        }

        public void ImageUpdate(ImageFile imageFile)
        {
            throw new NotImplementedException();
        }
    }
}
