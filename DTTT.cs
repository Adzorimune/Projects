using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace Disfunctional_TicTacToe
{
	public partial class DTTT : Form
	{

        Random random = new Random();
        public enum Player
		{
			X, O
        }
        List<Button> buttons;

		int[] fieldPlayer;
		int[] fieldAI;

		bool playerMayMove;

		public DTTT()
		{
			InitializeComponent();
			RestartGame();
		}
        private void RestartGame(object sender, EventArgs e)
        {
            RestartGame();
        }
        public void RestartGame()
        {
            buttons = new List<Button> { button1, button2, button3, button4,
                button5, button6, button7, button8, button9};
            fieldPlayer = new int[9];
            fieldAI = new int[9];

            playerMayMove = true;

            textBox1.Text = "";
            textBox1.BackColor = DefaultBackColor;
            textBox1.Enabled = false; //yeah, thats makes readability shitty but anyway
            textBox1.ForeColor = Color.Black;

            foreach (Button btn in buttons)
            {
                btn.Enabled = true;
                btn.Text = "";
                btn.TabStop = false;
                btn.BackColor = DefaultBackColor;
            }
        }
        //should've create this in "field" (aka players' action tracker class) buts its too late
        private void PlayerMove(object sender, EventArgs e)
        {
            if (playerMayMove == true)
            {
                var button = (Button)sender;
                buttons.Remove(button);

                button.Text = Player.X.ToString();
                button.Enabled = false;
                button.BackColor = Color.Cyan;
                UseButton(Player.X, button);

                playerMayMove = false;

                if (CheckVictoryOfPlayer())
                {
                    PlayerVictory();
                } else AITimer.Start();
            }
        }
        private void AIMove(object sender, EventArgs e)
		{
			if (buttons.Count > 0)
			{
				var button = buttons[random.Next(buttons.Count)];
				buttons.Remove(button);
				AITimer.Stop();

				button.Text = Player.O.ToString();
				button.Enabled = false;
				button.BackColor = Color.Red;
				UseButton(Player.O, button);

				if (CheckVictoryOfAI())
				{
					AIVictory();
				} else playerMayMove = true;
			} else Draw();
        }
        //fck switch-object inderect compatibility
        private void UseButton(Player p, Button b)
        {
            int temp = -1;
            if (b == button1) temp = 1;
            else if (b == button2) temp = 2;
            else if (b == button3) temp = 3;
            else if (b == button4) temp = 4;
            else if (b == button5) temp = 5;
            else if (b == button6) temp = 6;
            else if (b == button7) temp = 7;
            else if (b == button8) temp = 8;
            else if (b == button9) temp = 9;
            else { textBox1.Text = "Please be patient I have autism"; temp = 1; } // unnecessary but anyway

            switch (p)
            {
                case Player.X:
                    fieldPlayer[temp - 1] = temp;
                    break;

                case Player.O:
                    fieldAI[temp - 1] = temp;
                    break;
            }
        }
        //thats a fcking mess of a code. initially should've using additional class to store all players info
        private bool CheckVictoryOfPlayer()
		{
			if (fieldPlayer.Contains(1) && fieldPlayer.Contains(2) && fieldPlayer.Contains(3)) return true;
			else if (fieldPlayer.Contains(4) && fieldPlayer.Contains(5) && fieldPlayer.Contains(6)) return true;
			else if (fieldPlayer.Contains(7) && fieldPlayer.Contains(8) && fieldPlayer.Contains(9)) return true;
			else if (fieldPlayer.Contains(1) && fieldPlayer.Contains(5) && fieldPlayer.Contains(9)) return true;
			else if (fieldPlayer.Contains(3) && fieldPlayer.Contains(5) && fieldPlayer.Contains(7)) return true;
			else if (fieldPlayer.Contains(7) && fieldPlayer.Contains(8) && fieldPlayer.Contains(9)) return true;
			else if (fieldPlayer.Contains(1) && fieldPlayer.Contains(4) && fieldPlayer.Contains(7)) return true;
			else if (fieldPlayer.Contains(2) && fieldPlayer.Contains(5) && fieldPlayer.Contains(8)) return true;
			else if (fieldPlayer.Contains(3) && fieldPlayer.Contains(6) && fieldPlayer.Contains(9)) return true;

			else return false;
		}
        private bool CheckVictoryOfAI()
        {
            if (fieldAI.Contains(1) && fieldAI.Contains(2) && fieldAI.Contains(3)) return true;
            else if (fieldAI.Contains(4) && fieldAI.Contains(5) && fieldAI.Contains(6)) return true;
            else if (fieldAI.Contains(7) && fieldAI.Contains(8) && fieldAI.Contains(9)) return true;
            else if (fieldAI.Contains(1) && fieldAI.Contains(5) && fieldAI.Contains(9)) return true;
            else if (fieldAI.Contains(3) && fieldAI.Contains(5) && fieldAI.Contains(7)) return true;
            else if (fieldAI.Contains(7) && fieldAI.Contains(8) && fieldAI.Contains(9)) return true;
            else if (fieldAI.Contains(1) && fieldAI.Contains(4) && fieldAI.Contains(7)) return true;
            else if (fieldAI.Contains(2) && fieldAI.Contains(5) && fieldAI.Contains(8)) return true;
            else if (fieldAI.Contains(3) && fieldAI.Contains(6) && fieldAI.Contains(9)) return true;

            else return false;
        }
        //endings
        private void Draw()
		{
			textBox1.Text = "Thats a Draw";
			textBox1.BackColor = Color.Gray;
		}
		private void PlayerVictory()
		{
			textBox1.Text = "GJ";
			textBox1.BackColor = Color.Cyan;
		}
		private void AIVictory()
		{
			textBox1.Text = "HAHAHAHAHAHAHHAHAAHAHAHHAHAHAHAHAHAHHA";
			textBox1.BackColor = Color.Red;
		}
		private void DTTT_Load(object sender, EventArgs e)
		{

        }
    }
}
