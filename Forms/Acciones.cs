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
    public partial class Acciones : Form
    {
        SqlConnection conexion;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        DataTable acciones;

        string encriptacion = "wjhTZfnSzWvY6h3P";
        bool CrearActualizar = false;

        public Acciones()
        {
            InitializeComponent();
        }

        public Acciones(SqlConnection conexion)
        {
            InitializeComponent();
            this.conexion = conexion;
            ActualizarVista();
        }

        private void bttGuardar_Click(object sender, EventArgs e)
        {
            if(this.CrearActualizar == false)
            {
                //Crear registro
                this.command = new SqlCommand("CrearAccion", this.conexion);
                this.command.Parameters.AddWithValue("@idCuentaSolicitante", this.txtIdCuentaSolicitante.Text);
                this.command.Parameters.AddWithValue("@idCuentaRealizante", this.txtIdCuentaSolicitante.Text);
                this.command.Parameters.AddWithValue("@FechaInicio", this.dtpFechaInicio.Value);
                this.command.Parameters.AddWithValue("@FechaFinal", this.dtpFechaInicio.Value);
                this.command.Parameters.AddWithValue("@FormaContacto", this.txtFormaContacto.Text);
                this.command.Parameters.AddWithValue("@Descripcion", this.txtDescripcion.Text);
                this.command.CommandType = CommandType.StoredProcedure;
                this.command.ExecuteNonQuery();

                ActualizarVista();
            }
            else if(this.CrearActualizar == true)
            {
                //Actualizar registro
                this.command = new SqlCommand("ActualizarUsuario", this.conexion);

                this.command.CommandType = CommandType.StoredProcedure;
                this.command.ExecuteNonQuery();

                ActualizarVista();
            }

        }

        private void bttEliminar_Click(object sender, EventArgs e)
        {
            this.command = new SqlCommand("EliminarUsuario", this.conexion);
            this.command.Parameters.AddWithValue("@idUsuario", Convert.ToInt32(this.txtIdCuentaSolicitante.Text));
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
            this.command = new SqlCommand("ListarAcciones", this.conexion);
            this.command.CommandType = CommandType.StoredProcedure;

            this.dataAdapter = new SqlDataAdapter(this.command);
            this.acciones = new DataTable();
            this.dataAdapter.Fill(this.acciones);

            this.dgvAcciones.AutoGenerateColumns = true;
            this.dgvAcciones.DataSource = this.acciones;
            this.dgvAcciones.Update();

            LimpiarVista();
        }

        private void LimpiarVista()
        {
            this.CrearActualizar = false;

            this.txtIdCuentaSolicitante.Text = "";
            this.txtIdCuentaRealizante.Text = "";
            this.dtpFechaInicio.Value = DateTime.Now;
            this.txtDescripcion.Text = "";
            this.txtFormaContacto.Text = "";
        }

        private void dgvAcciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.CrearActualizar = true;

            int index = this.dgvAcciones.CurrentRow.Index;
            DataRow row = this.acciones.Rows[index];

            this.txtIdCuentaSolicitante.Text = row["idCuentaSolicitante"].ToString();
            this.txtIdCuentaRealizante.Text = row["idCuentaRealizante"].ToString();
            this.dtpFechaInicio.Value = Convert.ToDateTime(row["fechaInicio"]);
            this.txtDescripcion.Text = row["Descripcion"].ToString();
            this.txtFormaContacto.Text = row["FormaContacto"].ToString();
        }


    }
}
