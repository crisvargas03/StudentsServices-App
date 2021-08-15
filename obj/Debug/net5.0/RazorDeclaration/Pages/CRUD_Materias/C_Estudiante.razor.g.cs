// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Sistema_Estudiantil.Pages.CRUD_Materias
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
#nullable restore
#line 2 "C:\Users\Vheysck\Desktop\Mayo - Agosto 2021\Introduccion a la ingenieria de software\Proyecto Final\Intro_Ingenieria_G5\Pages\CRUD_Materias\C_Estudiante.razor"
using Sistema_Estudiantil.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CRUD_Materias/C_Estudiante")]
    public partial class C_Estudiante : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 85 "C:\Users\Vheysck\Desktop\Mayo - Agosto 2021\Introduccion a la ingenieria de software\Proyecto Final\Intro_Ingenieria_G5\Pages\CRUD_Materias\C_Estudiante.razor"
      
    bool success;
    string[] errors = { };
    MudTextField<string> pwField1;
    MudForm form;

    Estudiante estudiante = new Estudiante();

    void CreateEstudiante()
    {
        //---------------obtener el ultimo registro--------------------------
        List<Estudiante> getUltimoId() => new ProgramaEstudiantilDBContext().Materia.OrderByDescending(x => x.MateriaId).Take(1).ToList();

        foreach (var i in getUltimoId())
        {
            estudiante.matricula = Convert.ToInt32(i.matricula + 1);
        }
        //----------------------Fin----------------------------

        using (ProgramaEstudiantilDBContext cmd_Insert = new ProgramaEstudiantilDBContext())
        {
            cmd_Insert.Add(estudiante);
            cmd_Insert.SaveChanges();
            ShowAlert();
        }

    }

    //Close the alerts variables
    private bool showCallAlert = false;
    private bool showLeaveAlert = false;
    private bool errorAlert = false;

    //Method for closing the alert
    private void CloseMe(bool value)
    {
        if (value)
        {
            showLeaveAlert = false;
        }
        else
        {
            showCallAlert = false;
        }
    }

    //ShowAlert
    private void ShowAlert()
    {
        showCallAlert = true;
        showLeaveAlert = true;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
