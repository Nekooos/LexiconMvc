#pragma checksum "D:\repos\mvcexample\LexiconMvc\LexiconMvc\Views\AjaxPerson\AjaxPersonIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40a9b44db58f84c02313f36b7ea3243b3e3df2f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AjaxPerson_AjaxPersonIndex), @"mvc.1.0.view", @"/Views/AjaxPerson/AjaxPersonIndex.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40a9b44db58f84c02313f36b7ea3243b3e3df2f5", @"/Views/AjaxPerson/AjaxPersonIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ab67563ae57710e88ccedbabf6d475e0d08948b", @"/Views/_ViewImports.cshtml")]
    public class Views_AjaxPerson_AjaxPersonIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PeopleViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\repos\mvcexample\LexiconMvc\LexiconMvc\Views\AjaxPerson\AjaxPersonIndex.cshtml"
  
    ViewData["Title"] = "Lexicon Assignment Week 9 Person";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Ajax Peoples</h1>

<input id=""input-id"" type=""number"" />
<button onclick=""getById()"">Person details by id</button>

<div id=""PersonDetails""></div>

<h3>Partial View</h3>

<input type=""button"" class=""btn btn-primary"" onclick=""getAll()"" value=""Get All Persons"" />


<div id=""PersonList""></div>


<input id=""delete-input-id"" type=""number"" />
<button onclick=""deleteById()"">Delete Person by id</button>

<h3>Messages</h3>
<p id=""status-message""></p>




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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PeopleViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591