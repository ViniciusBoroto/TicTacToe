using TicTacToe.Models;

Match match = new Match(new Board());

while (true)
{
    // try
    // {
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
//     catch (Exception e)
//     {
//         Console.WriteLine(e.Message);
// Console.ReadKey();
//     }

// }
