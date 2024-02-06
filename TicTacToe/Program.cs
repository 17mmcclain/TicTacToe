namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TicTacToeFunctions game = new TicTacToeFunctions();

            //display rules
            game.Rules();

            game.OutPutArray(game.board);

            game.PlayFunction();

        }
    }
}