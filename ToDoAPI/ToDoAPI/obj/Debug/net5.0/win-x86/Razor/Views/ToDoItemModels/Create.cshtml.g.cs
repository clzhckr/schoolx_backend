#pragma checksum "C:\Docs\GitHub\schoolx_backend\ToDoAPI\ToDoAPI\Views\ToDoItemModels\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc9b71b05bb59f904383916f703c5a75bc2da547"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ToDoItemModels_Create), @"mvc.1.0.view", @"/Views/ToDoItemModels/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc9b71b05bb59f904383916f703c5a75bc2da547", @"/Views/ToDoItemModels/Create.cshtml")]
    public class Views_ToDoItemModels_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ToDoAPI.Models.ToDoItemModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Docs\GitHub\schoolx_backend\ToDoAPI\ToDoAPI\Views\ToDoItemModels\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>ToDoItemModel</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""ItemName"" class=""control-label""></label>
                <input asp-for=""ItemName"" class=""form-control"" />
                <span asp-validation-for=""ItemName"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ItemDescription"" class=""control-label""></label>
                <input asp-for=""ItemDescription"" class=""form-control"" />
                <span asp-validation-for=""ItemDescription"" class=""text-danger""></span>
            </div>
            <div class=""form-group form-check"">
                <label class=""form-check-label"">
                    <input class=""form-check-input"" asp-for=""ItemStatus"" /> ");
#nullable restore
#line 27 "C:\Docs\GitHub\schoolx_backend\ToDoAPI\ToDoAPI\Views\ToDoItemModels\Create.cshtml"
                                                                       Write(Html.DisplayNameFor(model => model.ItemStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </label>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 42 "C:\Docs\GitHub\schoolx_backend\ToDoAPI\ToDoAPI\Views\ToDoItemModels\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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