using CarRegisterWebAPI.Models;
using Microsoft.Owin.Security.OAuth;
using System.Security.Claims;
using System.Threading.Tasks;


namespace CarRegisterWebAPI.App_Start
{

    public class CustomAuthorizationServerProvider : OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {

            context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });

            AuthRepository authRepository = new AuthRepository();
            var isValid = authRepository.ValidateUser(context.UserName, context.Password);

            if (isValid)
            {
                var identity = new ClaimsIdentity(context.Options.AuthenticationType);

                identity.AddClaim(new Claim("Username", context.UserName));
                identity.AddClaim(new Claim("Password", context.Password));
                identity.AddClaim(new Claim(ClaimTypes.Role, "admin"));

                context.Validated(identity);
         
            }else
            {
                context.SetError("invalid_grant", "The user name or password is incorrect.");
                return;
            }

            
        }
    }

}