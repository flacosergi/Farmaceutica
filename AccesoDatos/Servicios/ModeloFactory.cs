using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.Modelos;
using AccesoDatos.Datos;

namespace AccesoDatos.Servicios
{
    public class ModeloFactory : AbstractFactory
    {
        public override object CreaObjeto(string tipo)
        {
            switch (tipo)
            {
                case "articulo":
                    return new Articulo();
                case "tipo_articulo":
                    return new Tipo_Articulo();
                case "unidad_medida":
                    return new Unidad_Medida();
                case "DaoArticulo":
                    return new DaoArticulo();
                case "marca":
                    return new Marca();
                default:
                    throw new ArgumentException($"Tipo de objeto inválido: {tipo}");
            }
        }
    }



}
