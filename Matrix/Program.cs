using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatrixVerifyer;

namespace Matrix
{
    partial class Program
    {
        static void Main(string[] args)
        {
            int input;

            float radians;
            Matrix22 matrixA = new Matrix22();
            Matrix22 matrixB = new Matrix22();



            Console.WriteLine("Enter Values For Matrix A: ");
            matrixA.elements[0, 0] = float.Parse(Console.ReadLine());
            matrixA.elements[0, 1] = float.Parse(Console.ReadLine());
            matrixA.elements[1, 0] = float.Parse(Console.ReadLine());
            matrixA.elements[1, 1] = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter Values For Matrix B: ");
            matrixB.elements[0, 0] = float.Parse(Console.ReadLine());
            matrixB.elements[0, 1] = float.Parse(Console.ReadLine());
            matrixB.elements[1, 0] = float.Parse(Console.ReadLine());
            matrixB.elements[1, 1] = float.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("1. Add\n2. Multiply\n3. Rotation");
            input = Convert.ToInt32(Console.ReadLine());

            if (input == 1)
            {
                Matrix22 matrixC = matrixA.Add(matrixB);
                Draw2x2Matrix(matrixC.elements);
            }
            if (input == 2)
            {
                Matrix22 matrixC = matrixA.Muliply(matrixB);
                Draw2x2Matrix(matrixC.elements);
                
            }
            if (input == 3)
            { 
                Console.WriteLine("Enter Radian: ");
                radians = float.Parse(Console.ReadLine());
                Matrix22 matrixC = Matrix22.CreateRotation(radians);
                Draw2x2Matrix(matrixC.elements);

                MatrixChecker.CheckRotationMatrix(radians, matrixC.elements[0, 0], matrixC.elements[0, 1], matrixC.elements[1, 0], matrixC.elements[1, 1]);

            }



            #region text
            /*
             * Där finns tester tillgängliga genom att skriva
             * MatrixChecker.CheckAddition
             * MatrixChecker.CheckMultiplication
             * MatrixChecker.CheckRotationMatrix
             * 
             * Observera att testerna inte är noga testade.
             * 
             * De tar emot argument enligt följande standard:
             * CheckAddition tar emot alla Matris-värden 00, 01, 10, 11 för matris A
             * och alla Matris-värden 00, 01, 10, 11 för matris B, och den sista är
             * då det uträknade resultatet av A + B, som då är en matris 00, 01, 10, 11
             * 
             * CheckMultiplication liknar CheckAddition, den tar emot tre matriser,
             * A, B och sedan resultatet av A * B. Sen kommer den att jämföra och se
             * ifall matrisen har blivit rätt
             * 
             * CheckRotationMatrix tar emot antalet radianer du roterat en matris av,
             * och sedan en rotationsmatris som du har skapat. Den jämför sedan värden
             * för att se ifall matriserna stämmer överens.
             */

            /*
             * Där finns ett inbyggt verktyg för att rita ut matriser i två format.
             * Den första tar emot alla matrisvärden, 00, 01, 10, 11 och den andra
             * tar emot en float[,] (en float 2D-array) och skriver sedan ut matrisen
             * formaterat, och endast med 2 decimaler.
             */

            // De fyra första siffrorna = Matris A, de nästa fyra siffrorna = Matris B, de sista fyra siffrorna = resultatet av A + B
            // Exempel: MatrixChecker.CheckAddition(1, 2, 3, 4, 1, 2, 3, 4, 2, 4, 6, 8);

            // De fyra första siffrorna = Matris A, de nästa fyra siffrorna = Matris B, de sista fyra siffrorna = resultatet av A * B
            // Exempel: MatrixChecker.CheckMultiplication(1, 2, 3, 4, 1, 2, 3, 4, 7, 10, 15, 22);


            // Byt ut detta anropet med dina matrisvärden, så kommer programmet att rita ut dem istället :)
            #endregion
            //Draw2x2Matrix(1.01f, 0.00f, 0.00f, 1);



            Console.ReadKey();
        }
    }
}
