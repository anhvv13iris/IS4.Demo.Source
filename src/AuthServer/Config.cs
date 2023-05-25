// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4.Models;
using System.Collections.Generic;

namespace AuthServer
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> IdentityResources =>
                   new IdentityResource[]
                   {
                        //new IdentityResources.OpenId(),
                        //new IdentityResources.Profile()
                   };

        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            {
                //new ApiScope("report.cms"),
                //new ApiScope("report.webKH"),
                //new ApiScope("workerservice"),
            };

        public static IEnumerable<ApiResource> GetApis => 
         new ApiResource[]
            {
                //new ApiResource("report.cms")
                //{
                //    ApiSecrets =
                //    {
                //        new Secret("reportCMSSecret".Sha256())
                //    },
                //    Scopes = new List<string> { "report.cms" }
                //},
                //new ApiResource("report.webKH", "Report Web KH Service"),
                //new ApiResource("workerservice", "Worker Service")
            };

        public static IEnumerable<Client> Clients =>
            new Client[]
            {
                // m2m client credentials flow client
                //new Client
                //{
                //    ClientId = "m2m.client",
                //    ClientName = "Client Credentials Client",

                //    AllowedGrantTypes = GrantTypes.ClientCredentials,
                //    ClientSecrets = { new Secret("511536EF-F270-4058-80CA-1C89C192F69A".Sha256()) },

                //    AllowedScopes = { "scope1" }
                //},

                //// interactive client using code flow + pkce
                //new Client
                //{
                //    ClientId = "interactive",
                //    ClientSecrets = { new Secret("49C1A7E1-0C79-4A89-A3D6-A37998FB86B0".Sha256()) },

                //    AllowedGrantTypes = GrantTypes.Code,

                //    RedirectUris = { "https://localhost:44300/signin-oidc" },
                //    FrontChannelLogoutUri = "https://localhost:44300/signout-oidc",
                //    PostLogoutRedirectUris = { "https://localhost:44300/signout-callback-oidc" },

                //    AllowOfflineAccess = true,
                //    AllowedScopes = { "openid", "profile", "scope2" }
                //},
                //new Client
                //{
                //    ClientName = "ReactJS Client",
                //    ClientId = "report_cms_client_id",
                //    ClientSecrets = { new Secret("49C1A7E1-0C79-4A89-A3D6-A37998FB86B0".Sha256()) },

                //    AllowedGrantTypes = GrantTypes.Code,

                //    RedirectUris = { "http://localhost:3004/signin-callback" },
                //    RequirePkce = true,
                //    PostLogoutRedirectUris = { "http://localhost:3004/signout-callback" },
                //    AllowedCorsOrigins = {"http://localhost:3004"},
                //    AllowOfflineAccess = true,
                //    AllowAccessTokensViaBrowser = true,
                //    AllowedScopes = { "openid", "profile", "report.cms" },
                //    RequireClientSecret = false,
                //    RequireConsent = false,
                //    AccessTokenLifetime = 600,
                //    AccessTokenType = AccessTokenType.Reference
                //},
                //new Client
                //{
                //    ClientName = "ReactJS Client",
                //    ClientId = "report_webKH_client_id",
                //    ClientSecrets = { new Secret("49C1A7E1-0C79-4A89-A3D6-A37998FB86B0".Sha256()) },

                //    AllowedGrantTypes = GrantTypes.Code,

                //    RedirectUris = { "http://localhost:3005/signin-callback" },
                //    RequirePkce = true,
                //    PostLogoutRedirectUris = { "http://localhost:3005/signout-callback" },
                //    AllowedCorsOrigins = {"http://localhost:3005"},
                //    AllowOfflineAccess = true,
                //    AllowAccessTokensViaBrowser = true,
                //    AllowedScopes = { "openid", "profile", "report.webKH" },
                //    RequireClientSecret = false,
                //    RequireConsent = false,
                //    AccessTokenLifetime = 600
                //},
                //new Client
                //{
                //    ClientName = "Worker Service Demo",
                //    ClientId = "worker_service_demo_client_id",
                //    ClientSecrets = { new Secret("49C1A7E1-0C79-4A89-A3D6-A37998FB86B0".Sha256()) },

                //    AllowedGrantTypes = GrantTypes.ClientCredentials,
                //    AllowedScopes = { "workerservice" },
                //},
            };
    }
}