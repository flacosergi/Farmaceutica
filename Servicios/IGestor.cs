using AccesoDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmaceutica.Servicios
{
    public interface IGestor
    {
        Task<string> Ingresar(object nuevo_objeto);
        Task<string> Modificar(object objeto_modificar);
        Task<string> Eliminar(object objeto_eliminar);
        Task<object?> ConsultarPorID(int codigo);

    }
}
