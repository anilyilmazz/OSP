#pragma checksum "C:\Users\Anıl\Desktop\SideProjects\NETCORE\OSP\SosyalMedya\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d34320b7f43e40744fa6fcda8b06ccae23c73a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/Index.cshtml", typeof(AspNetCore.Views_Users_Index))]
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
#line 1 "C:\Users\Anıl\Desktop\SideProjects\NETCORE\OSP\SosyalMedya\Views\_ViewImports.cshtml"
using SosyalMedya;

#line default
#line hidden
#line 2 "C:\Users\Anıl\Desktop\SideProjects\NETCORE\OSP\SosyalMedya\Views\_ViewImports.cshtml"
using SosyalMedya.Models;

#line default
#line hidden
#line 1 "C:\Users\Anıl\Desktop\SideProjects\NETCORE\OSP\SosyalMedya\Views\Users\Index.cshtml"
using YemekSepeti.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d34320b7f43e40744fa6fcda8b06ccae23c73a6", @"/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f7b636c910dbbb0a6382c646a4f86bc20c82b93", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("100x180"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/profile-icon.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 150px; width: 100px; margin-left:30%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Anıl\Desktop\SideProjects\NETCORE\OSP\SosyalMedya\Views\Users\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(116, 93, true);
            WriteLiteral("\r\n\r\n<div class=\"card card-block\" style=\"width: 25%;padding: 2% 0% 0% 10%; float:left;\">\r\n    ");
            EndContext();
            BeginContext(209, 126, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "02caaf9506914c8a83fa2e93e8a8dae8", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(335, 226, true);
            WriteLiteral("\r\n    <div class=\"card-block\">\r\n        <center><h4 class=\"card-title\">Hoş Geldin !!!</h4></center>\r\n        <p class=\"card-text\"></p>\r\n        <ul class=\"list-group list-group-flush\">\r\n            <li class=\"list-group-item\">");
            EndContext();
            BeginContext(562, 17, false);
#line 14 "C:\Users\Anıl\Desktop\SideProjects\NETCORE\OSP\SosyalMedya\Views\Users\Index.cshtml"
                                   Write(ViewData["email"]);

#line default
#line hidden
            EndContext();
            BeginContext(579, 47, true);
            WriteLiteral("</li>\r\n            <li class=\"list-group-item\">");
            EndContext();
            BeginContext(627, 18, false);
#line 15 "C:\Users\Anıl\Desktop\SideProjects\NETCORE\OSP\SosyalMedya\Views\Users\Index.cshtml"
                                   Write(ViewData["adress"]);

#line default
#line hidden
            EndContext();
            BeginContext(645, 398, true);
            WriteLiteral(@"</li>
        </ul>
        <center><a href=""cikisyap"" class=""btn btn-danger"">Çıkış Yap</a></center>
        <br />
    </div>
</div>

<table class=""table "" style="" width:60%; margin-right:10%;margin-top:2%;float:right"">
    <thead>
        <tr>
            <th>Restoran İsmi</th>
            <th>Restoran Türü</th>
            <th>Adres</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 31 "C:\Users\Anıl\Desktop\SideProjects\NETCORE\OSP\SosyalMedya\Views\Users\Index.cshtml"
         foreach (var item in ViewData["restoranlar"] as List<Restorant>)
        {

#line default
#line hidden
            BeginContext(1129, 32, true);
            WriteLiteral("        <tr>\r\n            <th><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1161, "\"", 1191, 2);
            WriteAttributeValue("", 1168, "/users/menu?id=", 1168, 15, true);
#line 34 "C:\Users\Anıl\Desktop\SideProjects\NETCORE\OSP\SosyalMedya\Views\Users\Index.cshtml"
WriteAttributeValue("", 1183, item.Id, 1183, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1192, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1194, 7, false);
#line 34 "C:\Users\Anıl\Desktop\SideProjects\NETCORE\OSP\SosyalMedya\Views\Users\Index.cshtml"
                                             Write(item.Ad);

#line default
#line hidden
            EndContext();
            BeginContext(1201, 27, true);
            WriteLiteral("</a></th>\r\n            <th>");
            EndContext();
            BeginContext(1229, 8, false);
#line 35 "C:\Users\Anıl\Desktop\SideProjects\NETCORE\OSP\SosyalMedya\Views\Users\Index.cshtml"
           Write(item.Tur);

#line default
#line hidden
            EndContext();
            BeginContext(1237, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(1261, 11, false);
#line 36 "C:\Users\Anıl\Desktop\SideProjects\NETCORE\OSP\SosyalMedya\Views\Users\Index.cshtml"
           Write(item.Adress);

#line default
#line hidden
            EndContext();
            BeginContext(1272, 22, true);
            WriteLiteral("</th>\r\n        </tr>\r\n");
            EndContext();
#line 38 "C:\Users\Anıl\Desktop\SideProjects\NETCORE\OSP\SosyalMedya\Views\Users\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1301, 253, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>Sipariş Tarihi</th>\r\n            <th>Restoran Adı</th>\r\n            <th>Ürün</th>\r\n            <th>Fiyat</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 52 "C:\Users\Anıl\Desktop\SideProjects\NETCORE\OSP\SosyalMedya\Views\Users\Index.cshtml"
         foreach (var item in ViewData["siparisler"] as List<Siparis>)
        {

#line default
#line hidden
            BeginContext(1637, 38, true);
            WriteLiteral("            <tr>\r\n                <th>");
            EndContext();
            BeginContext(1676, 10, false);
#line 55 "C:\Users\Anıl\Desktop\SideProjects\NETCORE\OSP\SosyalMedya\Views\Users\Index.cshtml"
               Write(item.tarih);

#line default
#line hidden
            EndContext();
            BeginContext(1686, 27, true);
            WriteLiteral("</th>\r\n                <th>");
            EndContext();
            BeginContext(1714, 16, false);
#line 56 "C:\Users\Anıl\Desktop\SideProjects\NETCORE\OSP\SosyalMedya\Views\Users\Index.cshtml"
               Write(item.RestorantAd);

#line default
#line hidden
            EndContext();
            BeginContext(1730, 27, true);
            WriteLiteral("</th>\r\n                <th>");
            EndContext();
            BeginContext(1758, 12, false);
#line 57 "C:\Users\Anıl\Desktop\SideProjects\NETCORE\OSP\SosyalMedya\Views\Users\Index.cshtml"
               Write(item.UrunAdi);

#line default
#line hidden
            EndContext();
            BeginContext(1770, 27, true);
            WriteLiteral("</th>\r\n                <th>");
            EndContext();
            BeginContext(1798, 10, false);
#line 58 "C:\Users\Anıl\Desktop\SideProjects\NETCORE\OSP\SosyalMedya\Views\Users\Index.cshtml"
               Write(item.Fiyat);

#line default
#line hidden
            EndContext();
            BeginContext(1808, 29, true);
            WriteLiteral(" TL</th>\r\n            </tr>\r\n");
            EndContext();
#line 60 "C:\Users\Anıl\Desktop\SideProjects\NETCORE\OSP\SosyalMedya\Views\Users\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1848, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
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
