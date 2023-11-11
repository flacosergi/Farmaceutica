using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.Servicios;

namespace AccesoDatos.Modelos
{
    public class Articulo
    {
        public int cod_articulo { get; set; }
        public Tipo_Articulo tipo_articulo { get; set; }
        public Unidad_Medida unidad_medida { get; set; }
        public Marca marca { get; set; }
        public decimal cant_um { get; set; }
        public string detalle { get; set; }
        public decimal precio { get; set; }
        public decimal stock_maximo { get; set; }
        public decimal stock_minimo { get; set; }
        public long codigo_barras { get; set; }
        public bool activo { get; set; }
        public string? imagen { get; set; }

        public Articulo()
        {
            ModeloFactory factory = new ModeloFactory();
            cod_articulo = 0;
            tipo_articulo = (Tipo_Articulo)factory.CreaObjeto("tipo_articulo");
            unidad_medida = (Unidad_Medida)factory.CreaObjeto("unidad_medida");
            marca = (Marca)factory.CreaObjeto("marca");
            cant_um = 0;
            detalle = string.Empty;
            precio = 0;
            stock_maximo = 0;
            stock_minimo = 0;
            codigo_barras = 0;
            activo = true;
            imagen = string.Empty;
        }

    }
}
