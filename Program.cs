string[] result = CreateArray();
ArraySort(result);

void ArraySort(string[] arr)
{
    int size = 3; 
    var value = string.Empty;
    string[] newarr = new string[arr.Length]; 
    for (int i = 0; i < arr.Length; i++)
    {
        value = arr[i]; 
        if (value.Length <= size) 
            newarr[i] = arr[i];
    }
    newarr = newarr.Where(x => x != null).ToArray(); 
    Console.WriteLine($"Отобранный массив: [{string.Join(", ", newarr)}]");
}

string[] CreateArray()
{
    Console.WriteLine("Введите элементы массива через запятую: ");
    string[] array = Console.ReadLine()!.Split(',');
    Console.WriteLine($"Изначальный массив: [{string.Join(", ", array)}]");
    return array;
}
