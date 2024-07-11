//get the lines out of the files 

string[] lines = File.ReadAllLines(@"dogOwners.txt");

//Dangelo Broomfield:[BRUISER:Blue,OTIS:Orange,KLARK:Black,NEVE:White,HENRY:Orange]
//     1                2     3    4     5     6      7    8    9      10   11

int amount = 0;

//space isnt included with the splitting so the first part is all one part 
foreach (string line in lines)
{
    //first we want to split it into parts so 0 1 2 3 4 etc so we can pick which parts we want to locate ( can be done with maths ) 
    string[] values = line.Split(new char[] { ':', '[', ',', ']' }, StringSplitOptions.RemoveEmptyEntries);

    // the number of owners with a name that begins with "B" who have less than 3 dogs.



    if (values[0][0] == 'B' )//if the first letter of the persons name is B - which is apart of the questiond
    {//and they have 

        // the number of owners with a name that begins with "B" who have less than 3 dogs. [question]
        //each part is allocated to the name 'values' so here in the above example that we have an overall 11 things and we want 5 dogs names so we do 11-1/2 = 5

        int numberOfDogs = (values.Length - 1) / 2; 

        if (numberOfDogs < 3)
        {
            Console.WriteLine(line);
            amount++;

        }
    }
}
Console.WriteLine(amount);