#pragma checksum "C:\Users\HP\Desktop\AspNet\The7 Backend\The7 Backend\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d758bbccfccfea8dfd176b988c0e40e2530057a"
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
#line 1 "C:\Users\HP\Desktop\AspNet\The7 Backend\The7 Backend\Views\_ViewImports.cshtml"
using The7_Backend.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\AspNet\The7 Backend\The7 Backend\Views\_ViewImports.cshtml"
using The7_Backend.View_Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d758bbccfccfea8dfd176b988c0e40e2530057a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"082c91d1df675be3f5236225403a6788d13b3c43", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<main>\r\n        <section id=\"for-intro\">\r\n            <div class=\"container\">\r\n                <div class=\"row\">\r\n                    <h1 style=\"color: white; text-align:center;margin-top:5rem;\">");
#nullable restore
#line 6 "C:\Users\HP\Desktop\AspNet\The7 Backend\The7 Backend\Views\Home\Index.cshtml"
                                                                            Write(Model.intro.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                    <p style=\"color: white; text-align:center; margin-top:3rem;\">");
#nullable restore
#line 7 "C:\Users\HP\Desktop\AspNet\The7 Backend\The7 Backend\Views\Home\Index.cshtml"
                                                                            Write(Html.Raw(Model.intro.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    <div class=""intro-btn"">
                        <button class=""btnn"" style=""width:10rem;height:3rem;"">Find Out More</button>
                    </div>
                </div>
            </div>
        </section>

        <section id=""our-service"">
            <div class=""container"">
                <div class=""services-title"">
                    <h1 style=""text-align:center;margin-top: 15rem; font-size: 4rem; font-weight: 100;"">OUR SERVICES</h1>
                </div>
                <div class=""row"">
");
#nullable restore
#line 21 "C:\Users\HP\Desktop\AspNet\The7 Backend\The7 Backend\Views\Home\Index.cshtml"
                     foreach (var item in Model.service)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-3\" style=\"margin-bottom: 6rem;\">\r\n                        <div class=\"card\" style=\"width: 18rem;\">\r\n                            ");
#nullable restore
#line 25 "C:\Users\HP\Desktop\AspNet\The7 Backend\The7 Backend\Views\Home\Index.cshtml"
                       Write(Html.Raw(item.Icon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <div class=\"card-body\">\r\n                              <h5 class=\"card-title\">");
#nullable restore
#line 27 "C:\Users\HP\Desktop\AspNet\The7 Backend\The7 Backend\Views\Home\Index.cshtml"
                                                Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                              <p class=\"card-text\">");
#nullable restore
#line 28 "C:\Users\HP\Desktop\AspNet\The7 Backend\The7 Backend\Views\Home\Index.cshtml"
                                              Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                              <a href=\"#\" class=\"btn btn-primary\">Read More</a>\r\n                            </div>\r\n                          </div>\r\n                    </div>\n");
#nullable restore
#line 33 "C:\Users\HP\Desktop\AspNet\The7 Backend\The7 Backend\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    
                </div>
            </div>
        </section>

        <section id=""text-slider"">
            <div class=""slideshow-container"">
                <div class=""mySlides"">
                  <q>I love you the more in that I believe you had liked me for my own sake and for nothing else</q>
                  <p class=""author"">- John Keats</p>
                </div>
                <div class=""mySlides"">
                  <q>But man is not made for defeat. A man can be destroyed but not defeated.</q>
                  <p class=""author"">- Ernest Hemingway</p>
                </div>
                <div class=""mySlides"">
                  <q>I have not failed. I've just found 10,000 ways that won't work.</q>
                  <p class=""author"">- Thomas A. Edison</p>
                </div>
                <a class=""prev"" onclick=""plusSlides(-1)"">❮</a>
                <a class=""next"" onclick=""plusSlides(1)"">❯</a>
                </div>
                <div class=""d");
            WriteLiteral(@"ot-container"">
                  <span class=""dot"" onclick=""currentSlide(1)""></span> 
                  <span class=""dot"" onclick=""currentSlide(2)""></span> 
                  <span class=""dot"" onclick=""currentSlide(3)""></span> 
                </div>
        </section>

        <section id=""our-blog"">
            <div class=""container"">
                <div class=""row"">
                    <h1>OUR BLOG</h1>
                    <div class=""row row-cols-1 row-cols-md-2 g-4"">
");
#nullable restore
#line 68 "C:\Users\HP\Desktop\AspNet\The7 Backend\The7 Backend\Views\Home\Index.cshtml"
                         foreach (var item in Model.blogs)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                          <div class=\"col\">\r\n                          <div class=\"card\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4d758bbccfccfea8dfd176b988c0e40e2530057a10401", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3278, "~/assets/img/post/", 3278, 18, true);
#nullable restore
#line 72 "C:\Users\HP\Desktop\AspNet\The7 Backend\The7 Backend\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 3296, item.ImageUrl, 3296, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <div class=\"card-body\">\r\n                                 <h5 class=\"card-title\" style=\"color: #208D79;\">");
#nullable restore
#line 74 "C:\Users\HP\Desktop\AspNet\The7 Backend\The7 Backend\Views\Home\Index.cshtml"
                                                                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <p style=\"color: #208D79;\">");
#nullable restore
#line 75 "C:\Users\HP\Desktop\AspNet\The7 Backend\The7 Backend\Views\Home\Index.cshtml"
                                                      Write(item.Subtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                              <p class=\"card-text\" >");
#nullable restore
#line 76 "C:\Users\HP\Desktop\AspNet\The7 Backend\The7 Backend\Views\Home\Index.cshtml"
                                               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                              <a href=\"#\" class=\"btn btn-primary\">Read More</a>\r\n                            </div>\r\n                          </div>\r\n                        </div>\n");
#nullable restore
#line 81 "C:\Users\HP\Desktop\AspNet\The7 Backend\The7 Backend\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                      </div>
                      <div class=""view-all"" style=""margin-bottom: 3rem;"">
                        <a href=""#"" class=""btn btn-primary"" style=""width:120px;margin-top:3rem; background-color:#208D79;"">View All</a>
                      </div>
                </div>
            </div>
        </section>

        <section id=""our-team"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""row row-cols-1 row-cols-md-3 g-4"">
");
#nullable restore
#line 94 "C:\Users\HP\Desktop\AspNet\The7 Backend\The7 Backend\Views\Home\Index.cshtml"
                         foreach (var item in Model.teams)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                          <div class=\"col-3\">\r\n                          <div class=\"card\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4d758bbccfccfea8dfd176b988c0e40e2530057a14485", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4578, "~/assets/img/team/", 4578, 18, true);
#nullable restore
#line 98 "C:\Users\HP\Desktop\AspNet\The7 Backend\The7 Backend\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 4596, item.ImageUrl, 4596, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <div class=\"card-body\">\r\n                              <h5 class=\"card-title\">");
#nullable restore
#line 100 "C:\Users\HP\Desktop\AspNet\The7 Backend\The7 Backend\Views\Home\Index.cshtml"
                                                Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                              <p class=\"card-text\">");
#nullable restore
#line 101 "C:\Users\HP\Desktop\AspNet\The7 Backend\The7 Backend\Views\Home\Index.cshtml"
                                              Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                          </div>\r\n                        </div>\n");
#nullable restore
#line 105 "C:\Users\HP\Desktop\AspNet\The7 Backend\The7 Backend\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                      </div>
                </div>
            </div>
        </section>

        <section id=""contact"">
            <h1 class=""section-header"">Contact</h1>
            <div class=""contact-wrapper"">
            <!-- Left contact page --> 
              
              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d758bbccfccfea8dfd176b988c0e40e2530057a17465", async() => {
                WriteLiteral("\r\n                <div class=\"form-group\">\r\n                  <div class=\"col-sm-12\" >\r\n                    <input type=\"text\" class=\"form-control\" id=\"name\" placeholder=\"NAME\" name=\"name\"");
                BeginWriteAttribute("value", " value=\"", 5510, "\"", 5518, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
                  </div>
                </div>
                <div class=""form-group"">
                  <div class=""col-sm-12"" style=""margin-top: 1rem;"">
                    <input type=""email"" class=""form-control"" id=""email"" placeholder=""EMAIL"" name=""email""");
                BeginWriteAttribute("value", " value=\"", 5796, "\"", 5804, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
                  </div>
                </div>
                <textarea class=""form-control"" style=""margin-top: 1rem;"" rows=""10"" placeholder=""MESSAGE"" name=""message"" required></textarea>
                <button class=""btn btn-primary send-button"" id=""submit"" type=""submit"" value=""SEND"">
                  <div class=""alt-send-button"">
                    <i class=""fa fa-paper-plane""></i><span class=""send-text"">SEND</span>
                  </div>
                </button>
              ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
              
            <!-- Left contact page --> 
              
                <div class=""direct-contact-container"">
                  <ul class=""contact-list"">
                    <li class=""list-item""><i class=""fa fa-map-marker fa-2x""><span class=""contact-text place"">City, State</span></i></li>
                    <li class=""list-item""><i class=""fa fa-phone fa-2x""><span class=""contact-text phone""><a href=""tel:1-212-555-5555"" title=""Give me a call"">(212) 555-2368</a></span></i></li>
                    <li class=""list-item""><i class=""fa fa-envelope fa-2x""><span class=""contact-text gmail""><a href=""mailto:#"" title=""Send me an email"">hitmeup@gmail.com</a></span></i></li>
                  </ul>
                  <div class=""copyright"">&copy; ALL OF THE RIGHTS RESERVED</div>
                </div>
            </div>
          </section>  
    </main>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591