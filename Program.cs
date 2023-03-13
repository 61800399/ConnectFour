namespace ConnectFour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Board game = new Board();
            Player player1 = new Player();
            Player player2 = new Player();
            Player[] players = { player1, player2 };
            var board = game.Initilize(); // Creates board
            output(board, game.Player); 
            while (true)
            {
                int x_coord = game.Ask_Column();
                int y_coord = game.Get_Y(x_coord, board);
                
                
                output(board, game.Player);
                if (game.Player == 1)
                {
                    if (players[0].Check_Win(game.Player, board))
                    {
                        Console.WriteLine("you have won player one");
                        break;
                    }
                }
                else if (game.Player == 2)
                {
                    if (players[1].Check_Win(game.Player, board))
                    {
                        Console.WriteLine("you have won player two");
                        break;
                    }
                }
                game.Switch_Player();
            }
        }
        public static void output(List<List<string>> board, int Player)
        {
            Console.Clear();
            Console.WriteLine($"Player {Player}\nRow\n1, 2, 3, 4, 5, 6, 7\n-------------------");
            foreach (var item in board)
            {
                //if ()
                string print = string.Join("  ", item);
                Console.WriteLine(print);
            }
        }
    }
}