using APIFarmaceutica.Datos;
using APIFarmaceutica.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIFarmaceutica.Modelos
{
    public class DominioFactory : AbstractFactory
    {
        public override object CreaObjeto(string tipo)
        {
            switch (tipo)
            {
                case "articulo":
                    return new Articulo(this);
                case "tipo_articulo":
                    return new Tipo_Articulo();
                case "unidad_medida":
                    return new Unidad_Medida();
                case "DaoArticulo":
                    return new DaoArticulo();
                default:
                    throw new ArgumentException($"Tipo de objeto inválido: {tipo}");
            }
        }
    }



}
