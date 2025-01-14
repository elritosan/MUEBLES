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
    public partial class FrmReporte_7122 : Form
    {
        public FrmReporte_7122()
        {
            InitializeComponent();
        }

        private void FrmReporte_7122_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetBDMuebles.Muebles7133' Puede moverla o quitarla según sea necesario.
            this.muebles7133TableAdapter.Fill(this.dataSetBDMuebles.Muebles7133);
            // TODO: esta línea de código carga datos en la tabla 'dataSetBDMuebles.Muebles7122' Puede moverla o quitarla según sea necesario.
            this.muebles7122TableAdapter.Fill(this.dataSetBDMuebles.Muebles7122);

            this.reportViewer1.RefreshReport();
        }
    }
}
