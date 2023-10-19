﻿using APIFarmaceutica.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace APIFarmaceutica.Modelos
{
    public class Articulo
    {
        public int cod_articulo { get; set; }
        public Tipo_Articulo tipo_articulo { get; set; }
        public Unidad_Medida unidad_medida { get; set; }
        public decimal cant_um { get; set; }
        public string detalle { get; set; }
        public decimal precio { get; set; }
        public decimal stock_maximo { get; set; }
        public decimal stock_minimo { get; set; }
        public long codigo_barras { get; set; }

        public Articulo(AbstractFactory factory)
        {
            cod_articulo = 0;
            tipo_articulo = (Tipo_Articulo)factory.CreaObjeto("tipo_articulo");
            unidad_medida = (Unidad_Medida)factory.CreaObjeto("unidad_medida");
            cant_um = 0;
            detalle = string.Empty;
            precio = 0;
            stock_maximo = 0;
            stock_minimo = 0;
            codigo_barras = 0;
        }

    }
}
