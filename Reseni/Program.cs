using System;

int[] bodyZaDny = [12, 7, 18, 5, 14];
int limit = 10;

int celkem = SpocitejSoucet(bodyZaDny, 0);
Predicate<int> splnilLimit = hodnota => hodnota >= limit;
int pocetSplnenychDnu = SpocitejSplnene(bodyZaDny, splnilLimit);

VypisSouhrn(bodyZaDny, limit, celkem, pocetSplnenychDnu);

static int SpocitejSoucet(int[] body, int index)
{
    if (index >= body.Length)
    {
        return 0;
    }

    return body[index] + SpocitejSoucet(body, index + 1);
}

static int SpocitejSplnene(int[] body, Predicate<int> podminka)
{
    int pocet = 0;

    foreach (int hodnota in body)
    {
        if (podminka(hodnota))
        {
            pocet++;
        }
    }

    return pocet;
}

static void VypisSouhrn(int[] body, int limit, int celkem, int pocetSplnenychDnu)
{
    Console.WriteLine($"Denní body: {string.Join(", ", body)}");
    Console.WriteLine($"Limit: {limit}");
    Console.WriteLine($"Celkem bodů: {celkem}");
    Console.WriteLine($"Počet dní se splněným limitem: {pocetSplnenychDnu}");
}
