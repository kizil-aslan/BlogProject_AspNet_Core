#pragma checksum "C:\Users\kizil\source\repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\BlogByWriter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1897c001b6099b8c2e6213d88227c50dfc844649"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogByWriter), @"mvc.1.0.view", @"/Views/Blog/BlogByWriter.cshtml")]
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
#line 1 "C:\Users\kizil\source\repos\BlogProject_AspNet_Core\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kizil\source\repos\BlogProject_AspNet_Core\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1897c001b6099b8c2e6213d88227c50dfc844649", @"/Views/Blog/BlogByWriter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_BlogByWriter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\kizil\source\repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\BlogByWriter.cshtml"
  
    ViewData["Title"] = "BlogByWriter";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Bloglar</h1>
<table class=""table table-bordered"">
    <tr>
        <th>ID</th>
        <th>Blog başlığı</th>
        <th>Oluşturma tarihi</th>
        <th>Kategori</th>
        <th>Durum</th>
        <th>Sil</th>
        <th>Düzenle</th>
    </tr>
");
#nullable restore
#line 18 "C:\Users\kizil\source\repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\BlogByWriter.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\kizil\source\repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\BlogByWriter.cshtml"
           Write(item.BlogID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\kizil\source\repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\BlogByWriter.cshtml"
           Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\kizil\source\repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\BlogByWriter.cshtml"
            Write(((DateTime)item.BlogCreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"badge badge-info\">");
#nullable restore
#line 24 "C:\Users\kizil\source\repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\BlogByWriter.cshtml"
                                    Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\kizil\source\repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\BlogByWriter.cshtml"
           Write(item.BlogStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 753, "\"", 789, 2);
            WriteAttributeValue("", 760, "/Blog/DeleteBlog/", 760, 17, true);
#nullable restore
#line 26 "C:\Users\kizil\source\repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\BlogByWriter.cshtml"
WriteAttributeValue("", 777, item.BlogID, 777, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 846, "\"", 882, 2);
            WriteAttributeValue("", 853, "/Blog/UpdateBlog/", 853, 17, true);
#nullable restore
#line 27 "C:\Users\kizil\source\repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\BlogByWriter.cshtml"
WriteAttributeValue("", 870, item.BlogID, 870, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Düzenle</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 29 "C:\Users\kizil\source\repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\BlogByWriter.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Blog/AddBlog/\" class=\"btn btn-primary\">Yeni blog ekle</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
