using AccesoDatos.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmaceutica.Servicios
{
    public class GestorRepoDescuentos
    {
        DaoRepoDescuentos dao = new DaoRepoDescuentos();

        public DataTable ObtenerReporte(int suc)
        {
            return dao.ObtenerReporteDescuentos(suc);
        }
    }
}
