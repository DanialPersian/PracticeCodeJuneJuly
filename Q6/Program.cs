//get the lines out of the files 

string[] lines = File.ReadAllLines("dogOwners");

//Dangelo Broomfield:[BRUISER:Blue,OTIS:Orange,KLARK:Black,NEVE:White,HENRY:Orange]


foreach (string line in lines)
{
    //first we want to split it into parts so 0 1 2 3 4 etc so we can pick which parts we want to locate ( can be done with maths ) 
    string[] values = line.Split(':','[');
}
