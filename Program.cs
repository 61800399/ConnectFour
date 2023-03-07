namespace ConnectFour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Board game = new Board();
            List<List<string>> list = game.Grid;
            output(list);
        }
        public static void output(List<List<string>> board)
        {
            foreach (var item in board)
            {
                string print = string.Join(", ", item);
                Console.WriteLine(print);
            }
        }

    }
}