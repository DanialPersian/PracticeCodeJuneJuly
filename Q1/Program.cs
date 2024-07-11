int[] array = new int[20];

for (int i = 0; i < array.Length; i ++) //this was i+=2 but i changed it to i++
{
    if (i % 2 == 1)
    {
        array[i] = 1;
    }

}

Console.WriteLine(array[5]); //i am testing it out like this 