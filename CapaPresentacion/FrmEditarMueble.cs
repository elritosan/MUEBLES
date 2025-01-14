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
    public partial class FrmEditarMueble : Form
    {
        ClCliente cliente = new ClCliente();
        ClMueble oMueble = new ClMueble();
        ClLogica oL = new ClLogica();

        int idMueble, cant_stock;
        string nombre, tipo, material, color, estilo, descripcion;
        double altura, ancho, profundidad, peso, precio_coste, precio_venta;

        public FrmEditarMueble()
        {
            InitializeComponent();
        }
        public FrmEditarMueble(ClCliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(TxtPrecioV.Text) <= Convert.ToDecimal(TxtPrecioC.Text))
                {
                    MessageBox.Show("El precio de venta debe ser mayor que el precio de coste. Por favor, ingrese un precio de venta válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtPrecioV.Clear();

                }
                else
                {
                    // Buscar el mueble usando el ID proporcionado
                    List<ClMueble> muebles = oL.BuscarMueble(int.Parse(Txt_idMueble.Text));

                    if (muebles == null || muebles.Count == 0)
                    {
                        MessageBox.Show("El artículo no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Obtener la información del mueble
                    ClMueble mueble = muebles[0];

                    // Confirmar la acción de edición
                    if (ValidarAccion(mueble.Nombre))
                    {
                        // Actualizar los valores del mueble
                        mueble.Nombre = TxtNombre.Text;
                        mueble.Tipo = TxtTipo.Text;
                        mueble.Material = CmBxMaterialMueble.Text;
                        mueble.Peso = decimal.Parse(TxtPeso.Text);
                        mueble.Color = ColorTranslator.ToHtml(colorDialog1.Color);
                        mueble.Ancho = decimal.Parse(TxtAncho.Text);
                        mueble.Altura = decimal.Parse(TxtAltura.Text);
                        mueble.Profundidad = decimal.Parse(TxtProfundidad.Text);
                        mueble.Estilo = CmBxEstiloMueble.Text;
                        mueble.PrecioCoste = decimal.Parse(TxtPrecioC.Text);
                        mueble.PrecioVenta = decimal.Parse(TxtPrecioV.Text);
                        mueble.Cantidad = int.Parse(TxtCantidad.Text);
                        mueble.Descripcion = TxtDescripcion.Text;

                        // Solo actualizar la imagen si se ha seleccionado una nueva
                        if (PbxFoto.Image != null)
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                // Asegúrate de que la imagen no esté en uso
                                Bitmap bmp = new Bitmap(PbxFoto.Image);
                                bmp.Save(ms, PbxFoto.Image.RawFormat);
                                mueble.Foto = ms.ToArray();
                                bmp.Dispose();
                            }
                        }

                        // Editar el mueble
                        oL.EditarMueble(mueble);
                        MessageBox.Show("Edición completada", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores válidos en todos los campos.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarAccion(string A)
        {
            // Muestra un cuadro de diálogo de confirmación
            DialogResult resultado = MessageBox.Show(string.Format("¿Estás seguro de que quieres Editar '{0}'?", A), "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            return (resultado == DialogResult.Yes);
        }

        private void TxtTipo_KeyPress(object sender, KeyPressEventArgs e)
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
                    tipo = TxtTipo.Text;
                    CmBxMaterialMueble.Focus();
                }
                catch
                {
                    MessageBox.Show("Ingreso incorrecto, intente de nuevo");
                    TxtTipo.Clear();
                    return;
                }
            }
        }

        private void TxtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

            if (char.IsDigit(e.KeyChar))
            {
                string[] parts = TxtAltura.Text.Split(',');
                if (parts.Length > 1 && parts[1].Length >= 2)
                {
                    e.Handled = true;
                }
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    double valor = Convert.ToDouble(TxtAltura.Text);
                    if (valor < 0.4 || valor > 2.0) // Ajusta el rango según lo que consideres razonable
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    altura = valor;
                    TxtAncho.Focus();
                }
                catch
                {
                    MessageBox.Show("Ingreso incorrecto, intente de nuevo");
                    TxtAltura.Clear();
                }
            }
        }

        private void TxtAncho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

            if (char.IsDigit(e.KeyChar))
            {
                string[] parts = TxtAncho.Text.Split(',');
                if (parts.Length > 1 && parts[1].Length >= 2)
                {
                    e.Handled = true;
                }
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    double valor = Convert.ToDouble(TxtAncho.Text);
                    if (valor < 0.4 || valor > 2.0) // Ajusta el rango según lo que consideres razonable
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    ancho = valor;
                    TxtProfundidad.Focus();
                }
                catch
                {
                    MessageBox.Show("Ingreso incorrecto, intente de nuevo");
                    TxtAncho.Clear();
                }
            }
        }

        private void TxtProfundidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

            if (char.IsDigit(e.KeyChar))
            {
                string[] parts = TxtProfundidad.Text.Split(',');
                if (parts.Length > 1 && parts[1].Length >= 2)
                {
                    e.Handled = true;
                }
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    double valor = Convert.ToDouble(TxtProfundidad.Text);
                    if (valor < 0.4 || valor > 2.0) // Ajusta el rango según lo que consideres razonable
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    profundidad = valor;
                    TxtPeso.Focus();
                }
                catch
                {
                    MessageBox.Show("Ingreso incorrecto, intente de nuevo");
                    TxtProfundidad.Clear();
                }
            }
        }

        private void TxtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                // Cancelar la pulsación de tecla si no es un número, una coma decimal ni la tecla de retroceso
                e.Handled = true;
            }

            // Permitir solo dos decimales
            if (char.IsDigit(e.KeyChar))
            {
                string[] parts = TxtPeso.Text.Split(',');
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
                    double valor = Convert.ToDouble(TxtPeso.Text);
                    if (valor < 2.0 || valor > 1000.0) // Ajusta el rango según lo que consideres razonable
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    peso = valor;
                    CmBxEstiloMueble.Focus();
                }
                catch
                {
                    MessageBox.Show("Peso fuera del rango establecido");
                    TxtPeso.Clear();
                }
            }
        }

        private void TxtPrecioC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                // Cancelar la pulsación de tecla si no es un número, un punto decimal ni la tecla de retroceso
                e.Handled = true;
            }

            // Permitir solo dos decimales
            if (char.IsDigit(e.KeyChar))
            {
                string[] parts = TxtPrecioC.Text.Split(',');
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
                    precio_coste = Convert.ToDouble(TxtPrecioC.Text);
                    TxtPrecioV.Focus();
                }
                catch
                {
                    MessageBox.Show("Ingreso incorrecto, intente de nuevo");
                    TxtPrecioC.Clear();
                    return;
                }
            }
        }

        private void TxtPrecioV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                // Cancelar la pulsación de tecla si no es un número, un punto decimal ni la tecla de retroceso
                e.Handled = true;
            }

            // Permitir solo dos decimales
            if (char.IsDigit(e.KeyChar))
            {
                string[] parts = TxtPrecioV.Text.Split(',');
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
                    precio_venta = Convert.ToDouble(TxtPrecioV.Text);
                    if (precio_venta <= precio_coste)
                    {
                        MessageBox.Show("El precio de venta debe ser mayor que el precio de coste. Por favor, ingrese un precio de venta válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TxtPrecioV.Clear();
                        return;
                    }
                    else
                    {
                        TxtCantidad.Focus();

                    }
                }
                catch
                {
                    MessageBox.Show("Ingreso incorrecto, intente de nuevo");
                    TxtPrecioV.Clear();
                    return;
                }
            }
        }

        private void CmBxEstiloMueble_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CmBxMaterialMueble_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void TxtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Cancelar la pulsación de tecla si no es un número ni la tecla de retroceso
                e.Handled = true;
            }

            if (e.KeyChar == '0' && TxtCantidad.Text.Length == 0)
            {
                // Cancelar la pulsación de tecla si se intenta ingresar un cero al inicio
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    cant_stock = Convert.ToInt16(TxtCantidad.Text);
                }
                catch
                {
                    MessageBox.Show("Ingreso incorrecto, intente de nuevo");
                    TxtCantidad.Clear();
                    return;
                }
            }

            if (TxtCantidad.Text.Length >= 3 && e.KeyChar != (char)Keys.Back)
            {
                // Cancelar la pulsación de tecla si se intenta ingresar más de 3 cifras
                e.Handled = true;
            }
        }

        private void TxtAltura_TextChanged(object sender, EventArgs e)
        {

        }

        private byte[] ImageToByteArray(Image image)
        {
            if (image == null) return null;

            using (MemoryStream ms = new MemoryStream())
            {
                try
                {
                    image.Save(ms, image.RawFormat);
                    return ms.ToArray();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al convertir la imagen a byte array: {ex.Message}");
                    MessageBox.Show("Error al convertir la imagen a byte array: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                List<ClMueble> muebles = oL.BuscarMueble(int.Parse(Txt_idMueble.Text));

                if (muebles == null || muebles.Count == 0)
                {
                    MessageBox.Show("El artículo no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                ClMueble mueble = muebles[0];
                Lbl_idMueble.Text = mueble.IdMueble.ToString();
                TxtNombre.Text = mueble.Nombre;
                TxtTipo.Text = mueble.Tipo;
                CmBxMaterialMueble.Text = mueble.Material;

                Color colorFondo;
                colorFondo = Color.FromName(mueble.Color);
                panelColorSelec.BackColor = colorFondo;
                Color colorF = ColorTranslator.FromHtml(mueble.Color);
                panelColorSelec.BackColor = colorF;

                TxtAltura.Text = mueble.Altura.ToString();
                TxtAncho.Text = mueble.Ancho.ToString();
                TxtProfundidad.Text = mueble.Profundidad.ToString();
                TxtPeso.Text = mueble.Peso.ToString();
                CmBxEstiloMueble.Text = mueble.Estilo;
                TxtPrecioC.Text = mueble.PrecioCoste.ToString();
                TxtPrecioV.Text = mueble.PrecioVenta.ToString();
                TxtCantidad.Text = mueble.Cantidad.ToString();
                PbxFoto.Image = ByteArrayToImage(mueble.Foto);  // Convertir bytes a imagen
                TxtDescripcion.Text = mueble.Descripcion.ToString();
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

        private void BtnCargarImagen_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PbxFoto.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            // Mostrar el diálogo y verificar si se seleccionó un color
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                // Establecer el color seleccionado como el color de fondo del panel
                panelColorSelec.Visible = true;
                // Obtener el color seleccionado
                panelColorSelec.BackColor = colorDialog1.Color;
                btnColor.Visible = false;
            }
        }

        private void BtnBuscarNombre_Click(object sender, EventArgs e)
        {
            try
            {

                List<ClMueble> muebles = oL.BuscarMuebleNombre(TxtENombre.Text);

                if (muebles == null || muebles.Count == 0)
                {
                    MessageBox.Show("El artículo no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                ClMueble mueble = muebles[0];
                Lbl_idMueble.Text = mueble.IdMueble.ToString();
                TxtNombre.Text = mueble.Nombre;
                TxtTipo.Text = mueble.Tipo;
                CmBxMaterialMueble.Text = mueble.Material;

                Color colorFondo;
                colorFondo = Color.FromName(mueble.Color);
                panelColorSelec.BackColor = colorFondo;
                Color colorF = ColorTranslator.FromHtml(mueble.Color);
                panelColorSelec.BackColor = colorF;

                TxtAltura.Text = mueble.Altura.ToString();
                TxtAncho.Text = mueble.Ancho.ToString();
                TxtProfundidad.Text = mueble.Profundidad.ToString();
                TxtPeso.Text = mueble.Peso.ToString();
                CmBxEstiloMueble.Text = mueble.Estilo;
                TxtPrecioC.Text = mueble.PrecioCoste.ToString();
                TxtPrecioV.Text = mueble.PrecioVenta.ToString();
                TxtCantidad.Text = mueble.Cantidad.ToString();
                PbxFoto.Image = ByteArrayToImage(mueble.Foto);  // Convertir bytes a imagen
                TxtDescripcion.Text = mueble.Descripcion.ToString();
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

        private void Txt_idMueble_KeyPress(object sender, KeyPressEventArgs e)
        {
            label25.Visible = false;
            TxtENombre.Visible = false;
            BtnBuscarNombre.Visible = false;

            // Comprobar si el carácter presionado es un dígito o una tecla de control
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Cancelar el evento de tecla presionada
                e.Handled = true;
            }
            label25.Visible = false;
            TxtENombre.Visible = false;
            BtnBuscarNombre.Visible = false;
        }

        private void TxtENombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            label24.Visible = false;
            Txt_idMueble.Visible = false;
            BtnBuscar.Visible = false;
        }

        private void FrmEditarMueble_Load(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    nombre = TxtNombre.Text;
                    TxtTipo.Focus();
                }
                catch
                {
                    MessageBox.Show("Ingreso incorrecto, intente de nuevo");
                    TxtNombre.Clear();
                    return;
                }
            }
        }
    }
}
