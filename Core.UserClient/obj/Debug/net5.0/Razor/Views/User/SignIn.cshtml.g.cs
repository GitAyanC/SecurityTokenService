#pragma checksum "C:\Users\Ayan.Choudhury\source\repos\SecurityTokenService\Core.UserClient\Views\User\SignIn.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b8bb6f38d18690018d3f6b983f165a458f58463"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_SignIn), @"mvc.1.0.view", @"/Views/User/SignIn.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b8bb6f38d18690018d3f6b983f165a458f58463", @"/Views/User/SignIn.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0871315033338f09b4d28f83248856d489b7a3c0", @"/Views/_ViewImports.cshtml")]
    public class Views_User_SignIn : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserLoginModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SignIn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("panel-body"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"panel-body help-block\">\r\n    Sign In to Core.UserClient\r\n</div>\r\n");
#nullable restore
#line 7 "C:\Users\Ayan.Choudhury\source\repos\SecurityTokenService\Core.UserClient\Views\User\SignIn.cshtml"
 foreach (var errorMessage in Model.Errors)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br /><span class=\"alert-danger\">");
#nullable restore
#line 9 "C:\Users\Ayan.Choudhury\source\repos\SecurityTokenService\Core.UserClient\Views\User\SignIn.cshtml"
                                Write(errorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 10 "C:\Users\Ayan.Choudhury\source\repos\SecurityTokenService\Core.UserClient\Views\User\SignIn.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<hr />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b8bb6f38d18690018d3f6b983f165a458f584636067", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 13 "C:\Users\Ayan.Choudhury\source\repos\SecurityTokenService\Core.UserClient\Views\User\SignIn.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1b8bb6f38d18690018d3f6b983f165a458f584636585", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 14 "C:\Users\Ayan.Choudhury\source\repos\SecurityTokenService\Core.UserClient\Views\User\SignIn.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ReturnUrl);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
                WriteLiteral("    <div class=\"form-group\" style=\"width: fit-content;\">\r\n        ");
#nullable restore
#line 17 "C:\Users\Ayan.Choudhury\source\repos\SecurityTokenService\Core.UserClient\Views\User\SignIn.cshtml"
   Write(Html.TextBoxFor((model) => model.Username, new { @placeholder = "User Name", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 18 "C:\Users\Ayan.Choudhury\source\repos\SecurityTokenService\Core.UserClient\Views\User\SignIn.cshtml"
   Write(Html.ValidationMessageFor((model) => model.Username));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\" style=\"width: fit-content;\">\r\n        ");
#nullable restore
#line 21 "C:\Users\Ayan.Choudhury\source\repos\SecurityTokenService\Core.UserClient\Views\User\SignIn.cshtml"
   Write(Html.PasswordFor((model) => model.Password, new { @placeholder = "Password", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 22 "C:\Users\Ayan.Choudhury\source\repos\SecurityTokenService\Core.UserClient\Views\User\SignIn.cshtml"
   Write(Html.ValidationMessageFor((model) => model.Password));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <button type=\"submit\" class=\"btn btn-primary\">Sign In</button>\r\n        <button type=\"button\" class=\"btn btn-secondary\"");
                BeginWriteAttribute("onclick", " onclick=\"", 1153, "\"", 1210, 3);
                WriteAttributeValue("", 1163, "location.href=\'", 1163, 15, true);
#nullable restore
#line 26 "C:\Users\Ayan.Choudhury\source\repos\SecurityTokenService\Core.UserClient\Views\User\SignIn.cshtml"
WriteAttributeValue("", 1178, Url.Action("Register", "User"), 1178, 31, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1209, "\'", 1209, 1, true);
                EndWriteAttribute();
                WriteLiteral(">Register yourself!</button>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div class=\"panel-body\">\r\n    <hr />\r\n    <button type=\"submit\" class=\"btn btn-warning\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1349, "\"", 1413, 3);
            WriteAttributeValue("", 1359, "location.href=\'", 1359, 15, true);
#nullable restore
#line 31 "C:\Users\Ayan.Choudhury\source\repos\SecurityTokenService\Core.UserClient\Views\User\SignIn.cshtml"
WriteAttributeValue("", 1374, Url.Action("SignInWithOAuth", "User"), 1374, 38, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1412, "\'", 1412, 1, true);
            EndWriteAttribute();
            WriteLiteral(">SignIn with Core.Access credentials</button>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserLoginModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
