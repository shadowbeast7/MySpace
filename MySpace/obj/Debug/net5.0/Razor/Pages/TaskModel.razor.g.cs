#pragma checksum "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace_v3.0\MySpace\Pages\TaskModel.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d3079098dcb41ea31a489b00b4c88a4cbafaff6"
// <auto-generated/>
#pragma warning disable 1591
namespace MySpace.Pages
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
#line 2 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace_v3.0\MySpace\Pages\TaskModel.razor"
using MySpace.Models;

#line default
#line hidden
#nullable disable
    public partial class TaskModel : MainLayout
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudDialog>(0);
            __builder.AddAttribute(1, "DialogContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n        Add people by email addresses\r\n\r\n        ");
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "d-flex flex-column");
                __builder2.OpenComponent<MudBlazor.MudItem>(5);
                __builder2.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MySpace.Pages.Temp>(7);
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n            ");
                __builder2.AddMarkupContent(9, "<p>Invite as</p>\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudItem>(10);
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudSelect<string>>(12);
                    __builder3.AddAttribute(13, "Strict", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 74 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace_v3.0\MySpace\Pages\TaskModel.razor"
                                              true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(14, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 74 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace_v3.0\MySpace\Pages\TaskModel.razor"
                                                             Variant.Outlined

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(15, "Format", "F2");
                    __builder3.AddAttribute(16, "AnchorOrigin", "Origin.BottomCenter");
                    __builder3.AddAttribute(17, "OffsetY", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 74 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace_v3.0\MySpace\Pages\TaskModel.razor"
                                                                                                                                       true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(18, "Style", "margin: -4px 0px ");
                    __builder3.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __Blazor.MySpace.Pages.TaskModel.TypeInference.CreateMudSelectItem_0(__builder4, 20, 21, 
#nullable restore
#line 75 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace_v3.0\MySpace\Pages\TaskModel.razor"
                                            "Guest Can chat, Start video call,and comment on tasks & notes."

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddMarkupContent(22, "\r\n                    ");
                        __Blazor.MySpace.Pages.TaskModel.TypeInference.CreateMudSelectItem_1(__builder4, 23, 24, 
#nullable restore
#line 76 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace_v3.0\MySpace\Pages\TaskModel.razor"
                                            "Member"

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddMarkupContent(25, "\r\n                    ");
                        __Blazor.MySpace.Pages.TaskModel.TypeInference.CreateMudSelectItem_2(__builder4, 26, 27, 
#nullable restore
#line 77 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace_v3.0\MySpace\Pages\TaskModel.razor"
                                            "Admin"

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(28, "DialogActions", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudButton>(29);
                __builder2.AddAttribute(30, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 88 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace_v3.0\MySpace\Pages\TaskModel.razor"
                            Cancel

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(32, "Cancel");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudButton>(34);
                __builder2.AddAttribute(35, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 89 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace_v3.0\MySpace\Pages\TaskModel.razor"
                          Color.Primary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 89 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace_v3.0\MySpace\Pages\TaskModel.razor"
                                                  Submit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(38, "Create");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 92 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace_v3.0\MySpace\Pages\TaskModel.razor"
       
    [CascadingParameter] MudDialogInstance MudDialog { get; set; }

    void Submit() => MudDialog.Close(DialogResult.Ok(true));
    void Cancel() => MudDialog.Cancel();
    public string TextValue { get; set; }


    

#line default
#line hidden
#nullable disable
#nullable restore
#line 106 "C:\Users\Shiv\OneDrive\Desktop\TeachBit\MySpace_v3.0\MySpace\Pages\TaskModel.razor"
           

    public class TodoItem { public string? Title { get; set; } }
    private List<TodoItem> todos = new();
    private string InputValue { get; set; }
    private string err { get; set; }

    public bool IsValidEmail(string email)
    {
        if (email.Trim().EndsWith("."))
        {
            return false; // suggested by @TK-421
        }
        try
        {
            var addr = new System.Net.Mail.MailAddress(email);
            return addr.Address == email;
        }
        catch
        {
            return false;
        }
    }

    public void Enter(KeyboardEventArgs e)
    {
        if (e.Code == "Enter" || e.Code == "NumpadEnter")
        {
            if (IsValidEmail(InputValue))
            {
                todos.Add(new TodoItem { Title = InputValue });
                err = string.Empty;
                InputValue = string.Empty;
            }
            else
            {
                err = "Not Valid";
            }
        }
    }


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.MySpace.Pages.TaskModel
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudSelectItem_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0)
        {
        __builder.OpenComponent<global::MudBlazor.MudSelectItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateMudSelectItem_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0)
        {
        __builder.OpenComponent<global::MudBlazor.MudSelectItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateMudSelectItem_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0)
        {
        __builder.OpenComponent<global::MudBlazor.MudSelectItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
