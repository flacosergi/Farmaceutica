using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIFarmaceutica.Datos
{
    public interface IObjetoDAO
    {
        int InsertarRegistro(object objeto);
        List<object> ListarRegistros();
        int ModificarRegistro(object objeto);
        int EliminarRegistro(int codigo);
    }
}
