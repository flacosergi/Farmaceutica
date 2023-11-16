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
        private static ModeloFactory? instancia;

        public static ModeloFactory ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new ModeloFactory();
            return instancia;
            
        }

        public override object CreaObjeto(string tipo, List<Object>? lista_parametros = default)
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
                case "DaoSucursal":
                    return new DaoSucursal();
                case "DaoFactura":
                    return new DaoFactura();
                case "marca":
                    return new Marca();
                case "pais":
                    return new Pais();
                case "provincia":
                    return new Provincia();
                case "localidad":
                    return new Localidad();
                case "tipo_doc":
                    return new TipoDoc();
                case "tipo_cliente":
                    return new TipoCliente();
                case "obra_social":
                    return new ObraSocial();
                case "plan_os":
                    return new PlanOS();
                case "cliente":
                    return new Cliente();
                case "sucursal":
                    return new Sucursal();
                case "factura":
                    return new Factura();
                case "detalle_factura":
                    return new DetalleFactura();
                case "forma_pago":
                    return new FormaPago();
                case "factura_forma_pago":
                    return new Factura_FormaPago();
                case "RepoStocks":
                    return new RepoStocks();
                case "DaoRepoStocks":
                    return new DaoRepoStocks();
                case "DaoRepoFacturas":
                    return new DaoRepoFacturas();
				case "RepoFactura":
					return new RepoFacturas();
                case "GeoLoc":
                    return new GeoLoc();



				default:
                    throw new ArgumentException($"Tipo de objeto inválido: {tipo}");
            }
        }
    }



}
