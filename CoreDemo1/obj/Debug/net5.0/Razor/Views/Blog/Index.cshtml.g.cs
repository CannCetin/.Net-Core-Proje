#pragma checksum "C:\Users\cance\source\repos\CoreDemo1\CoreDemo1\Views\Blog\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "46a5b2fdb629941f80966ee4c9eb554637e799defe6a7b6f0998e122740816ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\cance\source\repos\CoreDemo1\CoreDemo1\Views\_ViewImports.cshtml"
using CoreDemo1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cance\source\repos\CoreDemo1\CoreDemo1\Views\_ViewImports.cshtml"
using CoreDemo1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\cance\source\repos\CoreDemo1\CoreDemo1\Views\Blog\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"46a5b2fdb629941f80966ee4c9eb554637e799defe6a7b6f0998e122740816ce", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"33a7352a52205ae0d326a7ff2080cdf6a28bbf33813db0627cd6e95918f08b28", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\cance\source\repos\CoreDemo1\CoreDemo1\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""main-content-w3layouts-agileits"">
    <div class=""container"">
        <h3 class=""tittle"">Bloglar</h3>
        <div class=""inner-sec"">
            <!--left-->
            <div class=""left-blog-info-w3layouts-agileits text-left"">
                <div class=""row"">
");
#nullable restore
#line 14 "C:\Users\cance\source\repos\CoreDemo1\CoreDemo1\Views\Blog\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-4 card\">\r\n                            <a href=\"single.html\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 638, "\"", 659, 1);
#nullable restore
#line 18 "C:\Users\cance\source\repos\CoreDemo1\CoreDemo1\Views\Blog\Index.cshtml"
WriteAttributeValue("", 644, item.BlogImage, 644, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 691, "\"", 697, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>
                            <div class=""card-body"">
                                <ul class=""blog-icons my-4"">
                                    <li>
                                        <a href=""#"">
                                            <i class=""far fa-calendar-alt""></i> ");
#nullable restore
#line 24 "C:\Users\cance\source\repos\CoreDemo1\CoreDemo1\Views\Blog\Index.cshtml"
                                                                            Write(((DateTime)item.BlogCreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </a>
                                    </li>
                                    <li class=""mx-2"">
                                        <a href=""#"">
                                            <i class=""far fa-comment""></i> 0
                                        </a>
                                    </li>
                                    <li>
                                        <a href=""#"">
                                            <i class=""fas fa-eye""></i> ");
#nullable restore
#line 34 "C:\Users\cance\source\repos\CoreDemo1\CoreDemo1\Views\Blog\Index.cshtml"
                                                                  Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </a>\r\n                                    </li>\r\n\r\n                                </ul>\r\n                                <h5 class=\"card-title\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1872, "\"", 1910, 3);
            WriteAttributeValue("", 1879, "/Blog/BlogReadAll/", 1879, 18, true);
#nullable restore
#line 40 "C:\Users\cance\source\repos\CoreDemo1\CoreDemo1\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1897, item.BlogID, 1897, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1909, "/", 1909, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 40 "C:\Users\cance\source\repos\CoreDemo1\CoreDemo1\Views\Blog\Index.cshtml"
                                                                         Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </h5>\r\n                                <p class=\"card-text mb-3\">");
#nullable restore
#line 42 "C:\Users\cance\source\repos\CoreDemo1\CoreDemo1\Views\Blog\Index.cshtml"
                                                     Write(item.BlogContent.Substring(0,item.BlogContent.Substring(0,130).LastIndexOf(" ")));

#line default
#line hidden
#nullable disable
            WriteLiteral("... </p>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2155, "\"", 2193, 3);
            WriteAttributeValue("", 2162, "/Blog/BlogReadAll/", 2162, 18, true);
#nullable restore
#line 43 "C:\Users\cance\source\repos\CoreDemo1\CoreDemo1\Views\Blog\Index.cshtml"
WriteAttributeValue("", 2180, item.BlogID, 2180, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2192, "/", 2192, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary read-m\">Devamını Oku</a>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 46 "C:\Users\cance\source\repos\CoreDemo1\CoreDemo1\Views\Blog\Index.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
