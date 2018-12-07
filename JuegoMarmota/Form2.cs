using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace JuegoMarmota
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String conexionString = null;
            conexionString = "Server=LAPTOP-L5KSIJ6J;Database=Juego;Trusted_Connection=True;";
            SqlConnection conexion;
            conexion = new SqlConnection(conexionString);

            SqlCommand comando;

            string query;
            query = "INSERT INTO Jugadores VALUES('" + txtIngresa.Text + "')";

            conexion.Open();
            comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();


            this.Hide();
            Form1 ingresar = new Form1();
            ingresar.Show();

            comando.Dispose();
            conexion.Close();


        }
    }
}
