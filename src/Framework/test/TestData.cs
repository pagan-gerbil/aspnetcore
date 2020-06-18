// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Microsoft.AspNetCore
{
    public class TestData
    {
        public static HashSet<string> ListedSharedFxAssemblies = new HashSet<string>
        {
            "aspnetcorev2_inprocess",
            "Microsoft.AspNetCore",
            "Microsoft.AspNetCore.Antiforgery",
            "Microsoft.AspNetCore.Authentication",
            "Microsoft.AspNetCore.Authentication.Abstractions",
            "Microsoft.AspNetCore.Authentication.Cookies",
            "Microsoft.AspNetCore.Authentication.Core",
            "Microsoft.AspNetCore.Authentication.OAuth",
            "Microsoft.AspNetCore.Authorization",
            "Microsoft.AspNetCore.Authorization.Policy",
            "Microsoft.AspNetCore.Components",
            "Microsoft.AspNetCore.Components.Authorization",
            "Microsoft.AspNetCore.Components.Forms",
            "Microsoft.AspNetCore.Components.Server",
            "Microsoft.AspNetCore.Components.Web",
            "Microsoft.AspNetCore.Connections.Abstractions",
            "Microsoft.AspNetCore.CookiePolicy",
            "Microsoft.AspNetCore.Cors",
            "Microsoft.AspNetCore.Cryptography.Internal",
            "Microsoft.AspNetCore.Cryptography.KeyDerivation",
            "Microsoft.AspNetCore.DataProtection",
            "Microsoft.AspNetCore.DataProtection.Abstractions",
            "Microsoft.AspNetCore.DataProtection.Extensions",
            "Microsoft.AspNetCore.Diagnostics",
            "Microsoft.AspNetCore.Diagnostics.Abstractions",
            "Microsoft.AspNetCore.Diagnostics.HealthChecks",
            "Microsoft.AspNetCore.HostFiltering",
            "Microsoft.AspNetCore.Hosting",
            "Microsoft.AspNetCore.Hosting.Abstractions",
            "Microsoft.AspNetCore.Hosting.Server.Abstractions",
            "Microsoft.AspNetCore.Html.Abstractions",
            "Microsoft.AspNetCore.Http",
            "Microsoft.AspNetCore.Http.Abstractions",
            "Microsoft.AspNetCore.Http.Connections",
            "Microsoft.AspNetCore.Http.Connections.Common",
            "Microsoft.AspNetCore.Http.Extensions",
            "Microsoft.AspNetCore.Http.Features",
            "Microsoft.AspNetCore.HttpOverrides",
            "Microsoft.AspNetCore.HttpsPolicy",
            "Microsoft.AspNetCore.Identity",
            "Microsoft.AspNetCore.Localization",
            "Microsoft.AspNetCore.Localization.Routing",
            "Microsoft.AspNetCore.Metadata",
            "Microsoft.AspNetCore.Mvc",
            "Microsoft.AspNetCore.Mvc.Abstractions",
            "Microsoft.AspNetCore.Mvc.ApiExplorer",
            "Microsoft.AspNetCore.Mvc.Core",
            "Microsoft.AspNetCore.Mvc.Cors",
            "Microsoft.AspNetCore.Mvc.DataAnnotations",
            "Microsoft.AspNetCore.Mvc.Formatters.Json",
            "Microsoft.AspNetCore.Mvc.Formatters.Xml",
            "Microsoft.AspNetCore.Mvc.Localization",
            "Microsoft.AspNetCore.Mvc.Razor",
            "Microsoft.AspNetCore.Mvc.RazorPages",
            "Microsoft.AspNetCore.Mvc.TagHelpers",
            "Microsoft.AspNetCore.Mvc.ViewFeatures",
            "Microsoft.AspNetCore.Razor",
            "Microsoft.AspNetCore.Razor.Runtime",
            "Microsoft.AspNetCore.ResponseCaching",
            "Microsoft.AspNetCore.ResponseCaching.Abstractions",
            "Microsoft.AspNetCore.ResponseCompression",
            "Microsoft.AspNetCore.Rewrite",
            "Microsoft.AspNetCore.Routing",
            "Microsoft.AspNetCore.Routing.Abstractions",
            "Microsoft.AspNetCore.Server.HttpSys",
            "Microsoft.AspNetCore.Server.IIS",
            "Microsoft.AspNetCore.Server.IISIntegration",
            "Microsoft.AspNetCore.Server.Kestrel",
            "Microsoft.AspNetCore.Server.Kestrel.Core",
            "Microsoft.AspNetCore.Server.Kestrel.Transport.Sockets",
            "Microsoft.AspNetCore.Session",
            "Microsoft.AspNetCore.SignalR",
            "Microsoft.AspNetCore.SignalR.Common",
            "Microsoft.AspNetCore.SignalR.Core",
            "Microsoft.AspNetCore.SignalR.Protocols.Json",
            "Microsoft.AspNetCore.StaticFiles",
            "Microsoft.AspNetCore.WebSockets",
            "Microsoft.AspNetCore.WebUtilities",
            "Microsoft.Extensions.Caching.Abstractions",
            "Microsoft.Extensions.Caching.Memory",
            "Microsoft.Extensions.Configuration",
            "Microsoft.Extensions.Configuration.Abstractions",
            "Microsoft.Extensions.Configuration.Binder",
            "Microsoft.Extensions.Configuration.CommandLine",
            "Microsoft.Extensions.Configuration.EnvironmentVariables",
            "Microsoft.Extensions.Configuration.FileExtensions",
            "Microsoft.Extensions.Configuration.Ini",
            "Microsoft.Extensions.Configuration.Json",
            "Microsoft.Extensions.Configuration.KeyPerFile",
            "Microsoft.Extensions.Configuration.UserSecrets",
            "Microsoft.Extensions.Configuration.Xml",
            "Microsoft.Extensions.DependencyInjection",
            "Microsoft.Extensions.DependencyInjection.Abstractions",
            "Microsoft.Extensions.Diagnostics.HealthChecks",
            "Microsoft.Extensions.Diagnostics.HealthChecks.Abstractions",
            "Microsoft.Extensions.FileProviders.Abstractions",
            "Microsoft.Extensions.FileProviders.Composite",
            "Microsoft.Extensions.FileProviders.Embedded",
            "Microsoft.Extensions.FileProviders.Physical",
            "Microsoft.Extensions.FileSystemGlobbing",
            "Microsoft.Extensions.Hosting",
            "Microsoft.Extensions.Hosting.Abstractions",
            "Microsoft.Extensions.Http",
            "Microsoft.Extensions.Identity.Core",
            "Microsoft.Extensions.Identity.Stores",
            "Microsoft.Extensions.Localization",
            "Microsoft.Extensions.Localization.Abstractions",
            "Microsoft.Extensions.Logging",
            "Microsoft.Extensions.Logging.Abstractions",
            "Microsoft.Extensions.Logging.Configuration",
            "Microsoft.Extensions.Logging.Console",
            "Microsoft.Extensions.Logging.Debug",
            "Microsoft.Extensions.Logging.EventLog",
            "Microsoft.Extensions.Logging.EventSource",
            "Microsoft.Extensions.Logging.TraceSource",
            "Microsoft.Extensions.ObjectPool",
            "Microsoft.Extensions.Options",
            "Microsoft.Extensions.Options.ConfigurationExtensions",
            "Microsoft.Extensions.Options.DataAnnotations",
            "Microsoft.Extensions.Primitives",
            "Microsoft.Extensions.WebEncoders",
            "Microsoft.JSInterop",
            "Microsoft.Net.Http.Headers",
            "Microsoft.Win32.SystemEvents",
            "System.Diagnostics.EventLog",
            "System.Drawing.Common",
            "System.IO.Pipelines",
            "System.Security.Cryptography.Pkcs",
            "System.Security.Cryptography.Xml",
            "System.Security.Permissions",
            "System.Windows.Extensions"
        };

        public static HashSet<string> ListedTargetingPackAssemblies = new HashSet<string>
        {
            "Microsoft.AspNetCore",
            "Microsoft.AspNetCore.Antiforgery",
            "Microsoft.AspNetCore.Authentication",
            "Microsoft.AspNetCore.Authentication.Abstractions",
            "Microsoft.AspNetCore.Authentication.Cookies",
            "Microsoft.AspNetCore.Authentication.Core",
            "Microsoft.AspNetCore.Authentication.OAuth",
            "Microsoft.AspNetCore.Authorization",
            "Microsoft.AspNetCore.Authorization.Policy",
            "Microsoft.AspNetCore.Components",
            "Microsoft.AspNetCore.Components.Authorization",
            "Microsoft.AspNetCore.Components.Forms",
            "Microsoft.AspNetCore.Components.Server",
            "Microsoft.AspNetCore.Components.Web",
            "Microsoft.AspNetCore.Connections.Abstractions",
            "Microsoft.AspNetCore.CookiePolicy",
            "Microsoft.AspNetCore.Cors",
            "Microsoft.AspNetCore.Cryptography.Internal",
            "Microsoft.AspNetCore.Cryptography.KeyDerivation",
            "Microsoft.AspNetCore.DataProtection",
            "Microsoft.AspNetCore.DataProtection.Abstractions",
            "Microsoft.AspNetCore.DataProtection.Extensions",
            "Microsoft.AspNetCore.Diagnostics",
            "Microsoft.AspNetCore.Diagnostics.Abstractions",
            "Microsoft.AspNetCore.Diagnostics.HealthChecks",
            "Microsoft.AspNetCore.HostFiltering",
            "Microsoft.AspNetCore.Hosting",
            "Microsoft.AspNetCore.Hosting.Abstractions",
            "Microsoft.AspNetCore.Hosting.Server.Abstractions",
            "Microsoft.AspNetCore.Html.Abstractions",
            "Microsoft.AspNetCore.Http",
            "Microsoft.AspNetCore.Http.Abstractions",
            "Microsoft.AspNetCore.Http.Connections",
            "Microsoft.AspNetCore.Http.Connections.Common",
            "Microsoft.AspNetCore.Http.Extensions",
            "Microsoft.AspNetCore.Http.Features",
            "Microsoft.AspNetCore.HttpOverrides",
            "Microsoft.AspNetCore.HttpsPolicy",
            "Microsoft.AspNetCore.Identity",
            "Microsoft.AspNetCore.Localization",
            "Microsoft.AspNetCore.Localization.Routing",
            "Microsoft.AspNetCore.Metadata",
            "Microsoft.AspNetCore.Mvc",
            "Microsoft.AspNetCore.Mvc.Abstractions",
            "Microsoft.AspNetCore.Mvc.ApiExplorer",
            "Microsoft.AspNetCore.Mvc.Core",
            "Microsoft.AspNetCore.Mvc.Cors",
            "Microsoft.AspNetCore.Mvc.DataAnnotations",
            "Microsoft.AspNetCore.Mvc.Formatters.Json",
            "Microsoft.AspNetCore.Mvc.Formatters.Xml",
            "Microsoft.AspNetCore.Mvc.Localization",
            "Microsoft.AspNetCore.Mvc.Razor",
            "Microsoft.AspNetCore.Mvc.RazorPages",
            "Microsoft.AspNetCore.Mvc.TagHelpers",
            "Microsoft.AspNetCore.Mvc.ViewFeatures",
            "Microsoft.AspNetCore.Razor",
            "Microsoft.AspNetCore.Razor.Runtime",
            "Microsoft.AspNetCore.ResponseCaching",
            "Microsoft.AspNetCore.ResponseCaching.Abstractions",
            "Microsoft.AspNetCore.ResponseCompression",
            "Microsoft.AspNetCore.Rewrite",
            "Microsoft.AspNetCore.Routing",
            "Microsoft.AspNetCore.Routing.Abstractions",
            "Microsoft.AspNetCore.Server.HttpSys",
            "Microsoft.AspNetCore.Server.IIS",
            "Microsoft.AspNetCore.Server.IISIntegration",
            "Microsoft.AspNetCore.Server.Kestrel",
            "Microsoft.AspNetCore.Server.Kestrel.Core",
            "Microsoft.AspNetCore.Server.Kestrel.Transport.Sockets",
            "Microsoft.AspNetCore.Session",
            "Microsoft.AspNetCore.SignalR",
            "Microsoft.AspNetCore.SignalR.Common",
            "Microsoft.AspNetCore.SignalR.Core",
            "Microsoft.AspNetCore.SignalR.Protocols.Json",
            "Microsoft.AspNetCore.StaticFiles",
            "Microsoft.AspNetCore.WebSockets",
            "Microsoft.AspNetCore.WebUtilities",
            "Microsoft.Extensions.Caching.Abstractions",
            "Microsoft.Extensions.Caching.Memory",
            "Microsoft.Extensions.Configuration",
            "Microsoft.Extensions.Configuration.Abstractions",
            "Microsoft.Extensions.Configuration.Binder",
            "Microsoft.Extensions.Configuration.CommandLine",
            "Microsoft.Extensions.Configuration.EnvironmentVariables",
            "Microsoft.Extensions.Configuration.FileExtensions",
            "Microsoft.Extensions.Configuration.Ini",
            "Microsoft.Extensions.Configuration.Json",
            "Microsoft.Extensions.Configuration.KeyPerFile",
            "Microsoft.Extensions.Configuration.UserSecrets",
            "Microsoft.Extensions.Configuration.Xml",
            "Microsoft.Extensions.DependencyInjection",
            "Microsoft.Extensions.DependencyInjection.Abstractions",
            "Microsoft.Extensions.Diagnostics.HealthChecks",
            "Microsoft.Extensions.Diagnostics.HealthChecks.Abstractions",
            "Microsoft.Extensions.FileProviders.Abstractions",
            "Microsoft.Extensions.FileProviders.Composite",
            "Microsoft.Extensions.FileProviders.Embedded",
            "Microsoft.Extensions.FileProviders.Physical",
            "Microsoft.Extensions.FileSystemGlobbing",
            "Microsoft.Extensions.Hosting",
            "Microsoft.Extensions.Hosting.Abstractions",
            "Microsoft.Extensions.Http",
            "Microsoft.Extensions.Identity.Core",
            "Microsoft.Extensions.Identity.Stores",
            "Microsoft.Extensions.Localization",
            "Microsoft.Extensions.Localization.Abstractions",
            "Microsoft.Extensions.Logging",
            "Microsoft.Extensions.Logging.Abstractions",
            "Microsoft.Extensions.Logging.Configuration",
            "Microsoft.Extensions.Logging.Console",
            "Microsoft.Extensions.Logging.Debug",
            "Microsoft.Extensions.Logging.EventLog",
            "Microsoft.Extensions.Logging.EventSource",
            "Microsoft.Extensions.Logging.TraceSource",
            "Microsoft.Extensions.ObjectPool",
            "Microsoft.Extensions.Options",
            "Microsoft.Extensions.Options.ConfigurationExtensions",
            "Microsoft.Extensions.Options.DataAnnotations",
            "Microsoft.Extensions.Primitives",
            "Microsoft.Extensions.WebEncoders",
            "Microsoft.JSInterop",
            "Microsoft.Net.Http.Headers",
            "Microsoft.Win32.Registry",
            "System.Diagnostics.EventLog",
            "System.IO.Pipelines",
            "System.Security.AccessControl",
            "System.Security.Cryptography.Cng",
            "System.Security.Cryptography.Xml",
            "System.Security.Permissions",
            "System.Security.Principal.Windows",
            "System.Windows.Extensions"
        };

        public static string GetSharedFxVersion() => GetTestDataValue("SharedFxVersion");

        public static string GetMicrosoftNETCoreAppPackageVersion() => GetTestDataValue("MicrosoftNETCoreAppRuntimeVersion");

        public static string GetRepositoryCommit() => GetTestDataValue("RepositoryCommit");

        public static string GetSharedFxRuntimeIdentifier() => GetTestDataValue("TargetRuntimeIdentifier");

        public static string GetSharedFxDependencies() => GetTestDataValue("SharedFxDependencies");

        public static string GetTargetingPackDependencies() => GetTestDataValue("TargetingPackDependencies");

        public static bool VerifyAncmBinary() => string.Equals(GetTestDataValue("VerifyAncmBinary"), "true", StringComparison.OrdinalIgnoreCase);

        public static string GetTestDataValue(string key)
             => typeof(TestData).Assembly.GetCustomAttributes<TestDataAttribute>().Single(d => d.Key == key).Value;
    }
}
