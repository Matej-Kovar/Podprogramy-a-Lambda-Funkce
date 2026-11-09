using System;

int[] bodyZaDny = [12, 7, 18, 5, 14];
int limit = 10;

int celkem = SpocitejSoucet(bodyZaDny, 0);

// ÚKOL 1: Doplňte lambda výraz. Vrací true, pokud hodnota dosáhla limitu.
// Lambda má použít místní proměnnou limit z tohoto bloku.
Predicate<int> splnilLimit = hodnota => false;

int pocetSplnenychDnu = SpocitejSplnene(bodyZaDny, splnilLimit);
VypisSouhrn(bodyZaDny, limit, celkem, pocetSplnenychDnu);

// ÚKOL 2: Doplňte rekurzivní funkci. Sečte prvky od zadaného indexu
// do konce pole. Pro index na konci pole (nebo za ním) vrací 0.
static int SpocitejSoucet(int[] body, int index)
{
    return 0; // TODO: ukončovací podmínka a rekurzivní volání
}

// ÚKOL 3: Doplňte funkci, která spočítá prvky splňující předanou podmínku.
// Podmínku volejte pro každý prvek pole; nevkládejte sem pevný limit 10.
static int SpocitejSplnene(int[] body, Predicate<int> podminka)
{
    return 0; // TODO: projít pole a použít podminka(prvek)
}

// ÚKOL 4: Doplňte proceduru (metodu bez návratové hodnoty).
// Vypište čtyři řádky ve formátu uvedeném v README.md.
static void VypisSouhrn(int[] body, int limit, int celkem, int pocetSplnenychDnu)
{
    Console.WriteLine("Souhrn čeká na doplnění."); // TODO
}
