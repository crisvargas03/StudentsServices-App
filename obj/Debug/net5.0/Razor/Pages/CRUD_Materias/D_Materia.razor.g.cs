#pragma checksum "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\D_Materia.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19af14b2e04593bbb4b18201a9b6cb412f3ad777"
// <auto-generated/>
#pragma warning disable 1591
namespace Sistema_Estudiantil.Pages.CRUD_Materias
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
#nullable restore
#line 2 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\D_Materia.razor"
using Sistema_Estudiantil.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CRUD_Materias/D_Materia")]
    public partial class D_Materia : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudCard>(0);
            __builder.AddAttribute(1, "Style", "margin:30px;");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudCardContent>(3);
                __builder2.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(5);
                    __builder3.AddAttribute(6, "Link", "/CRUD_Materias/Materias");
                    __builder3.AddAttribute(7, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\D_Materia.razor"
                                                             Icons.Material.Filled.ArrowBack

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(8, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 12 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\D_Materia.razor"
                                                                                                     Color.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(9, "\r\n        ");
                    __builder3.AddMarkupContent(10, "<h2 class=\"text-center\"><strong>Eliminar Materia</strong></h2>\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudGrid>(11);
                    __builder3.AddAttribute(12, "Class", "mt-3");
                    __builder3.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudExpansionPanel>(14);
                        __builder4.AddAttribute(15, "Class", "bg-light");
                        __builder4.AddAttribute(16, "Text", "Formulario para eliminar la materia");
                        __builder4.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudForm>(18);
                            __builder5.AddAttribute(19, "IsValid", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\D_Materia.razor"
                                                    success

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(20, "IsValidChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => success = __value, success))));
                            __builder5.AddAttribute(21, "Errors", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String[]>(
#nullable restore
#line 16 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\D_Materia.razor"
                                                                           errors

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(22, "ErrorsChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String[]>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => errors = __value, errors))));
                            __builder5.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudGrid>(24);
                                __builder6.AddAttribute(25, "Class", "mt-3");
                                __builder6.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenComponent<MudBlazor.MudItem>(27);
                                    __builder7.AddAttribute(28, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 18 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\D_Materia.razor"
                                     12

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.AddMarkupContent(30, "<label>Ingrese el Codigo de la Materia:</label>\r\n                            ");
                                        __builder8.OpenComponent<MudBlazor.MudTextField<long>>(31);
                                        __builder8.AddAttribute(32, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 20 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\D_Materia.razor"
                                                   Variant.Outlined

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.AddAttribute(33, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<long>(
#nullable restore
#line 20 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\D_Materia.razor"
                                                                                           materia.MateriaId

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.AddAttribute(34, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<long>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<long>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => materia.MateriaId = __value, materia.MateriaId))));
                                        __builder8.CloseComponent();
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                    __builder7.AddMarkupContent(35, "\r\n                        ");
                                    __builder7.OpenComponent<MudBlazor.MudItem>(36);
                                    __builder7.AddAttribute(37, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 22 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\D_Materia.razor"
                                     12

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(38, "Style", "display:flex; justify-content:center;");
                                    __builder7.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.OpenComponent<MudBlazor.MudButton>(40);
                                        __builder8.AddAttribute(41, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 23 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\D_Materia.razor"
                                                Variant.Filled

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.AddAttribute(42, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 23 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\D_Materia.razor"
                                                                       Color.Error

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.AddAttribute(43, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 23 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\D_Materia.razor"
                                                                                                !success

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\D_Materia.razor"
                                                                                                                     DeleteMateria

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.AddAttribute(45, "EndIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\D_Materia.razor"
                                                                                                                                              Icons.Filled.DeleteForever

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder9) => {
                                            __builder9.AddContent(47, "Eliminar");
                                        }
                                        ));
                                        __builder8.CloseComponent();
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.AddComponentReferenceCapture(48, (__value) => {
#nullable restore
#line 16 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\D_Materia.razor"
                               form = (MudBlazor.MudForm)__value;

#line default
#line hidden
#nullable disable
                            }
                            );
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 32 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\D_Materia.razor"
 if (showErrorAlert)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<MudBlazor.MudAlert>(49);
            __builder.AddAttribute(50, "Style", "margin-bottom:25px;");
            __builder.AddAttribute(51, "Severity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Severity>(
#nullable restore
#line 35 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\D_Materia.razor"
                        Severity.Error

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 36 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\D_Materia.razor"
                       Variant.Filled

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(53, "AlertTextPosition", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.AlertTextPosition>(
#nullable restore
#line 37 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\D_Materia.razor"
                                 AlertTextPosition.Center

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "ShowCloseIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 38 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\D_Materia.razor"
                             true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "CloseIconClicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<MudBlazor.MudAlert>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<MudBlazor.MudAlert>(this, 
#nullable restore
#line 39 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\D_Materia.razor"
                                (() => CloseMe(false))

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(57, "\r\n        Debe llenar el campo del codigo de la materia...\r\n    ");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 42 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\D_Materia.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\D_Materia.razor"
 if (showErrorNotFoundAlert)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<MudBlazor.MudAlert>(58);
            __builder.AddAttribute(59, "Style", "margin-bottom:25px;");
            __builder.AddAttribute(60, "Severity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Severity>(
#nullable restore
#line 47 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\D_Materia.razor"
                        Severity.Error

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 48 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\D_Materia.razor"
                       Variant.Filled

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(62, "AlertTextPosition", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.AlertTextPosition>(
#nullable restore
#line 49 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\D_Materia.razor"
                                 AlertTextPosition.Center

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(63, "ShowCloseIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 50 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\D_Materia.razor"
                             true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(64, "CloseIconClicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<MudBlazor.MudAlert>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<MudBlazor.MudAlert>(this, 
#nullable restore
#line 51 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\D_Materia.razor"
                                (() => CloseMe(false))

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(65, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(66, "\r\n        La materia no fue encontrada...\r\n    ");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 54 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\D_Materia.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\D_Materia.razor"
 if (showSuccessfulAlert)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<MudBlazor.MudAlert>(67);
            __builder.AddAttribute(68, "Style", "margin-bottom:25px;");
            __builder.AddAttribute(69, "Severity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Severity>(
#nullable restore
#line 59 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\D_Materia.razor"
                        Severity.Success

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(70, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 60 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\D_Materia.razor"
                       Variant.Filled

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(71, "AlertTextPosition", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.AlertTextPosition>(
#nullable restore
#line 61 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\D_Materia.razor"
                                 AlertTextPosition.Center

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "ShowCloseIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 62 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\D_Materia.razor"
                             true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(73, "CloseIconClicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<MudBlazor.MudAlert>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<MudBlazor.MudAlert>(this, 
#nullable restore
#line 63 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\D_Materia.razor"
                                (() => CloseMe(false))

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(74, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(75, "\r\n        La materia fue eliminada de forma correcta...\r\n    ");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 66 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\D_Materia.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 70 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\CRUD_Materias\D_Materia.razor"
      
    bool success;
    string[] errors = { };
    MudTextField<string> pwField1;
    MudForm form;

    //Mostrar el formulario de editar, cuando el id sea encontrado
    bool showErrorAlert = false;
    bool showErrorNotFoundAlert = false;
    bool showSuccessfulAlert = false;

    private void CloseMe(bool value)
    {
        if (value)
        {
            showErrorAlert = false;
            showErrorNotFoundAlert = false;
            showSuccessfulAlert = false;
        }
        else
        {
            showErrorAlert = false;
            showErrorNotFoundAlert = false;
            showSuccessfulAlert = false;
        }
    }

    bool exists;
    string Mensaje;
    Materia materia = new Materia();
    List<Materia> GetMaterias() => new ProgramaEstudiantilDBContext().Materia.Where(x => x.MateriaId == materia.MateriaId).ToList();
    void DeleteMateria()
    {
        using (ProgramaEstudiantilDBContext cmd_Delete = new ProgramaEstudiantilDBContext())
        {
            if (materia.MateriaId == 0)
            {
                showErrorNotFoundAlert = false;
                showErrorAlert = true;
                Mensaje = "Debe Lenar el Campo Cedula!";
            }
            else
            {
                foreach (var item in @GetMaterias())
                {
                    exists = true;
                }
                if (exists == true)
                {
                    cmd_Delete.Remove(materia);
                    cmd_Delete.SaveChanges();
                    showSuccessfulAlert = true;
                    Mensaje = "Materia Eliminada!";
                }
                else
                {
                    Mensaje = "Materia no encontrada!";
                    showErrorAlert = false;
                    showErrorNotFoundAlert = true;
                }
            }
        }
        materia.MateriaId = 0;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
