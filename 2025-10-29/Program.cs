// Hei dette er en kommentar

string navn = ØyvindsReadLine("Hva heter du?");

//string alder = ØyvindsReadLine("Hvor gammel er du?");
//int alderSomTall = Convert.ToInt32(alder);

int alderSomTall = ReadNumber("Hvor gammel er du?");

if (alderSomTall > 40)
{
    Console.WriteLine($"Hei, {navn}. Du er skikkelig gammal!!");
}
else
{
    Console.WriteLine($"Hei, {navn}. Du er fortsatt ung :D ");
}

string ØyvindsReadLine(string meldingTilBruker)
{
    Console.WriteLine(meldingTilBruker);
    string innlestVerdi = Console.ReadLine();

    return innlestVerdi;
}

int ReadNumber(string meldingTilBruker)
{
    var innlestVerdi = ØyvindsReadLine(meldingTilBruker);

    bool success = int.TryParse(innlestVerdi, out int number);
    while (!success)
    {
        innlestVerdi = ØyvindsReadLine($"Vennligst skriv inn et tall");
        success = int.TryParse(innlestVerdi, out number);
    }
    return number;
}