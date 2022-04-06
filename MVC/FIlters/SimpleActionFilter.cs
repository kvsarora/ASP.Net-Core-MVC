using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.FIlters
{
    public class SimpleActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Debug.WriteLine("The Process is starting");
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Debug.WriteLine("The Process Has Started");
        }
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            Debug.WriteLine("The Process Is Generating The Results");
        }
        public override void OnResultExecuted(ResultExecutedContext context)
        {
            Debug.WriteLine("The Results have been generated");
        }
    }
}
