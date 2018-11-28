using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Exam2.Models;
using MathLibrary;

namespace Exam2.Controllers
{
    public class MathController : Controller
    {
        public IActionResult DoCalculation()
        {
            return View();
        }   
        [HttpPost]
        public IActionResult DoneCalculation(MathOperation model)
        {
            switch (model.Operator)
            {
                case "Plus":
                model.Result = MathLib.Add(Convert.ToDecimal(model.LeftOperand), Convert.ToDecimal(model.RightOperand));
                break;
                case "Minus":
                model.Result = MathLib.subtract(Convert.ToDecimal(model.LeftOperand), Convert.ToDecimal(model.RightOperand));
                break;
                case "Divided by":
                model.Result = MathLib.Divide(Convert.ToDecimal(model.LeftOperand), Convert.ToDecimal(model.RightOperand));
                break;
                case "Times":
                model.Result = MathLib.Multiply(Convert.ToDecimal(model.LeftOperand), Convert.ToDecimal(model.RightOperand));
                break;
                default:
                break;
                           
            }
            return View(model);
        }
      
    }
}