// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorAPP.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "D:\JetBrainsRider\BlazorAPP\BlazorAPP\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\JetBrainsRider\BlazorAPP\BlazorAPP\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\JetBrainsRider\BlazorAPP\BlazorAPP\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\JetBrainsRider\BlazorAPP\BlazorAPP\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\JetBrainsRider\BlazorAPP\BlazorAPP\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\JetBrainsRider\BlazorAPP\BlazorAPP\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\JetBrainsRider\BlazorAPP\BlazorAPP\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\JetBrainsRider\BlazorAPP\BlazorAPP\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\JetBrainsRider\BlazorAPP\BlazorAPP\_Imports.razor"
using BlazorAPP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\JetBrainsRider\BlazorAPP\BlazorAPP\_Imports.razor"
using BlazorAPP.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\JetBrainsRider\BlazorAPP\BlazorAPP\Pages\AddToy.razor"
using BlazorAPP.DataService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\JetBrainsRider\BlazorAPP\BlazorAPP\Pages\AddToy.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\JetBrainsRider\BlazorAPP\BlazorAPP\Pages\AddToy.razor"
using BlazorAPP.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddToy")]
    public partial class AddToy : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "D:\JetBrainsRider\BlazorAPP\BlazorAPP\Pages\AddToy.razor"
       
    private Data.Toy toy = new Data.Toy();

    private string name = "";

    private IList<Data.Child> _children = new List<Data.Child>();

    private ToyService _service = new ToyService();

    private ChildService _services = new ChildService();

    protected async override Task OnInitializedAsync()
    {
        _children = await _services.GetChildren();
    }


    public async Task addToy()
    {
        toy.Name=name;
        
        await _service.AddToy(toy,toy.Id);

    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
