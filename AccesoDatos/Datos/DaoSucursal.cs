using AccesoDatos.Modelos;
using AccesoDatos.Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Datos
{
    public class DaoSucursal : IObjetoDAO
    {
        public object BuscaRegistro(int registro)
        {
            throw new NotImplementedException();
        }

        public int EliminarRegistro(int codigo)
        {
            throw new NotImplementedException();
        }

        public int InsertarRegistro(object objeto)
        {
            throw new NotImplementedException();
        }

        public List<KeyValuePair<int, string>> ListaSimpleRegistros()
        {
            throw new NotImplementedException();
        }

        public int ModificarRegistro(object objeto)
        {
            throw new NotImplementedException();
        }

        public List<Sucursal> Obtiene_Susucrsales(ModeloFactory factory)
        {
            List<Sucursal> nueva_lista = new List<Sucursal>();
            DataTable nueva_tabla = new DataTable();
            nueva_tabla = DBHelper.ObtenerInstancia().CargarTabla("PA_SUCURSALES_CARGA_SUCURSALES");
            foreach (DataRow fila in nueva_tabla.Rows)
            {
                Sucursal nueva_sucursal = (Sucursal)factory.CreaObjeto("sucursal");
                nueva_sucursal.codigo_sucursal = Convert.ToInt32(fila["codigo_sucursal"].ToString());
                nueva_sucursal.nombre = (string)fila["nombre"];
                nueva_sucursal.calle = (string)fila["calle"];
                nueva_sucursal.numero = Convert.ToInt32(fila["numero"].ToString());
                nueva_sucursal.localidad.id_localidad = Convert.ToInt32(fila["id_localidad"].ToString());
                nueva_sucursal.localidad.nom_localidad = (string)fila["localidad"];
                nueva_sucursal.localidad.provincia.id_provincia = Convert.ToInt32(fila["id_provincia"].ToString());
                nueva_sucursal.localidad.provincia.provincia = (string)fila["provincia"];
                nueva_sucursal.localidad.provincia.pais.id_pais = Convert.ToInt32(fila["id_pais"].ToString());
                nueva_sucursal.localidad.provincia.pais.pais = (string)fila["pais"];
                nueva_lista.Add(nueva_sucursal);
            }
            return nueva_lista;
        }
    }
}
