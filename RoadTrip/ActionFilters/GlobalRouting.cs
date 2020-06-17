using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RoadTrip.ActionFilters
{
    public class GlobalRouting : IActionFilter

    {

        private readonly ClaimsPrincipal _claimsPrincipal;

        public GlobalRouting(ClaimsPrincipal claimsPrincipal)

        {

            _claimsPrincipal = claimsPrincipal;

        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var controller = context.RouteData.Values["controller"];
            if (controller.Equals("Home"))
            {
                if (_claimsPrincipal.IsInRole("Traveler"))
                {
                    context.Result = new RedirectToActionResult("Index",
                    "Travelerss", null);
                }
                else if (_claimsPrincipal.IsInRole("Agent"))
                {
                    context.Result = new RedirectToActionResult("Index",
                    "Agents", null);
                }
                else if (_claimsPrincipal.IsInRole("Operation"))
                {
                    context.Result = new RedirectToActionResult("Index",
                    "Operations", null);
                }
            }
        }

    

        public void OnActionExecuted(ActionExecutedContext context)

        {

        }

    }

}