using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Copiosis_Application.Controllers;

namespace Copiosis_Application.Filters
{
    public class CustomErrorHandlingAttribute : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            if (filterContext.ExceptionHandled == true)
            {
                return;
            }
            else
            {
                ControllerBase controllerContext = filterContext.Controller;
                string subject = "";
                string message = filterContext.Exception.Message;
                if (controllerContext.GetType() == typeof(HomeController)) {
                    subject = ((HomeController)controllerContext).getError().ErrorSubject;
                }
                else if (controllerContext.GetType() == typeof(AccountController))
                {
                    controllerContext = (AccountController)controllerContext;
                    subject = ((AccountController)controllerContext).getError().ErrorSubject;
                }
                else if (controllerContext.GetType() == typeof(AdminController))
                {
                    subject = ((AdminController)controllerContext).getError().ErrorSubject;
                }
                
                TempDataDictionary controllerTempData = filterContext.Controller.TempData;

                if (subject == null || subject.Equals("")) //if no error subject was provided
                {
                    //set to default errsubject:
                    subject = "An internal error occured";
                    Exception innerEx = filterContext.Exception.InnerException;
                    if (innerEx != null || !(innerEx.Equals("")))
                    {
                        message = innerEx.Message; //Display InnerException Message
                        while (innerEx.InnerException != null)
                        {
                            innerEx = innerEx.InnerException;
                            message += "  |  " + innerEx.Message;
                        }
                    }
                }
                controllerTempData.Add("errorSubject", subject);
                controllerTempData.Add("errorMessage", message);
                filterContext.Result = new ViewResult
                {
                    ViewName = "Error",
                    TempData = controllerTempData
                };
            }
            filterContext.ExceptionHandled = true;
        }
    }
}
