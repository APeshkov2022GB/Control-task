void InputArray(string[] array1)  // ввода массива с клавиатуры
{
    for (int i = 0; i < array1.Length; i++)
    {
        Console.WriteLine($" Введите {i+1}-й элемент массива ");
        array1[i] = Console.ReadLine() ?? "";
    }
}
Console.Clear();
Console.WriteLine("Введите количество элементов массива");
int n = int.Parse(Console.ReadLine()?? "");
string[] array1 = new string[n];
InputArray(array1);
PrintArray(array1);
string[] array2 = new string[array1.Length];
ArraySort(array1, array2);
PrintArray(array2);
Console.WriteLine("Программа работу закончила");
