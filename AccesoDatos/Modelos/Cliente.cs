using AccesoDatos.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Modelos
{
    public class Cliente
    {
        public int codigo_cliente { get; set; }
        public TipoDoc tipo_doc { get; set; }
        public long nro_doc { get; set; }
        public TipoCliente tipo_cliente { get; set; }
        public string? nombre { get; set; }
        public string? apellido { get; set; }
        public string? razon_social { get; set; }
        public  string calle { get; set; }
        public int numero { get; set; }
        public int cod_postal { get; set; }
        public Localidad localidad { get; set; }
        public ObraSocial obra_social { get; set; }

        public long? num_afiliado { get; set; }
        public DateTime fecha_alta { get; set; }

        public PlanOS plan_os { get; set; }

        public Cliente()
        {
            ModeloFactory factory = new ModeloFactory();
            codigo_cliente = 0;
            tipo_doc = (TipoDoc)factory.CreaObjeto("tipo_doc");
            nro_doc = 0;
            tipo_cliente = (TipoCliente)factory.CreaObjeto("tipo_cliente");
            calle = string.Empty;
            numero = 0;
            cod_postal = 0;
            localidad = (Localidad)factory.CreaObjeto("localidad");
            obra_social = (ObraSocial)factory.CreaObjeto("obra_social");
            num_afiliado = 0;
            plan_os = (PlanOS)factory.CreaObjeto("plan_os");
        }
    }
}
