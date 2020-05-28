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
    public partial class Cuentas : Form
    {
        SqlConnection conexion;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        DataTable cuentas;

        bool CrearActualizar = false;
        public Cuentas()
        {
            InitializeComponent();
        }
        public Cuentas(SqlConnection conexion) {
            InitializeComponent();
            this.conexion = conexion;
            ActualizarVista();
        }

        private void bttGuardar_Click(object sender, EventArgs e)
        {
            if (this.CrearActualizar == false)
            {
                //Crear registro
                this.command = new SqlCommand("CrearCuenta", this.conexion);
                this.command.Parameters.AddWithValue("@Codigo", this.txtCodigo.Text);
                this.command.Parameters.AddWithValue("@Nombre", this.txtNombreCompleto.Text);
                this.command.Parameters.AddWithValue("@RFC", this.txtRFC.Text);
                this.command.Parameters.AddWithValue("@FechaAlta", this.dtpFechaAlta.Value);
                this.command.Parameters.AddWithValue("@FechaNacimiento", this.dtpFechaNacimiento.Value);
                this.command.Parameters.AddWithValue("@PorcentajeComision", Convert.ToDouble(this.txtPorcentajeComision.Text));
                this.command.Parameters.AddWithValue("@Tipo", this.txtTipoInt.Text);
                this.command.CommandType = CommandType.StoredProcedure;
                this.command.ExecuteNonQuery();

                ActualizarVista();
            }
            else if (this.CrearActualizar == true)
            {
                //Actualizar registro
                this.command = new SqlCommand("ActualizarCuenta", this.conexion);
                this.command.Parameters.AddWithValue("@idCuenta", this.txtIdCuenta.Text);
                this.command.Parameters.AddWithValue("@Codigo", this.txtCodigo.Text);
                this.command.Parameters.AddWithValue("@Nombre", this.txtNombreCompleto.Text);
                this.command.Parameters.AddWithValue("@RFC", this.txtRFC.Text);
                this.command.Parameters.AddWithValue("@FechaAlta", this.dtpFechaAlta.Value);
                this.command.Parameters.AddWithValue("@FechaNacimiento", this.dtpFechaNacimiento.Value);
                this.command.Parameters.AddWithValue("@PorcentajeComision", Convert.ToDecimal(this.txtPorcentajeComision.Text));
                this.command.Parameters.AddWithValue("@Tipo", this.txtTipoInt.Text);


                this.command.CommandType = CommandType.StoredProcedure;
                this.command.ExecuteNonQuery();

                ActualizarVista();
            }
        }

        //
        private void bttEliminar_Click(object sender, EventArgs e)
        {
            this.command = new SqlCommand("EliminarCuenta", this.conexion);
            this.command.Parameters.AddWithValue("@idCuenta", Convert.ToInt32(this.txtIdCuenta.Text));
            this.command.CommandType = CommandType.StoredProcedure;
            this.command.ExecuteNonQuery();

            ActualizarVista();
        }

        private void bttLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarVista();
        }

        private void bttActualizar_Click(object sender, EventArgs e)
        {
            ActualizarVista();
        }
        private void ActualizarVista()
        {
            this.command = new SqlCommand("ListarCuentas", this.conexion);
            this.command.CommandType = CommandType.StoredProcedure;

            this.dataAdapter = new SqlDataAdapter(this.command);
            this.cuentas = new DataTable();
            this.dataAdapter.Fill(this.cuentas);

            this.dgvCuentas.AutoGenerateColumns = true;
            this.dgvCuentas.DataSource = this.cuentas;
            this.dgvCuentas.Update();

            LimpiarVista();
        }

        private void LimpiarVista()
        {
            this.CrearActualizar = false;

            this.txtIdCuenta.Text = "";
            this.txtCodigo.Text = "";
            this.txtRFC.Text = "";
            this.txtNombreCompleto.Text = "";
            this.dtpFechaAlta.Text = ""; 
            this.dtpFechaNacimiento.Text = "";
            this.txtPorcentajeComision.Text = "";
            this.txtTipoInt.Text = "";
        }

        private void dgvCuentas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.CrearActualizar = true;

            int index = this.dgvCuentas.CurrentRow.Index;
            DataRow row = this.cuentas.Rows[index];

            this.txtIdCuenta.Text = row["idCuenta"].ToString();
            this.txtCodigo.Text = row["Codigo"].ToString();
            this.txtRFC.Text = row["RFC"].ToString();
            this.txtNombreCompleto.Text = row["Nombre"].ToString();
            this.dtpFechaAlta.Value =Convert.ToDateTime( row["FechaAlta"]);
            this.dtpFechaNacimiento.Value =Convert.ToDateTime( row["FechaNacimiento"]);
            this.txtPorcentajeComision.Text = row["PorcentajeComision"].ToString();
            this.txtTipoInt.Text = row["Tipo"].ToString();


        }

        private void cbClientes_CheckedChanged(object sender, EventArgs e)
        {
            this.txtTipoInt.Text = "0";
        }

        private void cbAgenteVenta_CheckedChanged(object sender, EventArgs e)
        {
            this.txtTipoInt.Text = "1";
        }

        private void cbAgentesServicios_CheckedChanged(object sender, EventArgs e)
        {
            this.txtTipoInt.Text = "2";
        }
    }
}
