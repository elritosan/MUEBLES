using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using CapaEntidades;

namespace CapaPresentacion
{
    public partial class FrmIniciarSesion : Form
    {
        ClLogica oLogica = new ClLogica();
        public FrmIniciarSesion()
        {
            InitializeComponent();
        }

        private void FrmIniciarSesion_Load(object sender, EventArgs e)
        {

        }
        private void IniciarSesion()
        {
            List<ClCliente> oListaU = new List<ClCliente>();
            oListaU = oLogica.ValidarUsuario(TxtUsuario.Text, TxtContrasenia.Text);
            ClassValidarCorreo oCorreo = new ClassValidarCorreo(TxtUsuario.Text);

            if (oListaU.Count > 0)
            {
                if (TxtContrasenia.Text == oListaU[0].Contrasenia && oCorreo.ValidarCorreo())
                {
                    this.Hide();
                    FrmMenu oApp = new FrmMenu(oListaU[0]);
                    oApp.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña Incorrectos");
                    TxtUsuario.Focus();
                }
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrectos");
                TxtUsuario.Focus();
            }
        }
        private void Btn_Ejecutar_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }

        private void Btn_Registrar_Click(object sender, EventArgs e)
        {
            FrmRegistrarse oRegistro = new FrmRegistrarse();
            oRegistro.ShowDialog();
        }
    }
}
