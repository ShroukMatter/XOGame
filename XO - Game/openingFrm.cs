using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XO___Game
{
    public partial class openingFrm : Form
    {
        private int x = 0;
        private int o = 0 ;
        private char player1Choice = ' ';
        private char player2Choice = ' ';

      

        public openingFrm()
        {
            InitializeComponent();
            
        }

        private void openingFrm_Load(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void player1O_CheckedChanged(object sender, EventArgs e)
        {

            if (player1O.Checked)
            {
                 x = 2;
                 o = 1;
                player1Choice = 'O';
                player1X.Checked = false;

                if (player2_O.Checked)
                {
                    player2_O.Checked = false;

                }
                player2Choice = 'X';
                player2_X.Checked = true;


            }

        }



        private void player2O_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void player1X_CheckedChanged(object sender, EventArgs e)
        {
            if (player1X.Checked)
            {
                 x = 1;
                 o = 2;
                player1Choice = 'X';
                player1O.Checked = false;

                if (player2_X.Checked)
                {
                    player2_X.Checked = false;
                }
                player2Choice = 'O';
                player2_O.Checked = true;


            }
        }

        private void player2_X_CheckedChanged(object sender, EventArgs e)
        {
            if (player2_X.Checked)
            {
                x = 2;
                 o = 1;

                player2Choice = 'X';
                player2_O.Checked = false;

                if (player1X.Checked)
                {

                    player1X.Checked = false;
                }
                player1Choice = 'O';
                player1O.Checked = true;

            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void player2_O_CheckedChanged(object sender, EventArgs e)
        {
            if (player2_O.Checked)
            {
                x = 1;
                o = 2;

                player2Choice = 'O';
                player2_X.Checked = false;

                if (player1O.Checked)
                {
                    player1O.Checked = false;

                }
                player1Choice = 'X';
                player1X.Checked = true;


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length == 0 || textBox2.Text.Length == 0)
            {
                MessageBox.Show("Please Enter Names");


            }
            else
            {
                this.Hide();
                MainForm form = new MainForm(textBox1.Text, textBox2.Text , x,o);
                form.ShowDialog();
                this.Close();



            }
       
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
