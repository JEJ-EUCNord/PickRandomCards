// Vi skal bruge den klasse, som vi selv har udviklet
using PickRandomCards;

// Spørg brugeren, hvor mange kort, der skal trækkes
Console.Write("Hvor mange kort ønsker du at trække? ");

// Læs brugerens svar og gem svaret i variablen line, som er en streng (et antal karakterer)
string line = Console.ReadLine();

// Undersøg om brugerens indtastning (variablen line) er et nummer, og gem nummeret i variablen numberOfCards,
// som nu et af typen int, - altså et heltal
if (int.TryParse(line, out int numberOfCards))
{
    // Vælg det indtastede antal kort og gem dem i variablen mineKort, som her er en tabel med strenge
    string[] mineKort = CardPicker.PickSomeCards(numberOfCards);

    // Udskriv de valgte kort
    foreach (string kort in mineKort)
    {
        Console.WriteLine(kort);
    }
} 
else
{
    // Brugerens indtastning kunne ikke tolkes som et tal, så der udskrives en fejlmeddelelse
    Console.WriteLine("Indtast et gyldigt heltal!");
}