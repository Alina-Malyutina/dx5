float maxi(float [] array)
{
    float max = array[0];
    for(int i=0;i<array.Length;i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}
    
float mini(float [] array1)
{
    float min = array1[0];
    for(int i=0;i<array1.Length;i++)
    {
        if (array1[i] < min)
        {
            min = array1[i];
        }
    }
    return min;
}  

Console.WriteLine("This program counts the difference between max and min numbers");
float [] array3 = {1, 5, -3, 3, 8};
float maxx = maxi(array3);
float minn = mini(array3);
float diff = maxx - minn;

Console.WriteLine($"Difference is {diff}");

