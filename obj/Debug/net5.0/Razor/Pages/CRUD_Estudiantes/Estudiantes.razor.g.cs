#pragma checksum "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Intro_Ingenieria_G5\Pages\CRUD_Estudiantes\Estudiantes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1139d44c848140d5a5a7e60d99b4af328717a80"
// <auto-generated/>
#pragma warning disable 1591
namespace Sistema_Estudiantil.Pages.CRUD_Estudiantes
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Intro_Ingenieria_G5\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Intro_Ingenieria_G5\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Intro_Ingenieria_G5\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Intro_Ingenieria_G5\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Intro_Ingenieria_G5\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Intro_Ingenieria_G5\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Intro_Ingenieria_G5\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Intro_Ingenieria_G5\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Intro_Ingenieria_G5\_Imports.razor"
using Sistema_Estudiantil;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Intro_Ingenieria_G5\_Imports.razor"
using Sistema_Estudiantil.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Intro_Ingenieria_G5\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Intro_Ingenieria_G5\Pages\CRUD_Estudiantes\Estudiantes.razor"
using Sistema_Estudiantil.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CRUD_Estudiantes/Estudiantes")]
    public partial class Estudiantes : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudCard>(0);
            __builder.AddAttribute(1, "Style", "margin:25px;");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudCardHeader>(3);
                __builder2.AddAttribute(4, "CardHeaderContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(5, "<h2 class=\"text-center mt-5\"><strong>Estudiantes Registrados</strong></h2>");
                }
                ));
                __builder2.AddAttribute(6, "CardHeaderActions", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(7);
                    __builder3.AddAttribute(8, "Link", "/CRUD_Estudiantes/C_Estudiante");
                    __builder3.AddAttribute(9, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Intro_Ingenieria_G5\Pages\CRUD_Estudiantes\Estudiantes.razor"
                                                                        Icons.Material.Filled.NoteAdd

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(10, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 14 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Intro_Ingenieria_G5\Pages\CRUD_Estudiantes\Estudiantes.razor"
                                                                                                              Color.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudCardContent>(12);
                __builder2.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(14, "table");
                    __builder3.AddAttribute(15, "class", "table table-bordered");
                    __builder3.AddAttribute(16, "id", "table");
                    __builder3.AddMarkupContent(17, @"<thead class=""thead-dark""><tr><th>Matricula</th>
                    <th>Nombre</th>
                    <th>Apellido</th>
                    <th>Edad</th>
                    <th>Carrera</th>
                    <th>Becado</th></tr></thead>
            ");
                    __builder3.OpenElement(18, "tbody");
#nullable restore
#line 31 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Intro_Ingenieria_G5\Pages\CRUD_Estudiantes\Estudiantes.razor"
                 foreach (var est in GetEstudiantes())
                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(19, "tr");
                    __builder3.OpenElement(20, "td");
                    __builder3.AddContent(21, 
#nullable restore
#line 34 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Intro_Ingenieria_G5\Pages\CRUD_Estudiantes\Estudiantes.razor"
                             est.Matricula

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(22, "\r\n                        ");
                    __builder3.OpenElement(23, "td");
                    __builder3.AddContent(24, 
#nullable restore
#line 35 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Intro_Ingenieria_G5\Pages\CRUD_Estudiantes\Estudiantes.razor"
                             est.Nombre

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(25, "\r\n                        ");
                    __builder3.OpenElement(26, "td");
                    __builder3.AddContent(27, 
#nullable restore
#line 36 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Intro_Ingenieria_G5\Pages\CRUD_Estudiantes\Estudiantes.razor"
                             est.Apellido

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(28, "\r\n                        ");
                    __builder3.OpenElement(29, "td");
                    __builder3.AddContent(30, 
#nullable restore
#line 37 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Intro_Ingenieria_G5\Pages\CRUD_Estudiantes\Estudiantes.razor"
                             est.Edad

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(31, "\r\n                        ");
                    __builder3.OpenElement(32, "td");
                    __builder3.AddContent(33, 
#nullable restore
#line 38 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Intro_Ingenieria_G5\Pages\CRUD_Estudiantes\Estudiantes.razor"
                             est.Carrera

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(34, "\r\n                        ");
                    __builder3.OpenElement(35, "td");
                    __builder3.AddContent(36, 
#nullable restore
#line 39 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Intro_Ingenieria_G5\Pages\CRUD_Estudiantes\Estudiantes.razor"
                             FormatBeca(est.Beca)

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.CloseElement();
#nullable restore
#line 41 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Intro_Ingenieria_G5\Pages\CRUD_Estudiantes\Estudiantes.razor"
                }

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudCardActions>(38);
                __builder2.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudButton>(40);
                    __builder3.AddAttribute(41, "StartIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 46 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Intro_Ingenieria_G5\Pages\CRUD_Estudiantes\Estudiantes.razor"
                               Icons.Material.Filled.Edit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(42, "Link", "/CRUD_Estudiantes/U_Estudiante");
                    __builder3.AddAttribute(43, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 46 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Intro_Ingenieria_G5\Pages\CRUD_Estudiantes\Estudiantes.razor"
                                                                                                          Variant.Text

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(44, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 46 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Intro_Ingenieria_G5\Pages\CRUD_Estudiantes\Estudiantes.razor"
                                                                                                                               Color.Info

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(45, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(46, "Editar");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(47, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudButton>(48);
                    __builder3.AddAttribute(49, "StartIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 47 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Intro_Ingenieria_G5\Pages\CRUD_Estudiantes\Estudiantes.razor"
                               Icons.Material.Filled.Delete

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(50, "Link", "/CRUD_Estudiantes/D_Estudiante");
                    __builder3.AddAttribute(51, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 47 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Intro_Ingenieria_G5\Pages\CRUD_Estudiantes\Estudiantes.razor"
                                                                                                            Variant.Text

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(52, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 47 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Intro_Ingenieria_G5\Pages\CRUD_Estudiantes\Estudiantes.razor"
                                                                                                                                 Color.Error

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(54, "Eliminar");
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
#line 52 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Intro_Ingenieria_G5\Pages\CRUD_Estudiantes\Estudiantes.razor"
      
    List<Estudiante> GetEstudiantes() => new ProgramaEstudiantilDBContext().Estudiante.ToList();

    string FormatBeca(long becado)
    {
        string beca = becado == 0 ? "No" : "Si";
        return beca;
    }

    //Methods for the funcionality of Datatable
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await JSRuntime.InvokeAsync<object>("TestDataTablesAdd", "#table");
    }
    void IDisposable.Dispose()
    {
        JSRuntime.InvokeAsync<object>("TestDataTablesRemove", "#table");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
