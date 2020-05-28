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
    public partial class ProductosServicios : Form
    {
        SqlConnection conexion;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        DataTable productosServicios;

        bool CrearActualizar = false;
        public ProductosServicios()
        {
            InitializeComponent();
        }

        public ProductosServicios(SqlConnection conexion)
        {
            InitializeComponent();
            this.conexion = conexion;
            ActualizarVista();
        }

        private void bttGuardar_Click(object sender, EventArgs e)
        {
            if (this.CrearActualizar == false)
            {
                //Crear registro
                this.command = new SqlCommand("CrearProductosServicios", this.conexion);
                this.command.Parameters.AddWithValue("@Codigo", this.txtCodigo.Text.ToString());
                this.command.Parameters.AddWithValue("@Nombre", this.txtNombreCompleto.Text);
                this.command.Parameters.AddWithValue("@Descripcion", this.txtDescripcion.Text.ToString());
                this.command.Parameters.AddWithValue("@Inventario", Convert.ToInt32(this.txtInventario.Text));
                this.command.Parameters.AddWithValue("@Precio", Convert.ToDecimal(this.txtPrecio.Text));
                this.command.CommandType = CommandType.StoredProcedure;
                this.command.ExecuteNonQuery();

                ActualizarVista();
            }
            else if (this.CrearActualizar == true)
            {
                //Actualizar registro
                this.command = new SqlCommand("ActualizarProductosServicios", this.conexion);
                this.command.Parameters.AddWithValue("@idProdcutoServicio", Convert.ToInt32(this.txtIdProductoServicio.Text));
                this.command.Parameters.AddWithValue("@Codigo", this.txtCodigo.Text.ToString());
                this.command.Parameters.AddWithValue("@Nombre", this.txtNombreCompleto.Text.ToString());
                this.command.Parameters.AddWithValue("@Descripcion", this.txtDescripcion.Text.ToString());
                this.command.Parameters.AddWithValue("@Inventario",Convert.ToInt32(this.txtInventario.Text));
                this.command.Parameters.AddWithValue("@Precio", Convert.ToDecimal(this.txtPrecio.Text));


                this.command.CommandType = CommandType.StoredProcedure;
                this.command.ExecuteNonQuery();

                ActualizarVista();
            }
        }

        private void bttEliminar_Click(object sender, EventArgs e)
        {
            this.command = new SqlCommand("EliminarProductoServicio ", this.conexion);
            this.command.Parameters.AddWithValue("@idProductoServicio ", Convert.ToInt32(this.txtIdProductoServicio.Text));
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
            this.command = new SqlCommand("ListarProductosServicios", this.conexion);
            this.command.CommandType = CommandType.StoredProcedure;

            this.dataAdapter = new SqlDataAdapter(this.command);
            this.productosServicios = new DataTable();
            this.dataAdapter.Fill(this.productosServicios);

            this.dgvProductoServicio.AutoGenerateColumns = true;
            this.dgvProductoServicio.DataSource = this.productosServicios;
            this.dgvProductoServicio.Update();

            LimpiarVista();
        }
        private void LimpiarVista()
        {
            this.CrearActualizar = false;

            this.txtIdProductoServicio.Text = "";
            this.txtCodigo.Text = "";
            this.txtNombreCompleto.Text = "";
            this.txtDescripcion.Text = "";
            this.txtInventario.Text = "";
            this.txtPrecio.Text = "";
        }
        private void dgvProductoServicio_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.CrearActualizar = true;

            int index = this.dgvProductoServicio.CurrentRow.Index;
            DataRow row = this.productosServicios.Rows[index];

            this.txtIdProductoServicio.Text = row["idProductoServicio"].ToString();
            this.txtCodigo.Text = row["Codigo"].ToString();
            this.txtNombreCompleto.Text = row["Nombre"].ToString();
            this.txtDescripcion.Text = row["Descripcion"].ToString();
            this.txtInventario.Text = row["Inventario"].ToString();
            this.txtPrecio.Text = row["Precio"].ToString();

        }
    }
}
