using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcNetFramework.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult GetCategoryList()
        {
            var categoryValue = cm.GetList();
            return View(categoryValue);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
            
        }
        [HttpPost]
        public ActionResult AddCategory(Category category)
        {
            //cm.CategoryAdd(category);
            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult result = categoryValidator.Validate(category);
            if (result.IsValid)
            {
                cm.CategoryAdd(category);
                return RedirectToAction("GetCategoryList");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }
    }
}