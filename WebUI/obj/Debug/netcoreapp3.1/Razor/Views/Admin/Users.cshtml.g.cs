#pragma checksum "C:\Users\UgurYildiz\Desktop\Builder-Project\WebUI\Views\Admin\Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b89e4ef8e8ff793efff612dc97922c23c7e52a7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Users), @"mvc.1.0.view", @"/Views/Admin/Users.cshtml")]
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
#line 1 "C:\Users\UgurYildiz\Desktop\Builder-Project\WebUI\Views\_ViewImports.cshtml"
using WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\UgurYildiz\Desktop\Builder-Project\WebUI\Views\_ViewImports.cshtml"
using WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b89e4ef8e8ff793efff612dc97922c23c7e52a7a", @"/Views/Admin/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d47e27a2e52ed7f194c3d9ff4041a6ce3e670b2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList.Core.IPagedList<Entities.Concrete.User>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Users", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("param-page-number", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::PagedList.Core.Mvc.PagerTagHelper __PagedList_Core_Mvc_PagerTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""container-xxl flex-grow-1 container-p-y"">
    <h4 class=""fw-bold py-3 mb-4""><span class=""text-muted fw-light"">Kullanıcı Yönetimi /</span> Kullanıcılar</h4>
    <div class=""card"">
        <h5 class=""card-header"">Kullanıcılar</h5>
        <div class=""table-responsive text-nowrap"">
            <table class=""table table-hover"">
                <caption class=""ms-4"">
                    <div class=""col-md-1o"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b89e4ef8e8ff793efff612dc97922c23c7e52a7a4473", async() => {
            }
            );
            __PagedList_Core_Mvc_PagerTagHelper = CreateTagHelper<global::PagedList.Core.Mvc.PagerTagHelper>();
            __tagHelperExecutionContext.Add(__PagedList_Core_Mvc_PagerTagHelper);
#nullable restore
#line 11 "C:\Users\UgurYildiz\Desktop\Builder-Project\WebUI\Views\Admin\Users.cshtml"
__PagedList_Core_Mvc_PagerTagHelper.List = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("list", __PagedList_Core_Mvc_PagerTagHelper.List, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __PagedList_Core_Mvc_PagerTagHelper.AspController = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __PagedList_Core_Mvc_PagerTagHelper.AspAction = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __PagedList_Core_Mvc_PagerTagHelper.ParamPageNumber = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 11 "C:\Users\UgurYildiz\Desktop\Builder-Project\WebUI\Views\Admin\Users.cshtml"
__PagedList_Core_Mvc_PagerTagHelper.Options = PagedList.Core.Mvc.PagedListRenderOptions.Bootstrap4PageNumbersOnly;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("options", __PagedList_Core_Mvc_PagerTagHelper.Options, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-2\">\r\n                        Page ");
#nullable restore
#line 14 "C:\Users\UgurYildiz\Desktop\Builder-Project\WebUI\Views\Admin\Users.cshtml"
                         Write(Model.PageCount < Model.PageNumber ? 0 : Model.PageNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" of ");
#nullable restore
#line 14 "C:\Users\UgurYildiz\Desktop\Builder-Project\WebUI\Views\Admin\Users.cshtml"
                                                                                        Write(Model.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </caption>
                <thead>
                    <tr>
                        <th><strong>Ad</strong></th>
                        <th><strong>Soyad</strong></th>
                        <th><strong>Email</strong></th>
                        <th><strong>Username</strong></th>
                        <th><strong>Durum</strong></th>
                        <th><strong></strong></th>

                    </tr>
                </thead>
                <tbody class=""table-border-bottom-0"">
");
#nullable restore
#line 29 "C:\Users\UgurYildiz\Desktop\Builder-Project\WebUI\Views\Admin\Users.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 32 "C:\Users\UgurYildiz\Desktop\Builder-Project\WebUI\Views\Admin\Users.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 33 "C:\Users\UgurYildiz\Desktop\Builder-Project\WebUI\Views\Admin\Users.cshtml"
                           Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 34 "C:\Users\UgurYildiz\Desktop\Builder-Project\WebUI\Views\Admin\Users.cshtml"
                           Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 35 "C:\Users\UgurYildiz\Desktop\Builder-Project\WebUI\Views\Admin\Users.cshtml"
                           Write(item.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n");
#nullable restore
#line 37 "C:\Users\UgurYildiz\Desktop\Builder-Project\WebUI\Views\Admin\Users.cshtml"
                                 if (item.IsActive)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"badge bg-label-primary me-1\">Aktif</span>\r\n");
#nullable restore
#line 40 "C:\Users\UgurYildiz\Desktop\Builder-Project\WebUI\Views\Admin\Users.cshtml"
                                }
                                else if (!item.IsActive)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"badge bg-label-warning me-1\">Pasif</span>\r\n");
#nullable restore
#line 44 "C:\Users\UgurYildiz\Desktop\Builder-Project\WebUI\Views\Admin\Users.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </td>
                            <td>
                                <div class=""dropdown"">
                                    <button type=""button"" class=""btn p-0 dropdown-toggle hide-arrow"" data-bs-toggle=""dropdown"">
                                        <i class=""bx bx-dots-vertical-rounded""></i>
                                    </button>
                                    <div class=""dropdown-menu"">
                                        <a class=""dropdown-item""");
            BeginWriteAttribute("href", " href=\"", 2708, "\"", 2733, 2);
            WriteAttributeValue("", 2715, "User_Edit/", 2715, 10, true);
#nullable restore
#line 52 "C:\Users\UgurYildiz\Desktop\Builder-Project\WebUI\Views\Admin\Users.cshtml"
WriteAttributeValue("", 2725, item.Id, 2725, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"bx bx-edit-alt me-1\"></i> Düzenle</a>\r\n                                        <a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 2848, "\"", 2875, 2);
            WriteAttributeValue("", 2855, "User_Delete/", 2855, 12, true);
#nullable restore
#line 53 "C:\Users\UgurYildiz\Desktop\Builder-Project\WebUI\Views\Admin\Users.cshtml"
WriteAttributeValue("", 2867, item.Id, 2867, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"bx bx-trash me-1\"></i> Delete</a>\r\n                                    </div>\r\n                                </div>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 58 "C:\Users\UgurYildiz\Desktop\Builder-Project\WebUI\Views\Admin\Users.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList.Core.IPagedList<Entities.Concrete.User>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
