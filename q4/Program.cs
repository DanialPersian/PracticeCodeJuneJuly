int BingBangBONG = 0;

for (int i = 1000; i <= 50000; i++)
{
    bool divisibleBy3 = (i % 3 == 0);
    bool divisibleBy5 = (i % 5 == 0);

    if (divisibleBy3 && divisibleBy5)
    {
        if (isEvenDigitSum(i))
        {
            BingBangBONG++;
        }
    }
}

Console.WriteLine(BingBangBONG);

bool isEvenDigitSum(int num)
{
    int sumOfDigits = 0;
    foreach (char c in num.ToString())
    {
        sumOfDigits += c - '0';
    }
    return sumOfDigits % 2 == 0;
}
