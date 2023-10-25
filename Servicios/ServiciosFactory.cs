using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.Servicios;
using AccesoDatos.Modelos;

namespace Farmaceutica.Servicios
{
    public class ServiciosFactory:AbstractFactory
    {
        public override object CreaObjeto(string tipo)
        {
            switch (tipo)
            {
                case "gestor_art":
                    return new GestorArticulos();
                case "metodos_comunes":
                    return new MetodosComunes();
                case "articulo":
                    return new Articulo();
                case "tipo_articulo":
                    return new Tipo_Articulo();
                case "unidad_medida":
                    return new Unidad_Medida();
                case "marca":
                    return new Marca();
                default:
                    throw new ArgumentException($"Tipo de objeto inválido: {tipo}");
            }
        }


    }
}
