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
                case "DaoCliente":
                    return new DaoCliente();
                case "marca":
                    return new Marca();
                case "pais":
                    return new Pais();
                case "provincia":
                    return new Provincia(this);
                case "localidad":
                    return new Localidad(this);
                case "tipo_doc":
                    return new TipoDoc();
                case "tipo_cliente":
                    return new TipoCliente();
                case "obra_social":
                    return new ObraSocial(this);
                case "plan_os":
                    return new PlanOS(this);
                case "cliente":
                    return new Cliente(this);

                
                default:
                    throw new ArgumentException($"Tipo de objeto inválido: {tipo}");
            }
        }
    }



}
