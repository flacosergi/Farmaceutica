using AccesoDatos.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Datos
{
    public interface IObjetoDAO
    {
        int InsertarRegistro(object objeto);
        List<KeyValuePair<int, string>> ListaSimpleRegistros();
        object BuscaRegistro(int registro);
        int ModificarRegistro(object objeto);
        int EliminarRegistro(int codigo);
    }
}
