#pragma checksum "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTicketsDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3f527cb2b84feb6a89e2f3568e77790c0d28371"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tickets_MyTicketsDetails), @"mvc.1.0.view", @"/Views/Tickets/MyTicketsDetails.cshtml")]
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
#line 1 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/_ViewImports.cshtml"
using ZENBEAR.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/_ViewImports.cshtml"
using ZENBEAR.Web.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTicketsDetails.cshtml"
using ZENBEAR.Data.Models.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3f527cb2b84feb6a89e2f3568e77790c0d28371", @"/Views/Tickets/MyTicketsDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a0d0a8912d6b7039b508ebdc8e78d4dc60e9209", @"/Views/_ViewImports.cshtml")]
    public class Views_Tickets_MyTicketsDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ZENBEAR.Web.ViewModels.Tickets.MyTicketDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/finishbutton.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/comments.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/myTicketsDetails.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rows", new global::Microsoft.AspNetCore.Html.HtmlString("7"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("element5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("textarea"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Your Comment..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Comments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Comment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/hideShowComment.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3f527cb2b84feb6a89e2f3568e77790c0d283719842", async() => {
                WriteLiteral("\n    <script src=\"https://kit.fontawesome.com/a199d1b466.js\" crossorigin=\"anonymous\"></script>\n    <link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/font-awesome/4.4.0/css/font-awesome.min.css\">\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f3f527cb2b84feb6a89e2f3568e77790c0d2837110315", async() => {
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
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f3f527cb2b84feb6a89e2f3568e77790c0d2837111478", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f3f527cb2b84feb6a89e2f3568e77790c0d2837112641", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta2/css/all.min.css"" integrity=""sha512-YWzhKL2whUzgiheMoBFwW8CKV4qpHQAEuvilg9FAn5VJUDwKZZxkJNuGM4XkWuk94WCrrwslk8yWNGmY1EduTA=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />

");
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
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3f527cb2b84feb6a89e2f3568e77790c0d2837114785", async() => {
                WriteLiteral("\n    <div id=\"sides\">\n        <div class=\"tab\">\n            <button id=\"backBtn\" class=\"buttonLeft\" onclick=\"history.back(-1)\">&#8592; Back</button>\n            <p id=\"element\">&#9889; ");
#nullable restore
#line 18 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTicketsDetails.cshtml"
                               Write(Model.Ticket.IssueType);

#line default
#line hidden
#nullable disable
                WriteLiteral(" Issue</p>\n            <p id=\"element\">&#9806; TI-");
#nullable restore
#line 19 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTicketsDetails.cshtml"
                                  Write(Model.Ticket.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n        </div>\n        <hr />\n        <div id=\"sides\">\n            <div id=\"left\">\n                <i class=\"fa-light fa-ballot-check\"></i>\n                <h4 id=\"element2\"><i class=\"fa-solid fa-envelope-open-text\"></i> ");
#nullable restore
#line 25 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTicketsDetails.cshtml"
                                                                            Write(Model.Ticket.Summary);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\n                <p id=\"element1\">Priority</p>\n                <p id=\"element1\"");
                BeginWriteAttribute("style", " style=\"", 1382, "\"", 1469, 3);
                WriteAttributeValue("", 1390, "color:", 1390, 6, true);
#nullable restore
#line 27 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTicketsDetails.cshtml"
WriteAttributeValue("", 1396, Model.Ticket.Priority == Priority.Urgent.ToString() ? "red" : "green", 1396, 72, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1468, ";", 1468, 1, true);
                EndWriteAttribute();
                WriteLiteral(">&#10071;");
#nullable restore
#line 27 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTicketsDetails.cshtml"
                                                                                                                            Write(Model.Ticket.Priority);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n                <div id=\"element2\">\n                    <p>Attachments</p>\n");
#nullable restore
#line 30 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTicketsDetails.cshtml"
                     if (Model.Ticket.Attachments != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTicketsDetails.cshtml"
                         foreach (var item in Model.Ticket.Attachments)
                        {
                            var fileName = "/attachments/tickets/" + @item.Id + "." + @item.Extension;
                            

#line default
#line hidden
#nullable disable
                WriteLiteral("<i class=\"fa-solid fa-paperclip\"></i><a");
                BeginWriteAttribute("href", " href=\"", 1930, "\"", 1946, 1);
#nullable restore
#line 35 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTicketsDetails.cshtml"
WriteAttributeValue("", 1937, fileName, 1937, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" download>Download </a>\n");
#nullable restore
#line 36 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTicketsDetails.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTicketsDetails.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\n                <div id=\"element2\">\n                    <i class=\"fa-regular fa-keyboard\"></i>\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3f527cb2b84feb6a89e2f3568e77790c0d2837119247", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#nullable restore
#line 41 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTicketsDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Ticket.Description);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3f527cb2b84feb6a89e2f3568e77790c0d2837120954", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 42 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTicketsDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Ticket.Description);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </div>

            </div>

            <div id=""right"">
                <h4 id=""details"">Details</h4>
                <hr />
                <table class=""table-fill"">
                    <tbody class=""table-hover"">
                        <tr>
                            <td class=""text-left"">Assignee</td>
                            <td class=""text-left"">");
#nullable restore
#line 54 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTicketsDetails.cshtml"
                                             Write(Model.Ticket.Assignee);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                        </tr>\n                        <tr>\n                            <td class=\"text-left\">Reporter</td>\n                            <td class=\"text-left\">");
#nullable restore
#line 58 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTicketsDetails.cshtml"
                                             Write(Model.Ticket.Reporter.FullName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</td>
                        </tr>
                        <tr>
                            <td class=""text-left"">Telephone</td>
                            <td class=""text-left"">No</td>
                        <tr>
                            <td class=""text-left"">Email</td>
                            <td class=""text-left"">");
#nullable restore
#line 65 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTicketsDetails.cshtml"
                                             Write(Model.Ticket.Reporter.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                        </tr>\n                        <tr>\n                            <td class=\"text-left\">Department</td>\n                            <td class=\"text-left\">");
#nullable restore
#line 69 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTicketsDetails.cshtml"
                                             Write(Model.Ticket.Reporter.Department);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                        </tr>\n                        <tr>\n                            <td class=\"text-left\">Jobtitle</td>\n                            <td class=\"text-left\">");
#nullable restore
#line 73 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTicketsDetails.cshtml"
                                             Write(Model.Ticket.Reporter.Jobtitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                        </tr>\n                    </tbody>\n                </table>\n            </div>\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f3f527cb2b84feb6a89e2f3568e77790c0d2837125456", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#nullable restore
#line 78 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTicketsDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Ticket.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n            <h5 id=\"commentHeding\">Comments</h5>\n");
#nullable restore
#line 80 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTicketsDetails.cshtml"
             if (Model.Ticket.Comments != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTicketsDetails.cshtml"
                 foreach (var comment in Model.Ticket.Comments)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <div id=""comment"" class=""comments-container"">
                        <ul id=""comments-list"" class=""comments-list"">
                            <li>
                                <div class=""comment-main-level"">
                                    <div class=""comment-box"">
                                        <div class=""comment-head"">
                                            <h6 class=""comment-name by-author"">");
#nullable restore
#line 90 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTicketsDetails.cshtml"
                                                                          Write(comment.AddByUser);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\n                                            <span>");
#nullable restore
#line 91 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTicketsDetails.cshtml"
                                             Write(comment.CreatedOn.ToString("dd/MM/yyyy HH:mm"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                                            <i class=""fa fa-reply""></i>
                                            <i class=""fa fa-heart""></i>
                                        </div>
                                        <div class=""comment-content"">
                                            ");
#nullable restore
#line 96 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTicketsDetails.cshtml"
                                       Write(comment.Content);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                        </div>\n                                    </div>\n                                </div>\n                            </li>\n                        </ul>\n                    </div>\n");
#nullable restore
#line 103 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTicketsDetails.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 103 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTicketsDetails.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <div id='buttons'>
                <button id=""show"" style=""margin-left: 38px; margin-top: 20px;"" type=""button"" class=""btn btn-info"">Press for Comment</button>
                <button id=""hide"" type=""button"" class=""btn btn-light"">Hide</button>
            </div>

            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3f527cb2b84feb6a89e2f3568e77790c0d2837130414", async() => {
                    WriteLiteral("\n                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3f527cb2b84feb6a89e2f3568e77790c0d2837130693", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#nullable restore
#line 111 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTicketsDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Content);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\n                <input id=\"element2\" type=\"submit\" class=\"btn btn-primary\" value=\"Send\">\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_12.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_13.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_14.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_14);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-content", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 110 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTicketsDetails.cshtml"
                                                                                                WriteLiteral(Model.Content);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["content"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-content", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["content"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 110 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTicketsDetails.cshtml"
                                                                                                                                    WriteLiteral(Model.Ticket.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["ticketId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ticketId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["ticketId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n        </div>\n        <hr />\n\n    </div>\n");
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
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3f527cb2b84feb6a89e2f3568e77790c0d2837137042", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_15.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_15);
#nullable restore
#line 121 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTicketsDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ZENBEAR.Web.ViewModels.Tickets.MyTicketDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
