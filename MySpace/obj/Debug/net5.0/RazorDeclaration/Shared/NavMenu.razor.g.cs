// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MySpace.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace_v3.0\MySpace\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace_v3.0\MySpace\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace_v3.0\MySpace\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace_v3.0\MySpace\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace_v3.0\MySpace\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace_v3.0\MySpace\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace_v3.0\MySpace\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace_v3.0\MySpace\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace_v3.0\MySpace\_Imports.razor"
using MySpace;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace_v3.0\MySpace\_Imports.razor"
using MySpace.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace_v3.0\MySpace\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace_v3.0\MySpace\Shared\NavMenu.razor"
using MySpace.Models;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : MainLayout
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 108 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace_v3.0\MySpace\Shared\NavMenu.razor"
       

    bool open;

    void ToggleDrawer()
    {
        open = !open;
    }

    public string Search { get; set; }
    public string stringValue { get; set; }
    public string val { get; set; }




    MySpaceDbContext db = new MySpaceDbContext();

    List<PrsnlSpace> prsnl = new List<PrsnlSpace>();


    protected override void OnInitialized()
    {
        prsnl = db.PrsnlSpaces.ToList();
    }





    private MySpace.Pages.TaskModel Modal { get; set; }


    public List<string> pinUsers = new List<string>();



    protected void PinnUser(string value)
    {
        pinUsers.Add(value);
    }
    public void addUnPinnUser(string value)
    {
        pinUsers.Remove(value);
    }


    private void OpenDialog()
    {
        DialogService.Show<MySpace.Pages.TaskModel>("Create Space");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDialogService DialogService { get; set; }
    }
}
#pragma warning restore 1591
