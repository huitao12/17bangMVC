﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _17bangMVC.Filters
{
    public class ModelErrolTransferFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            ModelStateDictionary modelState = ((Controller)filterContext.Controller).ModelState;

            if (filterContext.IsChildAction)
            {

            }
            if (filterContext.HttpContext.Request.HttpMethod == "POST")
            {
                if (!modelState.IsValid)
                {
                    filterContext.Controller.TempData[Keys.ErrorInModel] = modelState;
                    filterContext.Result = new RedirectResult(filterContext.HttpContext.Request.Url.PathAndQuery);//重定向
                }
            }
            else if (filterContext.HttpContext.Request.HttpMethod == "GET")
            {
                ModelStateDictionary errors = filterContext.Controller.TempData[Keys.ErrorInModel] as ModelStateDictionary;
                if (errors != null)
                {
                    modelState.Merge(errors);
                }
            }
            else
            {
                throw new Exception();
            }
            base.OnActionExecuting(filterContext);
        }
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
        }
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            base.OnResultExecuting(filterContext);
        }
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            base.OnResultExecuted(filterContext);
        }
        
    }
}