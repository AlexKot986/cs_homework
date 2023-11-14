// Урок 2. Условные операторы, циклы, массивы, строки, StringBuilder
// Дан двумерный массив.

// 732

// 496

// 185

// Отсортировать данные в нем по возрастанию.

// 123

// 456

// 789

// Вывести результат на печать.

// class Program

// {

// static void Main(string[] args)

// {

// int[,] a = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };

// }

// }

int[,] arr = {{7, 3, 2}, {4, 9, 6}, {1, 8, 5}};

PrintSortArray(arr);

static void PrintSortArray(int[,] arr)
{
    int[] a = new int[arr.Length];
    int i = 0;

    foreach (int n in arr)
    {
        a[i++] = n;
    }

    Array.Sort(a);

    i = 0;

    foreach (int n in a)
    { 
        if (i == arr.GetLength(0)) 
        {
            i = 0;
            Console.WriteLine();
        }
        Console.Write(n);
        i++;
    }
}







