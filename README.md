# Maturitní úloha: Podprogramy a lambda funkce (C#)

**Doporučený čas:** 30 minut (přibližně 20 minut programování a 10 minut vysvětlení).  
**Výchozí projekt:** `Zadani/Zadani.csproj`  
**Referenční výsledek:** `Reseni/Reseni.csproj`

## Zadání pro zkoušeného

Program sleduje body získané v pěti dnech sportovní výzvy. Již obsahuje vstupní data, volání metod a všechny potřebné signatury. Doplňte pouze označené části souboru `Zadani/Program.cs`:

1. Napište lambda výraz typu `Predicate<int>`, který rozhodne, zda denní bodový zisk dosáhl proměnné `limit`.
2. Doplňte rekurzivní funkci `SpocitejSoucet`. Musí mít ukončovací podmínku a sečíst pole od předaného indexu. Pro prázdné pole má vrátit 0.
3. Doplňte funkci `SpocitejSplnene`. Předanou podmínku použijte na každý prvek pole a vraťte počet vyhovujících prvků. Funkce musí fungovat pro libovolnou předanou podmínku.
4. Doplňte proceduru `VypisSouhrn` tak, aby vypsala data a výsledky v uvedeném formátu.

Po dokončení má program pro připravená data vypsat přesně:

```text
Denní body: 12, 7, 18, 5, 14
Limit: 10
Celkem bodů: 56
Počet dní se splněným limitem: 3
```

## Teorie potřebná k řešení

- **Podprogram** je pojmenovaný blok kódu, který lze opakovaně volat. V C# jsou zde použity místní metody. Jejich signatura určuje název, typy parametrů a návratový typ.
- **Funkce** vrací hodnotu pomocí `return`. `SpocitejSoucet` a `SpocitejSplnene` vracejí `int`. **Procedura** vykoná činnost bez vrácení hodnoty; v C# má návratový typ `void`. `VypisSouhrn` vypisuje na konzoli.
- **Parametry** přenášejí vstupy do metody. Například `index` určuje, odkud se má součet počítat; `podminka` je předaný delegát, který metoda volá. Argumenty při volání se přiřadí odpovídajícím parametrům. Parametry se předávají hodnotou, pokud není uvedeno například `ref` nebo `out`. U pole se tímto způsobem kopíruje reference na stejné pole, nikoli celé pole.
- **Rekurze** znamená, že metoda volá sama sebe. Musí existovat ukončovací podmínka, zde `index >= body.Length`. Každé další volání posune `index` o 1, takže se k této podmínce dostane. Prázdné pole skončí hned s výsledkem 0.
- **Lambda výraz** je stručný zápis anonymní funkce, například `hodnota => hodnota >= limit`. Typ `Predicate<int>` představuje funkci s jedním argumentem `int` a výsledkem `bool`. Lze ji uložit do proměnné a předat jiné metodě jako parametr.
- **Obor platnosti proměnné** určuje, kde lze její jméno použít. `limit` je místní proměnná hlavního bloku; lambda ji zachycuje z okolního oboru. `hodnota` je parametr lambda výrazu a existuje jen v jeho těle. `index` existuje jen v metodě `SpocitejSoucet`. `pocet` existuje jen v bloku metody `SpocitejSplnene`. Metoda `VypisSouhrn` zná hodnotu limitu díky svému parametru `limit`, nikoli díky stejnojmenné proměnné v hlavním bloku.

## Postup od zadání k řešení

1. V souboru `Zadani/Program.cs` nahraďte tělo lambda výrazu porovnáním `hodnota >= limit`. Rovnost se počítá jako splněný limit.
2. V `SpocitejSoucet` nejprve vraťte 0, pokud `index >= body.Length`; jinak vraťte aktuální prvek plus výsledek volání se `index + 1`.
3. V `SpocitejSplnene` založte čítač, projděte pole a zvyšte jej pouze tehdy, když `podminka` pro daný prvek vrátí `true`. Nakonec čítač vraťte.
4. Ve `VypisSouhrn` použijte `Console.WriteLine`; prvky pole spojte pomocí `string.Join(", ", body)`.
5. Spusťte zadání znovu a porovnejte výstup se vzorem. Pro kontrolu okrajových případů vyzkoušejte prázdné pole, limit přesně rovný některé hodnotě a podmínku, která nevybere žádný prvek.

## Vodítko k hodnocení

Praktická část ověřuje správnost všech čtyř doplnění včetně prázdného pole a rovnosti s limitem. Při ústním vysvětlení má zkoušený správně rozlišit funkci od procedury, popsat parametry a návratové hodnoty, vysvětlit rekurzivní ukončení, předání lambda výrazu a obor platnosti i zachycení proměnné `limit`.
