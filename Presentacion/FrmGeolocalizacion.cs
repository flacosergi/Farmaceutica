using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.MapProviders;
using GMap.NET;
using AccesoDatos.Modelos;
using Farmaceutica.Servicios;

namespace Farmaceutica.Presentacion
{
    public partial class FrmGeoLocalizacion : Form
    {
        public FrmGeoLocalizacion()
        {
            InitializeComponent();
        }

        MetodosComunes metodos = new MetodosComunes();
        GestorFactura gestor_factura = (GestorFactura)ServiciosFactory.ObtenerInstancia().CreaObjeto("gestor_factura");
        GestorCliente gestor_cliente = (GestorCliente)ServiciosFactory.ObtenerInstancia().CreaObjeto("gestor_cliente");

        private async void GeoLocalizacion_Load(object sender, EventArgs e)
        {
            //Configura Mapa
            gmMapa.DragButton = MouseButtons.Left;
            gmMapa.CanDragMap = true;
            gmMapa.MapProvider = GMapProviders.OpenStreetMap;
            gmMapa.SetPositionByKeywords("Córdoba, Argentina");
            gmMapa.MinZoom = 0;
            gmMapa.MaxZoom = 24;
            gmMapa.Zoom = 10;
            gmMapa.AutoScroll = true;


            List<Sucursal> lista = await gestor_factura.CargarSucursales();
            metodos.LlenaCombo(cboSucursal, lista.ToList<object>(), "nombre", "codigo_sucursal");
        }

        private void FrmGeoLocalizacion_Shown(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }

        private async void btnLocalizar_Click(object sender, EventArgs e)
        {
            List<GeoLoc> nueva_lista = new List<GeoLoc>();
            nueva_lista = await gestor_cliente.GetGeoLoc((int)cboSucursal.SelectedValue);
            gmMapa.Overlays.Clear();
            foreach (GeoLoc gl in nueva_lista)
            {
                if (gl.tipo == 1)
                {
                    gmMapa.SetPositionByKeywords(gl.domicilio);
                    GMapOverlay markersoverlay = new GMapOverlay("markers");
                    GMarkerGoogle marker = new GMarkerGoogle(gmMapa.Position, GMarkerGoogleType.green);
                    marker.ToolTipText = gl.nombre;
                    markersoverlay.Markers.Add(marker);
                    gmMapa.Overlays.Add(markersoverlay);
                }
                else
                {
                    gmMapa.SetPositionByKeywords(gl.domicilio);
                    GMapOverlay markersoverlay = new GMapOverlay("markers");
                    GMarkerGoogle marker = new GMarkerGoogle(gmMapa.Position, GMarkerGoogleType.red);
                    marker.ToolTipText = gl.nombre;
                    markersoverlay.Markers.Add(marker);
                    gmMapa.Overlays.Add(markersoverlay);
                }
            }
            gmMapa.Zoom = 20;
            gmMapa.Refresh();
            gmMapa.Zoom = 14;
        }

        private void cboSucursal_SelectionChangeCommitted(object sender, EventArgs e)
        {
            btnLocalizar.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
