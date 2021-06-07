using static System.Console;
using System.Threading.Tasks;
namespace TicTacToe
{
    class Program
    {
        internal protected readonly static int player = 1;
        int choice;
        static async Task Main()
        {
            await new Program().GameAsync();
        }
        internal async Task GameAsync()
        {
            Clear();
            WriteLine("Player 1 : X\nPlayer 2 : Y");
            char[] array = new char[] { 'a', 'b', 'c', '1', '2', '3' };
            if (player % 2 == 0)
            {
                WriteLine("Player 2 turn");
            }
            else
            {
                WriteLine("Player 1 turn");
            }
            choice = int.Parse(ReadLine());

        }
    }
}
