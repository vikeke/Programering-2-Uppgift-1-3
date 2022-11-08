// See https://aka.ms/new-console-template for more information


//uppgift 1
// här skapas x och y kordinaten
Random rnd = new Random();
int xKordinat;
int yKordinat;

// Här skapas en loop som printar ut x och y med en variable i varje.

for (int a = 0; a < 10; a++)
{
    xKordinat = rnd.Next(-10, 10);
    yKordinat = rnd.Next(-10, 10);
    Console.WriteLine("X kordinaten är: " + xKordinat);
    Console.WriteLine("Y kordinaten är: " + yKordinat);
    Console.WriteLine("=======================");
}


//fördjupning 1 ("inga dubbletter")
int[] xkordinatlista = new int[10];
int[] ykordinatlista = new int[10];

for (int a = 0; a < 10; a++)
{
    xkordinatlista[a] = rnd.Next(-10, 10);
    ykordinatlista[a] = rnd.Next(-10, 10);
    xKordinat = rnd.Next(-10, 10);
    yKordinat = rnd.Next(-10, 10);
    Console.WriteLine("X kordinaten är: " + xKordinat);
    Console.WriteLine("Y kordinaten är: " + yKordinat);
    Console.WriteLine("=======================");
}

//detta är när sifforna skrivs ut i kordinat form

for (int a = 0; a < 10; a++)
{
    xKordinat = rnd.Next(-10, 10);
    yKordinat = rnd.Next(-10, 10);
    Console.WriteLine("[" + yKordinat + "," + xKordinat + "]");
    Console.WriteLine("=======================");
}


//fördjupning 2

// detta är för att man ska kunna bestämma själv hur många punkter man vill ha

static void genereraPunkter()
{
    // läser antalet nummer den ska printa
    Console.WriteLine("skriv ett nummer: ");

    string antalNummer = Console.ReadLine();
    int g = 0;
    g = int.Parse(antalNummer);


    Random rnd = new Random();
    int xKordinat;
    int yKordinat;

    for (int a = 0; a < g; a++)
    {
        xKordinat = rnd.Next(-10, 10);
        yKordinat = rnd.Next(-10, 10);
        Console.WriteLine("[" + yKordinat + "," + xKordinat + "]");
        Console.WriteLine(" ");
    }
}

// Fördjupning 3
static void genereraKordinater()
{
    // läser antalet nummer den ska printa
    Console.WriteLine("Skriv hur kångt du vill at X och Y kordinaten ska gå: ");
    string antalSiffor = Console.ReadLine();
    int k = 0;
    k = int.Parse(antalSiffor);

    Console.WriteLine("skriv ett nummer: ");

    string antalNummer = Console.ReadLine();
    int g = 0;
    g = int.Parse(antalNummer);


    Random rnd = new Random();
    int xKordinat;
    int yKordinat;

    for (int a = 0; a < g; a++)
    {
        xKordinat = rnd.Next(-k, k);
        yKordinat = rnd.Next(-k, k);
        Console.WriteLine("[" + yKordinat + "," + xKordinat + "]");
        Console.WriteLine(" ");
    }
}

genereraKordinater();







//Uppgift 2

// skriver ut kraven för lösenordet
Console.WriteLine("Skriv ett lösenord:  ");
Console.WriteLine("Krav; Du måste ha minst 8 tecken, max 15. Minst ett specialtecken, minst en versal, minst en gemen.");
String Lösenord = Console.ReadLine();
bool Go = true;

// Denna while loop används för att se till så att alla kraven möts .
while (Go)
{
    // Om ett lösenord som är inte stämmer med kraven skrivs in återställs allt så att man kan testa med en annan kod.
    int LösenordsLängd = Lösenord.Length;

    // här gör de att koden inte kan vara tomm, den retunerar att man ska försöka igen
    if (string.IsNullOrEmpty(Lösenord))
    {
        Console.WriteLine("Lösenordet får inte vara tomt, Testa igen!");
        Lösenord = Console.ReadLine();
    }

    // Här är kravet som gör så att lösenordet inte kan vara mindre än 8 tecken
    else if (LösenordsLängd < 8)
    {
        Console.WriteLine("koden har inte tillreckligt med tecken, Försök igen...");
        Lösenord = Console.ReadLine();
    }

    // Här är kravet som gör så att lösenordet mer än 30 tecken

    else if (LösenordsLängd > 15)
    {
        Console.WriteLine("koden har för många tecken, Försök igen...");
        Lösenord = Console.ReadLine();
    }

    // Ifall alla kraven är uppfyllda på rätt sätt så komer loopen att sluta vilket kommer leda till att koden man skrivit in "fungerar"
    else
    {
        Console.WriteLine("vald kod: " + " " + Lösenord);
        Go = false; 
    }
}