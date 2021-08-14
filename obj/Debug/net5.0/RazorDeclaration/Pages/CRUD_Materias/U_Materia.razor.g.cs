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
#line 1 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Sistema Estudiantil\Sistema Estudiantil\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Sistema Estudiantil\Sistema Estudiantil\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Sistema Estudiantil\Sistema Estudiantil\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Sistema Estudiantil\Sistema Estudiantil\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Sistema Estudiantil\Sistema Estudiantil\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Sistema Estudiantil\Sistema Estudiantil\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Sistema Estudiantil\Sistema Estudiantil\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Sistema Estudiantil\Sistema Estudiantil\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Sistema Estudiantil\Sistema Estudiantil\_Imports.razor"
using Sistema_Estudiantil;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Sistema Estudiantil\Sistema Estudiantil\_Imports.razor"
using Sistema_Estudiantil.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Sistema Estudiantil\Sistema Estudiantil\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Sistema Estudiantil\Sistema Estudiantil\Pages\CRUD_Materias\U_Materia.razor"
using Sistema_Estudiantil.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CRUD_Materias/U_Materia")]
    public partial class U_Materia : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 79 "C:\Users\Lusan\Desktop\ITLA SEXTO CUATRIMESTRE\Introducción a la ingienería de Software - Evanyeline Brito\Sistema Estudiantil\Sistema Estudiantil\Pages\CRUD_Materias\U_Materia.razor"
      
    bool success;
    string[] errors = { };
    MudTextField<string> pwField1;
    MudForm form;

    bool successEdit;
    string[] errorsEdit = { };
    MudTextField<string> pwField2;
    MudForm formEdit;

    //Mostrar el formulario de editar, cuando el id sea encontrado
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

    Materia materia = new Materia();
    ProgramaEstudiantilDBContext context = new ProgramaEstudiantilDBContext();
    List<Materia> getMaterias() => new ProgramaEstudiantilDBContext().Materia.Where(X => X.MateriaId == materia.MateriaId).ToList();

    void updateMateria()
    {
        var materiaUpdated = context.Materia.FirstOrDefault(x => x.MateriaId == materia.MateriaId);
        materiaUpdated.Nombre = materia.Nombre;
        materiaUpdated.Creditos = materia.Creditos;
        context.SaveChanges();
        showCorrectAlert = true;
    }

    void findMateria()
    {
        using (ProgramaEstudiantilDBContext Buscar = new ProgramaEstudiantilDBContext())
        {
            if (materia.MateriaId == 0)
            {
                idFinded = false;
                showErrorAlert = true;
            }
            else
            {
                foreach (var item in getMaterias())
                {
                    bool exists = true;
                    if (exists)
                    {
                        idFinded = true;
                        showAlert = true;
                        materia.Nombre = item.Nombre;
                        materia.Creditos = item.Creditos;
                    }
                }

            }
            if (materia.Nombre == null)
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
