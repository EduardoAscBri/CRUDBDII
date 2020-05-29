using CRUDBDII.Classes;
using CRUDBDII.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDBDII.Forms
{
    public partial class MenuCRUD : Form
    {
        SqlConnection conexion;
        public MenuCRUD()
        {
            InitializeComponent();

            string rutaLocal = Application.StartupPath;

            InnerDatabaseManager dbManager = new InnerDatabaseManager();
            this.conexion = dbManager.createConnectionFromIniFile(rutaLocal);
            this.conexion.Open();
        }

        private void bttUsuarios_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios(this.conexion);
            usuarios.Show();
        }

        private void bttAcciones_Click(object sender, EventArgs e)
        {
            Acciones acciones = new Acciones(this.conexion);
            acciones.Show();
        }

        private void bttCuentas_Click(object sender, EventArgs e)
        {
            Cuentas cuentas = new Cuentas(this.conexion);
            cuentas.Show();
        }

        private void bttProductosServicios_Click(object sender, EventArgs e)
        {
            ProductosServicios productosServicios = new ProductosServicios(this.conexion);
            productosServicios.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccionesDetalle accionesDetalle = new AccionesDetalle(this.conexion);
            accionesDetalle.Show();
        }

        private void bttAccionesEnDetalle_Click(object sender, EventArgs e)
        {
            Consultas consultas = new Consultas("AccionesEnDetalle", this.conexion);
            consultas.Show();
        }

        private void bttAccionesEnResumen_Click(object sender, EventArgs e)
        {
            Consultas consultas = new Consultas("AccionesEnResumen", this.conexion);
            consultas.Show();
        }

        private void bttInventarios_Click(object sender, EventArgs e)
        {
            Consultas consultas = new Consultas("Inventarios", this.conexion);
            consultas.Show();
        }

        private void bttReporteCuentas_Click(object sender, EventArgs e)
        {
            Consultas consultas = new Consultas("Cuentas", this.conexion);
            consultas.Show();
        }
    }
}
