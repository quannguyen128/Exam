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
                case "Add":
                model.Result = MathLib.Add(model.LeftOperand, model.RightOperand);
                break;
                case "Subtract":
                model.Result = MathLib.subtract(model.LeftOperand, model.RightOperand);
                
                break;
                case "Divide":
                model.Result = MathLib.Divide(model.LeftOperand, model.RightOperand);
                break;
                case "Multiply":
                model.Result = MathLib.Multiply(model.LeftOperand, model.RightOperand);
                break;
                default:
                break;
                           
            }
            return View(model);
        }
      
    }
}