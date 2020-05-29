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
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
        }

        public Consultas(string consulta, SqlConnection conexion)
        {
            InitializeComponent();

            SqlCommand command = new SqlCommand(consulta, conexion);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable reporte = new DataTable();
            dataAdapter.Fill(reporte);

            this.dgvConsulta.AutoGenerateColumns = true;
            this.dgvConsulta.DataSource = reporte;
            this.dgvConsulta.Update();

        }
    }
}
