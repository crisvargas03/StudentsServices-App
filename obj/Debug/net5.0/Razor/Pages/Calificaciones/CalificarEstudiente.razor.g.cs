#pragma checksum "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\Calificaciones\CalificarEstudiente.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "847bf9998243b7540efae7aa1b46cb1e79238219"
// <auto-generated/>
#pragma warning disable 1591
namespace Sistema_Estudiantil.Pages.Calificaciones
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
#line 2 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\Calificaciones\CalificarEstudiente.razor"
using Sistema_Estudiantil.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Calificaciones/CalificarEstudiantes")]
    public partial class CalificarEstudiente : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Calificar</h2>\r\n\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table");
            __builder.OpenElement(3, "tr");
            __builder.AddMarkupContent(4, "<td>Seleccione el estudiante:</td>\r\n        ");
            __builder.OpenElement(5, "td");
            __builder.OpenElement(6, "select");
            __builder.AddAttribute(7, "class", "form-control col-sm-8");
            __builder.AddAttribute(8, "name", "Estudiantes");
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\Calificaciones\CalificarEstudiente.razor"
                                                                             report.EstudianteId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => report.EstudianteId = __value, report.EstudianteId));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(11, "option");
            __builder.AddContent(12, "Eliga un estudiante");
            __builder.CloseElement();
#nullable restore
#line 12 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\Calificaciones\CalificarEstudiente.razor"
                 foreach (var item in GetEstudiantes())
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "option");
            __builder.AddAttribute(14, "value", 
#nullable restore
#line 14 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\Calificaciones\CalificarEstudiente.razor"
                                    item.Matricula

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(15, 
#nullable restore
#line 14 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\Calificaciones\CalificarEstudiente.razor"
                                                     item.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(16, " ");
            __builder.AddContent(17, 
#nullable restore
#line 14 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\Calificaciones\CalificarEstudiente.razor"
                                                                  item.Apellido

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 15 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\Calificaciones\CalificarEstudiente.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.OpenElement(19, "tr");
            __builder.AddMarkupContent(20, "<td>Seleccione la materia:</td>\r\n        ");
            __builder.OpenElement(21, "td");
            __builder.OpenElement(22, "select");
            __builder.AddAttribute(23, "class", "form-control col-sm-8");
            __builder.AddAttribute(24, "name", "Materia");
            __builder.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\Calificaciones\CalificarEstudiente.razor"
                                                                         report.MateriaId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => report.MateriaId = __value, report.MateriaId));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(27, "option");
            __builder.AddContent(28, "Eliga un estudiante");
            __builder.CloseElement();
#nullable restore
#line 24 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\Calificaciones\CalificarEstudiente.razor"
                 foreach (var item in GetMaterias())
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(29, "option");
            __builder.AddAttribute(30, "value", 
#nullable restore
#line 26 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\Calificaciones\CalificarEstudiente.razor"
                                    item.MateriaId

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(31, 
#nullable restore
#line 26 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\Calificaciones\CalificarEstudiente.razor"
                                                     item.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 27 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\Calificaciones\CalificarEstudiente.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.OpenElement(33, "tr");
            __builder.AddMarkupContent(34, "<td>Cuatrimestre: </td>\r\n        ");
            __builder.OpenElement(35, "td");
            __builder.OpenElement(36, "input");
            __builder.AddAttribute(37, "type", "text");
            __builder.AddAttribute(38, "class", "form-control col-sm-4");
            __builder.AddAttribute(39, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\Calificaciones\CalificarEstudiente.razor"
                                                                     report.Cuatrimestre

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => report.Cuatrimestre = __value, report.Cuatrimestre));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n    ");
            __builder.OpenElement(42, "tr");
            __builder.AddMarkupContent(43, "<td>Calificacion de la Materia: </td>\r\n        ");
            __builder.OpenElement(44, "td");
            __builder.OpenElement(45, "input");
            __builder.AddAttribute(46, "type", "num");
            __builder.AddAttribute(47, "class", "form-control col-sm-4");
            __builder.AddAttribute(48, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\Calificaciones\CalificarEstudiente.razor"
                                                                    report.Calificacion

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => report.Calificacion = __value, report.Calificacion));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n");
            __builder.OpenElement(51, "center");
            __builder.OpenElement(52, "strong");
            __builder.AddContent(53, 
#nullable restore
#line 41 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\Calificaciones\CalificarEstudiente.razor"
             Mensaje

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n    <br>\r\n    <br>\r\n    ");
            __builder.OpenElement(55, "button");
            __builder.AddAttribute(56, "class", "btn btn-primary");
            __builder.AddAttribute(57, "style", "background-color:#00C738");
            __builder.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\Calificaciones\CalificarEstudiente.razor"
                                                                               createReport

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(59, "<span class=\"oi oi-plus\" aria-hidden=\"true\"></span> Agregar Cliente\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n    <br>\r\n    <br>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Users\civar\Desktop\Tarea\Introduccion a Ingenieria\Intro_Ingenieria_G5\Pages\Calificaciones\CalificarEstudiente.razor"
      
    string Mensaje;
    ReporteCalificacion report = new ReporteCalificacion();
    List<Materia> GetMaterias() => new ProgramaEstudiantilDBContext().Materia.ToList();
    List<Estudiante> GetEstudiantes() => new ProgramaEstudiantilDBContext().Estudiante.ToList();

    void createReport(){
        //---------------obtener el ultimo registro--------------------------
        List<ReporteCalificacion> getUltimoId() => new ProgramaEstudiantilDBContext().ReporteCalificacion.OrderByDescending(x => x.ReporteCalificacionId).Take(1).ToList();

        foreach (var i in getUltimoId())
        {
            report.ReporteCalificacionId = Convert.ToInt32(i.ReporteCalificacionId + 1);
        }
        //----------------------Fin----------------------------

        if (report.EstudianteId == null || report.MateriaId == null || report.Cuatrimestre == null || report.Calificacion == 0)
        {
            Mensaje = "Existen Campos vacios...";
        }
        else
        {
            using (ProgramaEstudiantilDBContext cmd = new ProgramaEstudiantilDBContext())
            {
                cmd.Add(report);
                cmd.SaveChanges();
                Mensaje = "Reporte de Calificacion creado exitosamente!";
            }
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
