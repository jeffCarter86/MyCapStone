#pragma checksum "C:\Users\uglym\Downloads\MyCapStonemain\MyCapStone-64eee702fa0ef9852a6c82295e97f1020219986f\RoadTrip\Views\Travelers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf15d552725aea14961de6a7c29899c35ae4577f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Travelers_Index), @"mvc.1.0.view", @"/Views/Travelers/Index.cshtml")]
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
#line 1 "C:\Users\uglym\Downloads\MyCapStonemain\MyCapStone-64eee702fa0ef9852a6c82295e97f1020219986f\RoadTrip\Views\_ViewImports.cshtml"
using RoadTrip;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\uglym\Downloads\MyCapStonemain\MyCapStone-64eee702fa0ef9852a6c82295e97f1020219986f\RoadTrip\Views\_ViewImports.cshtml"
using RoadTrip.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf15d552725aea14961de6a7c29899c35ae4577f", @"/Views/Travelers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6f8384b89d04cd18a1e48eab4998d64bcb2ec15", @"/Views/_ViewImports.cshtml")]
    public class Views_Travelers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RoadTrip.Models.Traveler>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Route", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\uglym\Downloads\MyCapStonemain\MyCapStone-64eee702fa0ef9852a6c82295e97f1020219986f\RoadTrip\Views\Travelers\Index.cshtml"
   ViewData["Title"] = "Index"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1 align=\"center\">Master Trip List</h1>\n\n<p align=\"center\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf15d552725aea14961de6a7c29899c35ae4577f5103", async() => {
                WriteLiteral("Create New Trip");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" - ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf15d552725aea14961de6a7c29899c35ae4577f6266", async() => {
                WriteLiteral("Routes & More");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 14 "C:\Users\uglym\Downloads\MyCapStonemain\MyCapStone-64eee702fa0ef9852a6c82295e97f1020219986f\RoadTrip\Views\Travelers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 17 "C:\Users\uglym\Downloads\MyCapStonemain\MyCapStone-64eee702fa0ef9852a6c82295e97f1020219986f\RoadTrip\Views\Travelers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.From));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 20 "C:\Users\uglym\Downloads\MyCapStonemain\MyCapStone-64eee702fa0ef9852a6c82295e97f1020219986f\RoadTrip\Views\Travelers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.To));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 23 "C:\Users\uglym\Downloads\MyCapStonemain\MyCapStone-64eee702fa0ef9852a6c82295e97f1020219986f\RoadTrip\Views\Travelers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Distance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 26 "C:\Users\uglym\Downloads\MyCapStonemain\MyCapStone-64eee702fa0ef9852a6c82295e97f1020219986f\RoadTrip\Views\Travelers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Stops));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 29 "C:\Users\uglym\Downloads\MyCapStonemain\MyCapStone-64eee702fa0ef9852a6c82295e97f1020219986f\RoadTrip\Views\Travelers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GasCost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 32 "C:\Users\uglym\Downloads\MyCapStonemain\MyCapStone-64eee702fa0ef9852a6c82295e97f1020219986f\RoadTrip\Views\Travelers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SnackCost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 35 "C:\Users\uglym\Downloads\MyCapStonemain\MyCapStone-64eee702fa0ef9852a6c82295e97f1020219986f\RoadTrip\Views\Travelers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Emergency));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 38 "C:\Users\uglym\Downloads\MyCapStonemain\MyCapStone-64eee702fa0ef9852a6c82295e97f1020219986f\RoadTrip\Views\Travelers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TripCost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 41 "C:\Users\uglym\Downloads\MyCapStonemain\MyCapStone-64eee702fa0ef9852a6c82295e97f1020219986f\RoadTrip\Views\Travelers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MonthBudget));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 44 "C:\Users\uglym\Downloads\MyCapStonemain\MyCapStone-64eee702fa0ef9852a6c82295e97f1020219986f\RoadTrip\Views\Travelers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BudgetMonth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 50 "C:\Users\uglym\Downloads\MyCapStonemain\MyCapStone-64eee702fa0ef9852a6c82295e97f1020219986f\RoadTrip\Views\Travelers\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>\n        ");
#nullable restore
#line 54 "C:\Users\uglym\Downloads\MyCapStonemain\MyCapStone-64eee702fa0ef9852a6c82295e97f1020219986f\RoadTrip\Views\Travelers\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 57 "C:\Users\uglym\Downloads\MyCapStonemain\MyCapStone-64eee702fa0ef9852a6c82295e97f1020219986f\RoadTrip\Views\Travelers\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.From));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 60 "C:\Users\uglym\Downloads\MyCapStonemain\MyCapStone-64eee702fa0ef9852a6c82295e97f1020219986f\RoadTrip\Views\Travelers\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.To));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 63 "C:\Users\uglym\Downloads\MyCapStonemain\MyCapStone-64eee702fa0ef9852a6c82295e97f1020219986f\RoadTrip\Views\Travelers\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Distance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 66 "C:\Users\uglym\Downloads\MyCapStonemain\MyCapStone-64eee702fa0ef9852a6c82295e97f1020219986f\RoadTrip\Views\Travelers\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Stops));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 69 "C:\Users\uglym\Downloads\MyCapStonemain\MyCapStone-64eee702fa0ef9852a6c82295e97f1020219986f\RoadTrip\Views\Travelers\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.GasCost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 72 "C:\Users\uglym\Downloads\MyCapStonemain\MyCapStone-64eee702fa0ef9852a6c82295e97f1020219986f\RoadTrip\Views\Travelers\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.SnackCost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 75 "C:\Users\uglym\Downloads\MyCapStonemain\MyCapStone-64eee702fa0ef9852a6c82295e97f1020219986f\RoadTrip\Views\Travelers\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Emergency));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 78 "C:\Users\uglym\Downloads\MyCapStonemain\MyCapStone-64eee702fa0ef9852a6c82295e97f1020219986f\RoadTrip\Views\Travelers\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.TripCost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 81 "C:\Users\uglym\Downloads\MyCapStonemain\MyCapStone-64eee702fa0ef9852a6c82295e97f1020219986f\RoadTrip\Views\Travelers\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.MonthBudget));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 84 "C:\Users\uglym\Downloads\MyCapStonemain\MyCapStone-64eee702fa0ef9852a6c82295e97f1020219986f\RoadTrip\Views\Travelers\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.BudgetMonth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf15d552725aea14961de6a7c29899c35ae4577f15443", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 87 "C:\Users\uglym\Downloads\MyCapStonemain\MyCapStone-64eee702fa0ef9852a6c82295e97f1020219986f\RoadTrip\Views\Travelers\Index.cshtml"
                               WriteLiteral(item.Id);

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
            WriteLiteral(" |\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf15d552725aea14961de6a7c29899c35ae4577f17641", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 88 "C:\Users\uglym\Downloads\MyCapStonemain\MyCapStone-64eee702fa0ef9852a6c82295e97f1020219986f\RoadTrip\Views\Travelers\Index.cshtml"
                                  WriteLiteral(item.Id);

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
            WriteLiteral(" |\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf15d552725aea14961de6a7c29899c35ae4577f19845", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 89 "C:\Users\uglym\Downloads\MyCapStonemain\MyCapStone-64eee702fa0ef9852a6c82295e97f1020219986f\RoadTrip\Views\Travelers\Index.cshtml"
                                 WriteLiteral(item.Id);

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
            WriteLiteral("\n    </td>\n</tr>");
#nullable restore
#line 91 "C:\Users\uglym\Downloads\MyCapStonemain\MyCapStone-64eee702fa0ef9852a6c82295e97f1020219986f\RoadTrip\Views\Travelers\Index.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n\n\n   ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RoadTrip.Models.Traveler>> Html { get; private set; }
    }
}
#pragma warning restore 1591
