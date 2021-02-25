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
using System.Configuration;


namespace ColorsDBReal
{
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["ColorsDBReal.Properties.Settings.ColorsConnectionString"].ConnectionString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulatePetsTable();
        }
        private void PopulatePetsTable()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM PrimaryColor", connection))
            {
                DataTable primarytable = new DataTable();
                adapter.Fill(primarytable);

                listcolor.DisplayMember = "PrimaryColorName";
                listcolor.ValueMember = "Id";
                listcolor.DataSource = primarytable;
            }
        }

        private void listcolor_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateShadeNames();
        }
        private void PopulateShadeNames()
        {
            string query = "Select Shades.ColorName FROM Shades INNER JOIN PrimaryColor ON PrimaryColor.Id = Shades.PrimaryColorId WHERE PrimaryColor.Id = @PrimaryColorId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@PrimaryColorId", listcolor.SelectedValue);
                DataTable ShadeNameTable = new DataTable();
                adapter.Fill(ShadeNameTable);

                listShades.DisplayMember = "ColorName";
                listShades.ValueMember = "Id";
                listShades.DataSource = ShadeNameTable;

            }
        }
    }
}
