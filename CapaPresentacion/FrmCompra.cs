using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using CapaEntidades;
using CapaLogica;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion
{
    public partial class FrmCompra : Form
    {
        ClCliente oCliente = new ClCliente();
        ClassFACTURA oF = new ClassFACTURA();
        ClMueble oMueble = new ClMueble();
        ClLogica oLogica = new ClLogica();
        List<ClMueble> oListaA = new List<ClMueble>();
        List<ClassCOMPRA_MUEBLES> oListaFA = new List<ClassCOMPRA_MUEBLES> ();
        ClassCOMPRA_CLIENTES oFC = new ClassCOMPRA_CLIENTES();

        public FrmCompra()
        {
            InitializeComponent();
        }

        public FrmCompra(ClCliente oC)
        {
            InitializeComponent();

            oCliente = oC;
            btnclasico.Enabled = false;
            Console.WriteLine(oC.Cedula);
            ObtenerListaMuebles(btnclasico.Text);
            SubirBajar_Cantidad.Value = 0;
            Console.WriteLine("id_compra = "+oLogica.RetonarUltimaCompra());

        }

        private void ObtenerListaMuebles(string estilo)
        {
            oListaA = oLogica.FiltarMueblePorEstilo(estilo);
            //CmbNombre.Items.Clear();
            
                CmbNombre.DataSource = oListaA;
                CmbNombre.DisplayMember = "Nombre";
                CmbNombre.ValueMember = "IdMueble";
        }

        private void FrmCompra_Load(object sender, EventArgs e)
        { 
            btnPagar.Visible = false;
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnModerno_Click(object sender, EventArgs e)
        {
            if (btnModerno.Enabled)
            {
                btnModerno.Enabled = false;
                btnclasico.Enabled = true;
                btnRustico.Enabled = true;
            }
            ObtenerListaMuebles(btnModerno.Text);

        }

        private void btnclasico_Click(object sender, EventArgs e)
        {
            if (btnclasico.Enabled)
            {
                btnModerno.Enabled = true;
                btnclasico.Enabled = false;
                btnRustico.Enabled = true;
            }
            ObtenerListaMuebles(btnclasico.Text);
        }

        private void btnRustico_Click(object sender, EventArgs e)
        {
            if (btnRustico.Enabled)
            {
                btnModerno.Enabled = true;
                btnclasico.Enabled = true;
                btnRustico.Enabled = false;
            }
            ObtenerListaMuebles(btnRustico.Text);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CmbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbNombre.SelectedItem != null)
            {
                oMueble = (ClMueble)CmbNombre.SelectedItem;
                int idSeleccionado = oMueble.IdMueble;

                lblCodigo.Text = oMueble.IdMueble.ToString();
                lblTipo.Text = oMueble.Tipo;
                lblMaterial.Text = oMueble.Material;
                lblEstilo.Text = oMueble.Estilo;
                lblPrecio.Text = oMueble.PrecioVenta.ToString();
                //SubirBajar_Cantidad.Value = oMueble.Cantidad;

                PbxFoto.Image = DeBytesAImagen(oMueble.Foto);

                SubirBajar_Cantidad.Value = 0;
                SubirBajar_Cantidad.Minimum = 0;
                SubirBajar_Cantidad.Maximum = oMueble.Cantidad;
            }
        }

        private Image DeBytesAImagen(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int CantidadSeleccionada = (int)SubirBajar_Cantidad.Value;

            ClassCOMPRA_MUEBLES oFacturaArticulo = new ClassCOMPRA_MUEBLES();
            oFacturaArticulo.IdFacturaFA = oLogica.RetonarUltimaCompra();
            oFacturaArticulo.CodigoFA = oMueble.IdMueble;
            oFacturaArticulo.CantidadFA = CantidadSeleccionada;
            oFacturaArticulo.TotalFA = (decimal)oMueble.PrecioVenta * CantidadSeleccionada;

            oListaFA.Add(oFacturaArticulo);

            ClassGenerarFactura oGF = new ClassGenerarFactura(oListaFA);

            List<ClassProducto> oListaP = oGF.RetornarListaProductos();

            int N = oListaP.Count();

            Vista_Factura.RowCount = N;

            for (int k = 0; k < N; k++)
            {
                Vista_Factura.Rows[k].Cells[0].Value = oListaP[k].NombreArticulo;
                Vista_Factura.Rows[k].Cells[1].Value = oListaP[k].PrecioArticulo;
                Vista_Factura.Rows[k].Cells[2].Value = oListaP[k].CantidadArticulo;
                Vista_Factura.Rows[k].Cells[3].Value = oListaP[k].TotalArticulo;

            }

            btnAgregar.Enabled = true;
        }

        private void Vista_Factura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            oF.FechaActualFACTURA = DateTime.Now;

            oFC.IdFacturaFC = oLogica.RetonarUltimaCompra();
            oFC.CedulaFC = oCliente.Cedula;

            ClassGenerarFactura oGF = new ClassGenerarFactura(oListaFA);
            List<ClassCOMPRA_MUEBLES> oArticulosSeleccionados = oGF.AgruparPorIdYCodigo();

            oLogica.setFACTURA(oF);
            oLogica.setFACTURA_CLIENTE(oFC);
            foreach (ClassCOMPRA_MUEBLES x in oArticulosSeleccionados)
            {
                ClMueble oM = new ClMueble();
                oM = (ClMueble)CmbNombre.SelectedItem;
                oLogica.setFACTURA_ARTICULO(x);
                int EditarStock = oM.Cantidad - (int)(SubirBajar_Cantidad.Value);
                
                oM.Cantidad = EditarStock;

                oLogica.EditarMueble(oM);
            }

            
            decimal Total = oListaFA.Sum(x => x.TotalFA);

            lblTotal.Text = string.Format("Total: $ {0}", Total);
            oF = new ClassFACTURA();
            oListaFA = new List<ClassCOMPRA_MUEBLES>();
            btnPagar.Visible = true;
        }

        private void Btn_Reiniciar_Click(object sender, EventArgs e)
        {
            
            btnVender.Visible = true;

            Btn_Reiniciar.Visible = false;
            Btn_Reiniciar.Enabled = false;

            SubirBajar_Cantidad.Enabled = true;

            Vista_Factura.RowCount = 0;
            SubirBajar_Cantidad.Value = 0;

            lblTotal.Text = string.Format("Total: ...");

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
                try
                {
                    DialogResult rppta = MessageBox.Show("¿Desea eliminar producto?", "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (rppta == DialogResult.Yes)
                    {
                        // Eliminar el producto de la lista asociada (oListaFA) primero
                        if (Vista_Factura.CurrentRow != null)
                        {
                            int rowIndex = Vista_Factura.CurrentRow.Index;
                            oListaFA.RemoveAt(rowIndex); // Asumiendo que oListaFA está sincronizada con Vista_Factura

                            // Eliminar la fila del DataGridView
                            Vista_Factura.Rows.RemoveAt(rowIndex);
                        }

                        // Actualizar el valor total después de eliminar el producto
                        decimal Total = oListaFA.Sum(x => x.TotalFA);
                        lblTotal.Text = Total.ToString("C"); // Actualizar el label con el nuevo total, formateado como moneda
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void PbxFoto_Click(object sender, EventArgs e)
        {

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compra realizada con éxito!!");
            this.Close();
        }
    }
    
}
