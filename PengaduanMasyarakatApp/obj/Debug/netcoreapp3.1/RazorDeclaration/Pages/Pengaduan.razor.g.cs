// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PengaduanMasyarakatApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Ecep\Project\Projek C#\Blazor\PengaduanMasyarakatApp\PengaduanMasyarakatApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Ecep\Project\Projek C#\Blazor\PengaduanMasyarakatApp\PengaduanMasyarakatApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Ecep\Project\Projek C#\Blazor\PengaduanMasyarakatApp\PengaduanMasyarakatApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Ecep\Project\Projek C#\Blazor\PengaduanMasyarakatApp\PengaduanMasyarakatApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Ecep\Project\Projek C#\Blazor\PengaduanMasyarakatApp\PengaduanMasyarakatApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Ecep\Project\Projek C#\Blazor\PengaduanMasyarakatApp\PengaduanMasyarakatApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Ecep\Project\Projek C#\Blazor\PengaduanMasyarakatApp\PengaduanMasyarakatApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Ecep\Project\Projek C#\Blazor\PengaduanMasyarakatApp\PengaduanMasyarakatApp\_Imports.razor"
using PengaduanMasyarakatApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Ecep\Project\Projek C#\Blazor\PengaduanMasyarakatApp\PengaduanMasyarakatApp\_Imports.razor"
using PengaduanMasyarakatApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Ecep\Project\Projek C#\Blazor\PengaduanMasyarakatApp\PengaduanMasyarakatApp\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Ecep\Project\Projek C#\Blazor\PengaduanMasyarakatApp\PengaduanMasyarakatApp\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Ecep\Project\Projek C#\Blazor\PengaduanMasyarakatApp\PengaduanMasyarakatApp\Pages\Pengaduan.razor"
using PengaduanMasyarakatApp.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Ecep\Project\Projek C#\Blazor\PengaduanMasyarakatApp\PengaduanMasyarakatApp\Pages\Pengaduan.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/pengaduan")]
    public partial class Pengaduan : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 216 "E:\Ecep\Project\Projek C#\Blazor\PengaduanMasyarakatApp\PengaduanMasyarakatApp\Pages\Pengaduan.razor"
       

    private string a = "fetchdata";
    public DateTime TglNow
    {
        get
        {

            return DateTime.Now;

        }

        set
        {

        }
    }

    void ShowTooltip(ElementReference elementReference, string text, TooltipOptions options = null)
        => tooltipService.Open(elementReference, text, options);

    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TooltipService tooltipService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
