#pragma checksum "C:\Users\Ayan.Choudhury\source\repos\SecurityTokenService\Core.UserClient\Views\Shared\DisplayDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4767de013b779a9555f1350f76dbf9eab1603272"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_DisplayDetails), @"mvc.1.0.view", @"/Views/Shared/DisplayDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4767de013b779a9555f1350f76dbf9eab1603272", @"/Views/Shared/DisplayDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0871315033338f09b4d28f83248856d489b7a3c0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_DisplayDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"panel-body help-block\">\r\n    You will be redirected to our Home page in <span id=\"timer\" class=\"text-primary focus\">30</span>s.\r\n    ");
#nullable restore
#line 3 "C:\Users\Ayan.Choudhury\source\repos\SecurityTokenService\Core.UserClient\Views\Shared\DisplayDetails.cshtml"
Write(Html.Hidden("RedirectTo", Url.Action("Index", "Home")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<hr/>\r\n");
#nullable restore
#line 6 "C:\Users\Ayan.Choudhury\source\repos\SecurityTokenService\Core.UserClient\Views\Shared\DisplayDetails.cshtml"
   
    var className = ViewData["Message"].ToString().Contains("Error") ? "alert-danger" : "alert-success";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div");
            BeginWriteAttribute("class", " class=\"", 335, "\"", 363, 2);
            WriteAttributeValue("", 343, "jumbotron", 343, 9, true);
#nullable restore
#line 9 "C:\Users\Ayan.Choudhury\source\repos\SecurityTokenService\Core.UserClient\Views\Shared\DisplayDetails.cshtml"
WriteAttributeValue(" ", 352, className, 353, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    ");
#nullable restore
#line 10 "C:\Users\Ayan.Choudhury\source\repos\SecurityTokenService\Core.UserClient\Views\Shared\DisplayDetails.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"! 
</div>
<script>
    var timeInSeconds = 30;
    var timerId = setInterval(() => {
        getTime()
    }, 1000);
    function getTime() {
        document.getElementById(""timer"").innerHTML = timeInSeconds;
        timeInSeconds -= 1;

        if (timeInSeconds == 0) {
            clearInterval(timerId);
            var url = $(""#RedirectTo"").val();
            window.location.href = url
        }
    }
</script>
");
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
