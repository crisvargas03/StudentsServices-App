#pragma checksum "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae43f1d3736ee82ccfbd8ef8d60edd5753f9c1bd"
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
#line 1 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\_Imports.razor"
using Sistema_Estudiantil;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\_Imports.razor"
using Sistema_Estudiantil.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "centrar");
            __builder.AddAttribute(2, "style", "display:block; margin-left:auto; margin-right:auto;");
            __builder.AddAttribute(3, "b-z70dcqtp2k");
            __builder.OpenComponent<MudBlazor.MudAvatar>(4);
            __builder.AddAttribute(5, "Image", "images/logo_app.png");
            __builder.AddAttribute(6, "Style", "height:70px; width:70px;");
            __builder.AddAttribute(7, "Class", "ma-2");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\r\n");
            __builder.OpenComponent<MudBlazor.MudNavMenu>(9);
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudNavLink>(11);
                __builder2.AddAttribute(12, "Href", "/");
                __builder2.AddAttribute(13, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 7 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Shared\NavMenu.razor"
                                Icons.Filled.Home

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(15, "Home");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudNavGroup>(17);
                __builder2.AddAttribute(18, "Title", "Mantenimiento");
                __builder2.AddAttribute(19, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Shared\NavMenu.razor"
                                              Icons.Filled.Settings

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "Expanded", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 9 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Shared\NavMenu.razor"
                                                                               false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudNavLink>(22);
                    __builder3.AddAttribute(23, "Href", "/CRUD_Materias/Materias");
                    __builder3.AddAttribute(24, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Shared\NavMenu.razor"
                                                          Icons.Filled.NoteAdd

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(26, "Materia");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(27, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudNavLink>(28);
                    __builder3.AddAttribute(29, "Href", "/CRUD_Estudiantes/Estudiantes");
                    __builder3.AddAttribute(30, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Shared\NavMenu.razor"
                                                                Icons.Filled.NoteAdd

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(32, "Estudiantes");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\r\n\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudNavGroup>(34);
                __builder2.AddAttribute(35, "Title", "Calificaciones");
                __builder2.AddAttribute(36, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Shared\NavMenu.razor"
                                               Icons.Filled.Star

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "Expanded", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Shared\NavMenu.razor"
                                                                            false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudNavLink>(39);
                    __builder3.AddAttribute(40, "Href", "/calificaciones");
                    __builder3.AddAttribute(41, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Shared\NavMenu.razor"
                                                  Icons.Filled.Add

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(43, "Añadir calificación");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(44, "\r\n\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudNavLink>(45);
                __builder2.AddAttribute(46, "Href", "/about");
                __builder2.AddAttribute(47, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Shared\NavMenu.razor"
                                     Icons.Filled.ReadMore

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(49, "Sobre nosotros");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
