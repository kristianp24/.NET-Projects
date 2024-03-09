namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Game game;

        public Form1()
        {
            InitializeComponent();
            game = new Game();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Welcome to Tic Tac Toe.");

            // player1Input_SelectedIndexChanged(game, e);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }


        //Player p = new Player();
        private void button1_Click(object sender, EventArgs e)
        {



        }


        private void player1Input_SelectedIndexChanged(object sender, EventArgs e)
        {
            char s = Convert.ToChar(player1Input.SelectedItem);
            game.p1.Choice = s;
        }

        private void player2Input_SelectedIndexChanged(object sender, EventArgs e)
        {

            game.p2.Choice = Convert.ToChar(player2Input.SelectedItem);
        }

        private void EnterButton_MouseClick(object sender, MouseEventArgs e)
        {



        }


        private void Poz1_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            game.addChoice(Convert.ToChar(Poz1_0.SelectedItem), 1, 0);
            if (game.winner() != null)
            {
                Player winner = game.winner();
                if (winner == game.p1)
                    MessageBox.Show("Winner is Player 1");
                if (winner == game.p2)
                    MessageBox.Show("Winner is Player 2");
                if (winner != null)
                    this.Close();
            }

        }

        private void Poz1_1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            game.addChoice(Convert.ToChar(Poz1_1.SelectedItem), 1, 1);
            if (game.winner() != null)
            {
                Player winner = game.winner();
                if (winner == game.p1)
                    MessageBox.Show("Winner is Player 1");
                if (winner == game.p2)
                    MessageBox.Show("Winner is Player 2");
                if (winner != null)
                    this.Close();
            }
        }

        private void Poz1_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            game.addChoice(Convert.ToChar(Poz1_2.SelectedItem), 1, 2);
            if (game.winner() != null)
            {
                Player winner = game.winner();
                if (winner == game.p1)
                    MessageBox.Show("Winner is Player 1");
                if (winner == game.p2)
                    MessageBox.Show("Winner is Player 2");
                if (winner != null)
                    this.Close();
            }
        }

        private void Poz0_0_SelectedIndexChanged(object sender, EventArgs e)
        {
            game.addChoice(Convert.ToChar(Poz0_0.SelectedItem), 0, 0);
            if (game.winner() != null)
            {
                Player winner = game.winner();
                if (winner == game.p1)
                    MessageBox.Show("Winner is Player 1");
                if (winner == game.p2)
                    MessageBox.Show("Winner is Player 2");
                if (winner != null)
                    this.Close();
            }
        }

        private void Poz0_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            game.addChoice(Convert.ToChar(Poz0_1.SelectedItem), 0, 1);
            if (game.winner() != null)
            {
                Player winner = game.winner();
                if (winner == game.p1)
                    MessageBox.Show("Winner is Player 1");
                if (winner == game.p2)
                    MessageBox.Show("Winner is Player 2");
                if (winner != null)
                    this.Close();
            }
        }

        private void Poz0_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            game.addChoice(Convert.ToChar(Poz0_2.SelectedItem), 0, 2);
            if (game.winner() != null)
            {
                Player winner = game.winner();
                if (winner == game.p1)
                    MessageBox.Show("Winner is Player 1");
                if (winner == game.p2)
                    MessageBox.Show("Winner is Player 2");
                if (winner != null)
                    this.Close();
            }
        }

        private void Poz2_0_SelectedIndexChanged(object sender, EventArgs e)
        {
            game.addChoice(Convert.ToChar(Poz2_0.SelectedItem), 2, 0);
            if (game.winner() != null)
            {
                Player winner = game.winner();
                if (winner == game.p1)
                    MessageBox.Show("Winner is Player 1");
                if (winner == game.p2)
                    MessageBox.Show("Winner is Player 2");
                if (winner != null)
                    this.Close();
            }
        }

        private void Poz2_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            game.addChoice(Convert.ToChar(Poz2_1.SelectedItem), 2, 1);
            if (game.winner() != null)
            {
                Player winner = game.winner();
                if (winner == game.p1)
                    MessageBox.Show("Winner is Player 1");
                if (winner == game.p2)
                    MessageBox.Show("Winner is Player 2");
                if (winner != null)
                    this.Close();
            }
        }

        private void Poz2_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            game.addChoice(Convert.ToChar(Poz2_2.SelectedItem), 2, 2);
            if (game.winner() != null)
            {
                Player winner = game.winner();
                if (winner == game.p1)
                    MessageBox.Show("Winner is Player 1");
                if (winner == game.p2)
                    MessageBox.Show("Winner is Player 2");
                if (winner != null)
                    this.Close();
            }
        }

        private void Done_Game_MouseClick(object sender, MouseEventArgs e)
        {
            if (game.isGameEnded())
            {
                MessageBox.Show("The game ended equal");
                this.Close();

            }
            else
                MessageBox.Show("You left the game");
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}