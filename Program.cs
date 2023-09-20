using System.Reflection.Metadata;

int menuChoice = 0;
List<string> destanationsList = new();
List<int> destanationLenghtList = new();

int amountOfDest = 0;
// Denna är bara en extra v
//string antalResor = string.Empty;

Console.Clear();

while (true)
{
    Console.Clear();
    // TODO test
    Console.WriteLine("Hejsan, Vad vill du göra i din reselogg idag?\n1: Lägga till resemål.\n2: Visa alla resemål.\n3: Rensa alla resemål.\n4: Avlsuta programmet.");

    menuChoice = Convert.ToInt32(Console.ReadLine());


    if (menuChoice == 1 || menuChoice == 2 || menuChoice == 3 || menuChoice == 4)
    {
        switch (menuChoice)
        {
            case 1: // lägga till resemål
                AddTravelDest();

                break;
            case 2: // visa alla resemål
                ShowTravelDest();
                break;
            case 3: // rensa alla resemål
                ClearTravelDest();
                break;
            case 4: // avsluta programmet
                Console.WriteLine("Programmet avslutas.");
                Environment.Exit(0);
                break;

            default:
                Console.WriteLine("Ett fel uppståg snälla försökt igen!");
                break;

        }
    }
    else
    {

        Console.WriteLine("ogiltigt val försökt igen");

    }


}


void AddTravelDest()
{
    Console.Clear();
    Console.WriteLine("vad är namnet?");
    string newDestanation = Console.ReadLine();
    amountOfDest++;
    //antalResor += Console.ReadLine() + "\n";
    destanationsList.Add(newDestanation);

    Console.WriteLine("Hur långt är det i km?");
    int newDestanationLenghtList = Convert.ToInt32(Console.ReadLine());
    destanationLenghtList.Add(newDestanationLenghtList);


}
void ShowTravelDest()
{
    Console.Clear();
    Console.WriteLine("Alla resemål och deras strecka:");
    //Console.WriteLine(antalResor);
    int i = 0;
    while (i <= amountOfDest)
    {



        if (i >= amountOfDest)
        {
            break;
        }
        else
        {
            Console.Write(destanationsList[i]);
            Console.Write("Och har streckan i Km = ");
            Console.WriteLine(destanationLenghtList[i]);
            i++;
        }

    }
    Console.WriteLine("klicka på valfri knapp om klar");
    String klarMedLista = Console.ReadLine();

}
void ClearTravelDest()
{
    Console.Clear();
    destanationsList.Clear();
    destanationLenghtList.Clear();
    amountOfDest = 0;
    //antalResor = string.Empty;
    Console.WriteLine("Alla dina resor är återstälda");
    string klarMedRensa = Console.ReadLine();
}





