#pragma checksum "C:\Users\Ayan.Choudhury\source\repos\SecurityTokenService\Core.UserClient\Views\_ViewStart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7b038be492ef3b7400678e534c8be47ec54f414"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views__ViewStart), @"mvc.1.0.view", @"/Views/_ViewStart.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Ayan.Choudhury\source\repos\SecurityTokenService\Core.UserClient\Views\_ViewImports.cshtml"
using static Core.UserClient.Startup;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ayan.Choudhury\source\repos\SecurityTokenService\Core.UserClient\Views\_ViewImports.cshtml"
using Core.UserClient.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ayan.Choudhury\source\repos\SecurityTokenService\Core.UserClient\Views\_ViewImports.cshtml"
using Core.UserClient;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7b038be492ef3b7400678e534c8be47ec54f414", @"/Views/_ViewStart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0871315033338f09b4d28f83248856d489b7a3c0", @"/Views/_ViewImports.cshtml")]
    public class Views__ViewStart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Ayan.Choudhury\source\repos\SecurityTokenService\Core.UserClient\Views\_ViewStart.cshtml"
  
    if (User.Identity.IsAuthenticated)
    {
        Layout = "_LayoutAccess";
    }
    else
    {
        Layout = "_Layout";
    }
    /*
    Code in ViewStart is executed before the code in an individual view
    Move the common Code such as Setting the Layout Property to ViewStart
    Viewstart reduces Code Redundancy (DRY) and improves maintainability
    And it's hierarchiclly overriding withing folder subtree as we move out.
    */

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
