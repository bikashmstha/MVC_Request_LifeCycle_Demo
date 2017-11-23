using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MVC_LifeCycle_Demo
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        //
        // Summary:
        //     Occurs as the first event in the HTTP pipeline chain of execution when ASP.NET
        //     responds to a request.
        protected void Application_BeginRequest()
        {

        }
        
        //
        // Summary:
        //     Occurs when a security module has established the identity of the user.
        protected void Application_AuthenticateRequest()
        {

        }
        
        //
        // Summary:
        //     Occurs when a security module has established the identity of the user.
        protected void Application_PostAuthenticateRequest()
        {

        }
        
        //
        // Summary:
        //     Occurs when a security module has verified user authorization.
        protected void Application_AuthorizeRequest()
        {

        }

        //
        // Summary:
        //     Occurs when the user for the current request has been authorized.
        protected void Application_PostAuthorizeRequest()
        {

        }
        
        //
        // Summary:
        //     Occurs when ASP.NET finishes an authorization event to let the caching modules
        //     serve requests from the cache, bypassing execution of the event handler (for
        //     example, a page or an XML Web service).
        protected void Application_ResolveRequestCache()
        {

        }

        //
        // Summary:
        //     Occurs when ASP.NET bypasses execution of the current event handler and allows
        //     a caching module to serve a request from the cache.
        protected void Application_PostResolveRequestCache()
        {

        }

        //
        // Summary:
        //     Occurs when the handler is selected to respond to the request.
        protected void Application_MapRequestHandler()
        {

        }

        //
        // Summary:
        //     Occurs when ASP.NET has mapped the current request to the appropriate event handler.
        protected void Application_PostMapRequestHandler()
        {

        }

        //
        // Summary:
        //     Occurs when ASP.NET acquires the current state (for example, session state) that
        //     is associated with the current request.
        protected void Application_AcquireRequestState()
        {

        }

        //
        // Summary:
        //     Occurs when the request state (for example, session state) that is associated
        //     with the current request has been obtained.
        protected void Application_PostAcquireRequestState()
        {

        }

        //
        // Summary:
        //     Occurs just before ASP.NET starts executing an event handler (for example, a
        //     page or an XML Web service).
        protected void Application_PreRequestHandlerExecute()
        {

        }

        //
        // Summary:
        //     Occurs when the ASP.NET event handler (for example, a page or an XML Web service)
        //     finishes execution.
        protected void Application_PostRequestHandlerExecute()
        {

        }

        //
        // Summary:
        //     Occurs after ASP.NET finishes executing all request event handlers. This event
        //     causes state modules to save the current state data.
        protected void Application_ReleaseRequestState()
        {

        }
        
        //
        // Summary:
        //     Occurs when ASP.NET has completed executing all request event handlers and the
        //     request state data has been stored.
        protected void Application_PostReleaseRequestState()
        {

        }

        //
        // Summary:
        //     Occurs when ASP.NET finishes executing an event handler in order to let caching
        //     modules store responses that will be used to serve subsequent requests from the
        //     cache.
        protected void Application_UpdateRequestCache()
        {

        }
        
        //
        // Summary:
        //     Occurs when ASP.NET finishes updating caching modules and storing responses that
        //     are used to serve subsequent requests from the cache.
        protected void Application_PostUpdateRequestCache()
        {

        }

        //
        // Summary:
        //     Occurs just before ASP.NET performs any logging for the current request.
        protected void Application_LogRequest()
        {

        }

        //
        // Summary:
        //     Occurs when ASP.NET has completed processing all the event handlers for the System.Web.HttpApplication.LogRequest
        //     event.
        protected void Application_PostLogRequest()
        {

        }

        //
        // Summary:
        //     Occurs as the last event in the HTTP pipeline chain of execution when ASP.NET
        //     responds to a request.
        protected void Application_EndRequest()
        {

        }

        //
        // Summary:
        //     Occurs just before ASP.NET sends content to the client.
        protected void Application_PreSendRequestContent()
        {

        }
        //
        // Summary:
        //     Occurs just before ASP.NET sends HTTP headers to the client.
        protected void Application_PreSendRequestHeaders()
        {

        }

        //
        // Summary:
        //     Occurs when the managed objects that are associated with the request have been
        //     released.
        protected void Application_RequestCompleted()
        {

        }
        
    }
}
