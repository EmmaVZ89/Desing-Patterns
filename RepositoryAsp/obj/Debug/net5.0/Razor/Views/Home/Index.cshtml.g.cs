#pragma checksum "C:\Users\Note\Desktop\Learn\Patrones de diseño\Desing-Patterns\RepositoryAsp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e22a1b6b225ea8c90645d9fcf086642694c65649"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Note\Desktop\Learn\Patrones de diseño\Desing-Patterns\RepositoryAsp\Views\_ViewImports.cshtml"
using RepositoryAsp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Note\Desktop\Learn\Patrones de diseño\Desing-Patterns\RepositoryAsp\Views\_ViewImports.cshtml"
using RepositoryAsp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Note\Desktop\Learn\Patrones de diseño\Desing-Patterns\RepositoryAsp\Views\Home\Index.cshtml"
using DesignPatterns.Models.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e22a1b6b225ea8c90645d9fcf086642694c65649", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db3fe5da407bd790070e464b564e8187cb5924c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Beer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Note\Desktop\Learn\Patrones de diseño\Desing-Patterns\RepositoryAsp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-12\">\r\n");
#nullable restore
#line 10 "C:\Users\Note\Desktop\Learn\Patrones de diseño\Desing-Patterns\RepositoryAsp\Views\Home\Index.cshtml"
         foreach (var beer in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>");
#nullable restore
#line 12 "C:\Users\Note\Desktop\Learn\Patrones de diseño\Desing-Patterns\RepositoryAsp\Views\Home\Index.cshtml"
          Write(beer.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 13 "C:\Users\Note\Desktop\Learn\Patrones de diseño\Desing-Patterns\RepositoryAsp\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Beer>> Html { get; private set; }
    }
}
#pragma warning restore 1591