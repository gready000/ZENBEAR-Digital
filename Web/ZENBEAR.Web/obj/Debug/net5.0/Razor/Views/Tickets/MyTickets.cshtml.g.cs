#pragma checksum "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4401e395d03bbf1a499cafd47afd8cd7612eebf"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4401e395d03bbf1a499cafd47afd8cd7612eebf", @"/Views/Tickets/MyTickets.cshtml")]
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e4401e395d03bbf1a499cafd47afd8cd7612eebf6129", async() => {
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
#line 5 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e4401e395d03bbf1a499cafd47afd8cd7612eebf8055", async() => {
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
            WriteLiteral("\n\n");
#nullable restore
#line 8 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
  
    this.ViewData["Title"] = "My Tickets";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"row\">\n    <div id=\"admin\" class=\"col s12\">\n        <div class=\"card material-table\">\n            <div class=\"table-header\">\n                <span class=\"table-title\">");
#nullable restore
#line 16 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
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
#line 30 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                     foreach (var ticket in Model.MyTickets)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr id=\"li\">\n                            <td style=\"width: 5%; \">");
#nullable restore
#line 33 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                                               Write(ticket.IssueType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td style=\"width: 5%; \">TI-");
#nullable restore
#line 34 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                                                  Write(ticket.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td style=\"max-width: 150px; width: 30%\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1463, "\"", 1559, 5);
            WriteAttributeValue("", 1473, "location.href", 1473, 13, true);
            WriteAttributeValue(" ", 1486, "=", 1487, 2, true);
            WriteAttributeValue(" ", 1488, "\'", 1489, 2, true);
#nullable restore
#line 35 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
WriteAttributeValue("", 1490, Url.Action("MyTicketsDetails", "Tickets", new { Id = ticket.Id }), 1490, 68, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1558, "\'", 1558, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 35 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                                                                                                                                                                 Write(ticket.Summary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td style=\"width: 12%\">");
#nullable restore
#line 36 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                                              Write(ticket.CreateOn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td style=\"width: 22%\">");
#nullable restore
#line 37 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                                              Write(ticket.Assignee);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td style=\"width: 14%\">\n");
#nullable restore
#line 39 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                                 if (ticket.Status == "Closed")
                                {
                                    if (ticket.Rate != null)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"rating\">\n                                            <div class=\"stars\">\n");
#nullable restore
#line 45 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                                                 for (int i = 5; i >= 1; i--)
                                                {
                                                    if (@i <= ticket.Rate)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <input type=\"radio\" class=\"starfill\" name=\"rating\" disabled/>\n");
#nullable restore
#line 50 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <input type=\"radio\" class=\"star\" name=\"rating\" disabled/>\n");
#nullable restore
#line 54 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                                                    }
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </div>\n                                        </div>\n");
#nullable restore
#line 58 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"rating\">\n                                            <div class=\"stars\">\n                                                <input");
            BeginWriteAttribute("onclick", " onclick=\"", 3254, "\"", 3293, 3);
            WriteAttributeValue("", 3264, "postToController(", 3264, 17, true);
#nullable restore
#line 63 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
WriteAttributeValue("", 3281, ticket.Id, 3281, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3291, ");", 3291, 2, true);
            EndWriteAttribute();
            WriteLiteral(" type=\"radio\" class=\"star\" name=\"rating\" value=\"5\" />\n                                                <input");
            BeginWriteAttribute("onclick", " onclick=\"", 3402, "\"", 3441, 3);
            WriteAttributeValue("", 3412, "postToController(", 3412, 17, true);
#nullable restore
#line 64 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
WriteAttributeValue("", 3429, ticket.Id, 3429, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3439, ");", 3439, 2, true);
            EndWriteAttribute();
            WriteLiteral(" type=\"radio\" class=\"star\" name=\"rating\" value=\"4\" />\n                                                <input");
            BeginWriteAttribute("onclick", " onclick=\"", 3550, "\"", 3589, 3);
            WriteAttributeValue("", 3560, "postToController(", 3560, 17, true);
#nullable restore
#line 65 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
WriteAttributeValue("", 3577, ticket.Id, 3577, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3587, ");", 3587, 2, true);
            EndWriteAttribute();
            WriteLiteral(" type=\"radio\" class=\"star\" name=\"rating\" value=\"3\" />\n                                                <input");
            BeginWriteAttribute("onclick", " onclick=\"", 3698, "\"", 3737, 3);
            WriteAttributeValue("", 3708, "postToController(", 3708, 17, true);
#nullable restore
#line 66 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
WriteAttributeValue("", 3725, ticket.Id, 3725, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3735, ");", 3735, 2, true);
            EndWriteAttribute();
            WriteLiteral(" type=\"radio\" class=\"star\" name=\"rating\" value=\"2\" />\n                                                <input");
            BeginWriteAttribute("onclick", " onclick=\"", 3846, "\"", 3885, 3);
            WriteAttributeValue("", 3856, "postToController(", 3856, 17, true);
#nullable restore
#line 67 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
WriteAttributeValue("", 3873, ticket.Id, 3873, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3883, ");", 3883, 2, true);
            EndWriteAttribute();
            WriteLiteral(" type=\"radio\" class=\"star\" name=\"rating\" value=\"1\" />\n                                            </div>\n                                        </div>\n");
#nullable restore
#line 70 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                                    }
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div style=\"padding-left: 13px; color: yellowgreen\">");
#nullable restore
#line 74 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                                                                                   Write(ticket.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
#nullable restore
#line 75 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\n                        </tr>\n");
#nullable restore
#line 78 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\n            </table>\n\n            <nav aria-label=\"...\" style=\"margin-left: 10px; margin-top: 5px;\">\n                <ul class=\"pagination\">\n                    <li");
            BeginWriteAttribute("class", " class=\"", 4599, "\"", 4671, 2);
            WriteAttributeValue("", 4607, "page-item", 4607, 9, true);
            WriteAttributeValue(" ", 4616, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 84 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                                          if (!Model.HasPreviousPage) { 

#line default
#line hidden
#nullable disable
                WriteLiteral("disabled");
#nullable restore
#line 84 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                                                                                              }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 4617, 54, false);
            EndWriteAttribute();
            WriteLiteral(">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4401e395d03bbf1a499cafd47afd8cd7612eebf22109", async() => {
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
#line 85 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
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
#line 87 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                     for (int i = Model.PageNumber - 2; i < Model.PageNumber; i++)
                    {
                        if (i > 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"page-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4401e395d03bbf1a499cafd47afd8cd7612eebf24806", async() => {
#nullable restore
#line 91 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
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
#line 91 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
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
#line 92 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"page-item active\" aria-current=\"page\">\n                        <span class=\"page-link\">\n                            ");
#nullable restore
#line 96 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                       Write(Model.PageNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            <span class=\"sr-only\">(current)</span>\n                        </span>\n                    </li>\n");
#nullable restore
#line 100 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                     for (int i = Model.PageNumber + 1; i <= Model.PageNumber + 2; i++)
                    {
                        if (i <= Model.PagesCount)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"page-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4401e395d03bbf1a499cafd47afd8cd7612eebf28516", async() => {
#nullable restore
#line 104 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
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
#line 104 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
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
#line 105 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li");
            BeginWriteAttribute("class", " class=\"", 5832, "\"", 5900, 2);
            WriteAttributeValue("", 5840, "page-item", 5840, 9, true);
            WriteAttributeValue(" ", 5849, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 107 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                                          if (!Model.HasNextPage) { 

#line default
#line hidden
#nullable disable
                WriteLiteral("disabled");
#nullable restore
#line 107 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
                                                                                          }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 5850, 50, false);
            EndWriteAttribute();
            WriteLiteral(">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4401e395d03bbf1a499cafd47afd8cd7612eebf32329", async() => {
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
#line 108 "/Users/emilanov/Downloads/ZENBEAR-Digital/Web/ZENBEAR.Web/Views/Tickets/MyTickets.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4401e395d03bbf1a499cafd47afd8cd7612eebf34690", async() => {
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
<script>function postToController(ticketId) {
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
    }</script>");
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
