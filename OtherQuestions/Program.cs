int bish = 0;           // divisible by 3
int bash = 0;             // divisible by 5
int bishbash = 0;        // divisible by 3 and 5
int bishbashbosh = 0;   //each digit of number adds up to an odd number

int startLength = 1000;
int length = 50000;


for (int i = startLength; i < length; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        bishbash++;
        if (isEven(i.ToString()) % 2 != 0)
        {
            bishbashbosh++;
        }
    }
    else if (i % 5 == 0)
    {
        bash++;
    }
    else if (i % 3 == 0)
    {
        bish++;
    }

}

int isEven(string number)
{
    int isEven = 0;
    foreach(char c in number)
    {
      isEven += c - '0';
    }return isEven;

}


Console.WriteLine(bishbashbosh);