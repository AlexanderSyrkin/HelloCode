void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        //index = index + 1;
        index++;
    }
}

void PrintArray(int[] col) //void - войд метод, который ничего не возвращает
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int Index0f(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while(index < count)
    {
        if(collection[index] == find)
        {
           position = index; 
           break;
        }
        index++;
    }
    return position;
}


int [] array = new int[10]; // создаем новый массив, где будет 10 элеметов (по умолчанию заполняется нулями, чтобы
// заполнить случайными числами смотри, как это сделано в строках выше)

FillArray(array);
array[4] = 4;
array[6] = 4;
PrintArray(array);

Console.WriteLine();
int pos = Index0f(array, 4);
Console.WriteLine(pos);