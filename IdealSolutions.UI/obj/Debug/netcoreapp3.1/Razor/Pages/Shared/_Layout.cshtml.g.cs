#pragma checksum "D:\WorkSpace\tasks\IdealSolutions\IdealSolutions.UI\Pages\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0755ac0bb6abc47e0f12d5968fd0552d365798d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(IdealSolutions.UI.Pages.Shared.Pages_Shared__Layout), @"mvc.1.0.view", @"/Pages/Shared/_Layout.cshtml")]
namespace IdealSolutions.UI.Pages.Shared
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
#line 1 "D:\WorkSpace\tasks\IdealSolutions\IdealSolutions.UI\Pages\_ViewImports.cshtml"
using IdealSolutions.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\WorkSpace\tasks\IdealSolutions\IdealSolutions.UI\Pages\Shared\_Layout.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0755ac0bb6abc47e0f12d5968fd0552d365798d", @"/Pages/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36512cfdddd3d5360f6173809d7be6b8c846d6c7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("search-form d-none d-md-flex"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/dataTableDatetime.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/moment.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(" layout-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\" dir=\"ltr\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0755ac0bb6abc47e0f12d5968fd0552d365798d5240", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <title>Student - Dashboard</title>

    <!-- Prevent the demo from appearing in search engines (REMOVE THIS) -->
    <meta name=""robots"" content=""noindex"">

    <!-- Perfect Scrollbar -->
    <link type=""text/css"" href=""assets/vendor/perfect-scrollbar.css"" rel=""stylesheet"">
");
                WriteLiteral(@"    <!-- Material Design Icons -->
    <link type=""text/css"" href=""assets/css/material-icons.css"" rel=""stylesheet"">
    <link type=""text/css"" href=""assets/css/material-icons.rtl.css"" rel=""stylesheet"">
    <link type=""text/css"" href=""assets/css/Jquery.dataTables.css"" rel=""stylesheet"" />

    <!-- Font Awesome Icons -->
    <link type=""text/css"" href=""assets/css/fontawesome.css"" rel=""stylesheet"">

    <!-- App CSS -->
    <link type=""text/css"" href=""assets/css/app.css"" rel=""stylesheet"">
    <script>
        const baseUrl = ");
#nullable restore
#line 30 "D:\WorkSpace\tasks\IdealSolutions\IdealSolutions.UI\Pages\Shared\_Layout.cshtml"
                   Write(Json.Serialize(@Configuration.GetSection("ApiUrls").GetSection("baseUrl").Value));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        console.log(\'base url --> \', baseUrl);\r\n    </script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0755ac0bb6abc47e0f12d5968fd0552d365798d7676", async() => {
                WriteLiteral(@"

    <div class=""preloader"">
        <div class=""sk-double-bounce"">
            <div class=""sk-child sk-double-bounce1""></div>
            <div class=""sk-child sk-double-bounce2""></div>
        </div>
    </div>

    <!-- Header Layout -->
    <div class=""mdk-header-layout js-mdk-header-layout"">

        <!-- Header -->

        <div id=""header"" data-fixed class=""mdk-header js-mdk-header mb-0"">
            <div class=""mdk-header__content"">

                <!-- Navbar -->
                <nav id=""default-navbar"" class=""navbar navbar-expand navbar-dark bg-primary m-0"">
                    <div class=""container-fluid"">
                        <!-- Toggle sidebar -->
                        <button class=""navbar-toggler d-block"" data-toggle=""sidebar"" type=""button"">
                            <span class=""material-icons"">menu</span>
                        </button>

                        <!-- Brand -->
                        <a href=""/Employees"" class=""navbar-brand"">
             ");
                WriteLiteral(@"               <img src=""assets/images/logo/white.svg"" class=""mr-2"" alt=""DashBoard"" />
                            <span class=""d-none d-xs-md-block"">DashBoard</span>
                        </a>

                        <!-- Search -->
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0755ac0bb6abc47e0f12d5968fd0552d365798d9299", async() => {
                    WriteLiteral("\r\n                            <input type=\"text\" class=\"form-control\" placeholder=\"Search\">\r\n                            <button class=\"btn\" type=\"button\"><i class=\"material-icons font-size-24pt\">search</i></button>\r\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        <!-- // END Search -->

                        <div class=""flex""></div>
                    </div>
                </nav>
                <!-- // END Navbar -->

            </div>
        </div>

        <!-- // END Header -->
        <!-- Header Layout Content -->
        <div class=""mdk-header-layout__content"">

            <div data-push data-responsive-width=""992px"" class=""mdk-drawer-layout js-mdk-drawer-layout"">
                <div class=""mdk-drawer-layout__content page "">

                    ");
#nullable restore
#line 88 "D:\WorkSpace\tasks\IdealSolutions\IdealSolutions.UI\Pages\Shared\_Layout.cshtml"
               Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                </div>




                <div class=""mdk-drawer js-mdk-drawer"" id=""default-drawer"">
                    <div class=""mdk-drawer__content "">
                        <div class=""sidebar sidebar-left sidebar-dark bg-dark o-hidden"" data-perfect-scrollbar>
                            <div class=""sidebar-p-y"">
                                <div class=""sidebar-heading"">APPLICATIONS</div>
                                <ul class=""sidebar-menu sm-active-button-bg"">
                                    <li class=""sidebar-menu-item active"">
                                        <a class=""sidebar-menu-button"" href=""/Employees"">
                                            <i class=""sidebar-menu-icon sidebar-menu-icon--left material-icons"">account_box</i> Employees
                                        </a>
                                    </li>
                                    <li class=""sidebar-menu-item"">
                                        <a class=""sidebar-menu-but");
                WriteLiteral(@"ton"" href=""/Tasks"">
                                            <i class=""sidebar-menu-icon sidebar-menu-icon--left material-icons"">school</i> Tasks
                                        </a>
                                    </li>
                                </ul>

                            </div>
                        </div>
                    </div>
                </div>

            </div>

        </div>
    </div>



    <!-- jQuery -->
    <script src=""assets/vendor/jquery.min.js""></script>
    <!-- Bootstrap -->
    <script src=""assets/vendor/popper.min.js""></script>
    <script src=""assets/vendor/bootstrap.min.js""></script>
    <script src=""assets/js/Jquery.dataTables.js""></script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0755ac0bb6abc47e0f12d5968fd0552d365798d13567", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0755ac0bb6abc47e0f12d5968fd0552d365798d14667", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <!-- Perfect Scrollbar -->
    <script src=""assets/vendor/perfect-scrollbar.min.js""></script>

    <!-- MDK -->
    <script src=""assets/vendor/dom-factory.js""></script>
    <script src=""assets/vendor/material-design-kit.js""></script>

    <!-- App JS -->
    <script src=""assets/js/app.js""></script>

    <!-- Global Settings -->
    <script src=""assets/js/settings.js""></script>

    <!-- Moment.js -->
    <script src=""assets/vendor/moment.min.js""></script>
    <script src=""assets/vendor/moment-range.min.js""></script>

    ");
#nullable restore
#line 150 "D:\WorkSpace\tasks\IdealSolutions\IdealSolutions.UI\Pages\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IConfiguration Configuration { get; private set; }
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
