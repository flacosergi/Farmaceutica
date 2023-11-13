using AccesoDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmaceutica.Servicios
{
    public interface IGestorCliente
    {
        Task<Cliente> ObtenerClientePorID(int codigo_cliente);
        Task<List<TipoDoc>> GetTipoDoc();
        Task<List<TipoCliente>> GetTipoCliente();
        Task<List<Localidad>> GetTipoLocalidad();
        Task<List<ObraSocial>> GetTipoOS();
        Task<List<PlanOS>> GetPlanOS();

        Task<string> IngresarCliente(Cliente nuevo_articulo);
        Task<string> ModificarCliente(Cliente nuevo_articulo);


    }
}
