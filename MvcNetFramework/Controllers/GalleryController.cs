using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcNetFramework.Controllers
{
    public class GalleryController : Controller
    {
        ImageFileManager imageFileManager = new ImageFileManager(new EfImageFileDal()); 
        // GET: Gallery
        public ActionResult Index()
        {
            var imageValue = imageFileManager.GetList();
            return View(imageValue);
        }
    }
}