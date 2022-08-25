// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите колличество элементов массива:");
bool M = Convert.ToInt32(Console.ReadLine());
bool[] array = new bool[M];
bool sumP=0;
for ( i = 0; i < array.Length; i++)
{
    array[i] = sumP>0;
    sumP = array[i];
}
Console.WriteLine($"Больше нуля = {sumP}");

 
// Console.WriteLine("Введите колличество элементов массива:");
// int A = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[A];
// Random rand = new Random();

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = rand.Next(-99, 100);
// }
// Console.WriteLine(string.Join(", ", array));

// for (int i = 0; i < array.Length; i++)
// {
//     //array[i] = array[i] * -1;
//     array[i] *= -1;
//     //array[i] = - array[i];
// }
// Console.WriteLine(string.Join(", ", array));
