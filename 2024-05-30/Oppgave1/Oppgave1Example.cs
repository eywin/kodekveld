namespace _2024_05_30.Oppgave1;

public class Oppgave1Example
{
    public static void Start(string[] args)
    {
        if (args.Length != 2 || !int.TryParse(args[0], out int length) || !int.TryParse(args[1], out int width))
        {
            Console.WriteLine("LOL FEIL");
            return;
        }

        string rect = "";

        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < width; j++)
            {
                bool isEdge = (j == 0 || j == width - 1 || i == 0 || i == length - 1);
                rect += isEdge ? "#" : " ";
            }

            rect += "\n";
        }

        Console.WriteLine($"{rect}\nAreal: {length*width}");
    }
}