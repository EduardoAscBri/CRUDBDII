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
        DataTable cuentaSolicitante;
        DataTable cuentaRealizante;
        DataTable formaContacto;
        DataTable tipoAccion;

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


            ControlesAuxiliares();
            ActualizarVista();
        }

        private void ControlesAuxiliares()
        {
            this.command = new SqlCommand("ListarCuentas", this.conexion);
            this.command.CommandType = CommandType.StoredProcedure;
            this.dataAdapter = new SqlDataAdapter(this.command);
            this.cuentaSolicitante = new DataTable();
            this.cuentaRealizante = new DataTable();
            this.dataAdapter.Fill(this.cuentaSolicitante);
            this.dataAdapter.Fill(this.cuentaRealizante);

            this.cmbCuentaSolicitante.DataSource = this.cuentaSolicitante;
            this.cmbCuentaSolicitante.DisplayMember = "Nombre";
            this.cmbCuentaSolicitante.ValueMember = "idCuenta";

            this.cmbCuentaRealizante.DataSource = this.cuentaRealizante;
            this.cmbCuentaRealizante.DisplayMember = "Nombre";
            this.cmbCuentaRealizante.ValueMember = "idCuenta";

            this.formaContacto = new DataTable();
            this.formaContacto.Columns.Add("idFormaContacto");
            this.formaContacto.Columns.Add("Descripcion");

            DataRow row = this.formaContacto.NewRow();
            row["idFormaContacto"] = 0;
            row["Descripcion"] = "Llamada telefonica";
            this.formaContacto.Rows.Add(row);

            row = this.formaContacto.NewRow();
            row["idFormaContacto"] = 1;
            row["Descripcion"] = "Correo electronico";
            this.formaContacto.Rows.Add(row);

            row = this.formaContacto.NewRow();
            row["idFormaContacto"] = 2;
            row["Descripcion"] = "Whatsapp";
            this.formaContacto.Rows.Add(row);

            this.cmbFormaContacto.DataSource = this.formaContacto;
            this.cmbFormaContacto.DisplayMember = "Descripcion";
            this.cmbFormaContacto.ValueMember = "idFormaContacto";

            this.tipoAccion = new DataTable();
            this.tipoAccion.Columns.Add("idTipoAccion");
            this.tipoAccion.Columns.Add("Descripcion");

            row = this.tipoAccion.NewRow();
            row["idTipoAccion"] = 0;
            row["Descripcion"] = "Atencion";
            this.tipoAccion.Rows.Add(row);

            row = this.tipoAccion.NewRow();
            row["idTipoAccion"] = 1;
            row["Descripcion"] = "Venta";
            this.tipoAccion.Rows.Add(row);

            row = this.tipoAccion.NewRow();
            row["idTipoAccion"] = 2;
            row["Descripcion"] = "Servicio";
            this.tipoAccion.Rows.Add(row);

            this.cmbTipoAccion.DataSource = this.tipoAccion;
            this.cmbTipoAccion.DisplayMember = "Descripcion";
            this.cmbTipoAccion.ValueMember = "idTipoAccion";
        }

        private void bttGuardar_Click(object sender, EventArgs e)
        {
            if(this.CrearActualizar == false)
            {
                //Crear registro
                this.command = new SqlCommand("CrearAccion", this.conexion);
                this.command.Parameters.AddWithValue("@idCuentaSolicitante", this.txtIdCuentaSolicitante.Text);
                this.command.Parameters.AddWithValue("@idCuentaRealizante", this.txtIdCuentaRealizante.Text);
                this.command.Parameters.AddWithValue("@FechaInicio", this.dtpFechaInicio.Value);
                this.command.Parameters.AddWithValue("@FechaFinal", this.dtpFechaInicio.Value);
                this.command.Parameters.AddWithValue("@FormaContacto", Convert.ToInt32(this.txtFormaContacto.Text));
                this.command.Parameters.AddWithValue("@Descripcion", this.txtDescripcion.Text);
                this.command.Parameters.AddWithValue("@Tipo", Convert.ToInt32(this.txtTipoAccion.Text));
                this.command.CommandType = CommandType.StoredProcedure;
                this.command.ExecuteNonQuery();

                ActualizarVista();
            }
            else if(this.CrearActualizar == true)
            {
                //Actualizar registro
                this.command = new SqlCommand("ActualizarAccion", this.conexion);
                this.command.Parameters.AddWithValue("idAccion", Convert.ToInt32(this.txtIdAccion.Text));
                this.command.Parameters.AddWithValue("@idCuentaSolicitante", this.txtIdCuentaSolicitante.Text);
                this.command.Parameters.AddWithValue("@idCuentaRealizante", this.txtIdCuentaRealizante.Text);
                this.command.Parameters.AddWithValue("@FechaInicio", this.dtpFechaInicio.Value);
                this.command.Parameters.AddWithValue("@FechaFinal", this.dtpFechaInicio.Value);
                this.command.Parameters.AddWithValue("@FormaContacto", Convert.ToInt32(this.txtFormaContacto.Text));
                this.command.Parameters.AddWithValue("@Descripcion", this.txtDescripcion.Text);
                this.command.Parameters.AddWithValue("@Tipo", Convert.ToInt32(this.txtTipoAccion.Text));
                this.command.CommandType = CommandType.StoredProcedure;
                this.command.ExecuteNonQuery();

                ActualizarVista();
            }

        }

        private void bttEliminar_Click(object sender, EventArgs e)
        {
            this.command = new SqlCommand("EliminarAccion", this.conexion);
            this.command.Parameters.AddWithValue("@idAccion", Convert.ToInt32(this.txtIdAccion.Text));
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

            this.txtIdAccion.Text = "";
            this.txtIdCuentaSolicitante.Text = "";
            this.txtIdCuentaRealizante.Text = "";
            this.dtpFechaInicio.Value = DateTime.Now;
            this.txtDescripcion.Text = "";
            this.txtTipoAccion.Text = "";
            this.txtFormaContacto.Text = "";
            
        }

        private void dgvAcciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.CrearActualizar = true;

            int index = this.dgvAcciones.CurrentRow.Index;
            DataRow row = this.acciones.Rows[index];

            this.txtIdAccion.Text = row["idAccion"].ToString();
            this.txtIdCuentaSolicitante.Text = row["idCuentaSolicitante"].ToString();
            this.cmbCuentaSolicitante.SelectedValue = Convert.ToInt32(row["idCuentaSolicitante"]);
            this.txtIdCuentaRealizante.Text = row["idCuentaRealizante"].ToString();
            this.cmbCuentaRealizante.SelectedValue = Convert.ToInt32(row["idCuentaRealizante"]);
            this.dtpFechaInicio.Value = Convert.ToDateTime(row["fechaInicio"]);
            this.txtDescripcion.Text = row["Descripcion"].ToString();
            this.txtFormaContacto.Text = row["FormaContacto"].ToString();
            this.cmbFormaContacto.SelectedValue = Convert.ToInt32(row["FormaContacto"]);
            this.txtTipoAccion.Text = row["Tipo"].ToString();
            this.cmbTipoAccion.SelectedValue = Convert.ToInt32(row["Tipo"]);
        }

        private void cmbCuentaSolicitante_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtIdCuentaSolicitante.Text = this.cmbCuentaSolicitante.SelectedValue.ToString();
        }

        private void cmbCuentaRealizante_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtIdCuentaRealizante.Text = this.cmbCuentaRealizante.SelectedValue.ToString();
        }

        private void cmbFormaContacto_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtFormaContacto.Text = this.cmbFormaContacto.SelectedValue.ToString();
        }

        private void cmbTipoAccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtTipoAccion.Text = this.cmbTipoAccion.SelectedValue.ToString();
        }
    }
}
