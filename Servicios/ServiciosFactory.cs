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
                case "gestor_cliente":
                    return new GestorCliente();
                case "metodos_comunes":
                    return new MetodosComunes();
                case "gestor_buscador":
                    return new GestorBuscador();
                case "buscador_articulos":
                    return new FrmBuscador(this, "/api/Articulos/Obtener_Lista_Simple", "Seleccionar Artículo");
                case "factura":
                    return new FrmFacturas(this);
                case "buscador_clientes":
                    return new FrmBuscador(this, "/api/Clientes/Obtener_Lista_Simple", "Seleccionar Cliente");
                case "articulos":
                    return new FrmArticulos(this);
                case "cliente":
                    return new FrmClientes(this);


                default:
                    throw new ArgumentException($"Tipo de objeto inválido: {tipo}");
            }
        }


    }
}
