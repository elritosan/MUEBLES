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
using CapaEntidades;
using CapaLogica;

namespace CapaPresentacion
{
    public partial class FrmIngresar : Form
    {
        int idMueble, cant_stock;
        string nombre, tipo, material, color, estilo, descripcion;
        double altura, ancho, profundidad, peso, precio_coste, precio_venta;
        ClMueble objMueble = new ClMueble();
        ClLogica objLog = new ClLogica();
        // Crear y configurar el ColorDialog
        ColorDialog colorDialog = new ColorDialog();

        private void txtPesoMueble_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                // Cancelar la pulsación de tecla si no es un número, una coma decimal ni la tecla de retroceso
                e.Handled = true;
            }

            // Permitir solo dos decimales
            if (char.IsDigit(e.KeyChar))
            {
                string[] parts = txtPesoMueble.Text.Split(',');
                if (parts.Length > 1 && parts[1].Length >= 2)
                {
                    // Si ya hay dos decimales, cancelar la pulsación de tecla
                    e.Handled = true;
                }
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    double valor = Convert.ToDouble(txtPesoMueble.Text);
                    if (valor < 2.0 || valor > 1000.0) // Ajusta el rango según lo que consideres razonable
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    peso = valor;
                    CmBxEstiloMueble.Focus();
                }
                catch
                {
                    MessageBox.Show("El Peso fuera del rango establecido");
                    txtPesoMueble.Clear();
                }
            }
        }

        private void txtPrecioCoste_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                // Cancelar la pulsación de tecla si no es un número, un punto decimal ni la tecla de retroceso
                e.Handled = true;
            }

            // Permitir solo dos decimales
            if (char.IsDigit(e.KeyChar))
            {
                string[] parts = txtPrecioCoste.Text.Split(',');
                if (parts.Length > 1 && parts[1].Length >= 2)
                {
                    // Si ya hay dos decimales, cancelar la pulsación de tecla
                    e.Handled = true;
                }
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    precio_coste = Convert.ToDouble(txtPrecioCoste.Text);
                    txtPrecioVenta.Focus();
                }
                catch
                {
                    MessageBox.Show("Ingreso incorrecto, intente de nuevo");
                    txtPrecioCoste.Clear();
                    return;
                }
            }
        }

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                // Cancelar la pulsación de tecla si no es un número, un punto decimal ni la tecla de retroceso
                e.Handled = true;
            }

            // Permitir solo dos decimales
            if (char.IsDigit(e.KeyChar))
            {
                string[] parts = txtPrecioVenta.Text.Split(',');
                if (parts.Length > 1 && parts[1].Length >= 2)
                {
                    // Si ya hay dos decimales, cancelar la pulsación de tecla
                    e.Handled = true;
                }
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    precio_venta = Convert.ToDouble(txtPrecioVenta.Text);
                    if (precio_venta <= precio_coste)
                    {
                        MessageBox.Show("El precio de venta debe ser mayor que el precio de coste. Por favor, ingrese un precio de venta válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtPrecioVenta.Clear();
                        return;
                    }
                    else
                    {
                        txtStock.Focus();

                    }
                }
                catch
                {
                    MessageBox.Show("Ingreso incorrecto, intente de nuevo");
                    txtPrecioVenta.Clear();
                    return;
                }
            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Cancelar la pulsación de tecla si no es un número ni la tecla de retroceso
                e.Handled = true;
            }

            if (e.KeyChar == '0' && txtStock.Text.Length == 0)
            {
                // Cancelar la pulsación de tecla si se intenta ingresar un cero al inicio
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    cant_stock = Convert.ToInt16(txtStock.Text);
                }
                catch
                {
                    MessageBox.Show("Ingreso incorrecto, intente de nuevo");
                    txtStock.Clear();
                    return;
                }
            }

            if (txtStock.Text.Length >= 3 && e.KeyChar != (char)Keys.Back)
            {
                // Cancelar la pulsación de tecla si se intenta ingresar más de 3 cifras
                e.Handled = true;
            }
        }

        private void txtDescriMueble_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    descripcion = txtDescriMueble.Text;
                }
                catch
                {
                    MessageBox.Show("Ingreso incorrecto, intente de nuevo");
                    txtDescriMueble.Clear();
                    return;
                }
            }
        }

        private void btnGuardarMueble_Click(object sender, EventArgs e)
        {
            if (PbxImagenMueble.Image == null)
            {
                MessageBox.Show("Debes subir una imagen del mueble.", "Imagen requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                decimal precioCoste = Convert.ToDecimal(txtPrecioCoste.Text);
                decimal precioVenta = Convert.ToDecimal(txtPrecioVenta.Text);

                if (precioVenta <= precioCoste)
                {
                    MessageBox.Show("El precio de venta debe ser mayor que el precio de coste. Por favor, ingrese un precio de venta válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPrecioVenta.Clear();
                    return;
                }
                else
                {
                    // Convertir el color seleccionado a un valor hexadecimal
                    string colorHex = ColorTranslator.ToHtml(colorDialog.Color);


                    objMueble.IdMueble = Convert.ToInt16(txtid_mueble.Text);
                    objMueble.Nombre = txtNombreMueble.Text;
                    objMueble.Tipo = txtTipoMueble.Text;
                    objMueble.Material = CmBxMaterialMueble.Text;
                    objMueble.Color = colorHex;
                    objMueble.Altura = Convert.ToDecimal(txtAlturaMueble.Text);
                    objMueble.Ancho = Convert.ToDecimal(txtAnchoMueble.Text);
                    objMueble.Profundidad = Convert.ToDecimal(txtProfundidadMueble.Text);
                    objMueble.Peso = Convert.ToDecimal(txtPesoMueble.Text);
                    objMueble.Estilo = CmBxEstiloMueble.Text;
                    objMueble.PrecioCoste = Convert.ToDecimal(txtPrecioCoste.Text);
                    objMueble.PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text);
                    objMueble.Cantidad = Convert.ToInt16(txtStock.Text);
                    // Convertir la imagen a un arreglo de bytes
                    objMueble.Foto = ImageToByteArray(PbxImagenMueble.Image);
                    objMueble.Descripcion = txtDescriMueble.Text;

                    objLog.EnviarDatos(objMueble);

                    this.Hide();
                    // Suponiendo que tienes un objeto ClCliente llamado cliente
                    ClCliente cliente = new ClCliente(); // Asegúrate de inicializar correctamente ClCliente con los datos necesarios

                    // Luego creas una instancia de FrmMenu pasando cliente como parámetro
                    FrmMenu objM = new FrmMenu(cliente);

                    // Finalmente, muestras el formulario FrmMenu de manera modal
                    objM.ShowDialog();

                    // Cierras el formulario actual
                    this.Close();
                }
        }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, llene todos los campos.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        private void CmBxMaterialMueble_SelectedIndexChanged(object sender, EventArgs e)
        {
            material = CmBxMaterialMueble.Text;
        }

        private void txtProfundidadMueble_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

            if (char.IsDigit(e.KeyChar))
            {
                string[] parts = txtProfundidadMueble.Text.Split(',');
                if (parts.Length > 1 && parts[1].Length >= 2)
                {
                    e.Handled = true;
                }
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    double valor = Convert.ToDouble(txtProfundidadMueble.Text);
                    if (valor < 0.4 || valor > 2.0) // Ajusta el rango según lo que consideres razonable
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    profundidad = valor;
                    txtPesoMueble.Focus();
                }
                catch
                {
                    MessageBox.Show("El valor de la profundidad esta fuera del rango establecido");
                    txtProfundidadMueble.Clear();
                }
            }
        }

        private void CmBxMaterialMueble_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CmBxEstiloMueble_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtAnchoMueble_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

            if (char.IsDigit(e.KeyChar))
            {
                string[] parts = txtAnchoMueble.Text.Split(',');
                if (parts.Length > 1 && parts[1].Length >= 2)
                {
                    e.Handled = true;
                }
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    double valor = Convert.ToDouble(txtAnchoMueble.Text);
                    if (valor < 0.4 || valor > 2.0) // Ajusta el rango según lo que consideres razonable
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    ancho = valor;
                    txtProfundidadMueble.Focus();
                }
                catch
                {
                    MessageBox.Show("El valor de ancho esta fuera del rango establecido");
                    txtAnchoMueble.Clear();
                }
            }
        }

        private void txtAlturaMueble_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

            if (char.IsDigit(e.KeyChar))
            {
                string[] parts = txtAlturaMueble.Text.Split(',');
                if (parts.Length > 1 && parts[1].Length >= 2)
                {
                    e.Handled = true;
                }
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    double valor = Convert.ToDouble(txtAlturaMueble.Text);
                    if (valor < 0.4 || valor > 2.0) // Ajusta el rango según lo que consideres razonable
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    altura = valor;
                    txtAnchoMueble.Focus();
                }
                catch
                {
                    MessageBox.Show("El valor de la altura  esta fuera del rango establecido");
                    txtAlturaMueble.Clear();
                }
            }
        }

        private void txtTipoMueble_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es una letra, cancelar el evento
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    tipo = txtTipoMueble.Text;
                    CmBxMaterialMueble.Focus();
                }
                catch
                {
                    MessageBox.Show("Ingreso incorrecto, intente de nuevo");
                    txtTipoMueble.Clear();
                    return;
                }
            }
        }

        private void txtNombreMueble_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    nombre = txtNombreMueble.Text;
                    txtTipoMueble.Focus();
                }
                catch
                {
                    MessageBox.Show("Ingreso incorrecto, intente de nuevo");
                    txtNombreMueble.Clear();
                    return;
                }
            }
        }

        private void txtid_mueble_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    idMueble = Convert.ToInt16(txtid_mueble.Text);

                    ClLogica oL = new ClLogica();
                    List<ClMueble> muebles = oL.BuscarMueble(idMueble);
                    if (muebles.Any(m => m.IdMueble == idMueble))
                    {
                        MessageBox.Show("Ya existe este código, por favor ingrese otro.", "ID Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtid_mueble.Clear();
                    }
                    else
                    {
                        txtNombreMueble.Enabled = true;
                        txtNombreMueble.Enabled = true;
                        txtTipoMueble.Enabled = true;
                        CmBxMaterialMueble.Enabled = true;
                        btnColor.Enabled = true;
                        txtAlturaMueble.Enabled = true;
                        txtAnchoMueble.Enabled = true;
                        txtProfundidadMueble.Enabled = true;
                        txtPesoMueble.Enabled = true;
                        CmBxEstiloMueble.Enabled = true;
                        txtPrecioCoste.Enabled = true;
                        txtPrecioVenta.Enabled = true;
                        txtStock.Enabled = true;
                        btnCargaImagen.Enabled = true;
                        PbxImagenMueble.Enabled = true;
                        txtDescriMueble.Enabled = true;

                        txtNombreMueble.Focus();

                    }
                }
                catch
                {
                    MessageBox.Show("Ingreso incorrecto, intente de nuevo");
                    txtid_mueble.Clear();
                    return;
                }

            }
        }

        
        public FrmIngresar()
        {
            InitializeComponent();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            // Mostrar el diálogo y verificar si se seleccionó un color
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // Establecer el color seleccionado como el color de fondo del panel
                panelColorSelec.Visible = true;
                // Obtener el color seleccionado
                panelColorSelec.BackColor = colorDialog.Color;
                btnColor.Visible = false;
            }
        }

        private void FrmIngresar_Load(object sender, EventArgs e)
        {
            PbxImagenMueble.Visible = false;
            panelColorSelec.Visible = false;

            txtNombreMueble.Enabled = false;
            txtNombreMueble.Enabled = false;
            txtTipoMueble.Enabled = false;
            CmBxMaterialMueble.Enabled = false;
            btnColor.Enabled = false;
            txtAlturaMueble.Enabled = false;
            txtAnchoMueble.Enabled = false;
            txtProfundidadMueble.Enabled = false;
            txtPesoMueble.Enabled = false;
            CmBxEstiloMueble.Enabled = false;
            txtPrecioCoste.Enabled = false;
            txtPrecioVenta.Enabled = false;
            txtStock.Enabled = false;
            btnCargaImagen.Enabled = false;
            PbxImagenMueble.Enabled = false;
            txtDescriMueble.Enabled = false;
        }

        private void btnCargaImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Seleccione una imagen";
            ofd.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;";

            // Mostrar el diálogo y verificar si se seleccionó un archivo
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Cargar la imagen en el PictureBox
                PbxImagenMueble.Visible = true;
                PbxImagenMueble.Image = new System.Drawing.Bitmap(ofd.FileName);
                btnCargaImagen.Visible = false;
            }
        }

        private void btnCancelarMueble_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Suponiendo que tienes un objeto ClCliente llamado cliente
            ClCliente cliente = new ClCliente(); // Asegúrate de inicializar correctamente ClCliente con los datos necesarios

            // Luego creas una instancia de FrmMenu pasando cliente como parámetro
            FrmMenu objM = new FrmMenu(cliente);

            // Finalmente, muestras el formulario FrmMenu de manera modal
            objM.ShowDialog();

            // Cierras el formulario actual
            this.Close();
        }
        private Image DeBytesAImagen(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
