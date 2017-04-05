using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EATestClient.Common
{
    public class BearerToken
    {
        public BearerToken() { }

        public static BearerToken Parse(string tokenHeader)
        {
            if (!tokenHeader.StartsWith("bearer", StringComparison.InvariantCultureIgnoreCase) || tokenHeader.Length < 8) //meaning the string after "bearer " is empty
            {
                throw new InvalidOperationException("not a valid bearer token");
            }

            return new BearerToken() { Token = tokenHeader.Substring(7), BearerTokenHeader = tokenHeader };//"bearer "

        }

        public static BearerToken FromJwt(string jwt)
        {
            string bearerToken = $"bearer {jwt}";
            return Parse(bearerToken);
        }

        public string Token
        {
            get;
            private set;
        }

        public string BearerTokenHeader
        {
            get;
            private set;
        }

    }
}
