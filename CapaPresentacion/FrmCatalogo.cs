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
using CapaLogica;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace CapaPresentacion
{
    public partial class FrmCatalogo : Form
    {
        ClCliente oCliente = new ClCliente();
        ClassFACTURA oF = new ClassFACTURA();
        ClMueble oMueble = new ClMueble();
        ClLogica oLogica = new ClLogica();
        List<ClMueble> oListaA = new List<ClMueble>();
        List<ClassCOMPRA_MUEBLES> oListaFA = new List<ClassCOMPRA_MUEBLES>();
        ClassCOMPRA_CLIENTES oFC = new ClassCOMPRA_CLIENTES();

        private List<PictureBox> _pictureBoxes = new List<PictureBox>();
        private List<Label> _nameLabels = new List<Label>();
        private List<Label> _priceLabels = new List<Label>();
        public FrmCatalogo()
        {
            InitializeComponent();
            btnClasico.Enabled = false;
            //Console.WriteLine(oMueble.Nombre);

            ObtenerListaMuebles(btnClasico.Text);
        }

        private void EliminarControlesExistentes()
        {

            // Eliminar los controles existentes
            foreach (var pb in _pictureBoxes)
            {
                this.Controls.Remove(pb);
            }
            _pictureBoxes.Clear();

            foreach (var lbl in _nameLabels)
            {
                this.Controls.Remove(lbl);
            }
            _nameLabels.Clear();

            foreach (var lbl in _priceLabels)
            {
                this.Controls.Remove(lbl);
            }
            _priceLabels.Clear();
        }

        private void CrearNuevosControles()
        {

            // Crear nuevos controles basados en la cantidad de elementos en oListaA
            int x = 10, y = 80, width = 200, height = 200; // y = 80 para dejar espacio para los botones
            int labelHeight = 30;

            for (int i = 0; i < oListaA.Count; i++)
            {
                PictureBox pb = new PictureBox();
                pb.Location = new Point(x, y);
                pb.Size = new Size(width, height);
                pb.SizeMode = PictureBoxSizeMode.StretchImage; // Usar StretchImage para ajustar las imágenes al tamaño del PictureBox
                this.Controls.Add(pb);
                _pictureBoxes.Add(pb);

                Label lblNombre = new Label();
                lblNombre.Location = new Point(x, y + height);
                lblNombre.Size = new Size(width, labelHeight);
                lblNombre.TextAlign = ContentAlignment.MiddleCenter;
                lblNombre.Font = new Font(lblNombre.Font.FontFamily, 12, FontStyle.Bold); // Fuente negrita y tamaño 12
                this.Controls.Add(lblNombre);
                _nameLabels.Add(lblNombre);

                Label lblPrecio = new Label();
                lblPrecio.Location = new Point(x, y + height + labelHeight);
                lblPrecio.Size = new Size(width, labelHeight);
                lblPrecio.TextAlign = ContentAlignment.MiddleCenter;
                lblPrecio.Font = new Font(lblPrecio.Font.FontFamily, 12, FontStyle.Bold); // Fuente negrita y tamaño 12
                this.Controls.Add(lblPrecio);
                _priceLabels.Add(lblPrecio);

                x += width + 10;
                if (x + width > this.Width)
                {
                    x = 10;
                    y += height + labelHeight * 2 + 10;
                }
            }
        }

        private void ObtenerListaMuebles(string estilo)
        {

            oListaA = oLogica.FiltarMueblePorEstilo(estilo);

            // Eliminar los controles existentes
            EliminarControlesExistentes();

            // Crear nuevos controles
            CrearNuevosControles();

            MostrarMuebles();
        }
        private void MostrarMuebles()
        {
            // Asegúrate de crear nuevos controles si no hay suficientes
            if (_pictureBoxes.Count < oListaA.Count)
            {
                EliminarControlesExistentes();
                CrearNuevosControles();
            }

            for (int i = 0; i < oListaA.Count; i++)
            {
                var mueble = oListaA[i];

                var pb = _pictureBoxes[i];
                var lblNombre = _nameLabels[i];
                var lblPrecio = _priceLabels[i];

                lblNombre.Text = mueble.Nombre;
                lblPrecio.Text = $"Precio: ${mueble.PrecioVenta}";
                pb.Image = ByteArrayToImage(mueble.Foto);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private void btnModerno_Click_1(object sender, EventArgs e)
        {
            if (btnModerno.Enabled)
            {
                btnModerno.Enabled = false;
                btnClasico.Enabled = true;
                btnRustico.Enabled = true;
            }
            ObtenerListaMuebles(btnModerno.Text);
        }

        private void btnRustico_Click_1(object sender, EventArgs e)
        {
            if (btnRustico.Enabled)
            {
                btnModerno.Enabled = true;
                btnClasico.Enabled = true;
                btnRustico.Enabled = false;
            }
            ObtenerListaMuebles(btnRustico.Text);
        }

        private void btnClasico_Click_1(object sender, EventArgs e)
        {
            if (btnClasico.Enabled)
            {
                btnModerno.Enabled = true;
                btnClasico.Enabled = false;
                btnRustico.Enabled = true;
            }
            ObtenerListaMuebles(btnClasico.Text);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
