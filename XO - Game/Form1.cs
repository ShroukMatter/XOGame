using Microsoft.Data.SqlClient;

namespace XO___Game
{
    public partial class MainForm : Form
    {
        SqlConnection con;
        Boolean checker;
        int plusone;
        List<Button> list;
        private string player1;
        private string player2;
        private int x;
        private int o;
        int insertedId;


        public MainForm(string _player1, string _player2, int _x, int _o)
        {
            player1 = _player1;
            player2 = _player2;
            x = _x;
            o = _o;
            InitializeComponent();
            con = new SqlConnection("Server=DESKTOP-1G999G2\\SQLEXPRESS;Database=Xo-Game;Trusted_Connection=True;TrustServerCertificate=True");
            insertedId = CreateGame();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            list = new List<Button> { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };

            if (x == 1)
            {
                label1.Text = player2;
                label2.Text = player1;
            }
            else
            {
                label1.Text = player1;
                label2.Text = player2;
            }

        }

        public void Enable_False()
        {
            foreach (var item in list)
            {
                item.Enabled = false;
            }

        }

        void score()
        {

            //Player X
            if (btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X")
            {
                btn1.BackColor = Color.Yellow;
                btn2.BackColor = Color.Yellow;
                btn3.BackColor = Color.Yellow;
                MessageBox.Show($"The Winner is player {label2.Text}");
                plusone = int.Parse(X_lbl.Text);
                X_lbl.Text = Convert.ToString(plusone + 1);
                UpdateScore();
                Enable_False();
            }
            if (btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X")
            {
                btn1.BackColor = Color.Yellow;
                btn4.BackColor = Color.Yellow;
                btn7.BackColor = Color.Yellow;
                plusone = int.Parse(X_lbl.Text);
                X_lbl.Text = Convert.ToString(plusone + 1);
                MessageBox.Show($"The Winner is player {label2.Text}");
                UpdateScore();
                Enable_False();
            }
            if (btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X")
            {
                btn2.BackColor = Color.Yellow;
                btn5.BackColor = Color.Yellow;
                btn8.BackColor = Color.Yellow;
                MessageBox.Show($"The Winner is player {label2.Text}");

                plusone = int.Parse(X_lbl.Text);
                X_lbl.Text = Convert.ToString(plusone + 1);
                UpdateScore();
                Enable_False();
            }
            if (btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X")
            {
                btn3.BackColor = Color.Yellow;
                btn6.BackColor = Color.Yellow;
                btn9.BackColor = Color.Yellow;

                plusone = int.Parse(X_lbl.Text);
                X_lbl.Text = Convert.ToString(plusone + 1);
                MessageBox.Show($"The Winner is player {label2.Text}");
                UpdateScore();

                Enable_False();
            }

            if (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X")
            {
                btn4.BackColor = Color.Yellow;
                btn5.BackColor = Color.Yellow;
                btn6.BackColor = Color.Yellow;
                MessageBox.Show($"The Winner is player {label2.Text}");

                plusone = int.Parse(X_lbl.Text);
                X_lbl.Text = Convert.ToString(plusone + 1);
                UpdateScore();

                Enable_False();
            }

            if (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X")
            {
                btn7.BackColor = Color.Yellow;
                btn8.BackColor = Color.Yellow;
                btn9.BackColor = Color.Yellow;
                MessageBox.Show($"The Winner is player {label2.Text}");

                plusone = int.Parse(X_lbl.Text);
                X_lbl.Text = Convert.ToString(plusone + 1);
                UpdateScore();

                Enable_False();

            }

            if (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X")
            {
                btn1.BackColor = Color.Yellow;
                btn5.BackColor = Color.Yellow;
                btn9.BackColor = Color.Yellow;
                MessageBox.Show($"The Winner is player {label2.Text}");

                plusone = int.Parse(X_lbl.Text);
                X_lbl.Text = Convert.ToString(plusone + 1);
                UpdateScore();

                Enable_False();
            }
            if (btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X")
            {
                btn3.BackColor = Color.Yellow;
                btn5.BackColor = Color.Yellow;
                btn7.BackColor = Color.Yellow;
                MessageBox.Show($"The Winner is player {label2.Text}");

                plusone = int.Parse(X_lbl.Text);
                X_lbl.Text = Convert.ToString(plusone + 1);
                UpdateScore();

                Enable_False();
            }

            //Player O
            if (btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O")
            {
                btn1.BackColor = Color.Yellow;
                btn2.BackColor = Color.Yellow;
                btn3.BackColor = Color.Yellow;
                MessageBox.Show($"The Winner is player {label1.Text}");

                plusone = int.Parse(O_lbl.Text);
                O_lbl.Text = Convert.ToString(plusone + 1);
                UpdateScore();

                Enable_False();
            }
            if (btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O")
            {
                btn1.BackColor = Color.Yellow;
                btn4.BackColor = Color.Yellow;
                btn7.BackColor = Color.Yellow;
                MessageBox.Show($"The Winner is player {label1.Text}");

                plusone = int.Parse(O_lbl.Text);
                O_lbl.Text = Convert.ToString(plusone + 1);
                UpdateScore();

                Enable_False();
            }
            if (btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O")
            {
                btn2.BackColor = Color.Yellow;
                btn5.BackColor = Color.Yellow;
                btn8.BackColor = Color.Yellow;
                MessageBox.Show($"The Winner is player {label1.Text}");

                plusone = int.Parse(O_lbl.Text);
                O_lbl.Text = Convert.ToString(plusone + 1);
                UpdateScore();

                Enable_False();
            }
            if (btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O")
            {
                btn3.BackColor = Color.Yellow;
                btn6.BackColor = Color.Yellow;
                btn9.BackColor = Color.Yellow;
                MessageBox.Show($"The Winner is player {label1.Text}");

                plusone = int.Parse(O_lbl.Text);
                O_lbl.Text = Convert.ToString(plusone + 1);
                UpdateScore();

                Enable_False();
            }

            if (btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O")
            {
                btn4.BackColor = Color.Yellow;
                btn5.BackColor = Color.Yellow;
                btn6.BackColor = Color.Yellow;
                MessageBox.Show($"The Winner is player {label1.Text}");

                plusone = int.Parse(O_lbl.Text);
                O_lbl.Text = Convert.ToString(plusone + 1);
                UpdateScore();

                Enable_False();
            }

            if (btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O")
            {
                btn7.BackColor = Color.Yellow;
                btn8.BackColor = Color.Yellow;
                btn9.BackColor = Color.Yellow;
                MessageBox.Show($"The Winner is player {label1.Text}");

                plusone = int.Parse(O_lbl.Text);
                O_lbl.Text = Convert.ToString(plusone + 1);
                UpdateScore();

                Enable_False();

            }

            if (btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O")
            {
                btn1.BackColor = Color.Yellow;
                btn5.BackColor = Color.Yellow;
                btn9.BackColor = Color.Yellow;
                MessageBox.Show($"The Winner is player {label1.Text}");

                plusone = int.Parse(O_lbl.Text);
                O_lbl.Text = Convert.ToString(plusone + 1);
                UpdateScore();

                Enable_False();
            }
            if (btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O")
            {
                btn3.BackColor = Color.Yellow;
                btn5.BackColor = Color.Yellow;
                btn7.BackColor = Color.Yellow;
                MessageBox.Show($"The Winner is player {label1.Text}");

                plusone = int.Parse(O_lbl.Text);
                O_lbl.Text = Convert.ToString(plusone + 1);
                UpdateScore();

                Enable_False();
            }





        }



        private void btn1_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn1.Text = "X";
                checker = true;
            }
            else
            {
                btn1.Text = "O";
                checker = false;
            }

            score();
            btn1.Enabled = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {

                btn2.Text = "X";
                checker = true;
            }
            else
            {

                btn2.Text = "O";
                checker = false;
            }

            score();
            btn2.Enabled = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn3.Text = "X";
                checker = true;
            }
            else
            {
                btn3.Text = "O";
                checker = false;
            }

            score();
            btn3.Enabled = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn4.Text = "X";
                checker = true;
            }
            else
            {
                btn4.Text = "O";
                checker = false;
            }

            score();
            btn4.Enabled = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn5.Text = "X";
                checker = true;
            }
            else
            {
                btn5.Text = "O";
                checker = false;
            }

            score();
            btn5.Enabled = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn6.Text = "X";
                checker = true;
            }
            else
            {
                btn6.Text = "O";
                checker = false;
            }

            score();
            btn6.Enabled = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn7.Text = "X";
                checker = true;
            }
            else
            {
                btn7.Text = "O";
                checker = false;
            }

            score();
            btn7.Enabled = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn8.Text = "X";
                checker = true;
            }
            else
            {
                btn8.Text = "O";
                checker = false;
            }

            score();
            btn8.Enabled = false;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn9.Text = "X";
                checker = true;
            }
            else
            {
                btn9.Text = "O";
                checker = false;
            }

            score();
            btn9.Enabled = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        private int CreateGame()
        {
            insertedId = 0;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = "insert into Game ([Player1],[Player2],[P1Score],[P2Score]) OUTPUT INSERTED.id VALUES (@Player1 ,@Player2 , @P1Score ,@P2Score);";
            sqlCommand.Parameters.AddWithValue("@Player1", player1);
            sqlCommand.Parameters.AddWithValue("@Player2", player2);
            sqlCommand.Parameters.AddWithValue("@P1Score", int.Parse(X_lbl.Text));
            sqlCommand.Parameters.AddWithValue("@P2Score", int.Parse(O_lbl.Text));
            sqlCommand.Connection = con;

            try
            {
                // open connection
                con.Open();

                // exceute
                insertedId = Convert.ToInt32(sqlCommand.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // close connection
                con.Close();
            }
            return insertedId;
        }

        private void UpdateScore()
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = "update Game  SET [P1Score] = @P1Score,[P2Score] = @P2Score WHERE id = @id";
            sqlCommand.Parameters.AddWithValue("@id", insertedId);
            sqlCommand.Parameters.AddWithValue("@P1Score", int.Parse(X_lbl.Text));
            sqlCommand.Parameters.AddWithValue("@P2Score", int.Parse(O_lbl.Text));
            sqlCommand.Connection = con;

            try
            {
                // open connection
                con.Open();
                sqlCommand.ExecuteNonQuery();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // close connection
                con.Close();
            }
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            foreach (var item in list)
            {
                item.Text = "";
                item.BackColor = Color.White;
                item.Enabled = true;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Score form = new Score();
            form.ShowDialog();
            this.Close();
        }
    }
}
