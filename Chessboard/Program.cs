Console.Write("Hur stor ska brädet vara? skriv mellan 3 och 50: ");

string size = Console.ReadLine();

if(int.TryParse(size, out int boardSize))
{
    while(boardSize < 3 || boardSize > 50)
    {
        Console.Write("Ogiltig storlek. Vänligen ange ett tal mellan 3 och 50: ");
        size = Console.ReadLine();
        int.TryParse(size, out boardSize);
    }

}
