using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.Servicios;
using AccesoDatos.Modelos;
using Farmaceutica.Presentacion;
namespace Farmaceutica.Servicios
{
    public class ServiciosFactory : AbstractFactory
    {
        public override object CreaObjeto(string tipo)
        {
            switch (tipo)
            {
                case "gestor_art":
                    return new GestorArticulos();
                case "metodos_comunes":
                    return new MetodosComunes();
                case "gestor_buscador":
                    return new GestorBuscador();
                case "articulo":
                    return new Articulo();
                case "tipo_articulo":
                    return new Tipo_Articulo();
                case "unidad_medida":
                    return new Unidad_Medida();
                case "marca":
                    return new Marca();
                case "articulos":
                    return new FrmArticulos(this);
                default:
                    throw new ArgumentException($"Tipo de objeto inválido: {tipo}");
            }
        }


    }
}
