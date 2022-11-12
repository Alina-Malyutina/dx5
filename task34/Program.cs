void FillRandomArray (int [] array)
{
    for(int i=0;i<array.Length;i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

int CountEven (int [] array1)
{
int count = 0;
    for(int i=0;i<array1.Length;i++)
    {
        if (array1[i] % 2 == 0)
        {
            count++;
        }
    }
return count;
}


Console.WriteLine("This program fill array random three-digit numbers and count quantity even numbers");
int [] arrayRandom = new int [10];
FillRandomArray(arrayRandom);

Console.WriteLine("Investigating array is: ");
Console.Write("[");
for(int i=0;i<arrayRandom.Length;i++)
{
    Console.Write($"{arrayRandom[i]}, ");
}
Console.WriteLine("]");

int count1 = CountEven(arrayRandom);

Console.WriteLine($"Here is {count1} even numbers");
