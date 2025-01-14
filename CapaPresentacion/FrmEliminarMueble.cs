using CapaEntidades;
using CapaLogica;
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

namespace CapaPresentacion
{
    public partial class FrmEliminarMueble : Form
    {
        ClCliente cliente = new ClCliente();
        ClMueble mueble = new ClMueble();
        ClLogica oL = new ClLogica();
        public FrmEliminarMueble()
        {
            InitializeComponent();
        }

        public FrmEliminarMueble(ClCliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                ClLogica oL = new ClLogica();
                List<ClMueble> muebles = oL.BuscarMueble(int.Parse(Txt_idMueble.Text));

                if (muebles == null || muebles.Count == 0)
                {
                    MessageBox.Show("Este muueble no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                ClMueble mueble = muebles[0];
                Lbl_idMueble.Text = mueble.IdMueble.ToString();
                LblNombre.Text = mueble.Nombre;
                LblTipo.Text = mueble.Tipo;
                LblMaterial.Text = mueble.Material;
                LblColor.Text = mueble.Color;
                LblAltura.Text = mueble.Altura.ToString();
                LblAncho.Text = mueble.Ancho.ToString();
                LblProfundidad.Text = mueble.Profundidad.ToString();
                LblPeso.Text = mueble.Peso.ToString();
                LblEstilo.Text = mueble.Estilo;
                LblPrecioC.Text = mueble.PrecioCoste.ToString();
                LblPrecioV.Text = mueble.PrecioVenta.ToString();
                LblCantidad.Text = mueble.Cantidad.ToString();
                //PbxFoto.Image = ByteArrayToImage(mueble.Foto);  // Convertir bytes a imagen
                LblDescripcion.Text = mueble.Descripcion;

                if (mueble.Foto != null && mueble.Foto.Length > 0)
                {
                    Console.WriteLine("Imagen recuperada: " + mueble.Foto.Length + " bytes.");
                    PbxFoto.Image = ByteArrayToImage(mueble.Foto);  // Convertir bytes a imagen
                }
                else
                {
                    Console.WriteLine("No hay imagen disponible para este mueble.");
                    PbxFoto.Image = null;  // Limpiar PictureBox si no hay imagen
                }


                Color colorFondo;
                colorFondo = Color.FromName(LblColor.Text);
                // Establece el color de fondo del Label
                panelColorSelec.BackColor = colorFondo;

                Color colorF = ColorTranslator.FromHtml(LblColor.Text);

                // Establece el color de fondo del Panel
                panelColorSelec.BackColor = colorF;

                BtnEliminar.Enabled = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un ID de mueble válido", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Image ByteArrayToImage(byte[] byteArray)
        {
            if (byteArray == null || byteArray.Length == 0)
                return null;

            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            List<ClMueble> muebles = oL.BuscarMueble(int.Parse(Txt_idMueble.Text));

            // Obtener la información del mueble
            ClMueble mueble = muebles[0];

            // Confirmar la eliminación
            if (ValidarAccion(mueble.Nombre))
            {
                // Eliminar el mueble
                oL.EliminarMueble(int.Parse(Txt_idMueble.Text));

                // Mostrar el mensaje de confirmación
                MessageBox.Show(string.Format("El mueble '{0}' fue eliminado.", mueble.Nombre), "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        private bool ValidarAccion(string A)
        {
            DialogResult resultado = MessageBox.Show(string.Format("¿Estás seguro de que quieres Eliminar el mueble '{0}'?", A), "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            return (resultado == DialogResult.Yes);
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void Txt_idMueble_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_idMueble_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Cancelar el evento de tecla presionada
                e.Handled = true;
            }
        }

        private void FrmEliminarMueble_Load(object sender, EventArgs e)
        {
            BtnEliminar.Enabled = false;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<ClMueble> muebles = oL.BuscarMueble(int.Parse(Txt_idMueble.Text));

            // Obtener la información del mueble
            ClMueble mueble = muebles[0];

            // Confirmar la eliminación
            if (ValidarAccion(mueble.Nombre))
            {
                // Eliminar el mueble
                oL.EliminarMueble(int.Parse(Txt_idMueble.Text));

                // Mostrar el mensaje de confirmación
                MessageBox.Show(string.Format("El mueble '{0}' fue eliminado.", mueble.Nombre), "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
