// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечетных позициях.
// [3, 7, 23, 12] → 19
// [-4, -6, 89, 6] → 0


Console.Write("Введите размер массива: ");
int arr = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[arr];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int sum = 0;

for (int i = 1; i < numbers.Length; i+=2)
    sum += numbers[i];

    Console.WriteLine($"Сумма чисел с нечетными индексами -> {sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(-6,89);
        }
}
void PrintArray(int[] numbers)
{
    Console.Write("[");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i]);
            if (i < (numbers.Length-1)) Console.Write($", ");
        }
    Console.Write("]");
    Console.WriteLine();
}