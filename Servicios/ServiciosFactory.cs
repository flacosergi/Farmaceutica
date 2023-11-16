using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.Servicios;
using AccesoDatos.Modelos;
using Farmaceutica.Presentacion;
using Farmaceutica.Presentacion.Reportes;
using Farmaceutica.Presentacion.Reportes.ReporteDescuentos;

namespace Farmaceutica.Servicios
{
    public class ServiciosFactory : AbstractFactory
    {
        private static ServiciosFactory? instancia;

        public static ServiciosFactory ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new ServiciosFactory();
            return instancia;

        }

        public override object CreaObjeto(string tipo, List<Object>? lista_parametros = default)
        {
            switch (tipo)
            {
                case "gestor_art":
                    return new GestorArticulos();
                case "gestor_cliente":
                    return new GestorCliente();
                case "metodos_comunes":
                    return new MetodosComunes();
                case "gestor_buscador":
                    return new GestorBuscador();
                case "gestor_factura":
                    return new GestorFactura();
                case "gestor_formas_pago":
                    return new GestorFormasPago();
                case "buscador_articulos":
                    return new FrmBuscador(this, "/api/Articulos/Obtener_Lista_Simple", "Seleccionar Artículo");
                case "factura":
                    return new FrmFacturas(this);
                case "buscador_clientes":
                    return new FrmBuscador(this, "/api/Clientes/Obtener_Lista_Simple", "Seleccionar Cliente");
                case "buscador_facturas":
                    return new FrmBuscador(this, "/api/Factura/Obtener_Lista_Simple", "Seleccionar Factura");
                case "articulos":
                    return new FrmArticulos(this);
                case "cliente":
                    return new FrmClientes(this);
                case "formas_pago":
                    {
                        Factura factura = (Factura)ModeloFactory.ObtenerInstancia().CreaObjeto("factura");
                        int caso = 0;
                        if (lista_parametros != null)
                        {
                            factura = (Factura)lista_parametros[0];
                            caso = (int)lista_parametros[1];
                        }
                        return new FrmFormasPago(ref factura, caso);
                    }
                case "repoStock":
                    return new FrmRepoStocks(this);
                case "repoFactura":
                    return new FrmReporteFacturas(this);
                case "GestorReporteFacturas":
                    return new GestorReporteFacturas();
                case "GestorReporteStock":
                    return new GestorReporteStock();
                case "GestorSucursal":
                    return new GestorSucursal();
                case "geolocalizacion":
                    return new FrmGeoLocalizacion();
                case "FrmReporteDescuentos":
                    return new FrmReporteDescuentos(this);


                default:
                    throw new ArgumentException($"Tipo de objeto inválido: {tipo}");
            }
        }


    }
}
