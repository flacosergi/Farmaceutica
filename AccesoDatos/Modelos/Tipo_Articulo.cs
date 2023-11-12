using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Modelos
{
    public class Tipo_Articulo
    {
        public int id_tipo_articulo { get; set; }
        public string detalle { get; set; }

        public enum Tipos: int
        {
            MedicamentoConReceta = 1,
            MedicamentoVentaLibre = 2,
            MedicamentoRecetaArchivada = 3,
            Perfumeria = 4,
            HigienePersonal = 5,
            Comestibles = 6,
            Limpieza = 7,
            Ortopedia = 8,
            Deporte = 9
        }
        public Tipo_Articulo()
        {
            id_tipo_articulo = 0;
            detalle = string.Empty;
        }

    }
}
