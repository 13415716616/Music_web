#pragma checksum "F:\web\Music_web\Music_web\Views\Music\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "381b139e36ee15d58a9f7cc1fec81a22ab3ecd34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Music_Search), @"mvc.1.0.view", @"/Views/Music/Search.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Music/Search.cshtml", typeof(AspNetCore.Views_Music_Search))]
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
#line 1 "F:\web\Music_web\Music_web\Views\_ViewImports.cshtml"
using Music_web;

#line default
#line hidden
#line 2 "F:\web\Music_web\Music_web\Views\_ViewImports.cshtml"
using Music_web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"381b139e36ee15d58a9f7cc1fec81a22ab3ecd34", @"/Views/Music/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1356eb2545d98ffd3f923159667c1041b67ed5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Music_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Music>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/zhuanji_style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("lang", new global::Microsoft.AspNetCore.Html.HtmlString("en"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Music", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("parent"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("position: absolute;margin-top: 180px;margin-left: 30%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "F:\web\Music_web\Music_web\Views\Music\Search.cshtml"
  
    var music = ViewData["Music"] as IList<Music_web.Music_API.Music_info>;
    var islogin = ViewBag.Login;
    var i = 2;

#line default
#line hidden
            BeginContext(148, 27, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(175, 138, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "381b139e36ee15d58a9f7cc1fec81a22ab3ecd346337", async() => {
                BeginContext(191, 57, true);
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <title>搜索</title>\r\n    ");
                EndContext();
                BeginContext(248, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "381b139e36ee15d58a9f7cc1fec81a22ab3ecd346780", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(304, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(313, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(315, 2481, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "381b139e36ee15d58a9f7cc1fec81a22ab3ecd348992", async() => {
                BeginContext(321, 203, true);
                WriteLiteral("\r\n    <!--导航栏  开始-->\r\n    <div style=\"background-image: url(\'/img/Search_back .jpg\');background-repeat:inherit; height: 300px;width: 100%;margin-top: 5px\">\r\n        <div class=\"container1\">\r\n            ");
                EndContext();
                BeginContext(524, 473, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "381b139e36ee15d58a9f7cc1fec81a22ab3ecd349589", async() => {
                    BeginContext(650, 340, true);
                    WriteLiteral(@"
                <input type=""text""style=""width: 350px; height: 50px; border-radius: 18px; outline: none; border: 1px solid #ccc;"" placeholder=""搜索"" name=""text"">
                <input type=""submit""  class=""btn"" style=""float:left;margin-left:0;position:absolute; background-color:aliceblue;height:40px;width:60px"" value=""确定"">
            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(997, 30, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
                EndContext();
#line 25 "F:\web\Music_web\Music_web\Views\Music\Search.cshtml"
     if (music != null)
    {

#line default
#line hidden
                BeginContext(1059, 193, true);
                WriteLiteral("        <table class=\"table\" style=\"width: 90%;margin-left:5%\">\r\n            <thead style=\"size: 10ch\">\r\n                <th>歌曲名</th>\r\n                <th>歌手</th>\r\n                <th>专辑</th>\r\n");
                EndContext();
                BeginContext(1285, 98, true);
                WriteLiteral("                <th>收藏</th>\r\n            </thead>\r\n                <tbody style=\"opacity:0.5\">\r\n\r\n");
                EndContext();
#line 37 "F:\web\Music_web\Music_web\Views\Music\Search.cshtml"
                     foreach (var song in music)
                    {
                        

#line default
#line hidden
#line 39 "F:\web\Music_web\Music_web\Views\Music\Search.cshtml"
                         if (i % 2 == 0)
                        {

#line default
#line hidden
                BeginContext(1525, 106, true);
                WriteLiteral("                            <tr style=\"background-color:#f0fcff;\">\r\n                                <td><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1631, "\"", 1659, 2);
                WriteAttributeValue("", 1638, "writejson?id=", 1638, 13, true);
#line 42 "F:\web\Music_web\Music_web\Views\Music\Search.cshtml"
WriteAttributeValue("", 1651, song.id, 1651, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1660, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(1662, 15, false);
#line 42 "F:\web\Music_web\Music_web\Views\Music\Search.cshtml"
                                                               Write(song.music_name);

#line default
#line hidden
                EndContext();
                BeginContext(1677, 48, true);
                WriteLiteral("</a></td>\r\n                                <td >");
                EndContext();
                BeginContext(1726, 17, false);
#line 43 "F:\web\Music_web\Music_web\Views\Music\Search.cshtml"
                                Write(song.music_alname);

#line default
#line hidden
                EndContext();
                BeginContext(1743, 45, true);
                WriteLiteral("</td>\r\n                                <td><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1788, "\"", 1817, 2);
                WriteAttributeValue("", 1795, "album?id=", 1795, 9, true);
#line 44 "F:\web\Music_web\Music_web\Views\Music\Search.cshtml"
WriteAttributeValue("", 1804, song.albumid, 1804, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1818, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(1820, 10, false);
#line 44 "F:\web\Music_web\Music_web\Views\Music\Search.cshtml"
                                                                Write(song.album);

#line default
#line hidden
                EndContext();
                BeginContext(1830, 11, true);
                WriteLiteral("</a></td>\r\n");
                EndContext();
                BeginContext(1891, 76, true);
                WriteLiteral("                                <td>\r\n                                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1967, "\"", 2001, 2);
                WriteAttributeValue("", 1974, "/User/shouchang?id=", 1974, 19, true);
#line 47 "F:\web\Music_web\Music_web\Views\Music\Search.cshtml"
WriteAttributeValue("", 1993, song.id, 1993, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2002, 85, true);
                WriteLiteral(">收藏歌曲</a>\r\n                                </td>\r\n                            </tr>\r\n");
                EndContext();
#line 50 "F:\web\Music_web\Music_web\Views\Music\Search.cshtml"
                        }
                        else
                        {

#line default
#line hidden
                BeginContext(2171, 64, true);
                WriteLiteral("                        <tr>\r\n                            <td><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2235, "\"", 2263, 2);
                WriteAttributeValue("", 2242, "writejson?id=", 2242, 13, true);
#line 54 "F:\web\Music_web\Music_web\Views\Music\Search.cshtml"
WriteAttributeValue("", 2255, song.id, 2255, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2264, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(2266, 15, false);
#line 54 "F:\web\Music_web\Music_web\Views\Music\Search.cshtml"
                                                           Write(song.music_name);

#line default
#line hidden
                EndContext();
                BeginContext(2281, 43, true);
                WriteLiteral("</a></td>\r\n                            <td>");
                EndContext();
                BeginContext(2325, 17, false);
#line 55 "F:\web\Music_web\Music_web\Views\Music\Search.cshtml"
                           Write(song.music_alname);

#line default
#line hidden
                EndContext();
                BeginContext(2342, 41, true);
                WriteLiteral("</td>\r\n                            <td><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2383, "\"", 2412, 2);
                WriteAttributeValue("", 2390, "album?id=", 2390, 9, true);
#line 56 "F:\web\Music_web\Music_web\Views\Music\Search.cshtml"
WriteAttributeValue("", 2399, song.albumid, 2399, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2413, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(2415, 10, false);
#line 56 "F:\web\Music_web\Music_web\Views\Music\Search.cshtml"
                                                            Write(song.album);

#line default
#line hidden
                EndContext();
                BeginContext(2425, 11, true);
                WriteLiteral("</a></td>\r\n");
                EndContext();
                BeginContext(2482, 68, true);
                WriteLiteral("                            <td>\r\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2550, "\"", 2584, 2);
                WriteAttributeValue("", 2557, "/User/shouchang?id=", 2557, 19, true);
#line 59 "F:\web\Music_web\Music_web\Views\Music\Search.cshtml"
WriteAttributeValue("", 2576, song.id, 2576, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2585, 77, true);
                WriteLiteral(">收藏歌曲</a>\r\n                            </td>\r\n                        </tr>\r\n");
                EndContext();
#line 62 "F:\web\Music_web\Music_web\Views\Music\Search.cshtml"
                        }

#line default
#line hidden
#line 62 "F:\web\Music_web\Music_web\Views\Music\Search.cshtml"
                         
                        i++;
                    }

#line default
#line hidden
                BeginContext(2742, 40, true);
                WriteLiteral("                </tbody>\r\n    </table>\r\n");
                EndContext();
#line 67 "F:\web\Music_web\Music_web\Views\Music\Search.cshtml"
    }

#line default
#line hidden
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
            EndContext();
            BeginContext(2796, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Music> Html { get; private set; }
    }
}
#pragma warning restore 1591
