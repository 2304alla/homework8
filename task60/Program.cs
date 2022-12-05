// Задача 60: 
// Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел.
// Напишите программу, которая будет построчно выводить
// массив,
// добавляя индексы каждого элемента.


int[,,] CreateMatrix(int rows, int columns, int depht, int n)
{
    int[,,] matrix = new int[rows, columns, depht];


    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = n + 1;
                n++;
            }
        }


    }


    return matrix;
}

void PrintMatrix(int[,,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)

    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (k < matrix.GetLength(2)) Console.Write($"{matrix[i, j, k],5}; ");
                else Console.Write($"{matrix[i, j, k],5}");
            }
        }
        Console.WriteLine("|");
    }

}

void PrintMatrixRow(int[,,] matrix)
{
    int str=1;
for (int i = 0; i < matrix.GetLength(0); i++)

    {
        Console.Write($"Строка № {str}:");
        Console.WriteLine("");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                int index1=i;
                int index2 =j;
                int index3 = k;
                if (k < matrix.GetLength(2)) Console.Write($" {matrix[i, j, k]},{(index1,index2,index3), 2} ; ");
                else Console.Write($"{matrix[i, j, k],5}");
                Console.WriteLine();
                
            }
        }
        str++;
        Console.WriteLine("");
    }
}

int[,,] matrix3D = CreateMatrix(3, 4, 5, 10);
PrintMatrix(matrix3D);
PrintMatrixRow(matrix3D);