int[] CrateArray(int size, int min, int value)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(min, value + 1);
        
    }

    return arr;

}

void PrintArray(int[] array)
{
    Console.WriteLine(String.Join(" ",array));
}

int[] arr1 = CrateArray(20, 200, 700);
PrintArray(arr1);
