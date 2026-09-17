using Chessboard;
using Pastel;

internal class Program
{
    private static void Main(string[] args)
    {
        //Användaren anger input
        //felhanteras of TryParse() i if-sats och else-sats genom att anropa Size_Input metoden
        //if- och else-sats för att kontrollera om värdet är en integer. Kallar statisk metod från BoardRendering klassen om...
        //...integer är rätt, för att skriva ut schackbrädet. Annars startas om programmet.
        //while-loop används för att senare låta användaren välja om de vill stänga programmet eller fortsätta.

        bool active = true;
        while (active)
        {
            //Anropa metod för att be användaren om input, returnera värdet och lagra det i den lokala variablen "size".
            
            string size = User_Answer();

            //Anropa Size_Input() metoden så att "size" omvandlas till en integer utan fel.
            //Om konvertering från "size" strängen har lyckats så lagras den i "boardSize" varriabel.
            
            int boardSize = Size_Input(size);

            //Anropa statisk metod från BoardRendering-klassen, och skicka "boardSize" integer som argument för att skriva ut schakbrädet.
            
            BoardRendering.Render_Chessboard(boardSize);      

            //Frågar användaren ifall den vill bygga ett till schackbräde
            Console.Write("Vill du göra ett till schackbräde? (y/n): ".Pastel(ConsoleColor.Green));
            string answer = Console.ReadLine().ToLower();

            if (answer != "y")
            {
                Console.WriteLine("Programmet avslutas".Pastel(ConsoleColor.Red));
                active = false;
            }
        }
            
    }
            
        
    //Metod som ska omvandla "size" sträng input till en integer. "size" skickas som argument från Main metoden.
    //Inkluderar enkel felhantering med hjälp av en while-loop, som integrerar en kombinerad villkorsuttryck med hjälp av TryParse()
    //och jämförelse. 
    
    static int Size_Input(string size)
    {
        int boardSize;
        while (!int.TryParse(size, out boardSize) || boardSize < 3 || boardSize > 50)
        {
            Console.Beep();
            Console.Write("Ogiltig storlek eller tecken. Vänligen ange ett tal mellan 3 och 50: ".Pastel(ConsoleColor.Red));
            size = Console.ReadLine();
        }
        return boardSize;


    }

    //Metod för att användaren ska mata in ett svar, i form av sträng. Sträng-värdet returneras.
    
    static string User_Answer()
    {
        Console.Write("Hur stor ska brädet vara? skriv mellan 3 och 50: ".Pastel(ConsoleColor.Green));

        string size = Console.ReadLine();

        return size;
    }

}
