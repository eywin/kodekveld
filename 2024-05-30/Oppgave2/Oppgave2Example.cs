namespace _2024_05_30.Oppgave2;

public class Oppgave2Example
{
    public static void Start(string[] args)
    {
        var fileContent = File.ReadAllLines("Oppgave2/example.box");
        var boxes = fileContent.Select(line =>
        {
            var splitted = line.Split(',');
            if (splitted.Length != 2 || !int.TryParse(splitted[0], out int length) ||
                !int.TryParse(splitted[1], out int width))
            {
                throw new Exception("LOL FEIL INPUTDATA!");
            }

            return new Box(length, width);
        });
        foreach (var box in boxes)
        {
            Console.WriteLine($"{box.ToString()}\nArea: {box.GetArea()}");
        }
    }
}