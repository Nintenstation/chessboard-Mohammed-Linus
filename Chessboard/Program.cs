using Chessboard;

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

            //Anropa en statisk metod från en annan klass, som har själva nestlade for-loopen som skriver ut schackbrädet.
            //Använder den utmatade heltalet för att skicka som argument, till metodens parameter i klassen "BoardRendering".
            BoardRendering.Render_Chessboard(boardSize);
        }

        else
        {
            Console.WriteLine("Fel inmatning. Ange ett tal mellan 3 och 50, inga bokstäver.");
            Main(null);
        }        
    }
}