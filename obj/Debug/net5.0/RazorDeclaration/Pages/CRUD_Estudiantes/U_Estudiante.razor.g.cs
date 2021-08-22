// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Intro_Ingenieria_G5\Pages\CRUD_Estudiantes\U_Estudiante.razor"
using Sistema_Estudiantil.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CRUD_Estudiantes/U_Estudiante")]
    public partial class U_Estudiante : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 200 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Intro_Ingenieria_G5\Pages\CRUD_Estudiantes\U_Estudiante.razor"
      
    bool success;
    string[] errors = { };
    MudTextField<string> pwField1;
    MudForm form;

    bool successEdit;
    string[] errorsEdit = { };
    MudTextField<string> pwField2;
    MudForm formEdit;

    long selectCero;
    long selectOne = 1;

    bool idFinded = false;
    bool showAlert = false;
    bool showErrorAlert = false;
    bool showCorrectAlert = false;

    private void CloseMe(bool value)
    {
        if (value)
        {
            showAlert = false;
            showErrorAlert = false;
            showCorrectAlert = false;
        }
        else
        {
            showAlert = false;
            showErrorAlert = false;
            showCorrectAlert = false;
        }
    }

    void LimpiarCampos()
    {
        estudiante.Nombre = null;
        estudiante.Apellido = "";
        estudiante.Edad = 0;
        estudiante.Carrera = "";
        estudiante.Condicion = 0;
        estudiante.Beca = 0;
    }

    Estudiante estudiante = new Estudiante();
    ProgramaEstudiantilDBContext context = new ProgramaEstudiantilDBContext();
    List<Estudiante> getEstudiantes() => new ProgramaEstudiantilDBContext().Estudiante.Where(X => X.Matricula == estudiante.Matricula).ToList();

    void CreateEstudiante()
    {
        var estudianteUpdated = context.Estudiante.FirstOrDefault(x => x.Matricula == estudiante.Matricula);
        estudianteUpdated.Matricula = estudiante.Matricula;
        estudianteUpdated.Nombre = estudiante.Nombre;
        estudianteUpdated.Apellido = estudiante.Apellido;
        estudianteUpdated.Edad = estudiante.Edad;
        estudianteUpdated.Carrera = estudiante.Carrera;
        estudianteUpdated.Condicion = estudiante.Condicion;
        estudianteUpdated.Beca = estudiante.Beca;
        showCorrectAlert = true;
        context.SaveChanges();

        using (ProgramaEstudiantilDBContext cmd_Update = new ProgramaEstudiantilDBContext())
        {
            cmd_Update.Update(estudiante);
            cmd_Update.SaveChanges();
        }
    }
    void findEstudiante()
    {
        LimpiarCampos();
        using (ProgramaEstudiantilDBContext Buscar = new ProgramaEstudiantilDBContext())
        {
            if (estudiante.Matricula == 0)
            {
                idFinded = false;
                showErrorAlert = true;
            }
            else
            {
                foreach (var item in getEstudiantes())
                {
                    bool exists = true;
                    if (exists)
                    {
                        idFinded = true;
                        showAlert = true;
                        estudiante.Nombre = item.Nombre;
                        estudiante.Apellido = item.Apellido;
                        estudiante.Edad = item.Edad;
                        estudiante.Carrera = item.Carrera;
                        estudiante.Condicion = item.Condicion;
                        estudiante.Beca = item.Beca;
                    }
                }
            }
            if (estudiante.Nombre == null)
            {
                idFinded = false;
                showErrorAlert = true;
            }
        }
    }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
