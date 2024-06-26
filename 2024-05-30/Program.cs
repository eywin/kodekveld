// int Kvadrat(int number)
// {
//     return number * number;
// }
//
//
// int KvadratRot(int number)
// {
//     return (int)Math.Sqrt(number);
// }
//
// var tall = 7;
// int resultat = KvadratRot(Kvadrat(tall));
//
//
// Console.WriteLine(resultat);


class Tall
{
    public int Verdi { get; set; }

    public Tall Something(Func<int, int> func)
    {
        Verdi = func(Verdi);
        return this;
    }
    public Tall Kvadrat()
    {
        Verdi = Verdi * Verdi;
        return this;
    }

    public Tall Add(int n)
    {
        Verdi += n;
        return this;
    }
    public Tall Subtract(int n)
    {
        Verdi -= n;
        return this;
    }

    public Tall KvadratRot()
    {
        Verdi = (int)Math.Sqrt(Verdi);
        return this;
    }

    public override string ToString()
    {
        return Verdi.ToString();
    }
}

class DropDown
{
    public Tall Value { get; set; }
    public bool IsOpen { get; set; }

    public void OnSelect()
    {
        
    }
    
}

class Program
{
    public static void Main(string[] args)
    { 
        /*var tall = new Tall()
        {
            Verdi = 1000
        };

        tall.Add(tall.Verdi % 2 == 0 ? 10 : 0)
            .Kvadrat()
            .Subtract(500)
            .Something((v) => v * 3 / 6);

        var dd = new DropDown();
        dd.Value = tall;

        if (dd.IsOpen)
        {
            
        }*/


        int[] array = [1, 2, 3, 4, 5, 6, 7, 8];

        var bools = array.Select(n => n % 2 == 0).ToArray();
        
        
        var tallListe = array
            .Select(n => new Tall() { Verdi = n })
            .ToList();
        
        foreach (var t in tallListe)
        {
            t.Add(100);
        }
    }
}
