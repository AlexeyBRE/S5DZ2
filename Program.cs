// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] num = new int[5];
int sum = 0;

for (int i = 0; i < num.Length; i++)
{

    num[i] = new Random().Next(-100, 100);

    if (i % 2 == 0)
    {
        sum = sum + num[i];
    }
}
string mas = string.Join(" ", num);
Console.Write(mas);
Console.Write($"->{sum}");
