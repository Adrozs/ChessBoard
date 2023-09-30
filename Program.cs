// Adrian Rozsahegyi NET23

namespace Chessboard
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Unicode to show the squares, and setting a unicode standard output
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            // Take user input for prefered symbols/characters and size of the chessboard
            Console.Write("Choose size for the board: ");
            int size = int.Parse(Console.ReadLine());

            Console.Write("Choose character for black: ");
            string blackSquare = Console.ReadLine();

            Console.Write("Choose character for white: ");
            string whiteSquare = Console.ReadLine();

            Console.Write("Choose a special character: ");
            string specialSquare = Console.ReadLine();

            Console.Write("Choose a place on board ex: E7: ");
            string location = Console.ReadLine();

            // Splits up loacation into 2 separate variables to be able to compare them in the nested loops below. So that t.ex if input was "E7" char1 = "E" and char2 = "7" in separate variables.
            int char1 = (location[0]);
            int char2 = (location[1]);

            //Converts chars to numbers with ASCII t.ex "E" has ascii value 69. We want it to be so E is the 4th number. So 69-65 = 4. This works for all letters.
            //Same with numbers t.ex the char "7" has ASCII value 55 but we want it to be the value 7. So 55 - 48 = 7. This also works for all numbers when they're chars. 
            char1 -= 65;
            char2 -= 48;

            // Created an multidimentional array to get a "grid" to make up the structure of the chessboard the size the user put in.
            string[,] chessBoard = new string[size, size];

            // Nested loop to iterate over each row and column of the array. 
            // Checks if current positions is divadable with 2 to see if it's an even or odd number.
            // to be able to assign white or black squares every 2nd position
            for (int i = 0; i < size; i++)
            {   
                for (int j = 0; j < size; j++)
                {
                    // Checks if the position is the one that the user entered for the special symbol
                    if (i == char2 && j == char1) 
                    {
                        chessBoard[i, j] = specialSquare; 
                    }     
                    // If it isn't the special symbol, check if even and assign it black symbol
                    else if ((i + j) % 2 == 0)
                    {
                        chessBoard[i, j] = blackSquare; 

                    }
                    // If not special symbol nor black, assign it white symbol
                    else
                    {
                        chessBoard[i, j] = whiteSquare; // White squares
                    }
                }   
                
            }

            // This loops iterates through the chessboard to print out what's stored on each position, thus forming the chessboard.
            for (int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    Console.Write(chessBoard[i, j]);
                }
                Console.WriteLine();
            }

        }
    }
}
