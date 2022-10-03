using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pryCasaleBDAccess
{
    public partial class frmPrincipal : Form
    {
        OleDbConnection conexionBaseDatos;
        string CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source= \\\\servidor\\Compartida\\VIDEOCLUB.accdb";

        OleDbCommand QQuieroTraer;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try 
            {
                conexionBaseDatos = new OleDbConnection(CadenaConexion);
                conexionBaseDatos.Open();
                lblInformacion.Text = "Jeje";
            }
            catch (Exception Mensaje)
            {
                lblInformacion.Text = Mensaje.ToString() + "\n";
            }

        }

        private void btnAbrirTabla_Click(object sender, EventArgs e)
        {
            try
            {
                QQuieroTraer = new OleDbCommand();
                QQuieroTraer.Connection = conexionBaseDatos;
                QQuieroTraer.CommandType = CommandType.TableDirect;
                QQuieroTraer.CommandText = "Clientes";
                lblInformacion.Text = "Todo okis" + QQuieroTraer.CommandText;

                OleDbDataReader objetolectura = QQuieroTraer.ExecuteReader();
                while (objetolectura.Read())
                {
                    lblInformacion.Text =  lblInformacion + Convert.ToString(objetolectura["Nombre"]) + "\n";
                }
                objetolectura.Close();
            }
            catch (Exception Mensaje)
            {
                lblInformacion.Text = Mensaje.ToString() + "\n";
            }
        }
    }
}
