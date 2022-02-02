using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using brokfy.dashboard.api.data;
using brokfy.dashboard.api.data.DataModel;
using Microsoft.AspNetCore.Builder;

namespace brokfy.dashboard.api.Middleware
{
    public class ADAuthMiddleware
    {
        RequestDelegate next;

        public ADAuthMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext httpContext, brokfy_devContext db)
        {
            try
            {
                if (!IsAuthorized(db, httpContext.Request.Headers["Authorization"].ToString()))
                {
                    httpContext.Response.StatusCode = 403;
                    return;
                }

                await next(httpContext);
            }
            catch (Exception ex)
            {
                httpContext.Response.StatusCode = 403;
                return;
            }
            
        }

        private bool IsAuthorized (brokfy_devContext db, string Authorization)
        {
            string authString = Authorization.Split("Bearer").LastOrDefault().Trim();
            return true;
        }

    }
}
