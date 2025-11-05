namespace _2025_11_05;

public class Oppgave1
{
    /*
       a) Skriv et program som ber brukeren om å skrive inn favorittfargen
       sin i terminalen og lagre svaret i en variabel farge.

       b) Utvid programmet slik at hvis brukeren svarer "gul", "oransje"
       eller "grønn", skal programmet skrive ut navnet på en frukt som har den fargen.

    */
    public static void Oppgave()
    {
        Console.WriteLine("Hva er favorittfargen din?");
        var farge = Console.ReadLine();

        farge = farge.ToLower().Trim();
        
        if (farge == "gul")
        {
            Console.WriteLine("Banan!");
            
        } else if (farge == "oransje")
        {
            Console.WriteLine("Appelsin!");
            
        } else if (farge == "grønn")
        {
            Console.WriteLine("Kiwi!");
        }
        else
        {
            Console.WriteLine("Jeg kommer ikke på noen frukt med den fargen....!");
        }
    }
}