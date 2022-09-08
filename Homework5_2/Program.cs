// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int [] array = new int [6];
int oddIndex = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100,100);
    if(i%2 == 1)
    {
        oddIndex+=array[i];
    }
}
Console.WriteLine(string.Join(" ", array));
Console.WriteLine("Sum of elements with an odd index is " + oddIndex);