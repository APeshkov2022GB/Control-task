void InputArray(string[] array1)  // ввода массива с клавиатуры
{
    for (int i = 0; i < array1.Length; i++)
    {
        Console.WriteLine($" Введите {i+1}-й элемент массива ");
        array1[i] = Console.ReadLine() ?? "";
    }
}
void ArraySort(string[] array1, string[] array2) // сортировка массива 
{
    int j = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[j] = array1[i];
        j++;
        }
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
