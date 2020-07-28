using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace backend.Controllers
{
    
    [ApiController]
    public class TestController : ControllerBase
    {
        protected AppDBContext context;
        protected UserManager<User> mUserManager;
        protected SignInManager<User> mSignInManager;
        protected RoleManager<IdentityRole> mRoleManager;


        public TestController(AppDBContext mcontext, UserManager<User> userMAnager, SignInManager<User> signInManager, RoleManager<IdentityRole> roleManager)
        {
            context = mcontext;
            mUserManager = userMAnager;
            mSignInManager = signInManager;
            mRoleManager = roleManager;

            //lets create the roles here because why not


        }



        [HttpPost]
        [Route("api/[controller]/inActiveSmapy")]
        public void Change([FromBody] backend.Models.Userr us) { 
            User u = context.Users.First(f => f.UserName == us.username);
            u.Status = us.status;

            context.SaveChanges();
              
        }

        [Route("api/[controller]/Testing")]
        public List<Models.Message> Get() {
            

            List<Models.Message> MessageList = new List<Models.Message>();
            MessageList.Add(new Models.Message
                {
                Owner="shahd",Text = "Testing"
                }
            );
            return MessageList;
        
        }

        
        [HttpPost]
        [Route("api/[controller]/Test2")]
        public string IDK([FromBody]Models.Message m)
        {
            if (m != null)

                return ("yes");
            else
                return ("nope");
          //  return new HttpResponseMessage(HttpStatusCode.OK) { Content = new StringContent("Your message here") };

        }


        [HttpPost]
        [Route("api/[controller]/signup")]
        public async Task<IActionResult> SignUp([FromBody] Models.Userr moo)
        {

            string first_name = moo.first_name;
            string last_name = moo.last_name;
            string username = moo.username;
            string confirm_password = moo.confirm_password;
            string email = moo.email;
            string button = moo.button; //= "cust" if adding cust, ="adm" if adding admin

            #region creatingUser
            //lets make a new admin 
            User shahd = new User
            {



                UserName = username,
                Email = email,
                First_name = first_name,
                Last_name = last_name,
                Status = "Active"
                //EmailConfirmed =true



            };


            var re = await mUserManager.CreateAsync(shahd, confirm_password);
            #endregion


            if (re.Succeeded)
            {
                //adding admin role.

                if (button == "cust")
                {
                    User curuser = await mUserManager.FindByNameAsync(shahd.UserName);
                    await mUserManager.AddToRoleAsync(curuser, "customer");
                }
                else
               if (button == "adm")
                {
                    User curuser = await mUserManager.FindByNameAsync(shahd.UserName);
                    await mUserManager.AddToRoleAsync(curuser, "admin");
                }


                return Content("yes", "text/html");

            }
            else
            {
                var eer = re.Errors;
                List<string> ers = new List<string>();
                foreach (var it in eer)
                {
                    ers.Add(it.Description);

                }
                var m = string.Join(", ", ers);
                return Content(m, "text/html");
            }
            //return Content("if we wanted to return an html, view. we need to have a SignUp.cshtml in a folder named home because this is the home page.", "text/html");




        }

        [HttpPost]
        [Route("api/[controller]/login")]
        public async Task<IActionResult> LogIn ([FromBody] Models.UserLogin moo)
        {
            string username = moo.username;
            string password = moo.password;
            var hi = await mSignInManager.PasswordSignInAsync(username, password, true, false);

            if (hi.Succeeded)
            {
                
                var user = await mUserManager.FindByNameAsync(username);


                IList<string> roles = await mUserManager.GetRolesAsync(user);

                var m = string.Join(", ", roles);


                if (m == "admin")
                    return Content("Admin", "text/html");
                else
                    if (m == "customer")
                    return Content("Customer", "text/html");


            }



            return Content("fail", "text/html");

        }



        //3 need map cust home
        [Route("api/[controller]/CustHome")]
        //[Authorize(Roles = "customer, admin")]
        public async Task<IActionResult> CustHome()
        {

            //get cur user
            var u = await mUserManager.GetUserAsync(HttpContext.User);

            //get all order the user has made
            IEnumerable<Order> orders = context.Order.Where(o => o.CustomerUsername == u.Id);

            if (orders.Count() != 0)
            {
                //for simplicity get the first order
                int first_order_num = orders.First().OrderNumber;
                IEnumerable<ProductOrder> pos = context.ProductOrder.Where(p => p.OrderNumber == first_order_num);

                List<Product> products = new List<Product>();
                List<string> product_names = new List<string>();
                foreach (var po in pos)
                {
                    //for every product order in the product orders, we want to get the corresponding product.
                    //it's okay to use first beceause the product ID is unique, so there will only ever be one product.
                    products.Add(context.Product.Where(p => p.ProductID == po.ProductID).First());
                    product_names.Add(context.Product.Where(p => p.ProductID == po.ProductID).First().ProductName);

                }
                //string s=products.First().ProductName;
                var products_string = string.Join(", ", products);
                Models.productModel pm = new Models.productModel
                {
                    cust = u,
                    products = products,
                    productorders = pos

                };
                //Here is the order number;
                // return Content(products_string, "text/html");

                return Ok(pm);
            }
            else
                return Content("you don't have any orders", "text/html");
        }

        [Route("api/[controller]/index")]
        public async Task<IActionResult> Index()
        {



            context.Database.EnsureCreated();

            string[] roles = { "admin", "customer" };
            foreach (var role in roles)
            {
                //creating the roles and seeding them to the database
                var roleExist = await mRoleManager.RoleExistsAsync(role);
                if (!roleExist)
                {
                    await mRoleManager.CreateAsync(new IdentityRole(role));
                }
            }
            //Ok let's add some users, admins, products, orders.
            if (context.Product.Count<Product>() == 0)
            {
                Product p = new Product { ProductID = "1", Price = 3, ProductOrders = new Collection<ProductOrder>(), ProductName = "Brush" };
                Console.Write("yep");
                context.Product.Add(p);

                context.SaveChanges();

            }



            return Content("Yes");
        }

        [Route("api/[controller]/AdminHome")]
        //[Authorize ]
        public List<Models.productModel> AdminHome()
        {
            Console.Write("hi");
            //get cur user
            IEnumerable<User> UserList = context.Users;

            Console.Write("users", UserList);
            List<Models.productModel> pmList = new List<Models.productModel>();

            foreach (User u in UserList)
            {
                IEnumerable<Order> ordersList = context.Order.Where(o => o.CustomerUsername == u.Id);

                //if user u has no orders, we are basically done.
                if (ordersList.Count() == 0)
                {
                    List<Product> pro = new List<Product>();
                    pro.Add(new Product
                    {
                        ProductName = "no products coz no order",
                        ProductID = "null",
                        Price = 1000
                    });

                    List<ProductOrder> pos = new List<ProductOrder>();
                    pos.Add(new ProductOrder
                    {
                        ProductID = "no orders",
                        Product = new Product(),
                        Order = new Order(),
                        OrderNumber = -1
                    });
                    Models.productModel p = new Models.productModel
                    {

                        cust = u,
                        products = pro,
                        productorders = pos

                    };
                    pmList.Add(p);

                }
                else //user has made an order
                {
                    IEnumerable<Order> orders = context.Order.Where(o => o.CustomerUsername == u.Id);

                    //for simplicity get the first order
                    int first_order_num = orders.First().OrderNumber;
                    IEnumerable<ProductOrder> pos = context.ProductOrder.Where(p => p.OrderNumber == first_order_num);

                    List<Product> products = new List<Product>();
                    List<string> product_names = new List<string>();
                    foreach (var po in pos)
                    {
                        //for every product order in the product orders, we want to get the corresponding product.
                        //it's okay to use first beceause the product ID is unique, so there will only ever be one product.
                        products.Add(context.Product.Where(p => p.ProductID == po.ProductID).First());
                        product_names.Add(context.Product.Where(p => p.ProductID == po.ProductID).First().ProductName);

                    }
                    //string s=products.First().ProductName;
                    var products_string = string.Join(", ", products);
                    Models.productModel pm = new Models.productModel
                    {
                        cust = u,
                        products = products,
                        productorders = pos

                    };
                    pmList.Add(pm);

                }
            }

            return pmList;

        }

         
    }
}
