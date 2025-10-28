namespace _2024_06_26.Oppgave2;


/*
Oppgave:
https://trix.ifi.uio.no/assignments/424

I det fiktive landet Ruritania er skattereglene slik at hvis en person har inntekt < 10000, 
så betaler man 10% skatt på hele inntekten, og hvis inntekten >= 10000, 
så betaler man 10% skatt på de første 10000 kronene og 30% skatt på resten av inntekten. 
Lag et program som regner ut og skriver ut hvor mange kroner som skal betales i skatt gitt inntekten. 
Programmet skal lese inntekten (som antas å være et flyttall) fra terminal.


*/
public class Oppgave2
{
    public static void Oppgave()
    {
        Console.WriteLine("hva er inntekten din?");
        string inntektStr = Console.ReadLine();

        double inntekt = GetDouble(inntektStr);

        double tax10 = CalcTax10Percent(inntekt);
        double tax30 = CalcTax30Percent(inntekt);
        
        Console.WriteLine($"inntektskatt under 10000: {tax10}");
        Console.WriteLine($"inntektskatt over  10000: {tax30}");
        Console.WriteLine($"inntektskatt total: {tax10 + tax30}");
        
    }

    
    public static double CalcTax30Percent(double income)
    {
        if (income < 10000) return 0;

        return (income - 10000) * 0.1;
    }


    public static double CalcTax10Percent(double income)
    {
        if (income <= 10000) return income * 0.1;

        return 1000;
    }
    public static double GetDouble(string numberAsStr)
    {
        try
        {
            return Convert.ToDouble(numberAsStr);
        }
        catch (FormatException e)
        {
            Console.WriteLine("not correctly formatted!");
            throw;
        }
        catch (OverflowException e)
        {
            Console.WriteLine("number too big!");
            throw;
        }
    }
}