using TicTacToe.Models;

Match match = new Match(new Board());
string? winner = null;
while (winner == null)
{
    try
    {
        match.GameBoard.ShowBoard();
        Console.WriteLine($"Player {match.player}'s turn! select a position to make a move: ");
        string? pos = Console.ReadLine();
        if (pos == null)
        {
            throw new Exception("Por favor, digite a posição desejada");
        }
        else
        {
            match.MakeMove(new Position(pos));
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
        Console.WriteLine("Press a key to try again");
        Console.ReadKey();
    }
    winner = match.CheckWinner();
}
match.GameBoard.ShowBoard();
Console.WriteLine($"Congratulations Player {winner}, you won!!!");
