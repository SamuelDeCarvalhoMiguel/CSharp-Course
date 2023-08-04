namespace MultidimensionalArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exercise1();
            exercise2();
        }

        static void exercise1()
        {

            int negativeCounter = 0;

            Console.Write("Insert the Matrice size: ");
            int amount = int.Parse(Console.ReadLine());

            int[,] multArray = new int[amount, amount];

            for (int i = 0; i < amount; i++)
            {
                string[] array = Console.ReadLine().Split(' ');

                for (int c = 0; c < amount; c++)
                {

                    multArray[i, c] = int.Parse(array[c]);

                    if (multArray[i, c] < 0)
                        negativeCounter++;

                }
            }

            Console.WriteLine();
            Console.WriteLine("Main diagonal: ");

            for (int i = 0; i < amount; i++)
                Console.Write(multArray[i, i] + " ");

            Console.WriteLine();
            Console.WriteLine($"Negative numbers: {negativeCounter}");

        }

        static void exercise2()
        {

            Console.Write("Insert the array line: ");
            int aLine = int.Parse(Console.ReadLine());
            Console.Write("Insert the array column: ");
            int aColumn = int.Parse(Console.ReadLine());

            int[,] matrice = new int[aLine, aColumn];
            string[] arrayLine = new string[aLine];

            for (int i = 0; i < aLine; i++)
            {

                arrayLine = Console.ReadLine().Split(' ');

                for (int c = 0; c < aColumn; c++)
                {

                    matrice[i, c] = int.Parse(arrayLine[c]);

                }

            }

            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < aLine; i++)
            {
                for (int j = 0; j < aColumn; j++)
                {
                    if (matrice[i, j] == x)
                    {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + matrice[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + matrice[i - 1, j]);
                        }
                        if (j < aColumn - 1)
                        {
                            Console.WriteLine("Right: " + matrice[i, j + 1]);
                        }
                        if (i < aLine - 1)
                        {
                            Console.WriteLine("Down: " + matrice[i + 1, j]);
                        }
                    }
                }

            }
        }
    }
}