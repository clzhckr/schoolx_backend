#pragma checksum "C:\Users\coolz\OneDrive\Рабочий стол\ToDoAPI\ToDoAPI\Views\ToDoItemModels\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3472fa3fcb6c543b8dd970ae592e2bd3808ba5ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ToDoItemModels_Index), @"mvc.1.0.view", @"/Views/ToDoItemModels/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3472fa3fcb6c543b8dd970ae592e2bd3808ba5ec", @"/Views/ToDoItemModels/Index.cshtml")]
    public class Views_ToDoItemModels_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ToDoAPI.Models.ToDoItemModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\coolz\OneDrive\Рабочий стол\ToDoAPI\ToDoAPI\Views\ToDoItemModels\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Index</h1>\n\n<p>\n    <a asp-action=\"Create\">Create New</a>\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 16 "C:\Users\coolz\OneDrive\Рабочий стол\ToDoAPI\ToDoAPI\Views\ToDoItemModels\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ItemName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 19 "C:\Users\coolz\OneDrive\Рабочий стол\ToDoAPI\ToDoAPI\Views\ToDoItemModels\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ItemDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 22 "C:\Users\coolz\OneDrive\Рабочий стол\ToDoAPI\ToDoAPI\Views\ToDoItemModels\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ItemStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 28 "C:\Users\coolz\OneDrive\Рабочий стол\ToDoAPI\ToDoAPI\Views\ToDoItemModels\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 31 "C:\Users\coolz\OneDrive\Рабочий стол\ToDoAPI\ToDoAPI\Views\ToDoItemModels\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ItemName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 34 "C:\Users\coolz\OneDrive\Рабочий стол\ToDoAPI\ToDoAPI\Views\ToDoItemModels\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ItemDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 37 "C:\Users\coolz\OneDrive\Рабочий стол\ToDoAPI\ToDoAPI\Views\ToDoItemModels\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ItemStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 958, "\"", 985, 1);
#nullable restore
#line 40 "C:\Users\coolz\OneDrive\Рабочий стол\ToDoAPI\ToDoAPI\Views\ToDoItemModels\Index.cshtml"
WriteAttributeValue("", 973, item.ItemId, 973, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1037, "\"", 1064, 1);
#nullable restore
#line 41 "C:\Users\coolz\OneDrive\Рабочий стол\ToDoAPI\ToDoAPI\Views\ToDoItemModels\Index.cshtml"
WriteAttributeValue("", 1052, item.ItemId, 1052, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1118, "\"", 1145, 1);
#nullable restore
#line 42 "C:\Users\coolz\OneDrive\Рабочий стол\ToDoAPI\ToDoAPI\Views\ToDoItemModels\Index.cshtml"
WriteAttributeValue("", 1133, item.ItemId, 1133, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\n            </td>\n        </tr>\n");
#nullable restore
#line 45 "C:\Users\coolz\OneDrive\Рабочий стол\ToDoAPI\ToDoAPI\Views\ToDoItemModels\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ToDoAPI.Models.ToDoItemModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
