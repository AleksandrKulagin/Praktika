using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Calculator;
using Microsoft.AspNetCore.Mvc.Rendering;
using Calculator.Actions;
using WebCalc.Models;
using System.Diagnostics;
using Microsoft.Extensions.Logging;

namespace WebCalc.Controllers
{
    public class Home : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem() { Value = "Addition", Text ="Сложение" },
                new SelectListItem() { Value = "Substraction", Text ="Вычитание" },
                new SelectListItem() { Value = "Multiplication", Text ="Умножение" },
                new SelectListItem() { Value = "Division", Text ="Деление" },
                new SelectListItem() { Value = "OneDivOnX", Text ="1/х" },
                new SelectListItem() { Value = "XPowY", Text ="x^(1/y)" }
            };
            return View();
        }

        // GET: Home
        [HttpPost]
        public ActionResult Index(
            double firstArgument,
            double secondArgument,
            string operation)
        {
            double result = 0;

            switch (operation)
            {
                case "Addition":
                    Add addition = new Add();
                    result = addition.Addition(firstArgument, secondArgument);
                    break;

                case "Substraction":
                    Sub subtraction = new Sub();
                    result = subtraction.Substraction(firstArgument, secondArgument);
                    break;

                case "Multiplication":
                    Mult multiplication = new Mult();
                    result = multiplication.Multiplication(firstArgument, secondArgument);
                    break;
                case "Division":
                    Div division = new Div();
                    result = division.Division(firstArgument, secondArgument);
                    break;

                case "OneDivOnX":
                    DivOnX OneDivOnX = new DivOnX();
                    result = OneDivOnX.OneDivOnX(firstArgument);
                    break;

                case "XPowY":
                    XPow xpow = new XPow();
                    result = xpow.XPowY(firstArgument, secondArgument);
                    ViewBag.Result = result;
                    break;
            }

            ViewBag.Result = result;
            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem() { Value = "Addition", Text ="Сложение" },
                new SelectListItem() { Value = "Substraction", Text ="Вычитание" },
                new SelectListItem() { Value = "Multiplication", Text ="Умножение" },
                new SelectListItem() { Value = "Division", Text ="Деление" },
                new SelectListItem() { Value = "OneDivOnX", Text ="1/х" },
                new SelectListItem() { Value = "XPowY", Text ="x^(1/y)" }
            };
            return View();
        }
    }
}
