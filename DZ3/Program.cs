int[] array = { 1, 2, 5, 0, 10, 34 };
int size = array.Length;

void ShowArray(int[] arr, int size)
    {
        if (size == 0)
        {
            Console.Write(arr[size]);
            return;
        }
        Console.Write(arr[size - 1] + " ");
        ShowArray(arr, size - 1);
    }
Console.WriteLine("Элементы массива:");
ShowArray(array, size);    
