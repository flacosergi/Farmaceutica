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
                case "buscador_articulos":
                    return new FrmBuscador(this, "/api/Articulos/Obtener_Lista_Simple", "Seleccionar Artículo");
                case "factura":
                    return new FrmFacturas(this);
                case "buscador_clientes":
                    return new FrmBuscador(this, "/api/Clientes/Obtener_Lista_Simple", "Seleccionar Cliente");


                default:
                    throw new ArgumentException($"Tipo de objeto inválido: {tipo}");
            }
        }


    }
}
