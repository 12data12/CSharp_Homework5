// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int [] array = new int [6];
int countEven = 0;

for (int i = 0; i < array.Length; i++)
{
    array [i] = new Random().Next(100,999);
    if(array[i]%2 ==0)
    {
        countEven++;
    }
}
Console.WriteLine(String.Join(" ", array));
Console.WriteLine("Number of even numbers: "+ countEven);