using Cotizacion_Cootrasana.Clases;
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

namespace Cotizacion_Cootrasana
{
    public partial class Form1 : Form
    {
        
        private SqlConnection conexion;

        public Form1()
        {
            InitializeComponent();

            SqlConnection conexion = new SqlConnection("server=localhost; database=cotizacion; user=root;");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clases.Conexion objetoconexion = new Clases.Conexion();

            SqlCommand comando = new SqlCommand("select * from conductor", conexion);
            SqlDataAdapter Adaptador = new SqlDataAdapter();
            Adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            Adaptador.Fill(tabla);
            this.tabla.DataSource = tabla;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = tabla.SelectedCells[0].Value.ToString();
            textBox2.Text = tabla.SelectedCells[0].Value.ToString();
            textBox3.Text = tabla.SelectedCells[2].Value.ToString();
            textBox5.Text = tabla.SelectedCells[4].Value.ToString();
            textBox6.Text = tabla.SelectedCells[5].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conexion.Open();
            string consultar = "insert into conductor values('"+textBox1.Text+"','"+textBox2.Text+ "','" +textBox3.Text+ "',''" +textBox5.Text+ "','" +textBox6.Text+ "')";
            SqlCommand comando = new SqlCommand(consultar, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("registro agregado");
            llenar_tabla();
            limpiar_datos();

            Conexion.Close();
        }

        private void limpiar_datos()
        {
            throw new NotImplementedException();
        }

        private void llenar_tabla()
        {
            throw new NotImplementedException();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = tabla.SelectedCells[0].Value.ToString();
            textBox2.Text = tabla.SelectedCells[1].Value.ToString();
            textBox3.Text = tabla.SelectedCells[2].Value.ToString();
            textBox5.Text = tabla.SelectedCells[4].Value.ToString();
            textBox6.Text = tabla.SelectedCells[5].Value.ToString();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
