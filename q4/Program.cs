int BishBashBosh = 0;
int sum = 0;


for (int i = 1000; i <= 50000; i++)
{
    if(i % 3 == 0 && i % 5 == 0)
    {
        foreach(char c in (i.ToString()))
        {
            
            sum += c - '0';
           
        }
        if (sum % 2 == 0)
        {
            BishBashBosh++;
        }
    }
}

Console.WriteLine(BishBashBosh);