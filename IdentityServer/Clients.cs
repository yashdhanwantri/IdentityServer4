using IdentityServer4.Models;
using System.Collections.Generic;

namespace IdentityServer
{
    internal class Clients
    {
        public static IEnumerable<Client> Get()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientId = "oauthClient",
                    ClientName = "Boat Rental",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets = new List<Secret> { new Secret("abcde".Sha256())},
                    AllowedScopes = new List<string>{ "api1.read"}
                }
            };
        }
        
    }
}
