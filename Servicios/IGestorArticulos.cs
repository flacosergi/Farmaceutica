using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.Modelos;

namespace Farmaceutica.Servicios
{
    public interface IGestorArticulos
    {
        Task<List<Tipo_Articulo>> GetTipoArticulos();
        Task<List<Marca>> GetMarcas();
        Task<List<Unidad_Medida>> GetUM();
        Task<string> CargarArticulo(Articulo nuevo_articulo);
    }
}
