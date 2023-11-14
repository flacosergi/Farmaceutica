using AccesoDatos.Modelos;
using AccesoDatos.Servicios;
using Farmaceutica.Servicios;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Farmaceutica.Presentacion
{
 
    public partial class FrmArticulos : Form
    {
        const int Consultar = 1;
        const int Modificar = 2;

        List<Tipo_Articulo> lista = new List<Tipo_Articulo>();
        GestorArticulos gestor_art;
        MetodosComunes metodos;
        ServiciosFactory factoria;
        ModeloFactory factoria_modelos = new ModeloFactory();
        Articulo nuevo_articulo; 

        public FrmArticulos(ServiciosFactory fact)
        {
            InitializeComponent();
            factoria = fact;
            gestor_art = (GestorArticulos)factoria.CreaObjeto("gestor_art");
            metodos = (MetodosComunes)factoria.CreaObjeto("metodos_comunes");
            nuevo_articulo = (Articulo)factoria_modelos.CreaObjeto("articulo");
            CenterToScreen();
        }


        private async void Articulos_Load(object sender, EventArgs e)
        {
            List<Tipo_Articulo> lista = await gestor_art.GetTipoArticulos();
            metodos.LlenaCombo(cbo_tipo_art, lista.ToList<object>(), "detalle", "id_tipo_articulo");

            List<Marca> lista_m = await gestor_art.GetMarcas();
            metodos.LlenaCombo(cbo_marca, lista_m.ToList<object>(), "detalle", "id_marca");

            List<Unidad_Medida> lista_um = await gestor_art.GetUM();
            metodos.LlenaCombo(cboUM, lista_um.ToList<object>(), "detalle", "id_u_medida");

        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            pnlCarga.Enabled = true;
            btnGuardar.Enabled = true;
            chbActivo.Checked = true;
            chbActivo.Enabled = false;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnConsultar.Enabled = false;
            txtDescripcion.Focus();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            metodos.LimpiaControles(pnlCarga);
            btnGuardar.Enabled = false;
            pnlCarga.Enabled = false;
            chbActivo.Enabled = true;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnConsultar.Enabled = true;
            lbl_cod_art.Text = "000";
            metodos.BloqueaControles(pnlCarga, false);
            btnAgregaImagen.Enabled = true;
            btnBorraImagen.Enabled = true;
            btnGuardar.Text = "Guardar";
            nuevo_articulo = (Articulo)factoria_modelos.CreaObjeto("articulo");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregaImagen_Click(object sender, EventArgs e)
        {
            pbArticulo.ImageLocation = metodos.BuscarImagen(pbArticulo);
        }

        private void btnBorraImagen_Click(object sender, EventArgs e)
        {
            pbArticulo.Image = null;
            pbArticulo.ImageLocation = null;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarControles() == false)
                return;
            nuevo_articulo.detalle = txtDescripcion.Text;
            nuevo_articulo.tipo_articulo = (Tipo_Articulo)cbo_tipo_art.SelectedItem;
            nuevo_articulo.marca = (Marca)cbo_marca.SelectedItem;
            nuevo_articulo.unidad_medida = (Unidad_Medida)cboUM.SelectedItem;
            nuevo_articulo.cant_um = (decimal)ntbCantidad.ValorDecimal;
            nuevo_articulo.precio = (decimal)ntbPrecio.ValorDecimal;
            nuevo_articulo.stock_maximo = ntbStockMaximo.ValorEntero;
            nuevo_articulo.stock_minimo = ntbStockMinimo.ValorEntero;
            nuevo_articulo.codigo_barras = ntbCodBarras.ValorEntero;
            nuevo_articulo.activo = chbActivo.Checked;
            if (pbArticulo.ImageLocation != null)
                nuevo_articulo.imagen = Path.GetFileName(pbArticulo.ImageLocation);
            else
                if(pbArticulo.Image == null)
                    nuevo_articulo.imagen = string.Empty;            
            string resultado;
            if (btnGuardar.Text == "Guardar")
                resultado = await gestor_art.IngresarArticulo(nuevo_articulo);
            else
                resultado = await gestor_art.ModificarArticulo(nuevo_articulo);
            string respuestaIMG = string.Empty;
            if (pbArticulo.ImageLocation != null)
            {
                respuestaIMG = await gestor_art.Upload(pbArticulo.ImageLocation);
            }
            if (resultado == "OK")
            {
                if (btnGuardar.Text == "Guardar")
                    MessageBox.Show("El artículo se ingresó correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("El artículo fue modificado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLimpiar_Click(this, EventArgs.Empty);
            }
            else
                MessageBox.Show("Se ha producido un error. El artículo no pudo ser guardado.", "Atención:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (respuestaIMG != "OK" && pbArticulo.ImageLocation != null)
                MessageBox.Show("Se ha producido un error al guardar la imagen.", "Atención:", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool ValidarControles()
        {
            if (txtDescripcion.Text == string.Empty)
            {
                MessageBox.Show("Debe indicar una descripción del artículo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDescripcion.Focus();
                return false;
            }

            if (cbo_tipo_art.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un tipo de artículo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbo_tipo_art.Focus();
                return false;
            }

            if (cbo_marca.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un marca para el artículo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbo_marca.Focus();
                return false;
            }

            if (cboUM.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una unidad de medida para el artículo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboUM.Focus();
                return false;
            }

            if (ntbCantidad.Text == string.Empty)
            {
                MessageBox.Show("Ingrese una cantidad de artículo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ntbCantidad.Focus();
                return false;
            }

            if (ntbPrecio.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un precio para el artículo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ntbPrecio.Focus();
                return false;
            }

            if (ntbStockMaximo.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un valor de stock máximo para el artículo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ntbStockMaximo.Focus();
                return false;
            }

            if (ntbStockMinimo.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un valor de stock mínimo para el artículo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ntbStockMinimo.Focus();
                return false;
            }

            if (ntbCodBarras.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un código de barras para el artículo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ntbCodBarras.Focus();
                return false;
            }

            return true;
        }

        private void FrmArticulos_Shown(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            RellenarArticulo(Consultar);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            RellenarArticulo(Modificar);
            btnGuardar.Text = "Modificar";
            btnGuardar.Enabled = true;
        }

        private async void RellenarArticulo(int accion)
        {
            FrmBuscador buscador_articulos = (FrmBuscador)factoria.CreaObjeto("buscador_articulos");
            Opacity = 0.5;
            if (buscador_articulos.ShowDialog(this) == DialogResult.OK)
            {
                int codigo_buscado = Convert.ToInt32(buscador_articulos.dgvBusqueda.SelectedRows[0].Cells[0].Value.ToString());
                Articulo? articulo_buscado = await gestor_art.ObtenerArticuloPorID(codigo_buscado);
                if (articulo_buscado != null)
                {
                    Opacity = 1;
                    Cursor.Current = Cursors.WaitCursor;
                    lbl_cod_art.Text = articulo_buscado.cod_articulo.ToString();
                    txtDescripcion.Text = articulo_buscado.detalle;
                    cbo_tipo_art.SelectedValue = articulo_buscado.tipo_articulo.id_tipo_articulo;
                    cbo_marca.SelectedValue = articulo_buscado.marca.id_marca;
                    cboUM.SelectedValue = articulo_buscado.unidad_medida.id_u_medida;
                    ntbCantidad.Text = articulo_buscado.cant_um.ToString();
                    ntbPrecio.Text = articulo_buscado.precio.ToString();
                    ntbStockMaximo.Text = articulo_buscado.stock_maximo.ToString();
                    ntbStockMinimo.Text = articulo_buscado.stock_minimo.ToString();
                    ntbCodBarras.Text = articulo_buscado.codigo_barras.ToString();
                    chbActivo.Checked = articulo_buscado.activo;
                    if(articulo_buscado.imagen !=null) 
                        pbArticulo.Image = await gestor_art.DownLoad(articulo_buscado.imagen);
                    nuevo_articulo = articulo_buscado;
                    pnlCarga.Enabled = true;
                    Cursor.Current = Cursors.Default;
                    if (accion == Consultar)
                    {
                        metodos.BloqueaControles(pnlCarga, true);
                        btnAgregaImagen.Enabled = false;
                        btnBorraImagen.Enabled = false;
                    }
                }
                else
                {
                    Opacity = 1;
                    MessageBox.Show("No pudo encontrarse el artículo buscado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                btnLimpiar_Click(this, MouseEventArgs.Empty);
                Opacity = 1;
                return;
            }
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnConsultar.Enabled = false;

        }

 
    }

}
