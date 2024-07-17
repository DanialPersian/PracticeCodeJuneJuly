using System.Drawing;


//Lina Mills:[SATCHEL:Brown,NIKKI:Black,BUDD:Green]

string[] lines= File.ReadAllLines(@"C:\Users\Dania\source\repos\PracticeCodeJune\Q2\dogOwners2.txt");

foreach (string line in lines)
{
    string[] parts = line.Split(':');

    string Oname = parts[0];

    foreach (var a in Oname)
    {
        Console.WriteLine(a);
    }
}




//char[] seperator = new char[] {':'};

//foreach(var a in words.Split(seperator,StringSplitOptions.RemoveEmptyEntries))
//{
//    Console.WriteLine(a);
//}



