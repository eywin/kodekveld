/*
 * a) Skriv et program som spør brukeren om hvilket år den er født
 * og lagre svaret i en variabel birthyear.
 *
 * b) utvid programmet slik at brukeren må taste inn et årstall til - lagre også dette i en variabel currentyear
 *
 * c) regn ut antall år fra birthyear til currentyear og skriv det til terminalen :)
 *
 *
 * example
 *
 * in:
 * 1994
 * 2025
 *
 * out:
 * 31
 * 
 */
 
 






Console.WriteLine("Hvilket år ble du født?");
var birthyear = Console.ReadLine();
bool success = int.TryParse(birthyear, out int birthYearNumber);

if (!success)
{
    Console.WriteLine("Karte ikke å lese inn tallet");
    return;
}

Console.WriteLine("Hvilket år er det?");
var currentyear = Console.ReadLine();
success = int.TryParse(currentyear, out int currentYearNumber); 

if (!success)
{
    Console.WriteLine("Karte ikke å lese inn tallet");
    return;
}

currentYearNumber = currentYearNumber + 50;
int result = currentYearNumber - birthYearNumber;

Console.WriteLine($"Du blir {result} år i {currentYearNumber}");