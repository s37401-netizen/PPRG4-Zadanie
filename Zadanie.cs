// Zadanie 1
/*
int _while = 1;

Console.Write("Rosnąco: ");

while (_while <= 10)
{
    Console.Write(_while + " ");
    _while++;
}

Console.Write("\n");

Console.Write("Malejąco: ");

int _doWhile = 10;

do
{
    Console.Write(_doWhile + " ");
    _doWhile--;
} while (_doWhile >= 1 );

Console.Write("\n");

Console.Write("Parzyste: ");

int _for = 20;

for (int i = 0; i <= _for; i += 2)
{
    Console.Write(i + " ");
}

Console.WriteLine("\nStart!");
*/
// Zadanie 2
/*
Console.Write("Ile dni trwa wyprawa? ");
int IloscDni = int.Parse(Console.ReadLine()!);

int licznikZlota = 0;
int licznikD = 0;

for (int i = 1; i <= IloscDni; i++)
{
    Console.Write($"Złoto w dniu {i}: ");
    int zlotoZaDzien = int.Parse(Console.ReadLine());
    licznikZlota += zlotoZaDzien;
    if (zlotoZaDzien > 10)
    {
        licznikD++;
    }
}

Console.WriteLine($"Łącznie znaleziono: {licznikZlota} sztuk złota.");
Console.WriteLine("Dni z wynikiem powyżej 10: " + licznikD);
*/
//Zadanie 3
/*
int wysokosc = int.Parse(Console.ReadLine()!);

for (int i = 0; i < wysokosc; i++)
{
    for (int h = 0; h < wysokosc - i - 1; h++)
    {
        Console.Write(" ");
    }
    for (int r = 0; r < 2 * i - 1; r++)
    {
        Console.Write("*");
    }    
    Console.WriteLine("");
}

for (int i = 1; i < 2; i++)
{
    for (int h = 0; h < wysokosc - i - 1; h++)
    {
        Console.Write(" ");
    }
    Console.WriteLine("*");
}
*/
// Zadanie 4
/*
int liczbaTur;

while (true)
{
    Console.Write("Podaj liczbę tur od 1 do 10: ");
    bool poprawnyFormat = int.TryParse(Console.ReadLine(), out liczbaTur);

    if (!poprawnyFormat)
    {
        Console.WriteLine("Wpisz liczbę całkowitą.");
        continue;
    }

    if (liczbaTur < 1 || liczbaTur > 10)
    {
        Console.WriteLine("Liczba musi należeć do zakresu 1–10.");
        continue;
    }

    break;
}

Console.WriteLine($"Rozpoczynam grę na {liczbaTur} tur.");
*/
// Zadanie 5
/*
int zdrowieBohatera = 60;
int zdrowiePrzeciwnika = 45;
int liczbaMikstur = 2;
int numerTury = 1;
Random losowanie = new Random();


bool game = true;
bool ucieczka = false;

while (game)
{
    Console.WriteLine("Tura: " + numerTury);
    Console.WriteLine("1 — atak, 2 — mikstura, 3 — ucieczka");
    int Akcja =  int.Parse(Console.ReadLine()!);
    switch (Akcja)
    {
        case 1:
            zdrowiePrzeciwnika -= losowanie.Next(8, 16);
            Console.WriteLine(zdrowiePrzeciwnika);
            break;
        case 2 :
            if (liczbaMikstur > 0)
            {
                zdrowieBohatera += 15;
                liczbaMikstur--;
                Console.WriteLine(liczbaMikstur);
                Console.WriteLine(zdrowieBohatera);
            }
            else
            {
                Console.WriteLine("Nie masz mikstur");
            }
            break;
        case 3:
            Console.WriteLine("Koniec");
            ucieczka = true;
            break;
    }

    if (zdrowiePrzeciwnika >= 0)
    {
        zdrowieBohatera -= losowanie.Next(4, 10);
        Console.WriteLine(zdrowieBohatera);
    }
    numerTury++;
    if (zdrowiePrzeciwnika <= 0)
    {
        game = false;
        Console.WriteLine("Zwycięstwo");
    } else if (zdrowieBohatera <= 0)
    {
        game = false;
        Console.WriteLine("Porażka");
    } else if (ucieczka == true)
    {
        game = false;
        Console.WriteLine("Ucieczka");
    }
}
*/
// Zadanie 6
Console.WriteLine("Wpisz imię: ");
string imie = Console.ReadLine();
Console.WriteLine("Wpisz Hp: ");
int hp = int.Parse(Console.ReadLine()!);
Console.WriteLine("Wpisz mikstury: ");
int mikstury = int.Parse(Console.ReadLine()!);
Console.WriteLine("Wpisz złoto: ");
int zloto = int.Parse(Console.ReadLine()!);


int tura = 1;
bool graDziala = true;
int eksp = 0;
int wykon = tura - 1;    

Console.WriteLine("=== HELLO ADVENTURER ===");
Console.WriteLine($"Tura: {tura}");
Console.WriteLine($"Bohater : {imie}");
Console.WriteLine($"Zdrowie: {hp} | Złoto: {zloto} | Mikstury: {mikstury}\n");    

while (graDziala)
{
    Console.WriteLine("1 - Eksploruj loch");
    Console.WriteLine("2 - Użyj mikstury");
    Console.WriteLine("3 - Odpocznij");
    Console.WriteLine("4 - Pokaż statystyki");
    Console.WriteLine("5 - Zakończ grę");
    
    while (tura > wykon)
    {
        int wybor = int.Parse(Console.ReadLine()!);
        switch (wybor)
        {
            case 1:
                if (hp > 8)
                {
                    zloto += 10;
                    hp -= 8;
                    eksp += 1;
                    wykon += 1;
                    Console.WriteLine("Dostałeś 10 złota | -8 zdrowia");
                }
                else
                {
                    Console.WriteLine("Przegrałeś");
                    graDziala = false;
                }
                break;
            case 2:
                if (mikstury > 0)
                {
                    hp += 20;
                    mikstury -= 1;
                    wykon += 1;
                    Console.WriteLine("Dostałeś 20 zdrowia | -1 mikstura");
                }
                else
                {
                    Console.WriteLine("Nie masz już mikstur");
                }
                break;
            case 3:
                if (zloto >= 3)
                {
                    hp += 5;
                    zloto -= 3;
                    wykon += 1;
                    Console.WriteLine("Dostałeś 5 zdrowia | -3 złota");
                }
                else
                {
                    Console.WriteLine("Nie masz dostatecznej ilości złota");
                }
                break;
            case 4:
                Console.WriteLine($"Zdrowia: {hp}\nZłota: {zloto}\nMikstur: {mikstury}\nEksploracji: {eksp}\n");
                break;
            case 5:
                graDziala = false;
                break;
            default:
                Console.WriteLine("Nieznana opcja");
                break;
        } 
    }
    break;
}
Console.WriteLine("=== Resultat ===");
Console.WriteLine($"Zdrowia: {hp}\nZłota: {zloto}\nMikstur: {mikstury}\nEksploracji: {eksp}\n");