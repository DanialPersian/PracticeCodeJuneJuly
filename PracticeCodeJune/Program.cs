string question = "ab1cd23ef4gh";

char[] consonant = {'b', 'c', 'd','f','g', 'h','j', 'k', 'l','m','n','p','q','r','s','t','v','w','x','y','z'};

List<string> names = new List<string> { "b", "c"," d", "f"," g","h","j","k","l","m", "n"," p","q","r", "s","t","v","w", "x","y", "z" }; //started using a list now instead of an array but this time it is a character 

int sum = 0;
int answer = 0;


foreach(char c in question)
{
    if (names.Contains(c))
    {
        sum++;   
    }
    answer += c-'0';
}



Console.WriteLine(answer*sum);


string checker(string chcek)
{
    foreach(char c in chcek)
    {