#pragma checksum "C:\git\Dotnetcore2TestExample\src\MvcMovie\Views\Sample\Sort.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cade2ed391a135d7dbaf735e3e184a8a371cf987"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sample_Sort), @"mvc.1.0.view", @"/Views/Sample/Sort.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sample/Sort.cshtml", typeof(AspNetCore.Views_Sample_Sort))]
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
#line 1 "C:\git\Dotnetcore2TestExample\src\MvcMovie\Views\_ViewImports.cshtml"
using MvcMovie;

#line default
#line hidden
#line 2 "C:\git\Dotnetcore2TestExample\src\MvcMovie\Views\_ViewImports.cshtml"
using MvcMovie.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cade2ed391a135d7dbaf735e3e184a8a371cf987", @"/Views/Sample/Sort.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"686ad2e38abb871af45be971520cc6c3156da389", @"/Views/_ViewImports.cshtml")]
    public class Views_Sample_Sort : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MvcMovie.Models.SamplePostParameterViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\git\Dotnetcore2TestExample\src\MvcMovie\Views\Sample\Sort.cshtml"
  
    ViewData["Title"] = "Sample";

#line default
#line hidden
            BeginContext(97, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\git\Dotnetcore2TestExample\src\MvcMovie\Views\Sample\Sort.cshtml"
 foreach (var items in Model.Numbers) {

#line default
#line hidden
            BeginContext(140, 19, true);
            WriteLiteral("    <div>\r\n        ");
            EndContext();
            BeginContext(160, 27, false);
#line 9 "C:\git\Dotnetcore2TestExample\src\MvcMovie\Views\Sample\Sort.cshtml"
   Write(Html.DisplayFor(x => items));

#line default
#line hidden
            EndContext();
            BeginContext(187, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 11 "C:\git\Dotnetcore2TestExample\src\MvcMovie\Views\Sample\Sort.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MvcMovie.Models.SamplePostParameterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591