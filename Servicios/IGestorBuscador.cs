using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmaceutica.Servicios
{
    public interface IGestorBuscador
    {
        Task<DataTable> CargaLista(string url);

    }
}
