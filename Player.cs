
namespace TicTacToeGame
{
    public class Player
    {
        public string _name { get; private set; }
        public char _symbol { get; set; }
        public int _score { get; set; } = 0;
        public int CoordinateX { get; set; }
        public int CoordinateY { get; set; }


        public Player(string name, char symbol)
        {
            _name = name;
            _symbol = symbol;
        }

        public void SetCoordinates(int x, int y)
        {
            CoordinateX = x;
            CoordinateY = y;
        }

    }
}
