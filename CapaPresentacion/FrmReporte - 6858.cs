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
    public partial class FrmReporte___6858 : Form
    {
        public FrmReporte___6858()
        {
            InitializeComponent();
        }
//System.Data.SqlClient.SqlException: 'Error relacionado con la red o específico de la instancia mientras se establecía una conexión con el servidor SQL Server. No se encontró el servidor o éste no estaba accesible. Compruebe que el nombre de la instancia es correcto y que SQL Server está configurado para admitir conexiones remotas. (provider: Named Pipes Provider, error: 40 - No se pudo abrir una 
        private void FrmReporte___6858_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetBDMuebles1.Muebles6858' Puede moverla o quitarla según sea necesario.
            this.muebles6858TableAdapter.Fill(this.dataSetBDMuebles1.Muebles6858);

            this.reportViewer1.RefreshReport();
        }
    }
}
