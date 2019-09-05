using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MyLeasing.web.Helpers
{
    //cada ves que se crea una clase helper es necesario crear su interfas y agregarña en el
    // startup para que pueda ser cargada e utilizada en tod o el proyecto.
    public interface ICombosHelper
    {
         IEnumerable<SelectListItem> GetComboPropertyTypes();
    }
}
