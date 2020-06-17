using coderush.Areas.QuanLyMatHang.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace coderush.Areas.QuanLyMatHang.Controllers
{
    public class ProductController : Controller
    {

        DataContextQLMH db = new DataContextQLMH();
        // GET: QuanLyMatHang/Product
        public ActionResult Index()
        {

            return View(db.Products.ToList());
        }
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product obj = db.Products.Find(id);
            if (obj == null)
            {
                return HttpNotFound();
            }
            return View(obj);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(string ProductID, string ProductName, string ProductTT, string ProductPrice, string ProductGG, string ProductKeyW, string ProductStatus, string CategoryID, HttpPostedFileBase photo)
        {
            var img = Path.GetFileName(photo.FileName);
            Product product = new Product();
            product.ProductGG = Int32.Parse(ProductGG);
            product.ProductPrice = Int32.Parse(ProductPrice);
            product.ProductName = ProductName;
            product.ProductID = ProductID;
            product.ProductTT = ProductTT;
            product.ProductKeyW = ProductKeyW;
            product.ProductStatus = ProductStatus;
            product.CategoryID = CategoryID;
            if (ModelState.IsValid)
            {
                if (photo != null && photo.ContentLength > 0)
                {
                    var path = Path.Combine(Server.MapPath("~/Areas/QuanLyMatHang/Content/Photo/"),
                                            System.IO.Path.GetFileName(photo.FileName));
                    photo.SaveAs(path);

                    product.photo = photo.FileName;
                    db.Products.Add(product);
                }
                return RedirectToAction("Index");
            }
            else
            {
                return View(product);
            }
        }
    }
}