using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaLogica;

namespace CapaPresentacion
{
    public partial class FrmMenu : Form
    {
        ClCliente oCliente = new ClCliente();
        public FrmMenu(ClCliente oC) //mandar a todos los forms para que la sesion se mantenga iniciada
        {
            InitializeComponent();
            oCliente = oC;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Opciones();
        }

        private void Opciones()
        {
            if(oCliente.tipo_user == "Cliente")
            {
                ingresarToolStripMenuItem.Visible = false;
                editarToolStripMenuItem.Visible = false;
                buscarToolStripMenuItem.Visible = false;
                eliminarToolStripMenuItem.Visible = false;
                comprarToolStripMenuItem.Visible = true;
                catalogoToolStripMenuItem.Visible = true;
                reportesToolStripMenuItem.Visible = false;
                miPerfilToolStripMenuItem.Visible = true;
            }
            else
            {
                ingresarToolStripMenuItem.Visible = true;
                editarToolStripMenuItem.Visible = true;
                buscarToolStripMenuItem.Visible = true;
                eliminarToolStripMenuItem.Visible = true;
                comprarToolStripMenuItem.Visible = false;
                catalogoToolStripMenuItem.Visible = false;
                reportesToolStripMenuItem.Visible = true;
                miPerfilToolStripMenuItem.Visible = false;
            }
        }

        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmIngresar objIn = new FrmIngresar();
            objIn.ShowDialog();
            this.Close();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscarMueble oBuscar = new FrmBuscarMueble(oCliente);
            oBuscar.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEliminarMueble oEliminar = new FrmEliminarMueble(oCliente);
            oEliminar.ShowDialog();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditarMueble oEditar = new FrmEditarMueble(oCliente);
            oEditar.ShowDialog();
        }

        private void comprarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCompra objCompra = new FrmCompra(oCliente);
            objCompra.ShowDialog();
        }

        private void catalogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCatalogo objCat = new FrmCatalogo();
            objCat.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void miPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPerfil_Usuario oPerfil = new FrmPerfil_Usuario(oCliente);
            oPerfil.ShowDialog();
        }

        private void cerrarSesiónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmIniciarSesion oApp = new FrmIniciarSesion();
            oApp.ShowDialog();
            this.Close();
        }

        private void listarMueblesIDNombrePrecioDeFabricación6858ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporte___6858 objR = new FrmReporte___6858();
            objR.ShowDialog();
        }

        private void listarClientesRegistrados7036ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporte_7036 objR = new FrmReporte_7036();
            objR.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmReporte_7133 objR = new FrmReporte_7133();
            objR.ShowDialog();
        }

        private void toToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporte_7122 objR = new FrmReporte_7122();
            objR.ShowDialog();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\user\Documents\5TO\APLICACIONES\2PARCIAL\TRABAJO_GRUPAL\Ayuda_grupal\index.html");
        }
    }
}
