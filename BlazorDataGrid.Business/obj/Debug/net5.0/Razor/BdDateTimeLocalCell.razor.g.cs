#pragma checksum "C:\git\BlazorDataGrid\BlazorDataGrid.Business\BdDateTimeLocalCell.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5dc1a926d56cc660993af8118d4fc3afc944a594"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorDataGrid.Business
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\git\BlazorDataGrid\BlazorDataGrid.Business\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
    public partial class BdDateTimeLocalCell : BdInputCell
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 2 "C:\git\BlazorDataGrid\BlazorDataGrid.Business\BdDateTimeLocalCell.razor"
  
    var dt = Value as DateTime?;

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "input");
            __builder.AddAttribute(1, "type", "datetime-local");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\git\BlazorDataGrid\BlazorDataGrid.Business\BdDateTimeLocalCell.razor"
                   () => TypedValueChanged(dt)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "disabled", 
#nullable restore
#line 8 "C:\git\BlazorDataGrid\BlazorDataGrid.Business\BdDateTimeLocalCell.razor"
                   !IsEditable

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(4, "style", 
#nullable restore
#line 9 "C:\git\BlazorDataGrid\BlazorDataGrid.Business\BdDateTimeLocalCell.razor"
               Style

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(5, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 6 "C:\git\BlazorDataGrid\BlazorDataGrid.Business\BdDateTimeLocalCell.razor"
              dt

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-ddTHH:mm:ss", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(6, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => dt = __value, dt, format: "yyyy-MM-ddTHH:mm:ss", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
