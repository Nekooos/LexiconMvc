#pragma checksum "D:\repos\mvcexample\LexiconMvc\LexiconMvc\Views\Shared\PersonDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e359afa86f50c7e437e6f05e7c3670e818a9c014"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_PersonDetails), @"mvc.1.0.view", @"/Views/Shared/PersonDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e359afa86f50c7e437e6f05e7c3670e818a9c014", @"/Views/Shared/PersonDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ab67563ae57710e88ccedbabf6d475e0d08948b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PersonDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PersonViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h3> Person Details Partial View</h3>\r\n<div class=\"row\">\r\n    <div class=\"col-sm-2\"><p>");
#nullable restore
#line 5 "D:\repos\mvcexample\LexiconMvc\LexiconMvc\Views\Shared\PersonDetails.cshtml"
                        Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></div>\r\n    <div class=\"col-sm-2\"><p>");
#nullable restore
#line 6 "D:\repos\mvcexample\LexiconMvc\LexiconMvc\Views\Shared\PersonDetails.cshtml"
                        Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></div>\r\n    <div class=\"col-sm-2\"><p>");
#nullable restore
#line 7 "D:\repos\mvcexample\LexiconMvc\LexiconMvc\Views\Shared\PersonDetails.cshtml"
                        Write(Model.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></div>\r\n    <div class=\"col-sm-2\"><p>");
#nullable restore
#line 8 "D:\repos\mvcexample\LexiconMvc\LexiconMvc\Views\Shared\PersonDetails.cshtml"
                        Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PersonViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591