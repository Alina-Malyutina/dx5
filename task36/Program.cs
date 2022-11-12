void FillRandomArray (int [] array)
{
    for(int i=0;i<array.Length;i++)
    {
        array[i] = new Random().Next(1, 1000);
    }
}

int SumOfOddElements (int [] array1)
{
int sum = 0;
    for(int i=0;i<array1.Length;i++)
    {
        if (i % 2 == 1)
        {
            sum = sum + array1[i];
        }
    }
return sum;
}

Console.WriteLine("This program fill array random numbers and sum elements with odd index");
int [] arrayRandom = new int [7];
FillRandomArray(arrayRandom);

Console.WriteLine("Investigating array is: ");
Console.Write("[");
for(int i=0;i<arrayRandom.Length;i++)
{
    Console.Write($"{arrayRandom[i]}, ");
}
Console.WriteLine("]");

int sum1 = SumOfOddElements(arrayRandom);

Console.WriteLine($"Sum of elements with odd index is {sum1}");