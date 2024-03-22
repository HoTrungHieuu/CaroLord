namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        int[] arrBoard = new int[9];
        List<int> listP1 = new();
        List<int> listP2 = new();
        int turn = 0;
        bool isEnd=false;
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 9; i++)
            {
                arrBoard[i] = 0;
            }
        }

        private void putChess(Button btn, int pos)
        {
            if (turn == 0)
            {
                btn.Text = "X";
                btn.ForeColor = Color.Blue;
                if (listP1.Count > 2)
                {
                    listP1.Add(pos - 1);
                    RemoveChess(listP1[0]);
                    listP1.RemoveAt(0);
                }
                else
                {
                    listP1.Add(pos - 1);
                }
                if (listP1.Count == 3)
                {
                    ChangeBlack(listP1[0]);
                }
            }
            else
            {
                btn.Text = "O";
                btn.ForeColor = Color.Red;
                if (listP2.Count > 2)
                {
                    listP2.Add(pos - 1);
                    RemoveChess(listP2[0]);
                    listP2.RemoveAt(0);
                }
                else
                {
                    listP2.Add(pos - 1);
                }

                if (listP2.Count == 3)
                {
                    ChangeBlack(listP2[0]);
                }
            }
            if (CheckWin(pos - 1, turn + 1) == 1)
            {
                label2.Text = "player 1 win";
                isEnd = true;
                foreach (Control control in Controls)
                {
                    control.Enabled = false;
                }
            }
            else if (CheckWin(pos - 1, turn + 1) == 2)
            {
                label2.Text = "player 2 win";
                isEnd = true;
                foreach (Control control in Controls)
                {
                    control.Enabled = false;
                }
            }

            if (turn == 1 && !isEnd)
            {
                turn = 0;
                label2.Text = "P1 Turn";
                label2.ForeColor = Color.Blue;
            }
            else if(turn == 0 && !isEnd) 
            {
                turn = 1;
                label2.Text = "P2 Turn";
                label2.ForeColor = Color.Red;
            }


        }
        public void RemoveChess(int pos)
        {
            if (pos == 0)
            {
                button1.Text = "";
                arrBoard[0] = 0;
            }
            else if (pos == 1)
            {
                button2.Text = "";
                arrBoard[1] = 0;
            }
            else if (pos == 2)
            {
                button3.Text = "";
                arrBoard[2] = 0;
            }
            else if (pos == 3)
            {
                button4.Text = "";
                arrBoard[3] = 0;
            }
            else if (pos == 4)
            {
                button5.Text = "";
                arrBoard[4] = 0;
            }
            else if (pos == 5)
            {
                button6.Text = "";
                arrBoard[5] = 0;
            }
            else if (pos == 6)
            {
                button7.Text = "";
                arrBoard[6] = 0;
            }
            else if (pos == 7)
            {
                button8.Text = "";
                arrBoard[7] = 0;
            }
            else if (pos == 8)
            {
                button9.Text = "";
                arrBoard[8] = 0;
            }
        }
        private void ChangeBlack(int pos)
        {
            switch (pos)
            {
                case 0:
                    button1.ForeColor = Color.Black;
                    break;
                case 1:
                    button2.ForeColor = Color.Black;
                    break;
                case 2:
                    button3.ForeColor = Color.Black;
                    break;
                case 3:
                    button4.ForeColor = Color.Black;
                    break;
                case 4:
                    button5.ForeColor = Color.Black;
                    break;
                case 5:
                    button6.ForeColor = Color.Black;
                    break;
                case 6:
                    button7.ForeColor = Color.Black;
                    break;
                case 7:
                    button8.ForeColor = Color.Black;
                    break;
                case 8:
                    button9.ForeColor = Color.Black;
                    break;
            }
        }
        private int CheckWin(int position, int where)
        {
            if (position < 3)
            {
                if (arrBoard[position + 3] == where && arrBoard[position + 6] == where) return where;
                else if (position == 0 && arrBoard[4] == where && arrBoard[8] == where) return where;
                else if (position == 2 && arrBoard[4] == where && arrBoard[6] == where) return where;
                else if (arrBoard[0] == where && arrBoard[1] == where && arrBoard[2] == where) return where;
            }
            else if (position < 6)
            {
                if (arrBoard[position - 3] == where && arrBoard[position + 3] == where) return where;
                else if (position == 4 && arrBoard[0] == where && arrBoard[8] == where) return where;
                else if (position == 7 && arrBoard[2] == where && arrBoard[6] == where) return where;
                else if (arrBoard[3] == where && arrBoard[4] == where && arrBoard[5] == where) return where;
            }
            else if (position < 9)
            {
                if (arrBoard[position - 3] == where && arrBoard[position - 6] == where) return where;
                else if (position == 6 && arrBoard[4] == where && arrBoard[2] == where) return where;
                else if (position == 8 && arrBoard[4] == where && arrBoard[0] == where) return where;
                else if (arrBoard[6] == where && arrBoard[7] == where && arrBoard[8] == where) return where;
            }
            return 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text != "") return;
            if (turn == 0) arrBoard[0] = 1;
            else arrBoard[0] = 2;
            putChess(button1, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text != "") return;
            if (turn == 0) arrBoard[1] = 1;
            else arrBoard[1] = 2;
            putChess(button2, 2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text != "") return;
            if (turn == 0) arrBoard[2] = 1;
            else arrBoard[2] = 2;
            putChess(button3, 3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text != "") return;
            if (turn == 0) arrBoard[3] = 1;
            else arrBoard[3] = 2;
            putChess(button4, 4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text != "") return;
            if (turn == 0) arrBoard[4] = 1;
            else arrBoard[4] = 2;
            putChess(button5, 5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text != "") return;
            if (turn == 0) arrBoard[5] = 1;
            else arrBoard[5] = 2;
            putChess(button6, 6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text != "") return;
            if (turn == 0) arrBoard[6] = 1;
            else arrBoard[6] = 2;
            putChess(button7, 7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text != "") return;
            if (turn == 0) arrBoard[7] = 1;
            else arrBoard[7] = 2;
            putChess(button8, 8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text != "") return;
            if (turn == 0) arrBoard[8] = 1;
            else arrBoard[8] = 2;
            putChess(button9, 9);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}