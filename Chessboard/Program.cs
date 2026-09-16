using Chessboard;

internal class Program
{
    private static void Main(string[] args)
    {
        //Användaren anger input
        //felhanteras of TryParse() i if-sats och else-sats genom att anropa Size_Input metoden
        //if- och else-sats för att kontrollera om värdet är en integer. Kallar statisk metod från BoardRendering klassen om...
        //...integer är rätt, för att skriva ut schackbrädet. Annars startas om programmet.

        Console.Write("Hur stor ska brädet vara? skriv mellan 3 och 50: ");

        string size = Console.ReadLine();

        int boardSize = Size_Input(size);
        
        if(boardSize > 0)
        {
            BoardRendering.Render_Chessboard(boardSize);
        }
        else
        {
            Main(null);
        }

    static int Size_Input(string size)
    {
            //Kontrollera om användarens input är integer
            if (int.TryParse(size, out int boardSize))
            {
                //Felhantering med while-loop ifall användaren anger värde som inte är mellan 3 och 50.
                while (boardSize < 3 || boardSize > 50)
                {
                    Console.Write("Ogiltig storlek eller tecken. Vänligen ange ett tal mellan 3 och 50: ");
                    size = Console.ReadLine();
                    int.TryParse(size, out boardSize);
                }
                return boardSize;
            }
            //Om input är inte integer, returnera värde och starta om programmet.
            else
            {
                Console.WriteLine("Ogiltig storlek eller tecken. Vänligen ange ett tal mellan 3 och 50.");
                return boardSize;
            }
            


    }

    }
}