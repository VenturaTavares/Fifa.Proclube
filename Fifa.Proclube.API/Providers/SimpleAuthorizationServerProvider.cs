﻿using Microsoft.Owin.Security;
using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace Fifa.Proclube.API.Providers
{
    public class SimpleAuthorizationServerProvider : OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {

            context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });

            //var result = new UserRepository(new Domain.Infrastructure.SafeTravelsContext()).AuthenticateUser(context.UserName, context.Password);

            var result = 1; 


            if (result == null)
            {
                context.SetError("invalid_grant", "The user name or password is incorrect.");
                return;
            }

            var identity = new ClaimsIdentity(context.Options.AuthenticationType);
            //identity.AddClaim(new Claim("subject", context.UserName));
            //identity.AddClaim(new Claim("id", result.Id.ToString()));
            //identity.AddClaim(new Claim("role", "user"));


            //var props = new AuthenticationProperties(
            //            new Dictionary<string, string>
            //               {
            //            { "id", result.Id.ToString() },
            //            { "is_active", Convert.ToBoolean(result.Status.Value).ToString() }
            //              }
            //            );


            var props = new AuthenticationProperties(
                        new Dictionary<string, string>
                           {
                        { "id", result.ToString() },
                        { "is_active", Convert.ToBoolean(result).ToString() }
                          }
                        );

            var ticket = new AuthenticationTicket(identity, props);

            context.Validated(ticket);

        }


        public override Task TokenEndpoint(OAuthTokenEndpointContext context)
        {
            foreach (KeyValuePair<string, string> property in context.Properties.Dictionary.Where(s => s.Key != ".issued" && s.Key != ".expires"))
            {
                context.AdditionalResponseParameters.Add(property.Key, property.Value);
            }

            return Task.FromResult<object>(null);
        }
    }
}