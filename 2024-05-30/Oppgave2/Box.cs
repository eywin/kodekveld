namespace _2024_05_30.Oppgave2;

public class Box
{
    private readonly int Length;
    private readonly int Width;

    
    
    public Box(int length, int width)
    {
        Length = length;
        Width = width;
    }

    public override string ToString()
    {
        var rect = $"w: {Width}, l: {Length}\n";
        for (int i = 0; i < Length; i++)
        {
            for (int j = 0; j < Width; j++)
            {
                bool isEdge = (j == 0 || j == Width - 1 || i == 0 || i == Length - 1);
                rect += isEdge ? "#" : " ";
            }

            rect += "\n";
        }
        return rect;
    }

    public int GetArea()
    {
        return Width * Length;
    }
}