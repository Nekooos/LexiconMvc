#pragma checksum "D:\repos\mvcexample\LexiconMvc\LexiconMvc\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a7b9553e27360d1e5d12c6d140fe8f0487b5f95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "D:\repos\mvcexample\LexiconMvc\LexiconMvc\Views\_ViewImports.cshtml"
using LexiconMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\repos\mvcexample\LexiconMvc\LexiconMvc\Views\_ViewImports.cshtml"
using LexiconMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a7b9553e27360d1e5d12c6d140fe8f0487b5f95", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ab67563ae57710e88ccedbabf6d475e0d08948b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/person-script.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a7b9553e27360d1e5d12c6d140fe8f0487b5f954448", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
#nullable restore
#line 6 "D:\repos\mvcexample\LexiconMvc\LexiconMvc\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</title>
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"" integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a7b9553e27360d1e5d12c6d140fe8f0487b5f955389", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5a7b9553e27360d1e5d12c6d140fe8f0487b5f956488", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a7b9553e27360d1e5d12c6d140fe8f0487b5f958370", async() => {
                WriteLiteral("\r\n    <div class=\"grid-container\">\r\n        <header class=\"site-header\">\r\n            <h1 class=\"logo\">Logo</h1>\r\n            <nav>\r\n                <ul>\r\n                    <!-- link text, action, controller-->\r\n                    <li>");
#nullable restore
#line 19 "D:\repos\mvcexample\LexiconMvc\LexiconMvc\Views\Shared\_Layout.cshtml"
                   Write(Html.ActionLink("About", "Index", "Site"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                    <li>");
#nullable restore
#line 20 "D:\repos\mvcexample\LexiconMvc\LexiconMvc\Views\Shared\_Layout.cshtml"
                   Write(Html.ActionLink("Github Repositories", "ShowAllRepositories", "Site"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                    <li>");
#nullable restore
#line 21 "D:\repos\mvcexample\LexiconMvc\LexiconMvc\Views\Shared\_Layout.cshtml"
                   Write(Html.ActionLink("Contact", "ShowContactInformation", "Site"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                    <li>");
#nullable restore
#line 22 "D:\repos\mvcexample\LexiconMvc\LexiconMvc\Views\Shared\_Layout.cshtml"
                   Write(Html.ActionLink("Fever check", "FeverCheck", "Doctor"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                    <li>");
#nullable restore
#line 23 "D:\repos\mvcexample\LexiconMvc\LexiconMvc\Views\Shared\_Layout.cshtml"
                   Write(Html.ActionLink("Guessing Game", "GuessingGame", "GuessingGame"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                    <li>");
#nullable restore
#line 24 "D:\repos\mvcexample\LexiconMvc\LexiconMvc\Views\Shared\_Layout.cshtml"
                   Write(Html.ActionLink("Peoples", "Index", "People"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                    <li>");
#nullable restore
#line 25 "D:\repos\mvcexample\LexiconMvc\LexiconMvc\Views\Shared\_Layout.cshtml"
                   Write(Html.ActionLink("Countries", "Index", "Countries"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                    <li>");
#nullable restore
#line 26 "D:\repos\mvcexample\LexiconMvc\LexiconMvc\Views\Shared\_Layout.cshtml"
                   Write(Html.ActionLink("Cities", "Index", "Cities"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                    <li>");
#nullable restore
#line 27 "D:\repos\mvcexample\LexiconMvc\LexiconMvc\Views\Shared\_Layout.cshtml"
                   Write(Html.ActionLink("Language", "Index", "Languages"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                    <li>");
#nullable restore
#line 28 "D:\repos\mvcexample\LexiconMvc\LexiconMvc\Views\Shared\_Layout.cshtml"
                   Write(Html.ActionLink("Person Language", "Index", "PersonLanguages"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                </ul>\r\n            </nav>\r\n        </header>\r\n        <div class=\"container\">\r\n            <main class=\"render-body\">\r\n                ");
#nullable restore
#line 34 "D:\repos\mvcexample\LexiconMvc\LexiconMvc\Views\Shared\_Layout.cshtml"
           Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </main>\r\n        </div>\r\n\r\n        <footer>\r\n            <p>Time: <span class=\"current-time\">");
#nullable restore
#line 39 "D:\repos\mvcexample\LexiconMvc\LexiconMvc\Views\Shared\_Layout.cshtml"
                                           Write(DateTime.Now);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></p>\r\n            <p>Kristoffer Gustafsson</p>\r\n        </footer>\r\n     \r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
