using coderush.Areas.QuanLyKhachHang.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace coderush.Areas.QuanLyKhachHang.Controllers
{
    public class CustomerController : Controller
    {
        DatacontexQLKH db = new DatacontexQLKH();
        // GET: QuanLyKhachHang/Customer
        public ActionResult Index()
        {
            return View(db.Customers.ToList());
        }
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer obj = db.Customers.Find(id);
            if (obj == null)
            {
                return HttpNotFound();
            }
            return View(obj);
        }

        // GET: TTNhom_QLThuVien/Book/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TTNhom_QLThuVien/Author/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CustomerID, CustomerName, CustomerPassword, CustomerEmail, CustomerPhone, CustomerAddress, AVATAR, GIOITINH")] Customer obj)
        {
            if (ModelState.IsValid)
            {


                db.Customers.Add(obj);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obj);
        }
        //public ActionResult Create(string CustomerID, string CustomerName, string CustomerPassword, string CustomerEmail, string CustomerPhone,string CustormerAddress,string GIOITINH, HttpPostedFileBase AVATAR)
        //{
        //    var img = Path.GetFileName(AVATAR.FileName);
        //    Customer product = new Customer();
        //    //product.amount = Int32.Parse(amount);
        //    //product.price = Int32.Parse(price);
        //    product.CustomerName = CustomerName;
        //    //product.description = description;
        //    //product.idcategory = Int32.Parse(idcategory);
        //    if (ModelState.IsValid)
        //    {
        //        if (AVATAR != null && AVATAR.ContentLength > 0)
        //        {
        //            var path = Path.Combine(Server.MapPath("~/Areas/QuanLyKhachHang/Content/Photo/"),
        //                                    System.IO.Path.GetFileName(AVATAR.FileName));
        //            AVATAR.SaveAs(path);

        //            product.AVATAR =AVATAR.FileName;
        //            db.Customers.Add(product);
        //            db.SaveChanges();

        //        }
        //        return RedirectToAction("Index");
        //    }
        //    else
        //    {
        //        return View(product);
        //    }
        //}

        // GET: TTNhom_QLThuVien/Book/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer obj = db.Customers.Find(id);
            if (obj == null)
            {
                return HttpNotFound();
            }
            return View(obj);
        }

        // POST: TTNhom_QLThuVien/Author/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CustomerID, CustomerName, CustomerPassword, CustomerEmail, CustomerPhone, CustomerAddress")] Customer obj)
        {
            if (ModelState.IsValid)
            {
                db.Entry(obj).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        public ActionResult Delete(string id)
        {
            try
            {
                Customer obj = db.Customers.Find(id);
                db.Customers.Remove(obj);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}