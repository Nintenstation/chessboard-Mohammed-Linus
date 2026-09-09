internal class Program
{
    private static void Main(string[] args)
    {
        //1. Användaren anger input, felhanteras of TryParse() i if-sats
        Console.Write("Hur stor ska brädet vara? skriv mellan 3 och 50: ");

        string size = Console.ReadLine();

        if (int.TryParse(size, out int boardSize))
        {
            //2. Felhantering med while-loop ifall användaren anger värde som inte är mellan 3 och 50.
            while (boardSize < 3 || boardSize > 50)
            {
                Console.Write("Ogiltig storlek. Vänligen ange ett tal mellan 3 och 50: ");
                size = Console.ReadLine();
                int.TryParse(size, out boardSize);
            }
            //3. Nestald for-loop för att skapa rad och kolumn med lika stort antal utifrån använaderns input.
            //Översta for-loop skapar rad, och kör kolumn for-loopet inuti innan den skapar ny rad.
            for(int rows = 0; rows < boardSize; rows++)
            {
                //4. Skapa ny columns, modulo operator används för att byta mellan de två tecken som finns för varje plats.
                for(int columns = 0; columns < boardSize; columns++)
                {
                    if((rows + columns) % 2 == 0)
                    {
                        Console.Write("x ");
                    }
                    else
                    {
                        Console.Write("1 ");
                    }
                }
                Console.WriteLine();
            }
        }
        
        else
        {
            Console.WriteLine("Fel inmatning. Ange ett tal mellan 3 och 50, inga bokstäver.");
            Main(null);
        }        
    }
}