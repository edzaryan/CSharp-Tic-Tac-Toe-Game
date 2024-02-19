using TicTacToeGame;

Game game = new();

Player player1 = new("Arsen", 'x');
Player player2 = new("David", 'o');

int coordinateX, coordinateY;

Player targetPlayer = player1;


while (true)
{
    Console.WriteLine($"{targetPlayer._name} enter X:");
    coordinateX = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"{targetPlayer._name} enter Y:");
    coordinateY = Convert.ToInt32(Console.ReadLine());

    if (game.IsValidMove(coordinateX, coordinateY))
    {
        targetPlayer.SetCoordinates(coordinateX, coordinateY);
        game.Play(targetPlayer);
        targetPlayer = (targetPlayer == player1) ? player2 : player1;
    }

    game._board.ShowBoard();

    if (game.HasWinner())
    {
        targetPlayer._score++;

        Console.WriteLine($"Hey, we have a winner! - {targetPlayer._name}");

        Console.WriteLine("Do you want to play again? (y - yes | n - no)");

        char? answer = Convert.ToChar(Console.ReadLine());

        if (answer != 'y') break;
    }
}

Console.WriteLine(@$"The game finshed with score 
    {player1._name} - {player1._score} and {player2._name} - {player2._score}");

