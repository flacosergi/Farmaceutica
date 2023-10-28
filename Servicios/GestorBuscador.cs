using AccesoDatos.Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Farmaceutica.Servicios
{
    public class GestorBuscador : IGestorBuscador
    {
        public async Task<DataTable> CargaLista(string url)
        {
            DataTable tabla = new DataTable();
            List<KeyValuePair<int, string>> nueva_lista = new List<KeyValuePair<int, string>>();
            string contenido = await ClientSingleton.GetInstance().GetAsync(url);
            if (contenido != string.Empty)
            { 
               nueva_lista = JsonConvert.DeserializeObject<List<KeyValuePair<int, string>>>(contenido);
                DataColumn columna1 = new DataColumn("codigo");
                DataColumn columna2 = new DataColumn("descripcion");
                tabla.Columns.Add(columna1);
                tabla.Columns.Add(columna2);
                foreach (KeyValuePair<int, string> par in nueva_lista) 
                {
                    tabla.Rows.Add(par.Key, par.Value);
                }
            }
             
            return tabla;
        }
        
    }
}
