namespace _2024_06_26.Oppgave1;


/*
   a) Skriv et program som ber brukeren om å skrive inn favorittfargen
   sin i terminalen og lagre svaret i en variabel farge.

   b) Utvid programmet slik at hvis brukeren svarer "gul", "oransje" 
   eller "grønn", skal programmet skrive ut navnet på en frukt som har den fargen.
 */


public class Oppgave1
{
    private static Dictionary<string, string> fruitz = new()
    {
        { "grønn", "Pære" },
        { "gul", "Banan" },
        { "oransje", "Appelsin" },
    };
    public static void Oppgave()
    {
        Console.WriteLine("hva er yndlingsfargen din?");
        string farge = Console.ReadLine();

        if (fruitz.ContainsKey(farge))
            Console.WriteLine(fruitz[farge]);
        else
            Console.WriteLine("Det har vi ikke hørt om før");
    }
}