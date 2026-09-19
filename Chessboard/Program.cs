using Chessboard;
using Pastel;

internal class Program
{
    private static void Main(string[] args)
    {
        //Main method to call methods to receive user input, convert the values to integer, and send as an argument
        //Entry point starts inside a while-loop to keep the program running until user closes program

        bool active = true;
        while (active)
        {
            //Call method to ask user for input, returns value to store it in declared variable "size" to later use as argument
            
            string size = User_Answer();

            //Call method to send "size" as argument that converts it to integer, return integer value and store in "boardSize"
            
            int boardSize = Size_Input(size);

            //Call static method from a different class (BoardRenedering.cs) to print out chessboard
            
            BoardRendering.Render_Chessboard(boardSize);      

            //Asks the user if they want to print out more chessboards, otherwise close program

            Console.Write("Vill du göra ett till schackbräde? (y/n): ".Pastel(ConsoleColor.Green));
            string answer = Console.ReadLine().ToLower();

            if (answer != "y")
            {
                Console.WriteLine("Programmet avslutas".Pastel(ConsoleColor.Red));
                active = false;
            }
        }
            
    }
            
        
    //Method to convert "size" from string to integer "boardSize", includes exception handling and returns integer
    
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

    //Method for user input, returns as a string value
    
    static string User_Answer()
    {
        Console.Write("Hur stor ska brädet vara? skriv mellan 3 och 50: ".Pastel(ConsoleColor.Green));

        string size = Console.ReadLine();

        return size;
    }

}
