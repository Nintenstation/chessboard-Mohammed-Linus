using Chessboard;

internal class Program
{
    private static void Main(string[] args)
    {
        //Användaren anger input
        //felhanteras of TryParse() i if-sats och else-sats genom 

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
        //    if (int.TryParse(size, out int boardSize))
        //    {
        //        //Felhantering med while-loop ifall användaren anger värde som inte är mellan 3 och 50.

        //        while (boardSize < 3 || boardSize > 50)
        //        {
        //            Console.Write("Ogiltig storlek. Vänligen ange ett tal mellan 3 och 50: ");
        //            size = Console.ReadLine();
        //            int.TryParse(size, out boardSize);
        //        }

        //        //Anropa en statisk metod från en annan klass, som har själva nestlade for-loopen som skriver ut schackbrädet.
        //        //Använder den utmatade heltalet för att skicka som argument, till metodens parameter i klassen "BoardRendering".
        //    }

        //    else
        //    {
        //        Console.WriteLine("Fel inmatning. Ange ett tal mellan 3 och 50, inga bokstäver.");
        //        Main(null);
        //    }        
        //}

        static int Size_Input(string size)
    {

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
            else
            {
                Console.WriteLine("Ogiltig storlek eller tecken. Vänligen ange ett tal mellan 3 och 50.");
                return boardSize;
            }
            


    }

    }
}