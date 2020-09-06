using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using PaymentModule;
using PaymentModulle;
using  SimplifyCommerce.Payments;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            
            return View();
        }

        public JsonResult PayAttempt(PayTemplate model)
        {
            //Καλό το Class-Library Simple Pay έχω μέσα ένα modelaki με τα στοιχεία που χρειαζόμαστε. 
           SimplePay simple = new SimplePay();
           PayModel items = new PayModel(){amount = model.amount,cardToken = model.cardToken,reference = model.reference};
           string result = simple.MakePayment(items);
           return Json(new {success = result});
        }
    }
}