using System;
using System.Collections.Generic;
using System.Text;

namespace Chessboard
{
    public class BoardRendering
    {
        public static void Render_Chessboard(int BoardSize)
        {
            //Nested for-loop to print out a chessboard with equal amounts of rows and columns based on user input

            for (int rows = 0; rows < BoardSize; rows++)
            {
                //Modulo operator is utilzied to implement binary logic, where each position will change between white square or black square

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
