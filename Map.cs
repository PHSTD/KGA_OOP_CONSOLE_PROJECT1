namespace KGA_OOP_CONSOLE_PROJECT1;

public static class Map
{
    public static bool[,] tiles;

    public static void MapSet(int level)
    {
        switch (level)
        {
            case 1:
                tiles = new bool[5, 10]
                {
                    { false, false, false, false, false, false, false, false, false, false },
                    { false, true, true,true, true, true, true, true, true, false },
                    { false, true, true, true, true, true, true, true, true, false },
                    { false, true, true, true, true, true, true, true, true, false },
                    { false, false, false, false, false, false, false, false, false, false },

                };
                break;
            case 2:
                tiles = new bool[5, 10]
                {
                    { false, false, false, false, false, false, false, false, false, false },
                    { false, true, false, true, true, true, true, true, true, false },
                    { false, true, true, true, true, true, true, true, true, false },
                    { false, true, false, false, false, true, true, true, true, false },
                    { false, false, false, false, false, false, false, false, false, false },
                };
                break;
            case 3:
                tiles = new bool[5, 10]
                {
                    { false, false, false, false, false, false, false, false, false, false },
                    { false, true, false, true, true, true, true, true, true, false },
                    { false, true, true, true, false, false, true, true, true, false },
                    { false, true, false, false, false, true, true, false, true, false },
                    { false, false, false, false, false, false, false, false, false, false },
                };
                break;
            case 4:
                tiles = new bool[5, 10]
                {
                    { false, false, false, false, false, false, false, false, false, false },
                    { false, true, false, true, true, true, true, true, true, false },
                    { false, true, true, true, true, true, false, false, false, false },
                    { false, true, false, false, false, true, true, true, true, false },
                    { false, false, false, false, false, false, false, false, false, false },
                };
                break;
            case 5:
                tiles = new bool[5, 10]
                {
                    { false, false, false, false, false, false, false, false, false, false },
                    { false, true, false, true, false, false, false, true, true, false },
                    { false, true, true, true, true, true, false, false, true, false },
                    { false, true, false, false, false, true, true, true, true, false },
                    { false, false, false, false, false, false, false, false, false, false },
                };
                break;
        }   
    }
    public static void MapPrint()
    {
        Console.Clear();
        for (int i = 0; i < tiles.GetLength(0); i++)
        {
            for(int j = 0 ; j < tiles.GetLength(1) ; j++)
            {
                if (tiles[i, j] == false)
                {
                    Console.Write('#');
                }
                else
                {
                    Console.Write(' ');
                }
            }
            Console.WriteLine();
        }
    }
}