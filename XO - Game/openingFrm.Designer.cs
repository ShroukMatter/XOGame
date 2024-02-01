namespace XO___Game
{
    partial class openingFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            player2_O = new RadioButton();
            player2_X = new RadioButton();
            textBox2 = new TextBox();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            textBox1 = new TextBox();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            player1O = new RadioButton();
            player1X = new RadioButton();
            label2 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(player2_O);
            panel1.Controls.Add(player2_X);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(397, 126);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 299);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // player2_O
            // 
            player2_O.AutoSize = true;
            player2_O.Location = new Point(204, 252);
            player2_O.Name = "player2_O";
            player2_O.Size = new Size(117, 24);
            player2_O.TabIndex = 7;
            player2_O.TabStop = true;
            player2_O.Text = "radioButton1";
            player2_O.UseVisualStyleBackColor = true;
            player2_O.CheckedChanged += player2_O_CheckedChanged;
            // 
            // player2_X
            // 
            player2_X.AutoSize = true;
            player2_X.Location = new Point(68, 252);
            player2_X.Name = "player2_X";
            player2_X.Size = new Size(117, 24);
            player2_X.TabIndex = 6;
            player2_X.TabStop = true;
            player2_X.Text = "radioButton1";
            player2_X.UseVisualStyleBackColor = true;
            player2_X.CheckedChanged += player2_X_CheckedChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(146, 130);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe Print", 19.8000011F);
            label8.ForeColor = SystemColors.ControlLight;
            label8.Location = new Point(15, 108);
            label8.Name = "label8";
            label8.Size = new Size(125, 59);
            label8.TabIndex = 4;
            label8.Text = "Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe Print", 19.8000011F);
            label6.ForeColor = SystemColors.ControlLight;
            label6.Location = new Point(187, 187);
            label6.Name = "label6";
            label6.Size = new Size(52, 59);
            label6.TabIndex = 3;
            label6.Text = "O";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Print", 19.8000011F);
            label5.ForeColor = SystemColors.ControlLight;
            label5.Location = new Point(68, 187);
            label5.Name = "label5";
            label5.Size = new Size(50, 59);
            label5.TabIndex = 2;
            label5.Text = "X";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 22.2F);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(15, 9);
            label1.Name = "label1";
            label1.Size = new Size(188, 64);
            label1.TabIndex = 0;
            label1.Text = "Player 2";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(player1O);
            panel2.Controls.Add(player1X);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 126);
            panel2.Name = "panel2";
            panel2.Size = new Size(379, 299);
            panel2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(144, 130);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe Print", 19.8000011F);
            label7.ForeColor = SystemColors.ControlLight;
            label7.Location = new Point(13, 108);
            label7.Name = "label7";
            label7.Size = new Size(125, 59);
            label7.TabIndex = 8;
            label7.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 19.8000011F);
            label4.ForeColor = SystemColors.ControlLight;
            label4.Location = new Point(166, 187);
            label4.Name = "label4";
            label4.Size = new Size(52, 59);
            label4.TabIndex = 7;
            label4.Text = "O";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 19.8000011F);
            label3.ForeColor = SystemColors.ControlLight;
            label3.Location = new Point(26, 187);
            label3.Name = "label3";
            label3.Size = new Size(50, 59);
            label3.TabIndex = 6;
            label3.Text = "X";
            // 
            // player1O
            // 
            player1O.AutoSize = true;
            player1O.Location = new Point(170, 252);
            player1O.Name = "player1O";
            player1O.Size = new Size(90, 24);
            player1O.TabIndex = 5;
            player1O.Text = "player1O";
            player1O.UseVisualStyleBackColor = true;
            player1O.CheckedChanged += player1O_CheckedChanged;
            // 
            // player1X
            // 
            player1X.AutoSize = true;
            player1X.Location = new Point(40, 252);
            player1X.Name = "player1X";
            player1X.Size = new Size(88, 24);
            player1X.TabIndex = 4;
            player1X.Text = "player1X";
            player1X.UseVisualStyleBackColor = true;
            player1X.CheckedChanged += player1X_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(3, 9);
            label2.Name = "label2";
            label2.Size = new Size(188, 64);
            label2.TabIndex = 3;
            label2.Text = "Player 1";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe Print", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(218, 504);
            button1.Name = "button1";
            button1.Size = new Size(279, 67);
            button1.TabIndex = 3;
            button1.Text = "Start Game";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // openingFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(764, 583);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "openingFrm";
            Text = "openingFrm";
            Load += openingFrm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private RadioButton player1O;
        private RadioButton player1X;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label8;
        private Label label7;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private RadioButton player2_X;
        private RadioButton player2_O;
    }
}