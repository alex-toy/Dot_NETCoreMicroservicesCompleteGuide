using Microsoft.IdentityModel.Tokens;
using System.Security.Cryptography;

namespace Mango.Services.Identity
{
    public static class IdentityHelper
    {
        static public SigningCredentials CreateSigningCredential()
        {
            var credentials = new SigningCredentials(GetSecurityKey(), SecurityAlgorithms.RsaSha256);

            return credentials;
        }
        static RSACryptoServiceProvider GetRSACryptoServiceProvider()
        {
            return new RSACryptoServiceProvider(2048);
        }
        static SecurityKey GetSecurityKey()
        {
            return new RsaSecurityKey(GetRSACryptoServiceProvider());
        }
    }
}
