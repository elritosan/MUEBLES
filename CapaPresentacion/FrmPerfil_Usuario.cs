using CapaEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmPerfil_Usuario : Form
    {
        ClCliente cliente = new ClCliente();
        public FrmPerfil_Usuario()
        {
            InitializeComponent();
        }

        public FrmPerfil_Usuario(ClCliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            CargarPerfilUsuario();
        }

        private void CargarPerfilUsuario()
        {
            LblCedula.Text = cliente.Cedula;
            LblNombre.Text = cliente.Nombre;
            LblApellido.Text = cliente.Apellido;
            LblEdad.Text = cliente.Edad.ToString();
            LblCiudad.Text = cliente.Ciudad;
            LblCorreoE.Text = cliente.CorreoElectronico;

        }
        private void FrmPerfil_Usuario_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
