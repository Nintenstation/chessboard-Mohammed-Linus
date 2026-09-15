using System;
using System.Collections.Generic;
using System.Text;

namespace Chessboard
{
    public class BoardRendering
    {
        public static void Render_Chessboard(int BoardSize)
        {
            //3. Nestald for-loop för att skapa rad och kolumn med lika stort antal utifrån använaderns input.
            //Översta for-loop skapar rad, och kör kolumn for-loopet inuti innan den skapar ny rad. 

            for (int rows = 0; rows < BoardSize; rows++)
            {
                //4. Skapa ny columns, modulo operator används för att byta mellan de två tecken som finns för varje plats. 

                for (int columns = 0; columns < BoardSize; columns++)
                {
                    if ((rows + columns) % 2 == 0)
                    {
                        Console.Write("□ ");
                    }
                    else
                    {
                        Console.Write("■ ");
                    }
                }
                Console.WriteLine();
            }

        }

    }
}
