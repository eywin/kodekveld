namespace kodekveld;

public class GameOfLife
{
    public static void Start()
    {
        var arr = new bool[40, 120];
        Randomize(arr);

        PrintArray(arr, "seed");
        for (int i = 0; i < 3000; i++)
        {
            arr = Evolve(arr);
            PrintArray(arr, $"evolution: {(i + 1)}");

            // add some sleep, so you can see each evolution
            Thread.Sleep(50);
        }
    }
    public static void PrintArray(bool[,] arr, string title = "")
    {
        string s = title + "\n";
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                s += arr[i, j] ? "#" : " ";
            }
            s += "\n";
        }
        Console.WriteLine(s);
    }

    public static void Randomize(bool[,] array)
    {
        var r = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = r.Next(0, 5) == 0;
            }
        }
    }


    public static bool[,] Evolve(bool[,] array)
    {
        bool[,] nextGen = new bool[array.GetLength(0), array.GetLength(1)];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                nextGen[i, j] = CalcCell(array, i, j);
            }
        }

        return nextGen;
    }


    public static bool CalcCell(bool[,] array, int i, int j)
    {
        // rules
        // lives: true
        //      2 or 3 live neighbours alive
        //      dead cell with exactly 3 live neighbouring cells 
        // dies: false
        //      the rest...

        // calc living neighbours
        int aliveNeighbours = 0;

        int maxOffsetI = GetMaxOffset(i, array.GetLength(0));
        int maxOffsetJ = GetMaxOffset(j, array.GetLength(1));

        for (int offsetI = GetMinOffset(i); offsetI <= maxOffsetI; offsetI++)
        {
            for (int offsetJ = GetMinOffset(j); offsetJ <= maxOffsetJ; offsetJ++)
            {
                // skip self
                if (offsetI == 0 && offsetJ == 0) continue;

                // increment alive if neighbour is alive
                if (array[offsetI + i, offsetJ + j]) aliveNeighbours++;
            }
        }

        // decide if cell should be alive based on the rules

        bool isAlive = array[i, j];
        bool shouldLive = (isAlive && (aliveNeighbours <= 3 && aliveNeighbours >= 2)) ||
                          (!isAlive && aliveNeighbours == 3);

        return shouldLive;
    }

    public static int GetMinOffset(int x)
    {
        return x == 0 ? 0 : -1;
    }

    public static int GetMaxOffset(int x, int arrLength)
    {
        return x == arrLength - 1 ? 0 : 1;
    }
}