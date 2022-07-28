using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

using log4net;

namespace Day3.Filters
{
    public class MyExceptionFilter : IExceptionFilter
    {
        private readonly ILog _logger = LogManager.GetLogger(typeof(MyExceptionFilter));

        public void OnException(ExceptionContext context)
        {

            String Control = context.RouteData.Values["controller"].ToString();
            String ActionM = context.RouteData.Values["action"].ToString();

            _logger.Error("Controller Name" + Control);
            _logger.Error("ActionMethod Name" + ActionM);
            _logger.Error(context.Exception.Message);


            context.ExceptionHandled = true;
            context.Result = new ViewResult() { ViewName = "CustomError" };
        }
    }
}