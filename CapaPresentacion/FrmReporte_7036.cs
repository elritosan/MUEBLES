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
    public partial class FrmReporte_7036 : Form
    {
        public FrmReporte_7036()
        {
            InitializeComponent();
        }

        private void FrmReporte_7036_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetBDMuebles1.Clientes7036' Puede moverla o quitarla según sea necesario.
            this.clientes7036TableAdapter.Fill(this.dataSetBDMuebles1.Clientes7036);

            this.reportViewer1.RefreshReport();
        }
    }
}
