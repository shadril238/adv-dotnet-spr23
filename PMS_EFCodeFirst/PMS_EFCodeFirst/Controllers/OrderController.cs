using PMS_EFCodeFirst.EF;
using PMS_EFCodeFirst.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS_EFCodeFirst.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index(int pageno=1)
        {
            PMSContext db=new PMSContext();
            int itemperpage = 100;
            int total = db.Products.Count();
            int pages = (int)Math.Ceiling(total / (double)itemperpage);
            ViewBag.pages = pages;

            var products=db.Products.OrderBy(p=>p.Id).Skip((pageno-1)*itemperpage).Take(itemperpage).ToList();

            return View(products);
        }

        public ActionResult AddCart(int id)
        {
            PMSContext db=new PMSContext();
            var product = db.Products.Find(id);

            List<Product> cart = null;
            if (Session["Cart"] == null)
            {
                cart = new List<Product>();
            }
            else
            {
                cart = (List<Product>)Session["Cart"];
            }

            cart.Add(new Product()
            {
                Id=product.Id,
                Name=product.Name,
                Price=product.Price,
                Qty=1 //Assuming that 1 product will be added to the cart
            });
            db.SaveChanges();
            Session["Cart"] = cart;
            TempData["Msg"] = "Successfully Added!";
            TempData["Color"] = "alert-success";

            return RedirectToAction("Index");
        }

        public ActionResult Cart()
        {
            if (Session["Cart"] != null)
            {
                return View((List<Product>)Session["Cart"]);
            }
            TempData["Msg"] = "Cart is Empty!";
            TempData["Color"] = "alert-info";
            return RedirectToAction("Index");
        }

        public ActionResult PlaceOrder()
        {
            PMSContext db= new PMSContext();

            Order order=new Order();
            order.OrderDate = DateTime.Now;
            order.Status = "Ordered";
            order.Total= 0;
            db.Orders.Add(order);
            db.SaveChanges();

            var products = (List<Product>)Session["Cart"];
            foreach(Product product in products)
            {
                OrderDetail od = new OrderDetail();
                od.OId = order.Id;
                od.PId= product.Id;
                od.Qty= product.Qty;
                od.UnitPrice = product.Price;
                order.Total += product.Price * product.Qty;
                db.OrderDetails.Add(od);
            }
            db.SaveChanges();
            Session["Cart"] = null;
            TempData["Msg"] = "Order placed successfully!";
            TempData["Color"] = "alert-success";

            return RedirectToAction("Index");
        }
    }
}