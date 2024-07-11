using System.Diagnostics.CodeAnalysis;

string myVariable = "Hello World";

Console.WriteLine(StringToCaps(myVariable));

string StringToCaps(string toCapitalise)
{
    return toCapitalise.ToUpper();
}