#pragma checksum "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace_v3.0\MySpace\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e8a1e3d394f820ea7ab93d71800dafa41cdbb96"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace_v3.0\MySpace\Shared\MainLayout.razor"
using MySpace.Models;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudThemeProvider>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n");
            __builder.OpenComponent<MudBlazor.MudDialogProvider>(2);
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenComponent<MudBlazor.MudLayout>(4);
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudMainContent>(6);
                __builder2.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(8, 
#nullable restore
#line 7 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace_v3.0\MySpace\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.OpenComponent<MySpace.Shared.NavMenu>(10);
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n\r\n\r\n\r\n");
            __builder.OpenComponent<MudBlazor.MudAppBar>(12);
            __builder.AddAttribute(13, "xs", "12");
            __builder.AddAttribute(14, "sm", "12");
            __builder.AddAttribute(15, "md", "12");
            __builder.AddAttribute(16, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 14 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace_v3.0\MySpace\Shared\MainLayout.razor"
                                              1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "Style", "margin-left: 70px; overflow:visible; background-color: #FBFCFC; ");
            __builder.AddAttribute(18, "Fixed", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace_v3.0\MySpace\Shared\MainLayout.razor"
                                                                                                                                 true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudAvatar>(20);
                __builder2.AddAttribute(21, "Style", "margin-top: -8px; ");
                __builder2.AddAttribute(22, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 16 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace_v3.0\MySpace\Shared\MainLayout.razor"
                                                 Color.Warning

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 16 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace_v3.0\MySpace\Shared\MainLayout.razor"
                                                                         Variant.Filled

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(25, "SK");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n    ");
                __builder2.OpenElement(27, "h6");
                __builder2.AddAttribute(28, "style", "color:black; margin-left:5px; margin-bottom:24px; ");
                __builder2.AddAttribute(29, "b-bqvrear9ye");
                __builder2.AddContent(30, 
#nullable restore
#line 17 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace_v3.0\MySpace\Shared\MainLayout.razor"
                                                                     stringValue ?? "Your Space!"

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n\r\n\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudFab>(32);
                __builder2.AddAttribute(33, "DisableElevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 20 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace_v3.0\MySpace\Shared\MainLayout.razor"
                              true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace_v3.0\MySpace\Shared\MainLayout.razor"
                                           Icons.Material.Filled.SupervisorAccount

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "Style", "position: relative; padding: 15px; margin-top:30px; margin-left:-90px; color: blue; border-right: 2px solid #DBE4E1; font-size: small; height: 22px; border-radius: 0; background-color: #FBFCFC;");
                __builder2.AddAttribute(36, "Label", "Account");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudFab>(38);
                __builder2.AddAttribute(39, "DisableElevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 21 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace_v3.0\MySpace\Shared\MainLayout.razor"
                              true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace_v3.0\MySpace\Shared\MainLayout.razor"
                                           Icons.Material.Filled.List

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "Style", "color: blue; border-right: 2px solid #DBE4E1; padding: 15px; margin-top: 30px; font-size: small; height: 22px; border-radius: 0; background-color: #FBFCFC; ");
                __builder2.AddAttribute(42, "Label", "Tasks");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(43, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudFab>(44);
                __builder2.AddAttribute(45, "DisableElevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 22 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace_v3.0\MySpace\Shared\MainLayout.razor"
                              true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(46, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace_v3.0\MySpace\Shared\MainLayout.razor"
                                           Icons.Material.Outlined.InsertDriveFile

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "Style", "color: blue; border-right: 2px solid #DBE4E1; padding: 15px; margin-top: 30px; height: 22px; font-size: small; border-radius: 0; background-color: #FBFCFC; ");
                __builder2.AddAttribute(48, "Label", "Notes");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(49, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudFab>(50);
                __builder2.AddAttribute(51, "DisableElevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 23 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace_v3.0\MySpace\Shared\MainLayout.razor"
                              true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace_v3.0\MySpace\Shared\MainLayout.razor"
                                           Icons.Material.Outlined.FolderOpen

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "Style", "color: blue;  padding: 15px; margin-top: 30px; background-color: #FBFCFC; height: 22px; font-size: small; border-radius: 0; ");
                __builder2.AddAttribute(54, "Label", "Files");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(55, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudFab>(56);
                __builder2.AddAttribute(57, "DisableElevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 24 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace_v3.0\MySpace\Shared\MainLayout.razor"
                              true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(58, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace_v3.0\MySpace\Shared\MainLayout.razor"
                                           Icons.Material.Outlined.Search

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(59, "Style", "color: black; background-color:#FBFCFC; margin-left: 25em; ");
                __builder2.AddAttribute(60, "Edge", "Edge.End");
                __builder2.AddAttribute(61, "Label", "Search Space");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(62, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudFab>(63);
                __builder2.AddAttribute(64, "DisableElevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 25 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace_v3.0\MySpace\Shared\MainLayout.razor"
                              true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(65, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace_v3.0\MySpace\Shared\MainLayout.razor"
                                           Icons.Material.Outlined.FilterList

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(66, "Style", "color: black; background-color: #FBFCFC;");
                __builder2.AddAttribute(67, "Label", "Activity");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(68, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudFab>(69);
                __builder2.AddAttribute(70, "DisableElevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 26 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace_v3.0\MySpace\Shared\MainLayout.razor"
                              true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(71, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace_v3.0\MySpace\Shared\MainLayout.razor"
                                           Icons.Material.Outlined.Info

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(72, "Style", "color: black; background-color: #FBFCFC;");
                __builder2.AddAttribute(73, "Label", "Details");
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace_v3.0\MySpace\Shared\MainLayout.razor"
       
    public string stringValue { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
