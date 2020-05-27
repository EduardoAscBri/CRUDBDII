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
    public partial class Usuarios : Form
    {
        SqlConnection conexion;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        DataTable usuarios;

        string encriptacion = "wjhTZfnSzWvY6h3P";
        bool CrearActualizar = false;

        public Usuarios()
        {
            InitializeComponent();
        }

        public Usuarios(SqlConnection conexion)
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
                this.command = new SqlCommand("CrearUsuario", this.conexion);
                this.command.Parameters.AddWithValue("@Encriptacion", this.encriptacion);
                this.command.Parameters.AddWithValue("@Usuario", this.txtUsuario.Text);
                this.command.Parameters.AddWithValue("@Contraseña", this.txtContraseña.Text);
                this.command.Parameters.AddWithValue("@NombreCompleto", this.txtNombreCompleto.Text);
                this.command.CommandType = CommandType.StoredProcedure;
                this.command.ExecuteNonQuery();

                ActualizarVista();
            }
            else if(this.CrearActualizar == true)
            {
                //Actualizar registro
                this.command = new SqlCommand("ActualizarUsuario", this.conexion);
                this.command.Parameters.AddWithValue("@Encriptacion", this.encriptacion);
                this.command.Parameters.AddWithValue("@idUsuario", Convert.ToInt32(this.txtIdUsuario.Text));
                this.command.Parameters.AddWithValue("@Usuario", this.txtUsuario.Text);
                this.command.Parameters.AddWithValue("@Contraseña", this.txtContraseña.Text);
                this.command.Parameters.AddWithValue("@NombreCompleto", this.txtNombreCompleto.Text);
                this.command.CommandType = CommandType.StoredProcedure;
                this.command.ExecuteNonQuery();

                ActualizarVista();
            }
        }

        private void bttEliminar_Click(object sender, EventArgs e)
        {
            this.command = new SqlCommand("EliminarUsuario", this.conexion);
            this.command.Parameters.AddWithValue("@idUsuario", Convert.ToInt32(this.txtIdUsuario.Text));
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
            this.command = new SqlCommand("ListarUsuarios", this.conexion);
            this.command.Parameters.AddWithValue("@Encriptacion", this.encriptacion);
            this.command.CommandType = CommandType.StoredProcedure;

            this.dataAdapter = new SqlDataAdapter(this.command);
            this.usuarios = new DataTable();
            this.dataAdapter.Fill(this.usuarios);

            this.dgvUsuarios.AutoGenerateColumns = true;
            this.dgvUsuarios.DataSource = this.usuarios;
            this.dgvUsuarios.Update();

            LimpiarVista();
        }

        private void LimpiarVista()
        {
            this.CrearActualizar = false;

            this.txtIdUsuario.Text = "";
            this.txtUsuario.Text = "";
            this.txtContraseña.Text = "";
            this.txtNombreCompleto.Text = "";
        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.CrearActualizar = true;

            int index = this.dgvUsuarios.CurrentRow.Index;
            DataRow row = this.usuarios.Rows[index];

            this.txtIdUsuario.Text = row["idUsuario"].ToString();
            this.txtUsuario.Text = row["Usuario"].ToString();
            this.txtContraseña.Text = row["Contraseña"].ToString();
            this.txtNombreCompleto.Text = row["NombreCompleto"].ToString();
        }


    }
}
