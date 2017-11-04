using Fifa.Proclube.API;
using Fifa.Proclube.API.Providers;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Security.OAuth;
using Ninject;
using Ninject.Web.Common.OwinHost;
using Ninject.Web.WebApi.OwinHost;
using Owin;
using System;
using System.Reflection;
using System.Web.Http;

[assembly: OwinStartup(typeof(Startup))]
namespace Fifa.Proclube.API
{
    public class Startup
    {
        public class RouteHub : Hub
        {
            public void Send(string name, string message)
            {
                // Call the broadcastMessage method to update clients.
                Clients.All.broadcastMessage(name, message);
            }
        }

        public void Configuration(IAppBuilder app)
        {
            //ConfigureOAuth(app);
            HttpConfiguration config = new HttpConfiguration();
            WebApiConfig.Register(config);
            app.UseNinjectMiddleware(CreateKernel).UseNinjectWebApi(config);
            app.UseWebApi(config);

            var hubConfiguration = new HubConfiguration();
            hubConfiguration.EnableDetailedErrors = true;
            // hubConfiguration.EnableJavaScriptProxies = false;
            app.UseCors(CorsOptions.AllowAll);
            app.MapSignalR("/signalr", hubConfiguration);
        }

        public void ConfigureOAuth(IAppBuilder app)
        {
            OAuthAuthorizationServerOptions OAuthServerOptions = new OAuthAuthorizationServerOptions()
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/api/Account/Authenticate"),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(365),
                Provider = new SimpleAuthorizationServerProvider()
            };

            // Token Generation
            app.UseOAuthAuthorizationServer(OAuthServerOptions);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());

        }

        private static StandardKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            return kernel;
        }
    }
}