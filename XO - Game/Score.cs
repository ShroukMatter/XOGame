using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace XO___Game
{
    public partial class Score : Form
    {
        SqlConnection con;
        public Score()
        {
            InitializeComponent();

            con = new SqlConnection("Server=DESKTOP-1G999G2\\SQLEXPRESS;Database=Xo-Game;Trusted_Connection=True;TrustServerCertificate=True");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            

        }

        private void Score_Load(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT [Player1],[Player2],[P1Score],[P2Score] FROM Game order by id;";
                cmd.Connection = con;

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                con.Close();


                dgv.DataSource = dt;

            }
            catch (Exception ex) {
                MessageBox.Show($"{ex}");
            }
            

        }

    }
}
