// Поменять местами первую и последнюю строки в двумерном массиве


int m = 3, n = 4;
int[,] array = new int[m,n];

void PrintArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            Console.Write(collection[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            collection[i,j] = new Random().Next(-99,100);
        }
    }
}

void ChangeRaws(int[,] collection)
{
    int mem;
    for (int i = 0; i <= 0; i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            mem = collection[collection.GetLength(0)-1,j];
            collection[collection.GetLength(0)-1,j] = collection[i,j];
            collection[i,j] = mem;
        }
    }
}

FillArray(array);
PrintArray(array);
Console.WriteLine("_______________");
ChangeRaws(array);
PrintArray(array);