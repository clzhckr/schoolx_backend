#pragma checksum "C:\Users\coolz\OneDrive\Рабочий стол\ToDoAPI\ToDoAPI\Views\ToDoItemModels\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "435be020db1d84f25426fa17b40cc325b9c41053"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ToDoItemModels_Details), @"mvc.1.0.view", @"/Views/ToDoItemModels/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"435be020db1d84f25426fa17b40cc325b9c41053", @"/Views/ToDoItemModels/Details.cshtml")]
    public class Views_ToDoItemModels_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ToDoAPI.Models.ToDoItemModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\coolz\OneDrive\Рабочий стол\ToDoAPI\ToDoAPI\Views\ToDoItemModels\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Details</h1>\n\n<div>\n    <h4>ToDoItemModel</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 14 "C:\Users\coolz\OneDrive\Рабочий стол\ToDoAPI\ToDoAPI\Views\ToDoItemModels\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ItemName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 17 "C:\Users\coolz\OneDrive\Рабочий стол\ToDoAPI\ToDoAPI\Views\ToDoItemModels\Details.cshtml"
       Write(Html.DisplayFor(model => model.ItemName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 20 "C:\Users\coolz\OneDrive\Рабочий стол\ToDoAPI\ToDoAPI\Views\ToDoItemModels\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ItemDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 23 "C:\Users\coolz\OneDrive\Рабочий стол\ToDoAPI\ToDoAPI\Views\ToDoItemModels\Details.cshtml"
       Write(Html.DisplayFor(model => model.ItemDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 26 "C:\Users\coolz\OneDrive\Рабочий стол\ToDoAPI\ToDoAPI\Views\ToDoItemModels\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ItemStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 29 "C:\Users\coolz\OneDrive\Рабочий стол\ToDoAPI\ToDoAPI\Views\ToDoItemModels\Details.cshtml"
       Write(Html.DisplayFor(model => model.ItemStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 841, "\"", 869, 1);
#nullable restore
#line 34 "C:\Users\coolz\OneDrive\Рабочий стол\ToDoAPI\ToDoAPI\Views\ToDoItemModels\Details.cshtml"
WriteAttributeValue("", 856, Model.ItemId, 856, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\n    <a asp-action=\"Index\">Back to List</a>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ToDoAPI.Models.ToDoItemModel> Html { get; private set; }
    }
}
#pragma warning restore 1591