using AccesoDatos.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Modelos
{
    public class ObraSocial
    {
        public int codigo_os { get; set; }
        public TipoDoc tipo_doc { get; set; }
        public long nro_doc { get; set; }
        public string razon_social_os { get; set; }
        public string? sigla { get; set; }
        public string calle { get; set; }
        public int numero { get; set; }
        public int cod_postal { get; set; }
        public Localidad localidad { get; set; }
        public DateTime fecha_alta { get; set; }
        public bool activa { get; set; }

        public ObraSocial()
        {
            codigo_os = 0;
            tipo_doc = (TipoDoc)ModeloFactory.ObtenerInstancia().CreaObjeto("tipo_doc");
            nro_doc = 0;
            razon_social_os = string.Empty;
            calle = string.Empty;
            numero = 0;
            cod_postal = 0;
            localidad = (Localidad)ModeloFactory.ObtenerInstancia().CreaObjeto("localidad");
            fecha_alta = new DateTime();
            activa = true;
        }

    }
}
