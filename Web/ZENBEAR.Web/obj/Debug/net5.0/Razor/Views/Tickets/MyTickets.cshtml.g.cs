#pragma checksum "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52c463f7adf31bc45476f8e62e1994c32ea03d7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tickets_MyTickets), @"mvc.1.0.view", @"/Views/Tickets/MyTickets.cshtml")]
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
#line 2 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
using ZENBEAR.Data.Models.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52c463f7adf31bc45476f8e62e1994c32ea03d7e", @"/Views/Tickets/MyTickets.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a0d0a8912d6b7039b508ebdc8e78d4dc60e9209", @"/Views/_ViewImports.cshtml")]
    public class Views_Tickets_MyTickets : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ZENBEAR.Web.ViewModels.Tickets.AllMyTicketsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", "~/css/allticketstable.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", "~/css/rate.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MyTickets", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("antiForgeryForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<script src=\"https://kit.fontawesome.com/a199d1b466.js\" crossorigin=\"anonymous\"></script>\n<link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/font-awesome/4.4.0/css/font-awesome.min.css\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "52c463f7adf31bc45476f8e62e1994c32ea03d7e6325", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 6 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "52c463f7adf31bc45476f8e62e1994c32ea03d7e8251", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 7 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
#nullable restore
#line 9 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
 if (this.TempData.ContainsKey("Message"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\">");
#nullable restore
#line 11 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                                Write(this.TempData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
#nullable restore
#line 12 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 14 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
  
    this.ViewData["Title"] = "My Tickets";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"row\">\n    <div id=\"admin\" class=\"col s12\">\n        <div class=\"card material-table\">\n            <div class=\"table-header\">\n                <span class=\"table-title\">");
#nullable restore
#line 22 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                                     Write(this.ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
            </div>
            <table id=""datatable"">
                <thead>
                    <tr>
                        <th>Issue Type</th>
                        <th>Key</th>
                        <th>Summary</th>
                        <th>Create On</th>
                        <th>Assignee</th>
                        <th style=""padding-left: 11px;"">Rating</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 36 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                     foreach (var ticket in Model.MyTickets)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr id=\"li\">\n                            <td style=\"width: 5%; \">");
#nullable restore
#line 39 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                                               Write(ticket.IssueType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td style=\"width: 5%; \">TI-");
#nullable restore
#line 40 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                                                  Write(ticket.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td style=\"max-width: 150px; width: 30%\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1613, "\"", 1709, 5);
            WriteAttributeValue("", 1623, "location.href", 1623, 13, true);
            WriteAttributeValue(" ", 1636, "=", 1637, 2, true);
            WriteAttributeValue(" ", 1638, "\'", 1639, 2, true);
#nullable restore
#line 41 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
WriteAttributeValue("", 1640, Url.Action("MyTicketsDetails", "Tickets", new { Id = ticket.Id }), 1640, 68, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1708, "\'", 1708, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 41 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                                                                                                                                                                 Write(ticket.Summary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td style=\"width: 12%\">");
#nullable restore
#line 42 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                                              Write(ticket.CreateOn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td style=\"width: 22%\">");
#nullable restore
#line 43 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                                              Write(ticket.Assignee);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td style=\"width: 14%\">\n");
#nullable restore
#line 45 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                                 if (ticket.Status == Status.Closed.ToString())
                                {
                                    if (ticket.Rate != null)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"rating\">\n                                            <div class=\"stars\">\n");
#nullable restore
#line 51 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                                                 for (int i = 5; i >= 1; i--)
                                                {
                                                    if (@i <= ticket.Rate)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <input type=\"radio\" class=\"starfill\" name=\"rating\" disabled />\n");
#nullable restore
#line 56 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <input type=\"radio\" class=\"star\" name=\"rating\" disabled />\n");
#nullable restore
#line 60 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                                                    }
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </div>\n                                        </div>\n");
#nullable restore
#line 64 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"rating\">\n                                            <div class=\"stars\">\n                                                <input");
            BeginWriteAttribute("onclick", " onclick=\"", 3422, "\"", 3461, 3);
            WriteAttributeValue("", 3432, "postToController(", 3432, 17, true);
#nullable restore
#line 69 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
WriteAttributeValue("", 3449, ticket.Id, 3449, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3459, ");", 3459, 2, true);
            EndWriteAttribute();
            WriteLiteral(" type=\"radio\" class=\"star\" name=\"rating\" value=\"5\" />\n                                                <input");
            BeginWriteAttribute("onclick", " onclick=\"", 3570, "\"", 3609, 3);
            WriteAttributeValue("", 3580, "postToController(", 3580, 17, true);
#nullable restore
#line 70 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
WriteAttributeValue("", 3597, ticket.Id, 3597, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3607, ");", 3607, 2, true);
            EndWriteAttribute();
            WriteLiteral(" type=\"radio\" class=\"star\" name=\"rating\" value=\"4\" />\n                                                <input");
            BeginWriteAttribute("onclick", " onclick=\"", 3718, "\"", 3757, 3);
            WriteAttributeValue("", 3728, "postToController(", 3728, 17, true);
#nullable restore
#line 71 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
WriteAttributeValue("", 3745, ticket.Id, 3745, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3755, ");", 3755, 2, true);
            EndWriteAttribute();
            WriteLiteral(" type=\"radio\" class=\"star\" name=\"rating\" value=\"3\" />\n                                                <input");
            BeginWriteAttribute("onclick", " onclick=\"", 3866, "\"", 3905, 3);
            WriteAttributeValue("", 3876, "postToController(", 3876, 17, true);
#nullable restore
#line 72 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
WriteAttributeValue("", 3893, ticket.Id, 3893, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3903, ");", 3903, 2, true);
            EndWriteAttribute();
            WriteLiteral(" type=\"radio\" class=\"star\" name=\"rating\" value=\"2\" />\n                                                <input");
            BeginWriteAttribute("onclick", " onclick=\"", 4014, "\"", 4053, 3);
            WriteAttributeValue("", 4024, "postToController(", 4024, 17, true);
#nullable restore
#line 73 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
WriteAttributeValue("", 4041, ticket.Id, 4041, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4051, ");", 4051, 2, true);
            EndWriteAttribute();
            WriteLiteral(" type=\"radio\" class=\"star\" name=\"rating\" value=\"1\" />\n                                            </div>\n                                        </div>\n");
#nullable restore
#line 76 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                                    }
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div style=\"padding-left: 13px; color: yellowgreen\">");
#nullable restore
#line 80 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                                                                                   Write(ticket.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
#nullable restore
#line 81 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\n                        </tr>\n");
#nullable restore
#line 84 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\n            </table>\n\n            <nav aria-label=\"...\" style=\"margin-left: 10px; margin-top: 5px;\">\n                <ul class=\"pagination\">\n                    <li");
            BeginWriteAttribute("class", " class=\"", 4767, "\"", 4839, 2);
            WriteAttributeValue("", 4775, "page-item", 4775, 9, true);
            WriteAttributeValue(" ", 4784, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 90 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                                          if (!Model.HasPreviousPage) { 

#line default
#line hidden
#nullable disable
                WriteLiteral("disabled");
#nullable restore
#line 90 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                                                                                              }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 4785, 54, false);
            EndWriteAttribute();
            WriteLiteral(">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52c463f7adf31bc45476f8e62e1994c32ea03d7e23066", async() => {
                WriteLiteral("Previous");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 91 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                                                                      WriteLiteral(Model.PreviousPageNumber);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </li>\n");
#nullable restore
#line 93 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                     for (int i = Model.PageNumber - 2; i < Model.PageNumber; i++)
                    {
                        if (i > 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"page-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52c463f7adf31bc45476f8e62e1994c32ea03d7e25763", async() => {
#nullable restore
#line 97 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                                                                                                           Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 97 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                                                                                                WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\n");
#nullable restore
#line 98 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"page-item active\" aria-current=\"page\">\n                        <span class=\"page-link\">\n                            ");
#nullable restore
#line 102 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                       Write(Model.PageNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            <span class=\"sr-only\">(current)</span>\n                        </span>\n                    </li>\n");
#nullable restore
#line 106 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                     for (int i = Model.PageNumber + 1; i <= Model.PageNumber + 2; i++)
                    {
                        if (i <= Model.PagesCount)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"page-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52c463f7adf31bc45476f8e62e1994c32ea03d7e29474", async() => {
#nullable restore
#line 110 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                                                                                                           Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 110 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                                                                                                WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\n");
#nullable restore
#line 111 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li");
            BeginWriteAttribute("class", " class=\"", 6000, "\"", 6068, 2);
            WriteAttributeValue("", 6008, "page-item", 6008, 9, true);
            WriteAttributeValue(" ", 6017, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 113 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                                          if (!Model.HasNextPage) { 

#line default
#line hidden
#nullable disable
                WriteLiteral("disabled");
#nullable restore
#line 113 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                                                                                          }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 6018, 50, false);
            EndWriteAttribute();
            WriteLiteral(">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52c463f7adf31bc45476f8e62e1994c32ea03d7e33287", async() => {
                WriteLiteral("Next");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 114 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                                                                      WriteLiteral(Model.NextPageNumber);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </li>\n                </ul>\n            </nav>\n\n        </div>\n    </div>\n</div>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52c463f7adf31bc45476f8e62e1994c32ea03d7e35648", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    function postToController(ticketId) {
        var ratingValue = 0;
        for (i = 0; i < document.getElementsByName('rating').length; i++) {
            if (document.getElementsByName('rating')[i].checked == true) {
                ratingValue = document.getElementsByName('rating')[i].value;
                console.log(ratingValue);
                break;
            }
        }

        var antiForgeryToken = $('#antiForgeryForm input[name=__RequestVerificationToken]').val();
        var data = { ticketId: ticketId, value: ratingValue };

        $.ajax({
            type: ""POST"",
            url: ""/api/Rates"",
            data: JSON.stringify(data),
            headers: {
                'X-CSRF-TOKEN': antiForgeryToken
            },
            success: function (data) {
                console.log(data.value);
            },
            contentType: 'application/json',
        });
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ZENBEAR.Web.ViewModels.Tickets.AllMyTicketsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
