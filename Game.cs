
namespace TicTacToeGame
{
    public class Game
    {
        public Board _board { get; private set; }

        public Game()
        {
            _board = new Board();
        }

        public void Play(Player player)
        {                
            _board[player.CoordinateX, player.CoordinateY] = player._symbol;
        }

        public bool IsValidMove(int x, int y)
        {
            return _board[x, y] is null;
        }

        public bool HasWinner() 
        {
            int[][] winningCombinations = {
                [0, 0, 0, 1, 0, 2],
                [1, 0, 1, 1, 1, 2],
                [2, 0, 2, 1, 2, 2], 
                [0, 0, 1, 0, 2, 0], 
                [0, 1, 1, 1, 2, 1], 
                [0, 2, 1, 2, 2, 2], 
                [0, 0, 1, 1, 2, 2], 
                [0, 2, 1, 1, 2, 0]
            };

            foreach (var combination in winningCombinations)
            {
                char? firstMove = _board[combination[0], combination[1]];
                char? secondMove = _board[combination[2], combination[3]];
                char? thirdMove = _board[combination[4], combination[5]];

                if (firstMove != null && firstMove == secondMove && secondMove == thirdMove)
                {
                    return true;
                }
            }

            return false;
        }

        public void Reset()
        {
            _board = new Board();
        }
    }
}
