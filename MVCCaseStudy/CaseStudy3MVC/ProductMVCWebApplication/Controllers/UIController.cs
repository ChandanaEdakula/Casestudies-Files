using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProductDataAccessLayerLib;
namespace ProductMVCWebApplication.Controllers
{
    public class UIController : Controller
    {
        // GET: UI
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ViewCategory()
        {
            EFDALLib dal = new EFDALLib();
            List<tbl_product> lsp = dal.GetAllProducts();
            return View(lsp);
        }
        [HttpGet]
        public ActionResult AddProduct()
        {
            EFDALLib dal = new EFDALLib();
            var catid = dal.GetAllCategoryById().ToList();
            ViewData.Add("cid", catid);
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(tbl_product pd)
        {
            EFDALLib dal = new EFDALLib();
            dal.AddProducts(pd);
            var catid = dal.GetAllCategoryById().ToList();
            ViewData.Add("cid", catid);
            ViewData.Add("Message", "Product Added Successfully");

            return View();
        }
        public ActionResult ViewCategoryName(int ID,string cid)
        {
            EFDALLib dal = new EFDALLib();
            var record = dal.ViewProduct(ID);
            var catname = dal.ViewCategoryNane(cid);
            ViewData.Add("cname", catname);
            return View(record);
        }
       
        

    }
}