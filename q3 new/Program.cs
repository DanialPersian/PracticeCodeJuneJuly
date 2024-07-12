int BingBangBONG = 0;


for (int i = 0; i <= 100; i++)
{
    if(i % 3 == 0 && i % 5 == 0)
    {
        if(isString(i.ToString()) % 2 == 0)
        {
            BingBangBONG++;
        }

    }
}

Console.WriteLine(BingBangBONG);
//had to make num a string because I can't iterate through an int and characters can only go through strings but i am turning it back into an int with the function of -'0'
int isString(string num)
{
    int isString = 0;
    foreach (char c in num)
    {

        return isString += c-'0';
    }
    return isString;
}

