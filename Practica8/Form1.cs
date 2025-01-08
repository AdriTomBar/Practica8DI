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

namespace Practica8
{
    public partial class Form1 : Form
    {
        //Creamos la conexion como se indica en la documentacion de la practica
        SqlConnection conn = new SqlConnection("server=(local)\\SQLEXPRESS;database=master; Integrated Security = SSPI");
        SqlCommand comandosql = new SqlCommand();
        SqlTransaction transaccion;

        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //ADD
        private void btAdd_Click(object sender, EventArgs e)
        {
            conn.Open();

            transaccion = conn.BeginTransaction(); //Iniciamos transacción

            comandosql.Connection = conn;
            comandosql.Transaction = transaccion;
            comandosql.CommandText = "INSERT into traduccion (esp,ing) values(@esp,@ing)";
            comandosql.Parameters.Clear();
            comandosql.Parameters.AddWithValue("@esp", tbEspaniol.Text);
            comandosql.Parameters.AddWithValue("@ing", tbIngles.Text);
            comandosql.ExecuteNonQuery();

            transaccion.Commit(); //Confirmamos la transacción

            conn.Close();

            btCargar.PerformClick();
            tbEspaniol.Clear();
            tbIngles.Clear();
        }
        //UPDATE
        private void btUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();

            transaccion = conn.BeginTransaction(); //Iniciamos transacción

            comandosql.Connection = conn;
            comandosql.Transaction = transaccion;
            comandosql.CommandText = "UPDATE traduccion SET esp = @esp , ing = @ing where esp = @select";
            comandosql.Parameters.Clear();
            comandosql.Parameters.AddWithValue("@esp", tbEspaniol.Text);
            comandosql.Parameters.AddWithValue("@ing", tbIngles.Text);
            comandosql.Parameters.AddWithValue("@select", listView1.SelectedItems[0].Text);
            comandosql.ExecuteNonQuery();

            transaccion.Commit(); //Confirmamos la transacción

            conn.Close();

            btCargar.PerformClick();
            tbEspaniol.Clear();
            tbIngles.Clear();
        }
        //DELETE
        private void btDelete_Click(object sender, EventArgs e)
        {
            conn.Open();

            transaccion = conn.BeginTransaction(); //Iniciamos transacción

            comandosql.Connection = conn;
            comandosql.Transaction = transaccion;
            comandosql.CommandText = "DELETE FROM traduccion WHERE esp = @esp";
            comandosql.Parameters.Clear();
            comandosql.Parameters.AddWithValue("@esp", listView1.SelectedItems[0].Text);

            comandosql.ExecuteNonQuery();

            transaccion.Commit(); //Confirmamos la transacción

            conn.Close();

            btCargar.PerformClick();
        }
        //EXIT
        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //SEARCH
        private void btSearch_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();


            conn.Open();

            comandosql.Connection = conn;

            //Consulta en la que primero comprobamos el idioma de la palabra y después buscamos la palabra
            comandosql.CommandText = "SELECT * FROM traduccion WHERE (@pais = 'esp' AND esp LIKE @palabra) OR (@pais = 'ing' AND ing LIKE @palabra)";

            comandosql.Parameters.Clear();

            comandosql.Parameters.AddWithValue("@pais", comboBox1.Text); 
            comandosql.Parameters.AddWithValue("@palabra", "%" + tbBuscar.Text + "%");

            SqlDataReader reader = comandosql.ExecuteReader();

            while (reader.Read())
            {
                string dato1 = reader.GetString(0);
                string dato2 = reader.GetString(1);


                ListViewItem lista = listView1.Items.Add(dato1);
                lista.SubItems.Add(dato2);
            }
            reader.Close();
            conn.Close();
        }
        //LOAD
        private void btCargar_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            conn.Open();
            comandosql.Connection = conn;
            comandosql.CommandText = "SELECT * from traduccion";
            SqlDataReader reader = comandosql.ExecuteReader();
            string dato1;
            string dato2;
            while (reader.Read())
            {
                dato1 = reader.GetString(0);
                dato2 = reader.GetString(1);
                ListViewItem lista = listView1.Items.Add(dato1);
                lista.SubItems.Add(dato2);
            }
            reader.Close();
            conn.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
