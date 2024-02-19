

namespace TicTacToeGame
{
    public class Board
    {
        private char?[,] _board;

        public Board() 
        { 
            _board = new char?[3, 3];
        }

        public char? this[int x, int y]
        {
            get
            {
                return _board[x, y];
            }
            set
            {
                _board[x, y] = value;
            }
        }

        public void ShowBoard()
        {
            int width = _board.GetLength(0);
            int height = _board.GetLength(1);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write((_board[i, j] is null ? " " : _board[i, j]) + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
