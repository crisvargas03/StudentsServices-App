#pragma checksum "C:\Users\Vheysck\Desktop\Mayo - Agosto 2021\Introduccion a la ingenieria de software\Proyecto Final\Intro_Ingenieria_G5\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9edac1622270d31e91d2c60bff265ce2b2629155"
// <auto-generated/>
#pragma warning disable 1591
namespace Sistema_Estudiantil.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Vheysck\Desktop\Mayo - Agosto 2021\Introduccion a la ingenieria de software\Proyecto Final\Intro_Ingenieria_G5\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Vheysck\Desktop\Mayo - Agosto 2021\Introduccion a la ingenieria de software\Proyecto Final\Intro_Ingenieria_G5\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Vheysck\Desktop\Mayo - Agosto 2021\Introduccion a la ingenieria de software\Proyecto Final\Intro_Ingenieria_G5\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Vheysck\Desktop\Mayo - Agosto 2021\Introduccion a la ingenieria de software\Proyecto Final\Intro_Ingenieria_G5\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Vheysck\Desktop\Mayo - Agosto 2021\Introduccion a la ingenieria de software\Proyecto Final\Intro_Ingenieria_G5\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Vheysck\Desktop\Mayo - Agosto 2021\Introduccion a la ingenieria de software\Proyecto Final\Intro_Ingenieria_G5\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Vheysck\Desktop\Mayo - Agosto 2021\Introduccion a la ingenieria de software\Proyecto Final\Intro_Ingenieria_G5\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Vheysck\Desktop\Mayo - Agosto 2021\Introduccion a la ingenieria de software\Proyecto Final\Intro_Ingenieria_G5\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Vheysck\Desktop\Mayo - Agosto 2021\Introduccion a la ingenieria de software\Proyecto Final\Intro_Ingenieria_G5\_Imports.razor"
using Sistema_Estudiantil;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Vheysck\Desktop\Mayo - Agosto 2021\Introduccion a la ingenieria de software\Proyecto Final\Intro_Ingenieria_G5\_Imports.razor"
using Sistema_Estudiantil.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Vheysck\Desktop\Mayo - Agosto 2021\Introduccion a la ingenieria de software\Proyecto Final\Intro_Ingenieria_G5\_Imports.razor"
using MudBlazor;

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
            __builder.OpenComponent<MudBlazor.MudSnackbarProvider>(4);
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenComponent<MudBlazor.MudLayout>(6);
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudAppBar>(8);
                __builder2.AddAttribute(9, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 8 "C:\Users\Vheysck\Desktop\Mayo - Agosto 2021\Introduccion a la ingenieria de software\Proyecto Final\Intro_Ingenieria_G5\Shared\MainLayout.razor"
                      Color.Info

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(11);
                    __builder3.AddAttribute(12, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "C:\Users\Vheysck\Desktop\Mayo - Agosto 2021\Introduccion a la ingenieria de software\Proyecto Final\Intro_Ingenieria_G5\Shared\MainLayout.razor"
                              Icons.Material.Filled.Menu

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(13, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 9 "C:\Users\Vheysck\Desktop\Mayo - Agosto 2021\Introduccion a la ingenieria de software\Proyecto Final\Intro_Ingenieria_G5\Shared\MainLayout.razor"
                                                                 Color.Inherit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(14, "Edge", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Edge>(
#nullable restore
#line 9 "C:\Users\Vheysck\Desktop\Mayo - Agosto 2021\Introduccion a la ingenieria de software\Proyecto Final\Intro_Ingenieria_G5\Shared\MainLayout.razor"
                                                                                      Edge.Start

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(15, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\Vheysck\Desktop\Mayo - Agosto 2021\Introduccion a la ingenieria de software\Proyecto Final\Intro_Ingenieria_G5\Shared\MainLayout.razor"
                                                                                                             (e) => DrawerToggle()

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(16, "\r\n        ");
                    __builder3.AddMarkupContent(17, "<a href=\"/\" b-bjk4v2jses><h4 style=\"margin-top:8px; color:white;\" b-bjk4v2jses><strong b-bjk4v2jses>Sistema Estudiantil</strong></h4></a>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudDrawer>(19);
                __builder2.AddAttribute(20, "Style", "background-color:lightgrey;");
                __builder2.AddAttribute(21, "Open", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "C:\Users\Vheysck\Desktop\Mayo - Agosto 2021\Introduccion a la ingenieria de software\Proyecto Final\Intro_Ingenieria_G5\Shared\MainLayout.razor"
                                                                _drawerOpen

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "OpenChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _drawerOpen = __value, _drawerOpen))));
                __builder2.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Sistema_Estudiantil.Shared.NavMenu>(24);
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudMainContent>(26);
                __builder2.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudContainer>(28);
                    __builder3.AddAttribute(29, "MaxWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.MaxWidth>(
#nullable restore
#line 16 "C:\Users\Vheysck\Desktop\Mayo - Agosto 2021\Introduccion a la ingenieria de software\Proyecto Final\Intro_Ingenieria_G5\Shared\MainLayout.razor"
                                MaxWidth.Medium

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(31, 
#nullable restore
#line 17 "C:\Users\Vheysck\Desktop\Mayo - Agosto 2021\Introduccion a la ingenieria de software\Proyecto Final\Intro_Ingenieria_G5\Shared\MainLayout.razor"
             Body

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
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\Vheysck\Desktop\Mayo - Agosto 2021\Introduccion a la ingenieria de software\Proyecto Final\Intro_Ingenieria_G5\Shared\MainLayout.razor"
       
    bool _drawerOpen = true;

    void DrawerToggle()
    {
        _drawerOpen = !_drawerOpen;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
