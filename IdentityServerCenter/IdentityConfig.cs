using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServerCenter
{
    public class IdentityConfig
    {
        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>() {
                new ApiResource("api1","Myapi")
            };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>() {
                   new Client{
                       ClientId="client",
                       //使用 clientid/secret 实现认证
                       AllowedGrantTypes=GrantTypes.ClientCredentials,
                       // 用于认证的密码
                       ClientSecrets={ new Secret("secret".Sha256())},
                        // 客户端有权访问的范围（Scopes）
                       AllowedScopes={ "api1"}
                   }
               };
        }
    }
}
