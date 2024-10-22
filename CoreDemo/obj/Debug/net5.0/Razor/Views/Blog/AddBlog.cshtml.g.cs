#pragma checksum "F:\source\repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\AddBlog.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "b9f694653882aa007c2376941178506a88b765cb3bd5dd39d23893cc7a118866"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_AddBlog), @"mvc.1.0.view", @"/Views/Blog/AddBlog.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "F:\source\repos\BlogProject_AspNet_Core\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo

#nullable disable
    ;
#nullable restore
#line 2 "F:\source\repos\BlogProject_AspNet_Core\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"b9f694653882aa007c2376941178506a88b765cb3bd5dd39d23893cc7a118866", @"/Views/Blog/AddBlog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"28e9796c92c1d16a3954ba6ba0aa2474261584969ce6f7ea25d023e9241fc234", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_AddBlog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Blog>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\source\repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\AddBlog.cshtml"
  
    ViewData["Title"] = "AddBlog";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<h1>Yeni Blog Girişi</h1>\r\n\r\n");
#nullable restore
#line 9 "F:\source\repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\AddBlog.cshtml"
 using (Html.BeginForm("AddBlog", "Blog", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable

            Write(
#nullable restore
#line 11 "F:\source\repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\AddBlog.cshtml"
     Html.Label("Blog başlığı")

#line default
#line hidden
#nullable disable
            );
            Write(
#nullable restore
#line 12 "F:\source\repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\AddBlog.cshtml"
     Html.TextBoxFor(x => x.BlogTitle, new { @class = "form-control" })

#line default
#line hidden
#nullable disable
            );
            Write(
#nullable restore
#line 13 "F:\source\repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\AddBlog.cshtml"
     Html.ValidationMessageFor(x => x.BlogTitle)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("    <br />\r\n");
            Write(
#nullable restore
#line 15 "F:\source\repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\AddBlog.cshtml"
     Html.Label("Blog görseli")

#line default
#line hidden
#nullable disable
            );
            Write(
#nullable restore
#line 16 "F:\source\repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\AddBlog.cshtml"
     Html.TextBoxFor(x => x.BlogImage, new { @class = "form-control" })

#line default
#line hidden
#nullable disable
            );
            Write(
#nullable restore
#line 17 "F:\source\repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\AddBlog.cshtml"
     Html.ValidationMessageFor(x => x.BlogImage)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("    <br />\r\n");
            Write(
#nullable restore
#line 19 "F:\source\repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\AddBlog.cshtml"
     Html.Label("Blog küçük görsel")

#line default
#line hidden
#nullable disable
            );
            Write(
#nullable restore
#line 20 "F:\source\repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\AddBlog.cshtml"
     Html.TextBoxFor(x => x.BlogThambnailImage, new { @class = "form-control" })

#line default
#line hidden
#nullable disable
            );
            Write(
#nullable restore
#line 21 "F:\source\repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\AddBlog.cshtml"
     Html.ValidationMessageFor(x => x.BlogThambnailImage)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("    <br />\r\n");
            Write(
#nullable restore
#line 23 "F:\source\repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\AddBlog.cshtml"
     Html.Label("Blog kategori")

#line default
#line hidden
#nullable disable
            );
            Write(
#nullable restore
#line 24 "F:\source\repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\AddBlog.cshtml"
     Html.DropDownListFor(x => x.CategoryID, (List<SelectListItem>)ViewBag.CategoryValues, new { @class = "form-control" })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("    <br />\r\n");
            Write(
#nullable restore
#line 26 "F:\source\repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\AddBlog.cshtml"
     Html.Label("Blog içerik")

#line default
#line hidden
#nullable disable
            );
            Write(
#nullable restore
#line 27 "F:\source\repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\AddBlog.cshtml"
     Html.TextAreaFor(x => x.BlogContent, 3, 10, new { @class = "form-control" })

#line default
#line hidden
#nullable disable
            );
            Write(
#nullable restore
#line 28 "F:\source\repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\AddBlog.cshtml"
     Html.ValidationMessageFor(x => x.BlogContent)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-info\">Bloğu Ekle</button>\r\n");
#nullable restore
#line 31 "F:\source\repos\BlogProject_AspNet_Core\CoreDemo\Views\Blog\AddBlog.cshtml"
}

#line default
#line hidden
#nullable disable

        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Blog> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
