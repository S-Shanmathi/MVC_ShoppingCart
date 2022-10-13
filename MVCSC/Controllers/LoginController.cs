using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MVCSC.Models;
//using Microsoft.Crm.Sdk.Messages;
//using MVC_ShoppingCart.DAL;
//using MVCSC.Models;

namespace MVCSC.Controllers
{
    public class LoginController : Controller
    {
        // private DB_Entities _db = new DB_Entities();

        public ActionResult Index()
        {
            if (Session["UserId"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(UserDetail objUser)
        {
            if (ModelState.IsValid)
            {
                using (ShoppingCart1Entities1 db = new ShoppingCart1Entities1())
                {
                    var obj = db.UserDetails.Where(a => a.UserId.Equals(objUser.UserId) && a.Password.Equals(objUser.Password)).FirstOrDefault();
                    if (obj != null)
                    {
                        Session["UserId"] = obj.UserId.ToString();
                        Session["Password"] = obj.Password.ToString();
                        return RedirectToAction("ProductDetails");
                    }
                    else
                    {
                        ViewBag.error = "Login failed";
                        ModelState.Clear();
                        // return RedirectToAction("Register");
                    }
                }
            }
            return View(objUser);
        }
        public ActionResult Product()
        {

            ShoppingCart1Entities1 db= new ShoppingCart1Entities1();
            
            // List<Product> details = db.Products.ToList();
            //var details =  db.Database.SqlQuery<string>("select Product_Category.CATEGORY_NAME, Products.PRODUCT_NAME,Products.PRODUCT_DESCRIPTION,Products.PRODUCT_PRICE,Products.PRODUCT_COUNT from Products inner join Product_Category on Products.CATEGORY_ID=Product_Category.CATEGORY_ID");
           // return View(details);

            
            var studentViewModel = from s in db.Product_Category
                                   join st in db.Products on s.CATEGORY_ID equals st.CATEGORY_ID into st2
                                   from st in st2.DefaultIfEmpty()
                                   select new productdisplay{ pc= s, pd = st };
            return View(studentViewModel);
        }


        public ActionResult ProductDetails()
        {
            ShoppingCart1Entities1 context = new ShoppingCart1Entities1();
            List<Product> details = context.Products.ToList();
            return View(details);

        }
        public ActionResult AddToCart(int productid)
        {
            ShoppingCart1Entities1 db = new ShoppingCart1Entities1();
            Product product = new Product();
            product = db.Products.Where(a => a.PRODUCT_ID == productid).FirstOrDefault();
            //productid = product.PRODUCT_ID;
            Cart cart = new Cart();
            cart.PRODUCT_ID = productid;
            cart.PRODUCT_NAME = product.PRODUCT_NAME;
            //cart.PRODUCT_COUNT = 1;
            //cart.PRODUCT_TOTALPRICE = (1 * product.PRODUCT_PRICE);
            //db.Carts.Add(cart);
             if(product.PRODUCT_COUNT > cart.PRODUCT_COUNT)
            {
                cart.PRODUCT_COUNT = 1;
                cart.PRODUCT_TOTALPRICE = (1 * product.PRODUCT_PRICE);
                db.Carts.Add(cart);
            }
             else
                    {
                
            }
            // product.PRODUCT_COUNT = product.PRODUCT_COUNT - cart.PRODUCT_COUNT;
            db.SaveChanges();
            List<Cart> carts = db.Carts.ToList();
            //return RedirectToAction("AddToCart");
            return View(carts);
        }
        public ActionResult ViewCart()
        {
            ShoppingCart1Entities1 db = new ShoppingCart1Entities1();
            List<Cart> carts = db.Carts.ToList();
            return View(carts);
        }
        public ActionResult CDelete(int cartid)
        {
            ShoppingCart1Entities1 db = new ShoppingCart1Entities1();
            var data = db.Carts.Where(x => x.CART_ID == cartid).FirstOrDefault();
            return View(data);
        }
        [HttpPost]
        public ActionResult CDelete(Cart cart1)
        {
            ShoppingCart1Entities1 db = new ShoppingCart1Entities1();
            var data = db.Carts.Where(x => x.CART_ID == cart1.CART_ID).FirstOrDefault();
            db.Carts.Remove(data);
            db.SaveChanges();
            return RedirectToAction("ViewCart");
        }
        public ActionResult Delete(int productid)
        {
            ShoppingCart1Entities1 db = new ShoppingCart1Entities1();
            var data = db.Products.Where(x => x.PRODUCT_ID == productid).FirstOrDefault();
            return View(data);
        }
        [HttpPost]
        public ActionResult Delete(Product product)
        {
            ShoppingCart1Entities1 db = new ShoppingCart1Entities1();
            var data = db.Products.Where(x => x.PRODUCT_NAME == product.PRODUCT_NAME).FirstOrDefault();
            db.Products.Remove(data);
            db.SaveChanges();
            return RedirectToAction("Product");
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(UserDetail _user)
        {
            if (ModelState.IsValid)
            {
                ShoppingCart1Entities1 db = new ShoppingCart1Entities1();
                var check = db.UserDetails.FirstOrDefault(s => s.UserId == _user.UserId);
                db.UserDetails.Add(_user);
                db.SaveChanges();
                return RedirectToAction("Login");
            }
            else
            {
                ViewBag.error = "Login failed";
                ModelState.Clear();
                return View();
            }

        }
        [HttpPost]
        public ActionResult AdminLogin(string uname, string psw)
        {
            if (uname == "Admin" && psw == "Admin")
            {
                ViewBag.Text = "Welcome";
                return RedirectToAction("Product");
            }
            return View();
        }
        //GET : Login
        public ActionResult AdminLogin()
        {
            return View();
        }
        public ActionResult Add()
        {
            ViewBag.Add = new SelectList(new ShoppingCart1Entities1().Product_Category, "CATEGORY_ID", "CATEGORY_NAME");
            return View();
        }
        [HttpPost]
        public ActionResult Add(Product product)
        {
            ShoppingCart1Entities1 db = new ShoppingCart1Entities1();
            db.Products.Add(product);
            Product_Category pro = new Product_Category();
         
            db.SaveChanges();
            return RedirectToAction("Product");
        }
        public ActionResult ProductCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ProductCategory(Product_Category product_Category)
        {
            ShoppingCart1Entities1 db = new ShoppingCart1Entities1();
            db.Product_Category.Add(product_Category);
            db.SaveChanges();
            return RedirectToAction("Product");
        }
        public ActionResult Edit(int productid)
        {
            ShoppingCart1Entities1 db = new ShoppingCart1Entities1();
            var data = db.Products.Where(x => x.PRODUCT_ID == productid).FirstOrDefault();
            return View(data);
        }
        [HttpPost]
        public ActionResult Edit(Product product)
        {
            ShoppingCart1Entities1 db = new ShoppingCart1Entities1();
            var data = db.Products.Where(x => x.PRODUCT_ID == product.PRODUCT_ID).FirstOrDefault();
            //var data = db.Products.Where(x => x.PRODUCT_ID == product.PRODUCT_ID).FirstOrDefault();
            //Product product = new Product()
            db.Products.Remove(data);
            db.Products.Add(product);
            db.SaveChanges();
            return RedirectToAction("Product");
        }
        public ActionResult CEdit(int cartid)
        {
            ShoppingCart1Entities1 db = new ShoppingCart1Entities1();
            var data = db.Carts.Where(x => x.CART_ID == cartid).FirstOrDefault();
            return View(data);
        }
        [HttpPost]
        public ActionResult CEdit(Cart cart)
        {
            ShoppingCart1Entities1 db = new ShoppingCart1Entities1();
            Cart data = db.Carts.Where(x => x.CART_ID == cart.CART_ID).FirstOrDefault();
            Product data1 = db.Products.Where(x => x.PRODUCT_ID == cart.PRODUCT_ID).FirstOrDefault();
            db.Carts.Remove(data);
            db.Carts.Add(cart);
            db.SaveChanges();
            cart.PRODUCT_TOTALPRICE = Convert.ToDecimal(cart.PRODUCT_COUNT) * data1.PRODUCT_PRICE;
            db.SaveChanges();
            return RedirectToAction("ViewCart");
        }
        public ActionResult Payment()
        {
            ShoppingCart1Entities1 db = new ShoppingCart1Entities1();
            Cart cart = new Cart();
            cart.PRODUCT_TOTALPRICE = db.Database.SqlQuery<decimal>("SELECT sum(PRODUCT_TOTALPRICE) FROM Carts").FirstOrDefault();

            ViewBag.answer = cart.PRODUCT_TOTALPRICE;
            //var cartdetails = _context.Carts.Select(w => w.ProductId).ToList();

            //_context.Database.ExecuteSqlRaw("delete Cart");
            return View("Payment");
        }
        
            public ActionResult StockMinus()
            {

                ShoppingCart1Entities1 db = new ShoppingCart1Entities1();
                
               
                var cardid = db.Database.SqlQuery<int>("select PRODUCT_ID from Carts").ToList();

                
                
                    for (int i = 0; i < cardid.Count; i++)
                    {
                         db.Database.ExecuteSqlCommand($"Update Products set PRODUCT_COUNT=((select PRODUCT_COUNT from Products where PRODUCT_ID={cardid[i]})-(select PRODUCT_COUNT from Carts where PRODUCT_ID= {cardid[i]}))where PRODUCT_ID={cardid[i]} ");
                    }

            db.Database.ExecuteSqlCommand("delete Carts");
                return View();
           
            }
        public ActionResult Logout()
        {
            Session.Clear();//remove session
            return RedirectToAction("Login");
        }

    }
}