int[] array = new int[20];

for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0)
    {
        array[i] = 1;
    }
}

foreach(var item in array)
{
    Console.WriteLine(item);
}
//creates an array of size 20 and assign all the elements of the array that have an odd index to the value 1
//creates an array of size 20 and assign all the elements of the array that have an odd index to the value 1
