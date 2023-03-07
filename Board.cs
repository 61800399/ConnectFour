using System;

public class Board
{
    public List<List<string>> Grid { get; set; }

    public Board()
	{
		Initilize();
    }
	private void Initilize()
	{
		int g = 0;
		Grid = new List<List<string>>();
		for (int y = 0; y < 6; y++)
		{
			List<string> X = new List<string>();
			for (int x = 0; x < 7; x++)
			{
				g++;
				X.Add(g.ToString());
			}
			Grid.Add(X);
		}
	}
}
