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
    public partial class AccionesDetalle : Form
    {
        SqlConnection conexion;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        DataTable accionesDetalle;
        DataTable productosServicios;
        DataTable acciones;

        string encriptacion = "wjhTZfnSzWvY6h3P";
        bool CrearActualizar = false;

        public AccionesDetalle()
        {
            InitializeComponent();
        }

        public AccionesDetalle(SqlConnection conexion)
        {
            InitializeComponent();
            this.conexion = conexion;


            ControlesAuxiliares();
            ActualizarVista();
        }

        private void ControlesAuxiliares()
        {
            this.command = new SqlCommand("ListarProductosServicios", this.conexion);
            this.command.CommandType = CommandType.StoredProcedure;
            this.dataAdapter = new SqlDataAdapter(this.command);
            this.productosServicios = new DataTable();
            this.dataAdapter.Fill(this.productosServicios);

            this.cmbProductoServicio.DataSource = this.productosServicios;
            this.cmbProductoServicio.DisplayMember = "Nombre";
            this.cmbProductoServicio.ValueMember = "idProductoServicio";

            this.command = new SqlCommand("ListarAcciones", this.conexion);
            this.command.CommandType = CommandType.StoredProcedure;
            this.dataAdapter = new SqlDataAdapter(this.command);
            this.acciones = new DataTable();
            this.dataAdapter.Fill(this.acciones);

            this.cmbAccion.DataSource = this.acciones;
            this.cmbAccion.DisplayMember = "idAccion";
            this.cmbAccion.ValueMember = "idAccion";

        }

        private void bttGuardar_Click(object sender, EventArgs e)
        {
            if(this.CrearActualizar == false)
            {
                //Crear registro
                this.command = new SqlCommand("CrearAccionDetalle", this.conexion);
                this.command.Parameters.AddWithValue("@idAccion", this.txtIdAccion.Text);
                this.command.Parameters.AddWithValue("@idProductoServicio", this.txtIdProductoServicio.Text);
                this.command.Parameters.AddWithValue("@Cantidad", Convert.ToDecimal(this.txtCantidad.Text));
                this.command.Parameters.AddWithValue("@Precio", Convert.ToDecimal(this.txtPrecio.Text));
                this.command.Parameters.AddWithValue("@Descuento", Convert.ToDecimal(this.txtDescuento.Text));
                this.command.Parameters.AddWithValue("@Importe", Convert.ToDecimal(this.txtSubtotal.Text));
                this.command.Parameters.AddWithValue("@Impuesto", Convert.ToDecimal(this.txtImpuesto.Text));
                this.command.Parameters.AddWithValue("@Total", Convert.ToDecimal(this.txtTotal.Text));

                this.command.CommandType = CommandType.StoredProcedure;
                this.command.ExecuteNonQuery();

                ActualizarVista();
            }
            else if(this.CrearActualizar == true)
            {
                //Actualizar registro
                this.command = new SqlCommand("ActualizarAccionDetalle", this.conexion);
                this.command.Parameters.AddWithValue("@idAccionDetalle", this.txtIdAccionDetalle.Text);
                this.command.Parameters.AddWithValue("@idProductoServicio", this.txtIdProductoServicio.Text);
                this.command.Parameters.AddWithValue("@Cantidad", Convert.ToDecimal(this.txtCantidad.Text));
                this.command.Parameters.AddWithValue("@Precio", Convert.ToDecimal(this.txtPrecio.Text));
                this.command.Parameters.AddWithValue("@Descuento", Convert.ToDecimal(this.txtDescuento.Text));
                this.command.Parameters.AddWithValue("@Importe", Convert.ToDecimal(this.txtSubtotal.Text));
                this.command.Parameters.AddWithValue("@Impuesto", Convert.ToDecimal(this.txtImpuesto.Text));
                this.command.Parameters.AddWithValue("@Total", Convert.ToDecimal(this.txtTotal.Text));

                this.command.CommandType = CommandType.StoredProcedure;
                this.command.ExecuteNonQuery();

                ActualizarVista();
            }

        }

        private void bttEliminar_Click(object sender, EventArgs e)
        {
            this.command = new SqlCommand("EliminarAccionDetalle", this.conexion);
            this.command.Parameters.AddWithValue("@idAccionDetalle", Convert.ToInt32(this.txtIdAccionDetalle.Text));
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
            this.command = new SqlCommand("ListarAccionesDetalle", this.conexion);
            this.command.CommandType = CommandType.StoredProcedure;

            this.dataAdapter = new SqlDataAdapter(this.command);
            this.accionesDetalle = new DataTable();
            this.dataAdapter.Fill(this.accionesDetalle);

            this.dgvAcciones.AutoGenerateColumns = true;
            this.dgvAcciones.DataSource = this.accionesDetalle;
            this.dgvAcciones.Update();

            LimpiarVista();
        }

        private void LimpiarVista()
        {
            this.CrearActualizar = false;

            this.txtIdAccion.Text = "";
            this.txtIdAccionDetalle.Text = "";
            this.txtIdProductoServicio.Text = "";
            this.txtCantidad.Text = "";
            this.txtPrecio.Text = "";
            this.txtDescuento.Text = "";
            this.txtSubtotal.Text = "";
            this.txtImpuesto.Text = "";
            this.txtTotal.Text = "";
        }

        private void dgvAcciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.CrearActualizar = true;

            int index = this.dgvAcciones.CurrentRow.Index;
            DataRow row = this.accionesDetalle.Rows[index];

            this.txtIdAccion.Text = row["idAccion"].ToString();
            this.txtIdAccionDetalle.Text = row["idAccionDetalle"].ToString();
            this.txtIdProductoServicio.Text = row["idProductoServicio"].ToString();
            this.cmbProductoServicio.SelectedValue = Convert.ToInt32(row["idProductoServicio"]);
            this.txtCantidad.Text = row["Cantidad"].ToString();
            this.txtPrecio.Text = row["Precio"].ToString();
            this.txtDescuento.Text = row["Descuento"].ToString();
            this.txtSubtotal.Text = row["Importe"].ToString();
            this.txtImpuesto.Text = row["Impuesto"].ToString();
            this.txtTotal.Text = row["Total"].ToString();

        }

        private void cmbAccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtIdAccion.Text = this.cmbAccion.SelectedValue.ToString();
        }

        private void cmbProductoServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtIdProductoServicio.Text = this.cmbProductoServicio.SelectedValue.ToString();

            int index = this.cmbProductoServicio.SelectedIndex;
            this.txtPrecio.Text = this.productosServicios.Rows[index]["Precio"].ToString();
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            if(this.txtCantidad.Text != "")
            {
                double cantidad = Convert.ToDouble(this.txtCantidad.Text);
                double precio = Convert.ToDouble(this.txtPrecio.Text);

                double subtotal = cantidad * precio;

                this.txtSubtotal.Text = subtotal.ToString();
            }
        }

        private void txtDescuento_Leave(object sender, EventArgs e)
        {
            if(this.txtDescuento.Text != "")
            {
                double subtotal = Convert.ToDouble(this.txtSubtotal.Text);
                double descuento = Convert.ToDouble(this.txtDescuento.Text);

                double leSubtotal = subtotal - descuento;
                this.txtSubtotal.Text = leSubtotal.ToString();
                double impuesto = leSubtotal * 0.16;
                this.txtImpuesto.Text = impuesto.ToString();
                this.txtTotal.Text = (leSubtotal + impuesto).ToString();
            }
            else if(this.txtDescuento.Text == "")
            {
                this.txtDescuento.Text = "0";
                double subtotal = Convert.ToDouble(this.txtSubtotal.Text);
                double impuesto = subtotal * 0.16;
                this.txtImpuesto.Text = impuesto.ToString();
                this.txtTotal.Text = (subtotal + impuesto).ToString();
            }
        }
    }
}
