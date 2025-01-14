using CapaEntidades;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmRegistrarse : Form
    {
        string ced;
        string nombre;
        string apellido;
        string ciudad;
        string correo;
        string contraseña;
        string tipo_user = "Cliente";

        public FrmRegistrarse()
        {
            InitializeComponent();
        }

        public bool VerificarCedula(string cedula)
        {
            if (cedula.Length != 10)
                return false;

            int[] coeficientes = { 2, 1, 2, 1, 2, 1, 2, 1, 2 };
            int suma = 0;

            for (int i = 0; i < 9; i++)
            {
                int digito = int.Parse(cedula[i].ToString());
                int producto = digito * coeficientes[i];
                suma += producto >= 10 ? producto - 9 : producto;
            }

            int ultimoDigitoCalculado = suma % 10 == 0 ? 0 : 10 - (suma % 10);
            int ultimoDigitoCedula = int.Parse(cedula[9].ToString());

            return ultimoDigitoCalculado == ultimoDigitoCedula;
        }
        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                ClLogica oL = new ClLogica();
                List<ClCliente> clientes = oL.BuscarCliente(TxtCedula.Text);

                // Verificar si la cédula ya existe en la lista de clientes
                if (clientes.Any(c => c.Cedula == TxtCedula.Text))
                {
                    MessageBox.Show("Ya tienes una cuenta", "Cédula Duplicada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtCedula.Clear();
                    TxtCedula.Focus();
                    return;
                }

                // Verificar que la cédula sea válida
                ced = TxtCedula.Text;
                if (VerificarCedula(ced))
                {
                    // Si la cédula es válida, permitir al usuario continuar con el llenado de datos
                    TxtNombre.Focus();
                    TxtCedula.Enabled = false;
                    TxtNombre.Enabled = true;
                    TxtApellido.Enabled = true;
                    dateTimePicker1.Enabled = true;
                    Txtciudad.Enabled = true;
                    TxtContra.Enabled = true;
                    TxtCorreo.Enabled = true;
                    PbxCheck.Visible = true; // Mostrar un check si se usa un PictureBox
                }
                else
                {
                    MessageBox.Show("Cédula Incorrecta. Intenta nuevamente", "Validación de Cédula", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtCedula.Clear();
                    TxtCedula.Focus();
                }
            }

            // Permitir solo caracteres de control y dígitos
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // Limitar la longitud de la cédula a 10 caracteres
            if (TxtCedula.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
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
                    nombre = TxtNombre.Text;
                    TxtApellido.Focus();
                }
                catch
                {
                    MessageBox.Show("Ingreso de dato incorrecto");
                }
            }
        }

        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
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
                    apellido = TxtApellido.Text;
                    Txtciudad.Focus();
                }
                catch
                {
                    MessageBox.Show("Ingreso de dato incorrecto");
                }
            }
        }

        private void Txtciudad_KeyPress(object sender, KeyPressEventArgs e)
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
                    ciudad = Txtciudad.Text;
                    TxtCorreo.Focus();
                }
                catch
                {
                    MessageBox.Show("Ingreso de dato incorrecto");
                }
            }
        }

        private void TxtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    correo = TxtCorreo.Text;
                    TxtContra.Focus();
                }
                catch
                {
                    MessageBox.Show("Ingreso de dato incorrecto");
                }
            }
        }

        private int CalcularEdad()
        {
            DateTime fechaSeleccionada = dateTimePicker1.Value;
            DateTime fechaActual = DateTime.Today;

            int edad = fechaActual.Year - fechaSeleccionada.Year;
            if (fechaSeleccionada > fechaActual.AddYears(-edad))
            {
                edad--;
            }

            return edad;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Today;

            int edad = CalcularEdad();

            if (edad < 18 || edad > 70)
            {
                MessageBox.Show("La fecha seleccionada debe corresponder a una persona mayor de 18 años y menor de 70 años.", "Fecha no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Restablecer a una fecha válida si está fuera de los límites
                DateTime fechaValida = fechaActual.AddYears(-18);
                if (edad < 18)
                {
                    fechaValida = fechaActual.AddYears(-18);
                }
                else if (edad > 70)
                {
                    fechaValida = fechaActual.AddYears(-70);
                }
                dateTimePicker1.Value = fechaValida;
            }
        }

        private void BtnRegistro_Click(object sender, EventArgs e)
        {
            ClCliente cliente = new ClCliente();

            cliente.Cedula = TxtCedula.Text;
            cliente.Nombre = TxtNombre.Text;
            cliente.Apellido = TxtApellido.Text;
            cliente.Ciudad = Txtciudad.Text;
            //cliente.Edad = TxtEdad;
            cliente.CorreoElectronico = TxtCorreo.Text;
            cliente.FechaNacimiento = dateTimePicker1.Value;
            cliente.Contrasenia = TxtContra.Text;
            cliente.tipo_user = tipo_user;

            cliente.Edad = CalcularEdad();

            ClLogica oLogica = new ClLogica();

            try
            {
                oLogica.RegistrarUsuario(cliente);
                MessageBox.Show("Usuario registrado exitosamente.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmRegistrarse_Load(object sender, EventArgs e)
        {
            // Configurar los límites del dateTimePicker
            dateTimePicker1.MaxDate = DateTime.Today.AddYears(-18); // 18 años atrás desde hoy
            dateTimePicker1.MinDate = DateTime.Today.AddYears(-90); // 70 años atrás desde hoy
            TxtCedula.Enabled = true;
            TxtCedula.Focus();
            TxtNombre.Enabled = false;
            TxtApellido.Enabled = false;
            Txtciudad.Enabled = false;
            dateTimePicker1.Enabled = false;
            TxtContra.Enabled = false;
            TxtCorreo.Enabled = false;
            PbxCheck.Visible = false;
        }
    }
}
